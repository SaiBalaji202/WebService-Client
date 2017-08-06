using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using WebServiceClient.com.aonaware.services;

namespace WebServiceClient
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        System.Collections.Generic.Dictionary<string, string> dictionaryList;
        System.Collections.Generic.Dictionary<string, string> strategyList;

        DictService service;
        private string strSelectedID;

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            dictionaryList = new Dictionary<string, string>();
            strategyList = new Dictionary<string, string>();

            service = new DictService();
            LoadDictToCombo();
            LoadStrategiesToCombo();

            MakeLoadPanelHide(metroPanelHome);
            MakeLoadPanelHide(metroPanelLoad);
            MakeLoadPanelHide(metroPanelMatch);
        }

        private async void LoadStrategiesToCombo()
        {
            metroComboStratagies.Items.Clear();

            MakeLoadPanelVisible(metroPanelMatch);
            Strategy[] strategies =  await Task.Run(() => service.StrategyList());
            foreach (Strategy strategy in  strategies)
            {
                strategyList.Add(strategy.Id, strategy.Description);
                metroComboStratagies.Items.Add(strategy.Id);
            }
            MakeLoadPanelHide(metroPanelMatch);
        }

        private async void metroBtnSearchForAWord_Click(object sender, EventArgs e)
        {
            if (!(metroTxtWordToSearch.Text == ""))
            {
                WordDefinition wordDefinition = null;
                metroPanelLoad.Visible = true;
                
                wordDefinition = await Task.Run(() => service.Define(metroTxtWordToSearch.Text));
                rtxtWordDefn.Text = String.Format("Word Searched: \n\t{0}\n\nTotal No of Definition: {1}\n", 
                    wordDefinition.Word, wordDefinition.Definitions.Length);
                int c = 0;
                foreach (Definition definition in wordDefinition.Definitions)
                {
                    rtxtWordDefn.Text += String.Format("{0}) Dictionary: {1}\n\t Definition: {2}\n\n", ++c, definition.Dictionary, 
                        definition.WordDefinition);
                }
                metroPanelLoad.Visible = false;
            }
        }

        private async void metroComboAvailableDicts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboAvailableDicts.SelectedIndex != 0)
            {
                strSelectedID = dictionaryList.FirstOrDefault(x => x.Value == metroComboAvailableDicts.Text).Key;
                metroLblSelDict.Text = String.Format("Selected:\n\tDictionary Id: {0}\n\tDictionary Name: {1}",
                    strSelectedID, metroComboAvailableDicts.Text);

                MakeLoadPanelVisible(metroPanelHome);
                rtxtDictInfo.Text = await Task.Run(() => service.DictionaryInfo(strSelectedID));
                MakeLoadPanelHide(metroPanelHome);
            }
            else
            {
                metroLblSelDict.Text = "Selected: All";
            }

        }
        
        public async void LoadDictToCombo()
        {
            metroComboAvailableDicts.Items.Clear();
            metroComboAvailableDicts.Items.Add("All");

            MakeLoadPanelVisible(metroPanelHome);
            Dictionary[] dictionaries = await Task.Run(() => service.DictionaryList());
            foreach (Dictionary dictionary in dictionaries)
            {
                dictionaryList.Add(dictionary.Id, dictionary.Name);
                metroComboAvailableDicts.Items.Add(dictionary.Name);
            }
            MakeLoadPanelHide(metroPanelHome);
        }
        void MakeLoadPanelVisible(MetroPanel objMetroPanel)
        {
            objMetroPanel.Visible = true;
        }
        void MakeLoadPanelHide(MetroPanel objMetroPanel)
        {
            objMetroPanel.Visible = false;
        }

        private async void metroBtnGetDesc_Click(object sender, EventArgs e)
        {
            MakeLoadPanelVisible(metroPanelMatch);
            MetroFramework.MetroMessageBox.Show(this, strategyList[metroComboStratagies.Text], metroComboStratagies.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MakeLoadPanelHide(metroPanelMatch);
        }

        private async void metroBtnLoadSimilarWords_Click(object sender, EventArgs e)
        {
            MakeLoadPanelVisible(metroPanelMatch);
            lstSimilarWords.Items.Clear();

            string strWordToMatch = metroTxtWordToMatch.Text; string strStrategies = metroComboStratagies.Text;
            DictionaryWord[] words = await Task.Run( () => service.Match(strWordToMatch, strStrategies));
            string strDetails;

            lstSimilarWords.DataSource = await Task.Run(() =>
            {
                List<string> lstWords = new List<string>();
                foreach (DictionaryWord dictionaryWord in words)
                {
                    lstWords.Add(dictionaryWord.Word);
                }
                return lstWords;
            });
            MakeLoadPanelHide(metroPanelMatch);
        }

        private void lstSimilarWords_DoubleClick(object sender, EventArgs e)
        {
            string strWordtoSearch = lstSimilarWords.SelectedValue.ToString();
            metroTabControl1.SelectedIndex = 1;
            metroTxtWordToSearch.Text = strWordtoSearch;
            metroBtnSearchForAWord.PerformClick();
        }
    }
}

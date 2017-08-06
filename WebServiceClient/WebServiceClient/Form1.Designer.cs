namespace WebServiceClient
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabDefine = new MetroFramework.Controls.MetroTabPage();
            this.metroLblSelDict = new MetroFramework.Controls.MetroLabel();
            this.metroComboAvailableDicts = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rtxtWordDefn = new System.Windows.Forms.RichTextBox();
            this.metroBtnSearchForAWord = new MetroFramework.Controls.MetroButton();
            this.metroTxtWordToSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanelLoad = new MetroFramework.Controls.MetroPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtxtDictInfo = new System.Windows.Forms.RichTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroComboStratagies = new MetroFramework.Controls.MetroComboBox();
            this.metroBtnLoadSimilarWords = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTxtWordToMatch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelHome = new MetroFramework.Controls.MetroPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanelMatch = new MetroFramework.Controls.MetroPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroBtnGetDesc = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lstSimilarWords = new System.Windows.Forms.ListBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabDefine.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroPanelLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanelMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabDefine);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(546, 429);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabDefine
            // 
            this.metroTabDefine.Controls.Add(this.metroPanelHome);
            this.metroTabDefine.Controls.Add(this.metroLabel5);
            this.metroTabDefine.Controls.Add(this.rtxtDictInfo);
            this.metroTabDefine.Controls.Add(this.metroLblSelDict);
            this.metroTabDefine.Controls.Add(this.metroComboAvailableDicts);
            this.metroTabDefine.Controls.Add(this.metroLabel3);
            this.metroTabDefine.Controls.Add(this.metroTile2);
            this.metroTabDefine.HorizontalScrollbarBarColor = true;
            this.metroTabDefine.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabDefine.HorizontalScrollbarSize = 10;
            this.metroTabDefine.Location = new System.Drawing.Point(4, 38);
            this.metroTabDefine.Name = "metroTabDefine";
            this.metroTabDefine.Size = new System.Drawing.Size(538, 387);
            this.metroTabDefine.TabIndex = 0;
            this.metroTabDefine.Text = "Select a Dictionary";
            this.metroTabDefine.VerticalScrollbarBarColor = true;
            this.metroTabDefine.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabDefine.VerticalScrollbarSize = 10;
            // 
            // metroLblSelDict
            // 
            this.metroLblSelDict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLblSelDict.AutoSize = true;
            this.metroLblSelDict.Location = new System.Drawing.Point(30, 170);
            this.metroLblSelDict.Name = "metroLblSelDict";
            this.metroLblSelDict.Size = new System.Drawing.Size(24, 19);
            this.metroLblSelDict.TabIndex = 14;
            this.metroLblSelDict.Text = "All";
            // 
            // metroComboAvailableDicts
            // 
            this.metroComboAvailableDicts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboAvailableDicts.FormattingEnabled = true;
            this.metroComboAvailableDicts.ItemHeight = 23;
            this.metroComboAvailableDicts.Items.AddRange(new object[] {
            "All"});
            this.metroComboAvailableDicts.Location = new System.Drawing.Point(131, 115);
            this.metroComboAvailableDicts.Name = "metroComboAvailableDicts";
            this.metroComboAvailableDicts.Size = new System.Drawing.Size(322, 29);
            this.metroComboAvailableDicts.TabIndex = 13;
            this.metroComboAvailableDicts.UseSelectable = true;
            this.metroComboAvailableDicts.SelectedIndexChanged += new System.EventHandler(this.metroComboAvailableDicts_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Dictionaries";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile2.Location = new System.Drawing.Point(0, 3);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(538, 73);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Select A Dictionary";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanelLoad);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.rtxtWordDefn);
            this.metroTabPage2.Controls.Add(this.metroBtnSearchForAWord);
            this.metroTabPage2.Controls.Add(this.metroTxtWordToSearch);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroTile1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(538, 387);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Define";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel2.Location = new System.Drawing.Point(30, 189);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Definition: ";
            // 
            // rtxtWordDefn
            // 
            this.rtxtWordDefn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtWordDefn.Location = new System.Drawing.Point(52, 211);
            this.rtxtWordDefn.Name = "rtxtWordDefn";
            this.rtxtWordDefn.Size = new System.Drawing.Size(360, 105);
            this.rtxtWordDefn.TabIndex = 9;
            this.rtxtWordDefn.Text = "";
            // 
            // metroBtnSearchForAWord
            // 
            this.metroBtnSearchForAWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroBtnSearchForAWord.Location = new System.Drawing.Point(183, 136);
            this.metroBtnSearchForAWord.Name = "metroBtnSearchForAWord";
            this.metroBtnSearchForAWord.Size = new System.Drawing.Size(75, 23);
            this.metroBtnSearchForAWord.TabIndex = 8;
            this.metroBtnSearchForAWord.Text = "Search...";
            this.metroBtnSearchForAWord.UseSelectable = true;
            this.metroBtnSearchForAWord.Click += new System.EventHandler(this.metroBtnSearchForAWord_Click);
            // 
            // metroTxtWordToSearch
            // 
            this.metroTxtWordToSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.metroTxtWordToSearch.CustomButton.Image = null;
            this.metroTxtWordToSearch.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTxtWordToSearch.CustomButton.Name = "";
            this.metroTxtWordToSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtWordToSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtWordToSearch.CustomButton.TabIndex = 1;
            this.metroTxtWordToSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtWordToSearch.CustomButton.UseSelectable = true;
            this.metroTxtWordToSearch.CustomButton.Visible = false;
            this.metroTxtWordToSearch.Lines = new string[0];
            this.metroTxtWordToSearch.Location = new System.Drawing.Point(120, 97);
            this.metroTxtWordToSearch.MaxLength = 32767;
            this.metroTxtWordToSearch.Name = "metroTxtWordToSearch";
            this.metroTxtWordToSearch.PasswordChar = '\0';
            this.metroTxtWordToSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtWordToSearch.SelectedText = "";
            this.metroTxtWordToSearch.SelectionLength = 0;
            this.metroTxtWordToSearch.SelectionStart = 0;
            this.metroTxtWordToSearch.ShortcutsEnabled = true;
            this.metroTxtWordToSearch.Size = new System.Drawing.Size(207, 23);
            this.metroTxtWordToSearch.TabIndex = 7;
            this.metroTxtWordToSearch.UseSelectable = true;
            this.metroTxtWordToSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtWordToSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Word: ";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(1, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(534, 73);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "Define a Word";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lstSimilarWords);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.Controls.Add(this.metroPanelMatch);
            this.metroTabPage3.Controls.Add(this.metroTxtWordToMatch);
            this.metroTabPage3.Controls.Add(this.metroComboStratagies);
            this.metroTabPage3.Controls.Add(this.metroBtnGetDesc);
            this.metroTabPage3.Controls.Add(this.metroBtnLoadSimilarWords);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroTile3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(538, 387);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Matching Words";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroPanelLoad
            // 
            this.metroPanelLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanelLoad.Controls.Add(this.pictureBox1);
            this.metroPanelLoad.Controls.Add(this.metroLabel4);
            this.metroPanelLoad.HorizontalScrollbarBarColor = true;
            this.metroPanelLoad.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelLoad.HorizontalScrollbarSize = 10;
            this.metroPanelLoad.Location = new System.Drawing.Point(276, 166);
            this.metroPanelLoad.Name = "metroPanelLoad";
            this.metroPanelLoad.Size = new System.Drawing.Size(136, 39);
            this.metroPanelLoad.TabIndex = 11;
            this.metroPanelLoad.VerticalScrollbarBarColor = true;
            this.metroPanelLoad.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelLoad.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Searching...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WebServiceClient.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // rtxtDictInfo
            // 
            this.rtxtDictInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDictInfo.Location = new System.Drawing.Point(79, 269);
            this.rtxtDictInfo.Name = "rtxtDictInfo";
            this.rtxtDictInfo.Size = new System.Drawing.Size(386, 115);
            this.rtxtDictInfo.TabIndex = 15;
            this.rtxtDictInfo.Text = "";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(48, 247);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Dictionary Info: ";
            // 
            // metroComboStratagies
            // 
            this.metroComboStratagies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroComboStratagies.FormattingEnabled = true;
            this.metroComboStratagies.ItemHeight = 23;
            this.metroComboStratagies.Items.AddRange(new object[] {
            "All"});
            this.metroComboStratagies.Location = new System.Drawing.Point(146, 98);
            this.metroComboStratagies.Name = "metroComboStratagies";
            this.metroComboStratagies.Size = new System.Drawing.Size(322, 29);
            this.metroComboStratagies.TabIndex = 17;
            this.metroComboStratagies.UseSelectable = true;
            // 
            // metroBtnLoadSimilarWords
            // 
            this.metroBtnLoadSimilarWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroBtnLoadSimilarWords.Location = new System.Drawing.Point(242, 180);
            this.metroBtnLoadSimilarWords.Name = "metroBtnLoadSimilarWords";
            this.metroBtnLoadSimilarWords.Size = new System.Drawing.Size(75, 23);
            this.metroBtnLoadSimilarWords.TabIndex = 16;
            this.metroBtnLoadSimilarWords.Text = "Load";
            this.metroBtnLoadSimilarWords.UseSelectable = true;
            this.metroBtnLoadSimilarWords.Click += new System.EventHandler(this.metroBtnLoadSimilarWords_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(54, 101);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Stratagies";
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile3.Location = new System.Drawing.Point(3, 3);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(532, 73);
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "Load Similar Words";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTxtWordToMatch
            // 
            this.metroTxtWordToMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.metroTxtWordToMatch.CustomButton.Image = null;
            this.metroTxtWordToMatch.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.metroTxtWordToMatch.CustomButton.Name = "";
            this.metroTxtWordToMatch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtWordToMatch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtWordToMatch.CustomButton.TabIndex = 1;
            this.metroTxtWordToMatch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtWordToMatch.CustomButton.UseSelectable = true;
            this.metroTxtWordToMatch.CustomButton.Visible = false;
            this.metroTxtWordToMatch.Lines = new string[0];
            this.metroTxtWordToMatch.Location = new System.Drawing.Point(146, 142);
            this.metroTxtWordToMatch.MaxLength = 32767;
            this.metroTxtWordToMatch.Name = "metroTxtWordToMatch";
            this.metroTxtWordToMatch.PasswordChar = '\0';
            this.metroTxtWordToMatch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtWordToMatch.SelectedText = "";
            this.metroTxtWordToMatch.SelectionLength = 0;
            this.metroTxtWordToMatch.SelectionStart = 0;
            this.metroTxtWordToMatch.ShortcutsEnabled = true;
            this.metroTxtWordToMatch.Size = new System.Drawing.Size(322, 23);
            this.metroTxtWordToMatch.TabIndex = 18;
            this.metroTxtWordToMatch.UseSelectable = true;
            this.metroTxtWordToMatch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtWordToMatch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(54, 142);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Word: ";
            // 
            // metroPanelHome
            // 
            this.metroPanelHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanelHome.Controls.Add(this.pictureBox2);
            this.metroPanelHome.Controls.Add(this.metroLabel8);
            this.metroPanelHome.HorizontalScrollbarBarColor = true;
            this.metroPanelHome.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelHome.HorizontalScrollbarSize = 10;
            this.metroPanelHome.Location = new System.Drawing.Point(317, 150);
            this.metroPanelHome.Name = "metroPanelHome";
            this.metroPanelHome.Size = new System.Drawing.Size(136, 39);
            this.metroPanelHome.TabIndex = 17;
            this.metroPanelHome.VerticalScrollbarBarColor = true;
            this.metroPanelHome.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelHome.VerticalScrollbarSize = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WebServiceClient.Properties.Resources.ajax_loader;
            this.pictureBox2.Location = new System.Drawing.Point(14, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(49, 10);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(75, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Searching...";
            // 
            // metroPanelMatch
            // 
            this.metroPanelMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanelMatch.Controls.Add(this.pictureBox3);
            this.metroPanelMatch.Controls.Add(this.metroLabel9);
            this.metroPanelMatch.HorizontalScrollbarBarColor = true;
            this.metroPanelMatch.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMatch.HorizontalScrollbarSize = 10;
            this.metroPanelMatch.Location = new System.Drawing.Point(332, 212);
            this.metroPanelMatch.Name = "metroPanelMatch";
            this.metroPanelMatch.Size = new System.Drawing.Size(136, 39);
            this.metroPanelMatch.TabIndex = 19;
            this.metroPanelMatch.VerticalScrollbarBarColor = true;
            this.metroPanelMatch.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMatch.VerticalScrollbarSize = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WebServiceClient.Properties.Resources.ajax_loader;
            this.pictureBox3.Location = new System.Drawing.Point(14, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(49, 10);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Searching...";
            // 
            // metroBtnGetDesc
            // 
            this.metroBtnGetDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroBtnGetDesc.Location = new System.Drawing.Point(54, 180);
            this.metroBtnGetDesc.Name = "metroBtnGetDesc";
            this.metroBtnGetDesc.Size = new System.Drawing.Size(75, 23);
            this.metroBtnGetDesc.TabIndex = 16;
            this.metroBtnGetDesc.Text = "Get Desc";
            this.metroBtnGetDesc.UseSelectable = true;
            this.metroBtnGetDesc.Click += new System.EventHandler(this.metroBtnGetDesc_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(54, 231);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(91, 19);
            this.metroLabel10.TabIndex = 20;
            this.metroLabel10.Text = "Similar Words";
            // 
            // lstSimilarWords
            // 
            this.lstSimilarWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSimilarWords.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSimilarWords.FormattingEnabled = true;
            this.lstSimilarWords.ItemHeight = 20;
            this.lstSimilarWords.Location = new System.Drawing.Point(82, 272);
            this.lstSimilarWords.Name = "lstSimilarWords";
            this.lstSimilarWords.Size = new System.Drawing.Size(386, 84);
            this.lstSimilarWords.TabIndex = 21;
            this.lstSimilarWords.DoubleClick += new System.EventHandler(this.lstSimilarWords_DoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 515);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "FrmMain";
            this.Text = "Dictionary Service";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabDefine.ResumeLayout(false);
            this.metroTabDefine.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroPanelLoad.ResumeLayout(false);
            this.metroPanelLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanelHome.ResumeLayout(false);
            this.metroPanelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanelMatch.ResumeLayout(false);
            this.metroPanelMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabDefine;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroBtnSearchForAWord;
        private MetroFramework.Controls.MetroTextBox metroTxtWordToSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox rtxtWordDefn;
        private MetroFramework.Controls.MetroLabel metroLblSelDict;
        private MetroFramework.Controls.MetroComboBox metroComboAvailableDicts;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanelLoad;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.RichTextBox rtxtDictInfo;
        private MetroFramework.Controls.MetroTextBox metroTxtWordToMatch;
        private MetroFramework.Controls.MetroComboBox metroComboStratagies;
        private MetroFramework.Controls.MetroButton metroBtnLoadSimilarWords;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroPanel metroPanelHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanelMatch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroBtnGetDesc;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.ListBox lstSimilarWords;
    }
}


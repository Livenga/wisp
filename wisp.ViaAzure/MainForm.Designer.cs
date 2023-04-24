namespace wisp.ViaAzure
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOutputListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsAzureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.supportedLanguageGroup = new System.Windows.Forms.GroupBox();
            this.supportLanguageReferenceLink = new System.Windows.Forms.LinkLabel();
            this.voiceTypeSelector = new System.Windows.Forms.ComboBox();
            this.voiceTypeLabel = new System.Windows.Forms.Label();
            this.languageSelector = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.speechText = new System.Windows.Forms.TextBox();
            this.executeTextToSpeechButton = new System.Windows.Forms.Button();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.mainMenuStrip.SuspendLayout();
            this.supportedLanguageGroup.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.settingsMenu});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(409, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOutputListMenuItem,
            this.toolStripSeparator1,
            this.fileExitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(67, 20);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // fileOutputListMenuItem
            // 
            this.fileOutputListMenuItem.Name = "fileOutputListMenuItem";
            this.fileOutputListMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fileOutputListMenuItem.Size = new System.Drawing.Size(215, 22);
            this.fileOutputListMenuItem.Text = "出力ファイル一覧(&O)";
            this.fileOutputListMenuItem.Click += new System.EventHandler(this.OnFileOutputMenuClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // fileExitMenuItem
            // 
            this.fileExitMenuItem.Name = "fileExitMenuItem";
            this.fileExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.fileExitMenuItem.Size = new System.Drawing.Size(215, 22);
            this.fileExitMenuItem.Text = "終了(&X)";
            this.fileExitMenuItem.Click += new System.EventHandler(this.OnFileCloseMenuClick);
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsAzureMenuItem});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(57, 20);
            this.settingsMenu.Text = "設定(&S)";
            // 
            // settingsAzureMenuItem
            // 
            this.settingsAzureMenuItem.Name = "settingsAzureMenuItem";
            this.settingsAzureMenuItem.Size = new System.Drawing.Size(147, 22);
            this.settingsAzureMenuItem.Text = "Azure 設定(&A)";
            this.settingsAzureMenuItem.Click += new System.EventHandler(this.OnSettingsAzureMenuClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 579);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(409, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // supportedLanguageGroup
            // 
            this.supportedLanguageGroup.Controls.Add(this.supportLanguageReferenceLink);
            this.supportedLanguageGroup.Controls.Add(this.voiceTypeSelector);
            this.supportedLanguageGroup.Controls.Add(this.voiceTypeLabel);
            this.supportedLanguageGroup.Controls.Add(this.languageSelector);
            this.supportedLanguageGroup.Controls.Add(this.languageLabel);
            this.supportedLanguageGroup.Location = new System.Drawing.Point(12, 32);
            this.supportedLanguageGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supportedLanguageGroup.Name = "supportedLanguageGroup";
            this.supportedLanguageGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supportedLanguageGroup.Size = new System.Drawing.Size(385, 152);
            this.supportedLanguageGroup.TabIndex = 2;
            this.supportedLanguageGroup.TabStop = false;
            this.supportedLanguageGroup.Text = "Supported Language";
            // 
            // supportLanguageReferenceLink
            // 
            this.supportLanguageReferenceLink.AutoSize = true;
            this.supportLanguageReferenceLink.Location = new System.Drawing.Point(6, 125);
            this.supportLanguageReferenceLink.Name = "supportLanguageReferenceLink";
            this.supportLanguageReferenceLink.Size = new System.Drawing.Size(237, 18);
            this.supportLanguageReferenceLink.TabIndex = 4;
            this.supportLanguageReferenceLink.TabStop = true;
            this.supportLanguageReferenceLink.Text = "音声サービス - Azure Cognitive Services";
            // 
            // voiceTypeSelector
            // 
            this.voiceTypeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voiceTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voiceTypeSelector.FormattingEnabled = true;
            this.voiceTypeSelector.Location = new System.Drawing.Point(6, 93);
            this.voiceTypeSelector.Name = "voiceTypeSelector";
            this.voiceTypeSelector.Size = new System.Drawing.Size(373, 26);
            this.voiceTypeSelector.TabIndex = 3;
            // 
            // voiceTypeLabel
            // 
            this.voiceTypeLabel.AutoSize = true;
            this.voiceTypeLabel.Location = new System.Drawing.Point(6, 72);
            this.voiceTypeLabel.Name = "voiceTypeLabel";
            this.voiceTypeLabel.Size = new System.Drawing.Size(68, 18);
            this.voiceTypeLabel.TabIndex = 2;
            this.voiceTypeLabel.Text = "音声タイプ";
            // 
            // languageSelector
            // 
            this.languageSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageSelector.FormattingEnabled = true;
            this.languageSelector.Location = new System.Drawing.Point(6, 43);
            this.languageSelector.Name = "languageSelector";
            this.languageSelector.Size = new System.Drawing.Size(373, 26);
            this.languageSelector.TabIndex = 1;
            this.languageSelector.SelectedIndexChanged += new System.EventHandler(this.OnLanguageSelectorSelectedIndexChanged);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(6, 22);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(32, 18);
            this.languageLabel.TabIndex = 0;
            this.languageLabel.Text = "言語";
            // 
            // speechText
            // 
            this.speechText.AcceptsReturn = true;
            this.speechText.Location = new System.Drawing.Point(6, 24);
            this.speechText.Multiline = true;
            this.speechText.Name = "speechText";
            this.speechText.Size = new System.Drawing.Size(373, 323);
            this.speechText.TabIndex = 0;
            // 
            // executeTextToSpeechButton
            // 
            this.executeTextToSpeechButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeTextToSpeechButton.Location = new System.Drawing.Point(283, 353);
            this.executeTextToSpeechButton.Name = "executeTextToSpeechButton";
            this.executeTextToSpeechButton.Size = new System.Drawing.Size(96, 28);
            this.executeTextToSpeechButton.TabIndex = 1;
            this.executeTextToSpeechButton.Text = "実行(&E)";
            this.executeTextToSpeechButton.UseVisualStyleBackColor = true;
            this.executeTextToSpeechButton.Click += new System.EventHandler(this.OnExecuteTextToSpeechClick);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.speechText);
            this.inputGroup.Controls.Add(this.executeTextToSpeechButton);
            this.inputGroup.Location = new System.Drawing.Point(12, 191);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(385, 387);
            this.inputGroup.TabIndex = 3;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "入力";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 601);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.supportedLanguageGroup);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 640);
            this.Name = "MainForm";
            this.Text = "wisp.ViaAzure";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.supportedLanguageGroup.ResumeLayout(false);
            this.supportedLanguageGroup.PerformLayout();
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenuStrip;
        private StatusStrip statusStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fileExitMenuItem;
        private ToolStripMenuItem settingsMenu;
        private ToolStripMenuItem settingsAzureMenuItem;
        private GroupBox supportedLanguageGroup;
        private ComboBox languageSelector;
        private Label languageLabel;
        private ComboBox voiceTypeSelector;
        private Label voiceTypeLabel;
        private LinkLabel supportLanguageReferenceLink;
        private TextBox speechText;
        private Button executeTextToSpeechButton;
        private GroupBox inputGroup;
        private ToolStripMenuItem fileOutputListMenuItem;
    }
}

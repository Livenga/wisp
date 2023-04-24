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
            mainMenuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fileExitMenuItem = new ToolStripMenuItem();
            settingsMenu = new ToolStripMenuItem();
            settingsAzureMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            supportedLanguageGroup = new GroupBox();
            supportLanguageReferenceLink = new LinkLabel();
            voiceTypeSelector = new ComboBox();
            voiceTypeLabel = new Label();
            languageSelector = new ComboBox();
            languageLabel = new Label();
            speechText = new TextBox();
            executeTextToSpeechButton = new Button();
            mainMenuStrip.SuspendLayout();
            supportedLanguageGroup.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, settingsMenu });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(690, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, fileExitMenuItem });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(67, 20);
            fileMenu.Text = "ファイル(&F)";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(150, 6);
            // 
            // fileExitMenuItem
            // 
            fileExitMenuItem.Name = "fileExitMenuItem";
            fileExitMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            fileExitMenuItem.Size = new Size(153, 22);
            fileExitMenuItem.Text = "終了(&X)";
            fileExitMenuItem.Click += OnFileCloseMenuClick;
            // 
            // settingsMenu
            // 
            settingsMenu.DropDownItems.AddRange(new ToolStripItem[] { settingsAzureMenuItem });
            settingsMenu.Name = "settingsMenu";
            settingsMenu.Size = new Size(57, 20);
            settingsMenu.Text = "設定(&S)";
            // 
            // settingsAzureMenuItem
            // 
            settingsAzureMenuItem.Name = "settingsAzureMenuItem";
            settingsAzureMenuItem.Size = new Size(147, 22);
            settingsAzureMenuItem.Text = "Azure 設定(&A)";
            settingsAzureMenuItem.Click += OnSettingsAzureMenuClick;
            // 
            // statusStrip
            // 
            statusStrip.Location = new Point(0, 231);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(690, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // supportedLanguageGroup
            // 
            supportedLanguageGroup.Controls.Add(supportLanguageReferenceLink);
            supportedLanguageGroup.Controls.Add(voiceTypeSelector);
            supportedLanguageGroup.Controls.Add(voiceTypeLabel);
            supportedLanguageGroup.Controls.Add(languageSelector);
            supportedLanguageGroup.Controls.Add(languageLabel);
            supportedLanguageGroup.Location = new Point(12, 32);
            supportedLanguageGroup.Margin = new Padding(3, 4, 3, 4);
            supportedLanguageGroup.Name = "supportedLanguageGroup";
            supportedLanguageGroup.Padding = new Padding(3, 4, 3, 4);
            supportedLanguageGroup.Size = new Size(278, 152);
            supportedLanguageGroup.TabIndex = 2;
            supportedLanguageGroup.TabStop = false;
            supportedLanguageGroup.Text = "Supported Language";
            // 
            // supportLanguageReferenceLink
            // 
            supportLanguageReferenceLink.AutoSize = true;
            supportLanguageReferenceLink.Location = new Point(6, 125);
            supportLanguageReferenceLink.Name = "supportLanguageReferenceLink";
            supportLanguageReferenceLink.Size = new Size(237, 18);
            supportLanguageReferenceLink.TabIndex = 4;
            supportLanguageReferenceLink.TabStop = true;
            supportLanguageReferenceLink.Text = "音声サービス - Azure Cognitive Services";
            supportLanguageReferenceLink.LinkClicked += OnSupportLanguageReferenceLinkClick;
            // 
            // voiceTypeSelector
            // 
            voiceTypeSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            voiceTypeSelector.FormattingEnabled = true;
            voiceTypeSelector.Location = new Point(6, 93);
            voiceTypeSelector.Name = "voiceTypeSelector";
            voiceTypeSelector.Size = new Size(266, 26);
            voiceTypeSelector.TabIndex = 3;
            // 
            // voiceTypeLabel
            // 
            voiceTypeLabel.AutoSize = true;
            voiceTypeLabel.Location = new Point(6, 72);
            voiceTypeLabel.Name = "voiceTypeLabel";
            voiceTypeLabel.Size = new Size(68, 18);
            voiceTypeLabel.TabIndex = 2;
            voiceTypeLabel.Text = "音声タイプ";
            // 
            // languageSelector
            // 
            languageSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            languageSelector.FormattingEnabled = true;
            languageSelector.Location = new Point(6, 43);
            languageSelector.Name = "languageSelector";
            languageSelector.Size = new Size(266, 26);
            languageSelector.TabIndex = 1;
            languageSelector.SelectedIndexChanged += OnLanguageSelectorSelectedIndexChanged;
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new Point(6, 22);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new Size(32, 18);
            languageLabel.TabIndex = 0;
            languageLabel.Text = "言語";
            // 
            // speechText
            // 
            speechText.AcceptsReturn = true;
            speechText.Location = new Point(296, 32);
            speechText.Multiline = true;
            speechText.Name = "speechText";
            speechText.Size = new Size(382, 152);
            speechText.TabIndex = 3;
            // 
            // executeTextToSpeechButton
            // 
            executeTextToSpeechButton.Location = new Point(582, 190);
            executeTextToSpeechButton.Name = "executeTextToSpeechButton";
            executeTextToSpeechButton.Size = new Size(96, 28);
            executeTextToSpeechButton.TabIndex = 4;
            executeTextToSpeechButton.Text = "実行(&E)";
            executeTextToSpeechButton.UseVisualStyleBackColor = true;
            executeTextToSpeechButton.Click += OnExecuteTextToSpeechClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 253);
            Controls.Add(executeTextToSpeechButton);
            Controls.Add(speechText);
            Controls.Add(supportedLanguageGroup);
            Controls.Add(statusStrip);
            Controls.Add(mainMenuStrip);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = mainMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "wisp.ViaAzure";
            Load += OnLoad;
            Shown += OnShown;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            supportedLanguageGroup.ResumeLayout(false);
            supportedLanguageGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}

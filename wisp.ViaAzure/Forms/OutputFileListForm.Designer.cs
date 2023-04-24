namespace wisp.ViaAzure.Forms
{
    partial class OutputFileListForm
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
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.directoryPathText = new System.Windows.Forms.TextBox();
            this.directoryOpenButton = new System.Windows.Forms.Button();
            this.outputFileList = new System.Windows.Forms.ListView();
            this.fileNameHeader = new System.Windows.Forms.ColumnHeader();
            this.filePathHeader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // outputDirectoryLabel
            // 
            this.outputDirectoryLabel.AutoSize = true;
            this.outputDirectoryLabel.Location = new System.Drawing.Point(12, 16);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(56, 18);
            this.outputDirectoryLabel.TabIndex = 0;
            this.outputDirectoryLabel.Text = "出力パス";
            // 
            // directoryPathText
            // 
            this.directoryPathText.BackColor = System.Drawing.SystemColors.Control;
            this.directoryPathText.ForeColor = System.Drawing.Color.Blue;
            this.directoryPathText.Location = new System.Drawing.Point(74, 13);
            this.directoryPathText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.directoryPathText.Name = "directoryPathText";
            this.directoryPathText.ReadOnly = true;
            this.directoryPathText.Size = new System.Drawing.Size(314, 25);
            this.directoryPathText.TabIndex = 1;
            this.directoryPathText.Text = "#";
            // 
            // directoryOpenButton
            // 
            this.directoryOpenButton.Location = new System.Drawing.Point(394, 13);
            this.directoryOpenButton.Name = "directoryOpenButton";
            this.directoryOpenButton.Size = new System.Drawing.Size(96, 26);
            this.directoryOpenButton.TabIndex = 2;
            this.directoryOpenButton.Text = "開く(&O)";
            this.directoryOpenButton.UseVisualStyleBackColor = true;
            this.directoryOpenButton.Click += new System.EventHandler(this.OnOpenClick);
            // 
            // outputFileList
            // 
            this.outputFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameHeader,
            this.filePathHeader});
            this.outputFileList.FullRowSelect = true;
            this.outputFileList.GridLines = true;
            this.outputFileList.Location = new System.Drawing.Point(12, 45);
            this.outputFileList.Name = "outputFileList";
            this.outputFileList.Size = new System.Drawing.Size(602, 461);
            this.outputFileList.TabIndex = 3;
            this.outputFileList.UseCompatibleStateImageBehavior = false;
            this.outputFileList.View = System.Windows.Forms.View.Details;
            this.outputFileList.VirtualMode = true;
            this.outputFileList.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.OnOutputFileRetrieveVirtualItem);
            // 
            // fileNameHeader
            // 
            this.fileNameHeader.Text = "名称";
            this.fileNameHeader.Width = 120;
            // 
            // filePathHeader
            // 
            this.filePathHeader.Text = "パス";
            this.filePathHeader.Width = 320;
            // 
            // OutputFileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 518);
            this.Controls.Add(this.outputFileList);
            this.Controls.Add(this.directoryOpenButton);
            this.Controls.Add(this.directoryPathText);
            this.Controls.Add(this.outputDirectoryLabel);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputFileListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出力ファイル一覧";
            this.Shown += new System.EventHandler(this.OnShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label outputDirectoryLabel;
        private TextBox directoryPathText;
        private Button directoryOpenButton;
        private ListView outputFileList;
        private ColumnHeader fileNameHeader;
        private ColumnHeader filePathHeader;
    }
}

namespace wisp.ViaAzure.Forms
{
    partial class AzureSpeachServiceConfigForm
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
            keyLabel = new Label();
            keyText = new TextBox();
            regionLabel = new Label();
            regionText = new TextBox();
            applyButton = new Button();
            SuspendLayout();
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(12, 9);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(30, 18);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "&Key";
            // 
            // keyText
            // 
            keyText.Location = new Point(12, 30);
            keyText.Name = "keyText";
            keyText.Size = new Size(417, 25);
            keyText.TabIndex = 1;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new Point(12, 58);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(47, 18);
            regionLabel.TabIndex = 2;
            regionLabel.Text = "&Region";
            // 
            // regionText
            // 
            regionText.Location = new Point(12, 79);
            regionText.Name = "regionText";
            regionText.Size = new Size(417, 25);
            regionText.TabIndex = 3;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(333, 110);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(96, 28);
            applyButton.TabIndex = 4;
            applyButton.Text = "&OK";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += OnApplyClick;
            // 
            // AzureSpeachServiceConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 149);
            Controls.Add(applyButton);
            Controls.Add(regionText);
            Controls.Add(regionLabel);
            Controls.Add(keyText);
            Controls.Add(keyLabel);
            Font = new Font("メイリオ", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(455, 188);
            MinimizeBox = false;
            MinimumSize = new Size(455, 188);
            Name = "AzureSpeachServiceConfigForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Speach Service 設定";
            KeyUp += OnKeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label keyLabel;
        private TextBox keyText;
        private Label regionLabel;
        private TextBox regionText;
        private Button applyButton;
    }
}
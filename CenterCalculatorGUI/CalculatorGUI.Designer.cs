namespace CenterCalculatorGUI
{
    partial class centerCalculatorGUI
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
            this.DriveSprocketSelector = new System.Windows.Forms.NumericUpDown();
            this.driveSprocketSelectorLabel = new System.Windows.Forms.Label();
            this.DrivenSprocketSelector = new System.Windows.Forms.NumericUpDown();
            this.DrivenSprocketSelectorLabel = new System.Windows.Forms.Label();
            this.ratioSymbol = new System.Windows.Forms.Label();
            this.TorqueRatioIndicatorLabel = new System.Windows.Forms.Label();
            this.CenterDistEntry = new System.Windows.Forms.TextBox();
            this.centerDistInputLabel = new System.Windows.Forms.Label();
            this.PitchComboBox = new System.Windows.Forms.ComboBox();
            this.pitchSelectorLabel = new System.Windows.Forms.Label();
            this.LongCenterLabel = new System.Windows.Forms.Label();
            this.ShortLinkCountLabel = new System.Windows.Forms.Label();
            this.LongLinkCountLabel = new System.Windows.Forms.Label();
            this.TorqueRatioIndicator = new System.Windows.Forms.TextBox();
            this.ShortDistIndicator = new System.Windows.Forms.TextBox();
            this.ShortLengthIndicator = new System.Windows.Forms.TextBox();
            this.LongDistIndicator = new System.Windows.Forms.TextBox();
            this.LongLengthIndicator = new System.Windows.Forms.TextBox();
            this.ShortCenterLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.InvalidPitchInput = new System.Windows.Forms.Label();
            this.InvalidCenterInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriveSprocketSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrivenSprocketSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // DriveSprocketSelector
            // 
            this.DriveSprocketSelector.Location = new System.Drawing.Point(66, 169);
            this.DriveSprocketSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DriveSprocketSelector.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DriveSprocketSelector.Name = "DriveSprocketSelector";
            this.DriveSprocketSelector.Size = new System.Drawing.Size(80, 27);
            this.DriveSprocketSelector.TabIndex = 1;
            this.DriveSprocketSelector.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DriveSprocketSelector.ValueChanged += new System.EventHandler(this.DrivingSprocketChainged);
            // 
            // driveSprocketSelectorLabel
            // 
            this.driveSprocketSelectorLabel.AutoSize = true;
            this.driveSprocketSelectorLabel.Location = new System.Drawing.Point(13, 147);
            this.driveSprocketSelectorLabel.Name = "driveSprocketSelectorLabel";
            this.driveSprocketSelectorLabel.Size = new System.Drawing.Size(183, 19);
            this.driveSprocketSelectorLabel.TabIndex = 2;
            this.driveSprocketSelectorLabel.Text = "Teeth on driving sproket";
            // 
            // DrivenSprocketSelector
            // 
            this.DrivenSprocketSelector.Location = new System.Drawing.Point(314, 169);
            this.DrivenSprocketSelector.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DrivenSprocketSelector.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DrivenSprocketSelector.Name = "DrivenSprocketSelector";
            this.DrivenSprocketSelector.Size = new System.Drawing.Size(80, 27);
            this.DrivenSprocketSelector.TabIndex = 1;
            this.DrivenSprocketSelector.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.DrivenSprocketSelector.ValueChanged += new System.EventHandler(this.DrivenSprocketChainged);
            this.DrivenSprocketSelector.Leave += new System.EventHandler(this.DrivenSprocketChainged);
            // 
            // DrivenSprocketSelectorLabel
            // 
            this.DrivenSprocketSelectorLabel.AutoSize = true;
            this.DrivenSprocketSelectorLabel.Location = new System.Drawing.Point(268, 147);
            this.DrivenSprocketSelectorLabel.Name = "DrivenSprocketSelectorLabel";
            this.DrivenSprocketSelectorLabel.Size = new System.Drawing.Size(178, 19);
            this.DrivenSprocketSelectorLabel.TabIndex = 2;
            this.DrivenSprocketSelectorLabel.Text = "Teeth on driven sproket";
            // 
            // ratioSymbol
            // 
            this.ratioSymbol.AutoSize = true;
            this.ratioSymbol.Location = new System.Drawing.Point(304, 246);
            this.ratioSymbol.Name = "ratioSymbol";
            this.ratioSymbol.Size = new System.Drawing.Size(24, 19);
            this.ratioSymbol.TabIndex = 3;
            this.ratioSymbol.Text = ":1";
            this.ratioSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TorqueRatioIndicatorLabel
            // 
            this.TorqueRatioIndicatorLabel.AutoSize = true;
            this.TorqueRatioIndicatorLabel.Location = new System.Drawing.Point(127, 246);
            this.TorqueRatioIndicatorLabel.Name = "TorqueRatioIndicatorLabel";
            this.TorqueRatioIndicatorLabel.Size = new System.Drawing.Size(107, 19);
            this.TorqueRatioIndicatorLabel.TabIndex = 4;
            this.TorqueRatioIndicatorLabel.Text = "Torque Ratio:";
            // 
            // CenterDistEntry
            // 
            this.CenterDistEntry.Location = new System.Drawing.Point(314, 72);
            this.CenterDistEntry.MaxLength = 8;
            this.CenterDistEntry.Name = "CenterDistEntry";
            this.CenterDistEntry.Size = new System.Drawing.Size(83, 27);
            this.CenterDistEntry.TabIndex = 6;
            this.CenterDistEntry.TextChanged += new System.EventHandler(this.DesierdCenterChanged);
            // 
            // centerDistInputLabel
            // 
            this.centerDistInputLabel.AutoSize = true;
            this.centerDistInputLabel.Location = new System.Drawing.Point(271, 50);
            this.centerDistInputLabel.Name = "centerDistInputLabel";
            this.centerDistInputLabel.Size = new System.Drawing.Size(177, 19);
            this.centerDistInputLabel.TabIndex = 7;
            this.centerDistInputLabel.Text = "Desired Center Distance";
            // 
            // PitchComboBox
            // 
            this.PitchComboBox.FormattingEnabled = true;
            this.PitchComboBox.Items.AddRange(new object[] {
            "#25",
            "#35",
            "#40",
            "#50",
            "#60",
            "#80",
            "#100",
            "#120",
            "#140",
            "#160",
            "#180",
            "#200",
            "#240"});
            this.PitchComboBox.Location = new System.Drawing.Point(55, 72);
            this.PitchComboBox.MaxLength = 6;
            this.PitchComboBox.Name = "PitchComboBox";
            this.PitchComboBox.Size = new System.Drawing.Size(97, 27);
            this.PitchComboBox.TabIndex = 9;
            this.PitchComboBox.TextUpdate += new System.EventHandler(this.PitchValueChanged);
            this.PitchComboBox.TextChanged += new System.EventHandler(this.PitchValueChanged);
            // 
            // pitchSelectorLabel
            // 
            this.pitchSelectorLabel.AutoSize = true;
            this.pitchSelectorLabel.Location = new System.Drawing.Point(18, 31);
            this.pitchSelectorLabel.Name = "pitchSelectorLabel";
            this.pitchSelectorLabel.Size = new System.Drawing.Size(190, 38);
            this.pitchSelectorLabel.TabIndex = 10;
            this.pitchSelectorLabel.Text = "Select the ANSI chain #\r\nor enter the decimal pitch";
            // 
            // LongCenterLabel
            // 
            this.LongCenterLabel.AutoSize = true;
            this.LongCenterLabel.Location = new System.Drawing.Point(22, 492);
            this.LongCenterLabel.Name = "LongCenterLabel";
            this.LongCenterLabel.Size = new System.Drawing.Size(165, 19);
            this.LongCenterLabel.TabIndex = 8;
            this.LongCenterLabel.Text = "Long Center Distance:";
            this.LongCenterLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShortLinkCountLabel
            // 
            this.ShortLinkCountLabel.AutoSize = true;
            this.ShortLinkCountLabel.Location = new System.Drawing.Point(22, 408);
            this.ShortLinkCountLabel.Name = "ShortLinkCountLabel";
            this.ShortLinkCountLabel.Size = new System.Drawing.Size(179, 19);
            this.ShortLinkCountLabel.TabIndex = 8;
            this.ShortLinkCountLabel.Text = "Short Chain Link Count:";
            this.ShortLinkCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LongLinkCountLabel
            // 
            this.LongLinkCountLabel.AutoSize = true;
            this.LongLinkCountLabel.Location = new System.Drawing.Point(22, 524);
            this.LongLinkCountLabel.Name = "LongLinkCountLabel";
            this.LongLinkCountLabel.Size = new System.Drawing.Size(176, 19);
            this.LongLinkCountLabel.TabIndex = 8;
            this.LongLinkCountLabel.Text = "Long Chain Link Count:";
            this.LongLinkCountLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TorqueRatioIndicator
            // 
            this.TorqueRatioIndicator.Location = new System.Drawing.Point(230, 243);
            this.TorqueRatioIndicator.Name = "TorqueRatioIndicator";
            this.TorqueRatioIndicator.ReadOnly = true;
            this.TorqueRatioIndicator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TorqueRatioIndicator.Size = new System.Drawing.Size(72, 27);
            this.TorqueRatioIndicator.TabIndex = 11;
            this.TorqueRatioIndicator.Text = "1";
            // 
            // ShortDistIndicator
            // 
            this.ShortDistIndicator.Location = new System.Drawing.Point(187, 370);
            this.ShortDistIndicator.Name = "ShortDistIndicator";
            this.ShortDistIndicator.ReadOnly = true;
            this.ShortDistIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShortDistIndicator.Size = new System.Drawing.Size(259, 27);
            this.ShortDistIndicator.TabIndex = 11;
            // 
            // ShortLengthIndicator
            // 
            this.ShortLengthIndicator.Location = new System.Drawing.Point(198, 405);
            this.ShortLengthIndicator.Name = "ShortLengthIndicator";
            this.ShortLengthIndicator.ReadOnly = true;
            this.ShortLengthIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShortLengthIndicator.Size = new System.Drawing.Size(259, 27);
            this.ShortLengthIndicator.TabIndex = 11;
            // 
            // LongDistIndicator
            // 
            this.LongDistIndicator.Location = new System.Drawing.Point(187, 489);
            this.LongDistIndicator.Name = "LongDistIndicator";
            this.LongDistIndicator.ReadOnly = true;
            this.LongDistIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LongDistIndicator.Size = new System.Drawing.Size(259, 27);
            this.LongDistIndicator.TabIndex = 11;
            // 
            // LongLengthIndicator
            // 
            this.LongLengthIndicator.Location = new System.Drawing.Point(196, 521);
            this.LongLengthIndicator.Name = "LongLengthIndicator";
            this.LongLengthIndicator.ReadOnly = true;
            this.LongLengthIndicator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LongLengthIndicator.Size = new System.Drawing.Size(259, 27);
            this.LongLengthIndicator.TabIndex = 11;
            // 
            // ShortCenterLabel
            // 
            this.ShortCenterLabel.AutoSize = true;
            this.ShortCenterLabel.Location = new System.Drawing.Point(19, 373);
            this.ShortCenterLabel.Name = "ShortCenterLabel";
            this.ShortCenterLabel.Size = new System.Drawing.Size(168, 19);
            this.ShortCenterLabel.TabIndex = 8;
            this.ShortCenterLabel.Text = "Short Center Distance:";
            this.ShortCenterLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(167, 302);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(126, 36);
            this.runButton.TabIndex = 12;
            this.runButton.Text = "Run Calculator";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // InvalidPitchInput
            // 
            this.InvalidPitchInput.AutoSize = true;
            this.InvalidPitchInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidPitchInput.Location = new System.Drawing.Point(54, 102);
            this.InvalidPitchInput.Name = "InvalidPitchInput";
            this.InvalidPitchInput.Size = new System.Drawing.Size(100, 19);
            this.InvalidPitchInput.TabIndex = 13;
            this.InvalidPitchInput.Text = "Invalid Input";
            this.InvalidPitchInput.Visible = false;
            // 
            // InvalidCenterInput
            // 
            this.InvalidCenterInput.AutoSize = true;
            this.InvalidCenterInput.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidCenterInput.Location = new System.Drawing.Point(304, 102);
            this.InvalidCenterInput.Name = "InvalidCenterInput";
            this.InvalidCenterInput.Size = new System.Drawing.Size(100, 19);
            this.InvalidCenterInput.TabIndex = 13;
            this.InvalidCenterInput.Text = "Invalid Input";
            this.InvalidCenterInput.Visible = false;
            // 
            // centerCalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 567);
            this.Controls.Add(this.InvalidCenterInput);
            this.Controls.Add(this.InvalidPitchInput);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.LongLengthIndicator);
            this.Controls.Add(this.LongDistIndicator);
            this.Controls.Add(this.ShortLengthIndicator);
            this.Controls.Add(this.ShortDistIndicator);
            this.Controls.Add(this.TorqueRatioIndicator);
            this.Controls.Add(this.pitchSelectorLabel);
            this.Controls.Add(this.PitchComboBox);
            this.Controls.Add(this.LongCenterLabel);
            this.Controls.Add(this.LongLinkCountLabel);
            this.Controls.Add(this.ShortCenterLabel);
            this.Controls.Add(this.ShortLinkCountLabel);
            this.Controls.Add(this.centerDistInputLabel);
            this.Controls.Add(this.CenterDistEntry);
            this.Controls.Add(this.TorqueRatioIndicatorLabel);
            this.Controls.Add(this.ratioSymbol);
            this.Controls.Add(this.DrivenSprocketSelectorLabel);
            this.Controls.Add(this.driveSprocketSelectorLabel);
            this.Controls.Add(this.DrivenSprocketSelector);
            this.Controls.Add(this.DriveSprocketSelector);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "centerCalculatorGUI";
            this.Text = "Sprocket Center Distance Caculator";
            ((System.ComponentModel.ISupportInitialize)(this.DriveSprocketSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrivenSprocketSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown DriveSprocketSelector;
        private System.Windows.Forms.Label driveSprocketSelectorLabel;
        private System.Windows.Forms.NumericUpDown DrivenSprocketSelector;
        private System.Windows.Forms.Label DrivenSprocketSelectorLabel;
        private System.Windows.Forms.Label ratioSymbol;
        private System.Windows.Forms.Label TorqueRatioIndicatorLabel;
        private System.Windows.Forms.TextBox CenterDistEntry;
        private System.Windows.Forms.Label centerDistInputLabel;
        private System.Windows.Forms.ComboBox PitchComboBox;
        private System.Windows.Forms.Label pitchSelectorLabel;
        private System.Windows.Forms.Label LongCenterLabel;
        private System.Windows.Forms.Label ShortLinkCountLabel;
        private System.Windows.Forms.Label LongLinkCountLabel;
        private System.Windows.Forms.TextBox TorqueRatioIndicator;
        private System.Windows.Forms.TextBox ShortDistIndicator;
        private System.Windows.Forms.TextBox ShortLengthIndicator;
        private System.Windows.Forms.TextBox LongDistIndicator;
        private System.Windows.Forms.TextBox LongLengthIndicator;
        private System.Windows.Forms.Label ShortCenterLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label InvalidPitchInput;
        private System.Windows.Forms.Label InvalidCenterInput;
    }
}


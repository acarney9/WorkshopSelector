namespace WorkshopSelector
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.workshopLabel = new System.Windows.Forms.Label();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.programmingCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.socialCheckBox = new System.Windows.Forms.CheckBox();
            this.securityCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.insuranceRadioButton = new System.Windows.Forms.RadioButton();
            this.noInsuranceRadioButton = new System.Windows.Forms.RadioButton();
            this.nightsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.MistyRose;
            this.outputLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(12, 293);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(251, 159);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling stress           3 Days   $1,000",
            "Time Mgt.                    3 Days   $ 800",
            "Supervision Skills        3 Days   $ 1,500",
            "Negotiation                 5 Days   $ 1,300",
            "How to Interview        1 Days   $500"});
            this.workshopListBox.Location = new System.Drawing.Point(15, 52);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(248, 56);
            this.workshopListBox.TabIndex = 1;
            // 
            // workshopLabel
            // 
            this.workshopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopLabel.Location = new System.Drawing.Point(12, 31);
            this.workshopLabel.Name = "workshopLabel";
            this.workshopLabel.Size = new System.Drawing.Size(237, 18);
            this.workshopLabel.TabIndex = 2;
            this.workshopLabel.Text = "Workshop/ Days/ Fee";
            this.workshopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin     $150",
            "Chicago  $ 225",
            "Dallas      $ 175",
            "Orlando  $ 300"});
            this.locationListBox.Location = new System.Drawing.Point(371, 52);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(131, 56);
            this.locationListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location/ Lodging Fees";
            // 
            // programmingCheckBox
            // 
            this.programmingCheckBox.AutoSize = true;
            this.programmingCheckBox.Location = new System.Drawing.Point(11, 30);
            this.programmingCheckBox.Name = "programmingCheckBox";
            this.programmingCheckBox.Size = new System.Drawing.Size(193, 17);
            this.programmingCheckBox.TabIndex = 5;
            this.programmingCheckBox.Text = "C# Programming Tarining - $125.00";
            this.programmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.socialCheckBox);
            this.groupBox1.Controls.Add(this.securityCheckBox);
            this.groupBox1.Controls.Add(this.programmingCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conference Extra\'s";
            // 
            // socialCheckBox
            // 
            this.socialCheckBox.AutoSize = true;
            this.socialCheckBox.Location = new System.Drawing.Point(11, 97);
            this.socialCheckBox.Name = "socialCheckBox";
            this.socialCheckBox.Size = new System.Drawing.Size(128, 17);
            this.socialCheckBox.TabIndex = 7;
            this.socialCheckBox.Text = "Social Event - $25.00";
            this.socialCheckBox.UseVisualStyleBackColor = true;
            // 
            // securityCheckBox
            // 
            this.securityCheckBox.AutoSize = true;
            this.securityCheckBox.Location = new System.Drawing.Point(11, 63);
            this.securityCheckBox.Name = "securityCheckBox";
            this.securityCheckBox.Size = new System.Drawing.Size(153, 17);
            this.securityCheckBox.TabIndex = 6;
            this.securityCheckBox.Text = "Security Training - $125.00";
            this.securityCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.insuranceRadioButton);
            this.groupBox2.Controls.Add(this.noInsuranceRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(371, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancellation Insurance";
            // 
            // insuranceRadioButton
            // 
            this.insuranceRadioButton.AutoSize = true;
            this.insuranceRadioButton.Location = new System.Drawing.Point(22, 62);
            this.insuranceRadioButton.Name = "insuranceRadioButton";
            this.insuranceRadioButton.Size = new System.Drawing.Size(114, 17);
            this.insuranceRadioButton.TabIndex = 1;
            this.insuranceRadioButton.TabStop = true;
            this.insuranceRadioButton.Text = "Insurance - $30.00";
            this.insuranceRadioButton.UseVisualStyleBackColor = true;
            // 
            // noInsuranceRadioButton
            // 
            this.noInsuranceRadioButton.AutoSize = true;
            this.noInsuranceRadioButton.Location = new System.Drawing.Point(22, 28);
            this.noInsuranceRadioButton.Name = "noInsuranceRadioButton";
            this.noInsuranceRadioButton.Size = new System.Drawing.Size(89, 17);
            this.noInsuranceRadioButton.TabIndex = 0;
            this.noInsuranceRadioButton.TabStop = true;
            this.noInsuranceRadioButton.Text = "No Insurance";
            this.noInsuranceRadioButton.UseVisualStyleBackColor = true;
            // 
            // nightsListBox
            // 
            this.nightsListBox.FormattingEnabled = true;
            this.nightsListBox.Items.AddRange(new object[] {
            "None",
            "1 Night -   $ 100.00",
            "2 Nights - $ 200.00",
            "3 Nights - $ 300.00"});
            this.nightsListBox.Location = new System.Drawing.Point(367, 253);
            this.nightsListBox.Name = "nightsListBox";
            this.nightsListBox.Size = new System.Drawing.Size(173, 56);
            this.nightsListBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Additional Nights";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(27, 487);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 59);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(222, 487);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 59);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(415, 487);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 59);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(590, 612);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nightsListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workshopLabel);
            this.Controls.Add(this.workshopListBox);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.Label workshopLabel;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox programmingCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox socialCheckBox;
        private System.Windows.Forms.CheckBox securityCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton insuranceRadioButton;
        private System.Windows.Forms.RadioButton noInsuranceRadioButton;
        private System.Windows.Forms.ListBox nightsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}


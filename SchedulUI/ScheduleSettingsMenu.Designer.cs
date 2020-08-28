namespace SchedulUI
{
    partial class ScheduleSettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleSettingsMenu));
            this.confirmButton = new System.Windows.Forms.Button();
            this.lunchExtraCheckBox = new System.Windows.Forms.CheckedListBox();
            this.lunchFront10 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lunchGroupBox = new System.Windows.Forms.GroupBox();
            this.lunchBack35 = new System.Windows.Forms.ComboBox();
            this.lunchFront35 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lunchBack10 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dinnerGroupBox = new System.Windows.Forms.GroupBox();
            this.dinnerBack9 = new System.Windows.Forms.ComboBox();
            this.dinnerfront9 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dinnerBack8 = new System.Windows.Forms.ComboBox();
            this.dinnerfront8 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dinnerExtraCheckbox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dayOfWeekCombobox = new System.Windows.Forms.ComboBox();
            this.lunchGroupBox.SuspendLayout();
            this.dinnerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(436, 664);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(227, 76);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // lunchExtraCheckBox
            // 
            this.lunchExtraCheckBox.FormattingEnabled = true;
            this.lunchExtraCheckBox.Items.AddRange(new object[] {
            "Extra Cash",
            "Custard",
            "Runner",
            "Dining",
            "Extra Grill",
            "Float",
            "Extra Buns",
            "Extra Fryer"});
            this.lunchExtraCheckBox.Location = new System.Drawing.Point(114, 30);
            this.lunchExtraCheckBox.Name = "lunchExtraCheckBox";
            this.lunchExtraCheckBox.Size = new System.Drawing.Size(227, 228);
            this.lunchExtraCheckBox.TabIndex = 6;
            // 
            // lunchFront10
            // 
            this.lunchFront10.FormattingEnabled = true;
            this.lunchFront10.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lunchFront10.Location = new System.Drawing.Point(144, 345);
            this.lunchFront10.MaxDropDownItems = 9;
            this.lunchFront10.Name = "lunchFront10";
            this.lunchFront10.Size = new System.Drawing.Size(93, 33);
            this.lunchFront10.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frontline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "BackLine";
            // 
            // lunchGroupBox
            // 
            this.lunchGroupBox.Controls.Add(this.lunchBack35);
            this.lunchGroupBox.Controls.Add(this.lunchFront35);
            this.lunchGroupBox.Controls.Add(this.label6);
            this.lunchGroupBox.Controls.Add(this.lunchBack10);
            this.lunchGroupBox.Controls.Add(this.label1);
            this.lunchGroupBox.Controls.Add(this.lunchExtraCheckBox);
            this.lunchGroupBox.Controls.Add(this.lunchFront10);
            this.lunchGroupBox.Controls.Add(this.label5);
            this.lunchGroupBox.Controls.Add(this.label4);
            this.lunchGroupBox.Location = new System.Drawing.Point(12, 94);
            this.lunchGroupBox.Name = "lunchGroupBox";
            this.lunchGroupBox.Size = new System.Drawing.Size(473, 528);
            this.lunchGroupBox.TabIndex = 12;
            this.lunchGroupBox.TabStop = false;
            this.lunchGroupBox.Text = "Lunch";
            // 
            // lunchBack35
            // 
            this.lunchBack35.FormattingEnabled = true;
            this.lunchBack35.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lunchBack35.Location = new System.Drawing.Point(318, 437);
            this.lunchBack35.Name = "lunchBack35";
            this.lunchBack35.Size = new System.Drawing.Size(93, 33);
            this.lunchBack35.TabIndex = 19;
            // 
            // lunchFront35
            // 
            this.lunchFront35.FormattingEnabled = true;
            this.lunchFront35.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lunchFront35.Location = new System.Drawing.Point(142, 437);
            this.lunchFront35.Name = "lunchFront35";
            this.lunchFront35.Size = new System.Drawing.Size(93, 33);
            this.lunchFront35.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "People 3-5";
            // 
            // lunchBack10
            // 
            this.lunchBack10.FormattingEnabled = true;
            this.lunchBack10.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.lunchBack10.Location = new System.Drawing.Point(318, 345);
            this.lunchBack10.Name = "lunchBack10";
            this.lunchBack10.Size = new System.Drawing.Size(93, 33);
            this.lunchBack10.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "People at 10";
            // 
            // dinnerGroupBox
            // 
            this.dinnerGroupBox.Controls.Add(this.dinnerBack9);
            this.dinnerGroupBox.Controls.Add(this.dinnerfront9);
            this.dinnerGroupBox.Controls.Add(this.label9);
            this.dinnerGroupBox.Controls.Add(this.dinnerBack8);
            this.dinnerGroupBox.Controls.Add(this.dinnerfront8);
            this.dinnerGroupBox.Controls.Add(this.label8);
            this.dinnerGroupBox.Controls.Add(this.dinnerExtraCheckbox);
            this.dinnerGroupBox.Controls.Add(this.label3);
            this.dinnerGroupBox.Controls.Add(this.label7);
            this.dinnerGroupBox.Location = new System.Drawing.Point(587, 94);
            this.dinnerGroupBox.Name = "dinnerGroupBox";
            this.dinnerGroupBox.Size = new System.Drawing.Size(473, 528);
            this.dinnerGroupBox.TabIndex = 13;
            this.dinnerGroupBox.TabStop = false;
            this.dinnerGroupBox.Text = "Dinner";
            // 
            // dinnerBack9
            // 
            this.dinnerBack9.FormattingEnabled = true;
            this.dinnerBack9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.dinnerBack9.Location = new System.Drawing.Point(350, 432);
            this.dinnerBack9.Name = "dinnerBack9";
            this.dinnerBack9.Size = new System.Drawing.Size(93, 33);
            this.dinnerBack9.TabIndex = 24;
            // 
            // dinnerfront9
            // 
            this.dinnerfront9.FormattingEnabled = true;
            this.dinnerfront9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.dinnerfront9.Location = new System.Drawing.Point(183, 432);
            this.dinnerfront9.Name = "dinnerfront9";
            this.dinnerfront9.Size = new System.Drawing.Size(93, 33);
            this.dinnerfront9.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "People at 9";
            // 
            // dinnerBack8
            // 
            this.dinnerBack8.FormattingEnabled = true;
            this.dinnerBack8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.dinnerBack8.Location = new System.Drawing.Point(350, 345);
            this.dinnerBack8.Name = "dinnerBack8";
            this.dinnerBack8.Size = new System.Drawing.Size(93, 33);
            this.dinnerBack8.TabIndex = 21;
            // 
            // dinnerfront8
            // 
            this.dinnerfront8.FormattingEnabled = true;
            this.dinnerfront8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.dinnerfront8.Location = new System.Drawing.Point(183, 345);
            this.dinnerfront8.Name = "dinnerfront8";
            this.dinnerfront8.Size = new System.Drawing.Size(93, 33);
            this.dinnerfront8.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "People at 8";
            // 
            // dinnerExtraCheckbox
            // 
            this.dinnerExtraCheckbox.FormattingEnabled = true;
            this.dinnerExtraCheckbox.Items.AddRange(new object[] {
            "Extra Cash",
            "Extra Custard",
            "Runner",
            "Dining",
            "Extra Grill",
            "Float",
            "Extra Buns",
            "Extra Fryer"});
            this.dinnerExtraCheckbox.Location = new System.Drawing.Point(119, 30);
            this.dinnerExtraCheckbox.Name = "dinnerExtraCheckbox";
            this.dinnerExtraCheckbox.Size = new System.Drawing.Size(227, 228);
            this.dinnerExtraCheckbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "BackLine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Frontline";
            // 
            // dayOfWeekCombobox
            // 
            this.dayOfWeekCombobox.FormattingEnabled = true;
            this.dayOfWeekCombobox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayOfWeekCombobox.Location = new System.Drawing.Point(410, 26);
            this.dayOfWeekCombobox.MaxDropDownItems = 9;
            this.dayOfWeekCombobox.Name = "dayOfWeekCombobox";
            this.dayOfWeekCombobox.Size = new System.Drawing.Size(227, 33);
            this.dayOfWeekCombobox.TabIndex = 14;
            this.dayOfWeekCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ScheduleSettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 804);
            this.Controls.Add(this.dayOfWeekCombobox);
            this.Controls.Add(this.dinnerGroupBox);
            this.Controls.Add(this.lunchGroupBox);
            this.Controls.Add(this.confirmButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScheduleSettingsMenu";
            this.Text = "Schedule Settings";
            this.lunchGroupBox.ResumeLayout(false);
            this.lunchGroupBox.PerformLayout();
            this.dinnerGroupBox.ResumeLayout(false);
            this.dinnerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.CheckedListBox lunchExtraCheckBox;
        private System.Windows.Forms.ComboBox lunchFront10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox lunchGroupBox;
        private System.Windows.Forms.ComboBox lunchBack10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dinnerGroupBox;
        private System.Windows.Forms.CheckedListBox dinnerExtraCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dayOfWeekCombobox;
        private System.Windows.Forms.ComboBox lunchBack35;
        private System.Windows.Forms.ComboBox lunchFront35;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dinnerBack9;
        private System.Windows.Forms.ComboBox dinnerfront9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dinnerBack8;
        private System.Windows.Forms.ComboBox dinnerfront8;
    }
}
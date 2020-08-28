namespace SchedulUI
{
    partial class AvailabilityForm
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
            this.availLabel = new System.Windows.Forms.Label();
            this.daysOfWeekCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allDayCheckbox = new System.Windows.Forms.CheckBox();
            this.addAvailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availLabel
            // 
            this.availLabel.AutoSize = true;
            this.availLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.availLabel.Location = new System.Drawing.Point(12, 9);
            this.availLabel.Name = "availLabel";
            this.availLabel.Size = new System.Drawing.Size(421, 47);
            this.availLabel.TabIndex = 0;
            this.availLabel.Text = "Add Employee Availability";
            // 
            // daysOfWeekCheckListBox
            // 
            this.daysOfWeekCheckListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysOfWeekCheckListBox.FormattingEnabled = true;
            this.daysOfWeekCheckListBox.Items.AddRange(new object[] {
            "Sundays",
            "Mondays",
            "Tuesdays",
            "Wednesdays",
            "Thursdays",
            "Fridays",
            "Saturdays"});
            this.daysOfWeekCheckListBox.Location = new System.Drawing.Point(20, 98);
            this.daysOfWeekCheckListBox.Name = "daysOfWeekCheckListBox";
            this.daysOfWeekCheckListBox.Size = new System.Drawing.Size(228, 270);
            this.daysOfWeekCheckListBox.TabIndex = 1;
            // 
            // startTimePicker
            // 
            this.startTimePicker.CustomFormat = "Time";
            this.startTimePicker.Location = new System.Drawing.Point(309, 208);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(359, 35);
            this.startTimePicker.TabIndex = 3;
            this.startTimePicker.Value = new System.DateTime(2020, 8, 25, 10, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.CustomFormat = "Time";
            this.endTimePicker.Location = new System.Drawing.Point(309, 324);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(359, 35);
            this.endTimePicker.TabIndex = 4;
            this.endTimePicker.Value = new System.DateTime(2020, 8, 25, 15, 0, 0, 0);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(304, 175);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(106, 30);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "End Time";
            // 
            // allDayCheckbox
            // 
            this.allDayCheckbox.AutoSize = true;
            this.allDayCheckbox.BackColor = System.Drawing.Color.White;
            this.allDayCheckbox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDayCheckbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.allDayCheckbox.Location = new System.Drawing.Point(307, 98);
            this.allDayCheckbox.Name = "allDayCheckbox";
            this.allDayCheckbox.Size = new System.Drawing.Size(126, 44);
            this.allDayCheckbox.TabIndex = 7;
            this.allDayCheckbox.Text = "All Day";
            this.allDayCheckbox.UseVisualStyleBackColor = false;
            this.allDayCheckbox.CheckedChanged += new System.EventHandler(this.allDayCheckbox_CheckedChanged);
            // 
            // addAvailButton
            // 
            this.addAvailButton.Location = new System.Drawing.Point(220, 444);
            this.addAvailButton.Name = "addAvailButton";
            this.addAvailButton.Size = new System.Drawing.Size(227, 84);
            this.addAvailButton.TabIndex = 8;
            this.addAvailButton.Text = "Add Availability";
            this.addAvailButton.UseVisualStyleBackColor = true;
            this.addAvailButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 581);
            this.Controls.Add(this.addAvailButton);
            this.Controls.Add(this.allDayCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.daysOfWeekCheckListBox);
            this.Controls.Add(this.availLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AvailabilityForm";
            this.Text = "AvailabilityForm";
            this.Load += new System.EventHandler(this.AvailabilityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availLabel;
        private System.Windows.Forms.CheckedListBox daysOfWeekCheckListBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox allDayCheckbox;
        private System.Windows.Forms.Button addAvailButton;
    }
}
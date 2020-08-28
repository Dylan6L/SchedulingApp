namespace SchedulUI
{
    partial class TimeOffForm
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
            this.emplyeesLabel = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.MonthCalendar();
            this.endDate = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.allDayCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emplyeesLabel
            // 
            this.emplyeesLabel.AutoSize = true;
            this.emplyeesLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplyeesLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.emplyeesLabel.Location = new System.Drawing.Point(12, 9);
            this.emplyeesLabel.Name = "emplyeesLabel";
            this.emplyeesLabel.Size = new System.Drawing.Size(310, 65);
            this.emplyeesLabel.TabIndex = 2;
            this.emplyeesLabel.Text = "Add Time Off";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(18, 159);
            this.startDate.MaxSelectionCount = 1;
            this.startDate.Name = "startDate";
            this.startDate.TabIndex = 3;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(18, 397);
            this.endDate.MaxSelectionCount = 1;
            this.endDate.Name = "endDate";
            this.endDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(18, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "End";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(305, 199);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(169, 29);
            this.startTimePicker.TabIndex = 7;
            this.startTimePicker.Value = new System.DateTime(2020, 8, 25, 10, 0, 0, 0);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(305, 425);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(179, 29);
            this.endTimePicker.TabIndex = 8;
            this.endTimePicker.Value = new System.DateTime(2020, 8, 25, 13, 0, 0, 0);
            // 
            // allDayCheckbox
            // 
            this.allDayCheckbox.AutoSize = true;
            this.allDayCheckbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDayCheckbox.ForeColor = System.Drawing.Color.SteelBlue;
            this.allDayCheckbox.Location = new System.Drawing.Point(305, 113);
            this.allDayCheckbox.Name = "allDayCheckbox";
            this.allDayCheckbox.Size = new System.Drawing.Size(109, 36);
            this.allDayCheckbox.TabIndex = 9;
            this.allDayCheckbox.Text = "All Day";
            this.allDayCheckbox.UseVisualStyleBackColor = true;
            this.allDayCheckbox.CheckedChanged += new System.EventHandler(this.allDayCheckbox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(164, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Time Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimeOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 745);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allDayCheckbox);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.emplyeesLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimeOffForm";
            this.Text = "TimeOffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emplyeesLabel;
        private System.Windows.Forms.MonthCalendar startDate;
        private System.Windows.Forms.MonthCalendar endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.CheckBox allDayCheckbox;
        private System.Windows.Forms.Button button1;
    }
}
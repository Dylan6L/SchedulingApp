namespace SchedulUI
{
    partial class AddPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.hoursAllowedInput = new System.Windows.Forms.TextBox();
            this.maxHoursLabel = new System.Windows.Forms.Label();
            this.frontlineTags = new System.Windows.Forms.CheckedListBox();
            this.backlineTags = new System.Windows.Forms.CheckedListBox();
            this.frontlineLabel = new System.Windows.Forms.Label();
            this.backlineLabel = new System.Windows.Forms.Label();
            this.specialTags = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.availablilityLabel = new System.Windows.Forms.Label();
            this.availListBox = new System.Windows.Forms.ListBox();
            this.availRefresh = new System.Windows.Forms.Button();
            this.addAvailablilityButton = new System.Windows.Forms.Button();
            this.availDeleteButton = new System.Windows.Forms.Button();
            this.timeOffDeleteButton = new System.Windows.Forms.Button();
            this.addTimeOffButton = new System.Windows.Forms.Button();
            this.TimeOffRefreshButton = new System.Windows.Forms.Button();
            this.timeOffListBox = new System.Windows.Forms.ListBox();
            this.timeOffLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 45);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Location = new System.Drawing.Point(21, 61);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(324, 35);
            this.nameInput.TabIndex = 1;
            // 
            // hoursAllowedInput
            // 
            this.hoursAllowedInput.Location = new System.Drawing.Point(21, 185);
            this.hoursAllowedInput.Name = "hoursAllowedInput";
            this.hoursAllowedInput.Size = new System.Drawing.Size(100, 35);
            this.hoursAllowedInput.TabIndex = 2;
            // 
            // maxHoursLabel
            // 
            this.maxHoursLabel.AutoSize = true;
            this.maxHoursLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHoursLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.maxHoursLabel.Location = new System.Drawing.Point(13, 137);
            this.maxHoursLabel.Name = "maxHoursLabel";
            this.maxHoursLabel.Size = new System.Drawing.Size(305, 45);
            this.maxHoursLabel.TabIndex = 4;
            this.maxHoursLabel.Text = "Max Hours Allowed:";
            // 
            // frontlineTags
            // 
            this.frontlineTags.FormattingEnabled = true;
            this.frontlineTags.Items.AddRange(new object[] {
            "Runner",
            "Dining",
            "Cash",
            "Dining Close",
            "DT Cash",
            "DT Order",
            "Custard Close"});
            this.frontlineTags.Location = new System.Drawing.Point(411, 74);
            this.frontlineTags.Name = "frontlineTags";
            this.frontlineTags.Size = new System.Drawing.Size(155, 214);
            this.frontlineTags.TabIndex = 12;
            this.frontlineTags.SelectedIndexChanged += new System.EventHandler(this.frontLineTags_SelectedIndexChanged);
            // 
            // backlineTags
            // 
            this.backlineTags.FormattingEnabled = true;
            this.backlineTags.Items.AddRange(new object[] {
            "Buns",
            "Grill",
            "Fryers",
            "Middle",
            "Dish Close",
            "Kitchen Close"});
            this.backlineTags.Location = new System.Drawing.Point(609, 74);
            this.backlineTags.Name = "backlineTags";
            this.backlineTags.Size = new System.Drawing.Size(157, 214);
            this.backlineTags.TabIndex = 13;
            // 
            // frontlineLabel
            // 
            this.frontlineLabel.AutoSize = true;
            this.frontlineLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontlineLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.frontlineLabel.Location = new System.Drawing.Point(403, 13);
            this.frontlineLabel.Name = "frontlineLabel";
            this.frontlineLabel.Size = new System.Drawing.Size(153, 45);
            this.frontlineLabel.TabIndex = 14;
            this.frontlineLabel.Text = "Frontline:";
            // 
            // backlineLabel
            // 
            this.backlineLabel.AutoSize = true;
            this.backlineLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlineLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.backlineLabel.Location = new System.Drawing.Point(601, 13);
            this.backlineLabel.Name = "backlineLabel";
            this.backlineLabel.Size = new System.Drawing.Size(143, 45);
            this.backlineLabel.TabIndex = 15;
            this.backlineLabel.Text = "Backline:";
            // 
            // specialTags
            // 
            this.specialTags.FormattingEnabled = true;
            this.specialTags.Items.AddRange(new object[] {
            "Porter",
            "Prep",
            "Openner Manager",
            "Frontline Manager",
            "Backline Manager",
            "Frontline Closer"});
            this.specialTags.Location = new System.Drawing.Point(800, 74);
            this.specialTags.Name = "specialTags";
            this.specialTags.Size = new System.Drawing.Size(213, 214);
            this.specialTags.TabIndex = 16;
            this.specialTags.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(792, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Special:";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(372, 805);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(291, 103);
            this.addPersonButton.TabIndex = 18;
            this.addPersonButton.Text = "Confirm";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // availablilityLabel
            // 
            this.availablilityLabel.AutoSize = true;
            this.availablilityLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablilityLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.availablilityLabel.Location = new System.Drawing.Point(116, 304);
            this.availablilityLabel.Name = "availablilityLabel";
            this.availablilityLabel.Size = new System.Drawing.Size(180, 45);
            this.availablilityLabel.TabIndex = 20;
            this.availablilityLabel.Text = "Availablility";
            // 
            // availListBox
            // 
            this.availListBox.FormattingEnabled = true;
            this.availListBox.ItemHeight = 30;
            this.availListBox.Location = new System.Drawing.Point(55, 373);
            this.availListBox.Name = "availListBox";
            this.availListBox.Size = new System.Drawing.Size(405, 244);
            this.availListBox.TabIndex = 21;
            // 
            // availRefresh
            // 
            this.availRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availRefresh.Location = new System.Drawing.Point(337, 614);
            this.availRefresh.Name = "availRefresh";
            this.availRefresh.Size = new System.Drawing.Size(82, 34);
            this.availRefresh.TabIndex = 22;
            this.availRefresh.Text = "Refresh";
            this.availRefresh.UseVisualStyleBackColor = true;
            this.availRefresh.Click += new System.EventHandler(this.availRefresh_Click);
            // 
            // addAvailablilityButton
            // 
            this.addAvailablilityButton.Location = new System.Drawing.Point(153, 695);
            this.addAvailablilityButton.Name = "addAvailablilityButton";
            this.addAvailablilityButton.Size = new System.Drawing.Size(210, 50);
            this.addAvailablilityButton.TabIndex = 23;
            this.addAvailablilityButton.Text = "Add Availablility";
            this.addAvailablilityButton.UseVisualStyleBackColor = true;
            this.addAvailablilityButton.Click += new System.EventHandler(this.addAvailablilityButton_Click);
            // 
            // availDeleteButton
            // 
            this.availDeleteButton.Location = new System.Drawing.Point(124, 623);
            this.availDeleteButton.Name = "availDeleteButton";
            this.availDeleteButton.Size = new System.Drawing.Size(113, 54);
            this.availDeleteButton.TabIndex = 24;
            this.availDeleteButton.Text = "Delete";
            this.availDeleteButton.UseVisualStyleBackColor = true;
            this.availDeleteButton.Click += new System.EventHandler(this.availDeleteButton_Click);
            // 
            // timeOffDeleteButton
            // 
            this.timeOffDeleteButton.Location = new System.Drawing.Point(618, 623);
            this.timeOffDeleteButton.Name = "timeOffDeleteButton";
            this.timeOffDeleteButton.Size = new System.Drawing.Size(113, 54);
            this.timeOffDeleteButton.TabIndex = 29;
            this.timeOffDeleteButton.Text = "Delete";
            this.timeOffDeleteButton.UseVisualStyleBackColor = true;
            this.timeOffDeleteButton.Click += new System.EventHandler(this.timeOffDeleteButton_Click);
            // 
            // addTimeOffButton
            // 
            this.addTimeOffButton.Location = new System.Drawing.Point(647, 695);
            this.addTimeOffButton.Name = "addTimeOffButton";
            this.addTimeOffButton.Size = new System.Drawing.Size(210, 50);
            this.addTimeOffButton.TabIndex = 28;
            this.addTimeOffButton.Text = "Add Time Off";
            this.addTimeOffButton.UseVisualStyleBackColor = true;
            this.addTimeOffButton.Click += new System.EventHandler(this.addTimeOffButton_Click);
            // 
            // TimeOffRefreshButton
            // 
            this.TimeOffRefreshButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOffRefreshButton.Location = new System.Drawing.Point(831, 614);
            this.TimeOffRefreshButton.Name = "TimeOffRefreshButton";
            this.TimeOffRefreshButton.Size = new System.Drawing.Size(82, 34);
            this.TimeOffRefreshButton.TabIndex = 27;
            this.TimeOffRefreshButton.Text = "Refresh";
            this.TimeOffRefreshButton.UseVisualStyleBackColor = true;
            // 
            // timeOffListBox
            // 
            this.timeOffListBox.FormattingEnabled = true;
            this.timeOffListBox.ItemHeight = 30;
            this.timeOffListBox.Location = new System.Drawing.Point(517, 373);
            this.timeOffListBox.Name = "timeOffListBox";
            this.timeOffListBox.Size = new System.Drawing.Size(551, 244);
            this.timeOffListBox.TabIndex = 26;
            // 
            // timeOffLabel
            // 
            this.timeOffLabel.AutoSize = true;
            this.timeOffLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOffLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.timeOffLabel.Location = new System.Drawing.Point(610, 304);
            this.timeOffLabel.Name = "timeOffLabel";
            this.timeOffLabel.Size = new System.Drawing.Size(143, 45);
            this.timeOffLabel.TabIndex = 25;
            this.timeOffLabel.Text = "Time Off";
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 920);
            this.Controls.Add(this.timeOffDeleteButton);
            this.Controls.Add(this.addTimeOffButton);
            this.Controls.Add(this.TimeOffRefreshButton);
            this.Controls.Add(this.timeOffListBox);
            this.Controls.Add(this.timeOffLabel);
            this.Controls.Add(this.availDeleteButton);
            this.Controls.Add(this.addAvailablilityButton);
            this.Controls.Add(this.availRefresh);
            this.Controls.Add(this.availListBox);
            this.Controls.Add(this.availablilityLabel);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specialTags);
            this.Controls.Add(this.backlineLabel);
            this.Controls.Add(this.frontlineLabel);
            this.Controls.Add(this.backlineTags);
            this.Controls.Add(this.frontlineTags);
            this.Controls.Add(this.maxHoursLabel);
            this.Controls.Add(this.hoursAllowedInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddPersonForm";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.AddPersonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox hoursAllowedInput;
        private System.Windows.Forms.Label maxHoursLabel;
        private System.Windows.Forms.CheckedListBox frontlineTags;
        private System.Windows.Forms.CheckedListBox backlineTags;
        private System.Windows.Forms.Label frontlineLabel;
        private System.Windows.Forms.Label backlineLabel;
        private System.Windows.Forms.CheckedListBox specialTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Label availablilityLabel;
        private System.Windows.Forms.ListBox availListBox;
        private System.Windows.Forms.Button availRefresh;
        private System.Windows.Forms.Button addAvailablilityButton;
        private System.Windows.Forms.Button availDeleteButton;
        private System.Windows.Forms.Button timeOffDeleteButton;
        private System.Windows.Forms.Button addTimeOffButton;
        private System.Windows.Forms.Button TimeOffRefreshButton;
        private System.Windows.Forms.ListBox timeOffListBox;
        private System.Windows.Forms.Label timeOffLabel;
    }
}


namespace SchedulUI
{
    partial class ScheduleMenu
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
            this.scheduleSettingsButton = new System.Windows.Forms.Button();
            this.scheduleViewer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleSettingsButton
            // 
            this.scheduleSettingsButton.Location = new System.Drawing.Point(138, 308);
            this.scheduleSettingsButton.Name = "scheduleSettingsButton";
            this.scheduleSettingsButton.Size = new System.Drawing.Size(337, 74);
            this.scheduleSettingsButton.TabIndex = 0;
            this.scheduleSettingsButton.Text = "Schedule Settings";
            this.scheduleSettingsButton.UseVisualStyleBackColor = true;
            this.scheduleSettingsButton.Click += new System.EventHandler(this.scheduleSettingsButton_Click);
            // 
            // scheduleViewer
            // 
            this.scheduleViewer.Location = new System.Drawing.Point(138, 109);
            this.scheduleViewer.Name = "scheduleViewer";
            this.scheduleViewer.Size = new System.Drawing.Size(337, 73);
            this.scheduleViewer.TabIndex = 1;
            this.scheduleViewer.Text = "Schedule Viewer";
            this.scheduleViewer.UseVisualStyleBackColor = true;
            this.scheduleViewer.Click += new System.EventHandler(this.scheduleViewer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schedule";
            // 
            // hoursChartButton
            // 
            this.hoursChartButton.Location = new System.Drawing.Point(138, 206);
            this.hoursChartButton.Name = "hoursChartButton";
            this.hoursChartButton.Size = new System.Drawing.Size(337, 74);
            this.hoursChartButton.TabIndex = 3;
            this.hoursChartButton.Text = "Hours Chart";
            this.hoursChartButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 456);
            this.Controls.Add(this.hoursChartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduleViewer);
            this.Controls.Add(this.scheduleSettingsButton);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ScheduleMenu";
            this.Text = "ScheduleMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scheduleSettingsButton;
        private System.Windows.Forms.Button scheduleViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hoursChartButton;
    }
}
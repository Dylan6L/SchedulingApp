using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulUI
{
    public partial class ScheduleMenu : Form
    {

        public ScheduleMenu()
        {
            InitializeComponent();
        }

        private void scheduleViewer_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "ScheduleSettingsMenu")
                { 
                    MessageBox.Show("Schedule Settings is open!", "Message", MessageBoxButtons.OK);
                    return;
                }
                if (f.Name != "MainForm" && f.Name != "ScheduleMenu")
                {
                    MessageBox.Show("Another window is open!", "Message", MessageBoxButtons.OK);
                    return;
                }
            }

            if (Program.weekSchedule.Length > 0)
            {
                if (MessageBox.Show("Another Form is in the system, load?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Debug.WriteLine("load previous schedule");
                else
                {
                    WeekScheduleSelector ws = new WeekScheduleSelector();
                    ws.Show();
                    this.Close();
                }
            }
            else
            {
                WeekScheduleSelector ws = new WeekScheduleSelector();
                ws.Show();
                this.Close();
            }
        }

        private void scheduleSettingsButton_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "ScheduleViewerForm")
                {
                    MessageBox.Show("Schedule viewer is open!", "Message", MessageBoxButtons.OK);
                    return;
                }
                if (f.Name != "MainForm" && f.Name != "ScheduleMenu")
                {
                    MessageBox.Show("Another window is open!", "Message", MessageBoxButtons.OK);
                    return;
                }
            }

            ScheduleSettingsMenu sm = new ScheduleSettingsMenu();
            sm.Show();
        }
    }
}

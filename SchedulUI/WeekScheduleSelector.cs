using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulUI
{
    public partial class WeekScheduleSelector : Form
    {
        public WeekScheduleSelector()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.weekSchedule.Length > 0)
                if (MessageBox.Show("Overwrite previous schedule?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            // CREATE NEW SCHEDULE
            DateTime dt = monthCalendar1.SelectionStart.Date;

            while (dt.DayOfWeek != DayOfWeek.Monday)
                dt = dt.AddDays(-1);

            Program.CreateNewSchedule(dt, this);

        }
    }
}

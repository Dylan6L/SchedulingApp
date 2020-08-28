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
    public partial class TimeOffForm : Form
    {

        AddPersonForm apf;

        public TimeOffForm(AddPersonForm ap)
        {
            InitializeComponent();

            apf = ap;
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (endDate.SelectionRange.Start < startDate.SelectionRange.Start)
            {
                MessageBox.Show("Start Date must be after End Date", "Message", MessageBoxButtons.OK);
                return;
            }

            string s = startDate.SelectionRange.Start.ToShortDateString();
            string f = endDate.SelectionRange.Start.ToShortDateString();

            if (allDayCheckbox.Checked)
            {
                if (s == f)
                    apf.AddTimeOff(s);
                else
                    apf.AddTimeOff(s + "-" + f);
            }
            else
            {
                if (s == f)
                {
                    if (startTimePicker.Value > endTimePicker.Value)
                    {
                        MessageBox.Show("Start Time must be before End Time", "Message", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        apf.AddTimeOff(s + ";" + startTimePicker.Value.ToLongTimeString() +
                            "-" + endTimePicker.Value.ToLongTimeString());
                    }
                }
                else
                {
                    apf.AddTimeOff(s + ";" + startTimePicker.Value.ToLongTimeString() +
                            "-" + f + ";" + endTimePicker.Value.ToLongTimeString());
                }

                //apf.AddTimeOff(s + ";" + startTimePicker.Value.ToShortTimeString() + "-"
                //    + f + ";" + endTimePicker.Value.ToShortTimeString());
            }

            this.Close();
        }

        private void allDayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (allDayCheckbox.Checked)
            {
                startTimePicker.Enabled = false;
                endTimePicker.Enabled = false;
            }
            else
            {
                startTimePicker.Enabled = true;
                endTimePicker.Enabled = true;
            }
        }
    }
}

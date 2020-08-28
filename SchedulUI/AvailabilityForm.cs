using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulUI
{
    public partial class AvailabilityForm : Form
    {

        AddPersonForm apf;

        public AvailabilityForm(AddPersonForm ap)
        {
            InitializeComponent();

            apf = ap;
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
        }

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!allDayCheckbox.Checked && startTimePicker.Value > endTimePicker.Value)
            {
                MessageBox.Show("Start Time must be before End Time", "Message", MessageBoxButtons.OK);
                return;
            }

            foreach (string s in daysOfWeekCheckListBox.CheckedItems)
            {
                if (allDayCheckbox.Checked)
                    apf.AddAvail(s + "-all day");
                else
                    apf.AddAvail(s + "-" + startTimePicker.Value.ToLongTimeString()
                        + "-" + endTimePicker.Value.ToLongTimeString());
            }
            this.Close();
        }
    }
}

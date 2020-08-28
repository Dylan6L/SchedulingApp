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
    public partial class ScheduleSettingsMenu : Form
    {

        public ScheduleSettingsMenu()
        {
            InitializeComponent();

            dayOfWeekCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            lunchFront10.DropDownStyle = ComboBoxStyle.DropDownList;
            lunchBack10.DropDownStyle = ComboBoxStyle.DropDownList;
            lunchBack35.DropDownStyle = ComboBoxStyle.DropDownList;
            lunchFront35.DropDownStyle = ComboBoxStyle.DropDownList;

            dinnerfront8.DropDownStyle = ComboBoxStyle.DropDownList;
            dinnerBack8.DropDownStyle = ComboBoxStyle.DropDownList;
            dinnerfront9.DropDownStyle = ComboBoxStyle.DropDownList;
            dinnerBack9.DropDownStyle = ComboBoxStyle.DropDownList;

            dinnerGroupBox.Enabled = false;
            lunchGroupBox.Enabled = false;
            confirmButton.Enabled = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dinnerGroupBox.Enabled = true;
            lunchGroupBox.Enabled = true;
            confirmButton.Enabled = true;

            int inx = Program.GetDayOfWeekNumber(dayOfWeekCombobox.Text.Substring(0, 3));
            if (Program.scheduleSettings[inx] != null)
            {
                ScheduleSettingsModel sm = Program.scheduleSettings[inx];

                foreach (string tag in sm.lunchExtras)
                    lunchExtraCheckBox.SetItemChecked(lunchExtraCheckBox.Items.IndexOf(tag), true);
                foreach (string tag in sm.dinnerExtras)
                    dinnerExtraCheckbox.SetItemChecked(dinnerExtraCheckbox.Items.IndexOf(tag), true);

                lunchFront10.Text = sm.lunchPeople[0].ToString();
                lunchFront35.Text = sm.lunchPeople[1].ToString();
                lunchBack10.Text = sm.lunchPeople[2].ToString();
                lunchBack35.Text = sm.lunchPeople[3].ToString();

                dinnerfront8.Text = sm.dinnerPeople[0].ToString();
                dinnerfront9.Text = sm.dinnerPeople[1].ToString();
                dinnerBack8.Text = sm.dinnerPeople[2].ToString();
                dinnerBack9.Text = sm.dinnerPeople[3].ToString();
            }
            else
            {
                for (int i = 0; i < lunchExtraCheckBox.Items.Count; i++)
                    lunchExtraCheckBox.SetItemChecked(i, false);

                for (int i = 0; i < dinnerExtraCheckbox.Items.Count; i++)
                    dinnerExtraCheckbox.SetItemChecked(i, false);

                lunchFront10.SelectedItem = null;
                lunchFront35.SelectedItem = null;
                lunchBack10.SelectedItem = null;
                lunchBack35.SelectedItem = null;

                dinnerfront8.SelectedItem = null;
                dinnerfront9.SelectedItem = null;
                dinnerBack8.SelectedItem = null;
                dinnerBack9.SelectedItem = null;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string d = "";

            d += dayOfWeekCombobox.SelectedItem.ToString() + ",";

            // lunch extra
            foreach (string s in lunchExtraCheckBox.CheckedItems)
                d += s + ",";

            d += "d,";

            // dinner extra
            foreach (string s in dinnerExtraCheckbox.CheckedItems)
                d += s + ",";

            d += "p,";

            d += (lunchFront10.SelectedIndex > -1 ? lunchFront10.SelectedItem.ToString() : "0") + ",";
            d += (lunchFront35.SelectedIndex > -1 ? lunchBack35.SelectedItem.ToString() : "0") + ",";
            d += (lunchBack10.SelectedIndex > -1 ? lunchBack10.SelectedItem.ToString() : "0") + ",";
            d += (lunchBack35.SelectedIndex > -1 ? lunchFront35.SelectedItem.ToString() : "0") + ",";

            d += "dt,";

            d += (dinnerfront8.SelectedIndex > -1 ? dinnerfront8.SelectedItem.ToString() : "0") + ",";
            d += (dinnerfront9.SelectedIndex > -1 ? dinnerfront9.SelectedItem.ToString() : "0") + ",";
            d += (dinnerBack8.SelectedIndex > -1 ? dinnerBack8.SelectedItem.ToString() : "0") + ",";
            d += (dinnerBack9.SelectedIndex > -1 ? dinnerBack9.SelectedItem.ToString() : "0") + ",";

            d += "e";

            Debug.WriteLine(d);

            Program.AddNewScheduleSettingsModel(d);
        }
    }
}

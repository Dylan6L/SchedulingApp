using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Deployment.Internal;
using ScheduleLibrary;

namespace SchedulUI
{
    public partial class AddPersonForm : Form
    {

        PeopleMenu pm;
        bool editPerson = false;

        public List<string> avail = new List<string>();
        public List<string> timeO = new List<string>();

        string originalName = "";

        public AddPersonForm(PeopleMenu pmf, string editPersonName)
        {
            InitializeComponent();

            pm = pmf;

            if (editPersonName.Length > 0)
            {
                editPerson = true;

                PersonModel person = Program.GetEmployee(editPersonName);

                //string[] personS = Program.data[Program.employees.IndexOf(editPersonName)].Split(',');

                nameInput.Text = person.name;
                originalName = person.name;

                foreach (string tag in person.tags)
                {
                    if (specialTags.Items.Contains(tag))
                        specialTags.SetItemChecked(specialTags.Items.IndexOf(tag), true);
                    else if (backlineTags.Items.Contains(tag))
                        backlineTags.SetItemChecked(backlineTags.Items.IndexOf(tag), true);
                    else if (frontlineTags.Items.Contains(tag))
                        frontlineTags.SetItemChecked(frontlineTags.Items.IndexOf(tag), true);
                }

                // Max Hours
                hoursAllowedInput.Text = person.maxHours.ToString();

                // Availability
                foreach (string av in person.avail)
                {
                    if (av != "")
                        avail.Add(av);
                }
                RefreshAvail();

                // Time Off
                foreach (string to in person.timeOff)
                    timeO.Add(to);
                RefreshTimeOff();
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frontLineTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {

            if (nameInput.Text.Length == 0)
            {
                MessageBox.Show("Enter a Name", "Message", MessageBoxButtons.OK);
                return;
            }
            string s = nameInput.Text;

            // tags
            int tagNumber = 0;
            foreach (string t in frontlineTags.CheckedItems)
            {
                s += ',' + t;
                tagNumber++;
            }
            foreach (string t in backlineTags.CheckedItems)
            {
                s += ',' + t;
                tagNumber++;
            }
            foreach (string t in specialTags.CheckedItems)
            {
                s += ',' + t;
                tagNumber++;
            }
            // tag #
            if (tagNumber < 1)
            {
                MessageBox.Show("Enter a Position", "Message", MessageBoxButtons.OK);
                return;
            }
            s = s.Insert(nameInput.Text.Length + 1, tagNumber.ToString() + ",");

            // hours allowed
            s += ',' + hoursAllowedInput.Text + ",";
            if (hoursAllowedInput.Text.Length < 1)
            {
                MessageBox.Show("Enter Max Allowed Hours", "Message", MessageBoxButtons.OK);
                return;
            }

            // availability
            s += "a,";
            foreach (string i in avail)
                s += i + ",";

            // time off
            s += "t,";
            foreach (string a in timeO)
                s += a + ",";

            // add end marker
            s += "e";

            // add it to data
            if (!editPerson)
                Program.AddNewPerson(s);
            else
                Program.EditPerson(s, nameInput.Text, originalName);

            pm.RefreshList();
            Debug.WriteLine(s);
            this.Close();
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void addAvailablilityButton_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name == "AvailabilityForm" || f.Name == "TimeOffForm")
                    return;
            
            AvailabilityForm af = new AvailabilityForm(this);
            af.Show();
        }

        private void addTimeOffButton_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name == "AvailabilityForm" || f.Name == "TimeOffForm")
                    return;

            TimeOffForm tof = new TimeOffForm(this);
            tof.Show();
        }

        private void availRefresh_Click(object sender, EventArgs e)
        {

        }

        public void AddAvail(string av)
        {
            avail.Add(av);
            RefreshAvail();
        }

        private void RefreshAvail()
        {
            availListBox.Items.Clear();
            foreach (string av in avail)
            {
                availListBox.Items.Add(av);
            }
        }

        private void availDeleteButton_Click(object sender, EventArgs e)
        {
            avail.Remove(availListBox.SelectedItem.ToString());
            RefreshAvail();
        }

        public void AddTimeOff(string timeOff)
        {
            timeO.Add(timeOff);
            RefreshTimeOff();
        }
        private void RefreshTimeOff()
        {
            timeOffListBox.Items.Clear();
            foreach (string to in timeO)
                timeOffListBox.Items.Add(to);
        }

        private void timeOffDeleteButton_Click(object sender, EventArgs e)
        {
            timeO.Remove(timeOffListBox.SelectedItem.ToString());
            RefreshTimeOff();
        }

    }
}

using ScheduleLibrary;
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
    public partial class PeopleMenu : Form
    {
        public PeopleMenu()
        {
            InitializeComponent();

            RefreshList();
        }

        private void PeopleMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name == "AddPersonForm" || f.Name == "EditPersonForm")
                    return;

            if (employeeListBox.SelectedItem == null)
                MessageBox.Show("Select an employee to edit", "Message", MessageBoxButtons.OK);
            else
            {
                AddPersonForm ep = new AddPersonForm(this, employeeListBox.SelectedItem.ToString());
                ep.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name == "AddPersonForm" || f.Name == "EditPersonForm")
                    return;

            AddPersonForm ap = new AddPersonForm(this, "");
            ap.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete " + employeeListBox.SelectedItem +
                "?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.DeleteEmployee(employeeListBox.SelectedItem.ToString());
                RefreshList();
            }
        }

        public void RefreshList()
        {
            employeeListBox.Items.Clear();
            foreach (string em in Program.employees)
                employeeListBox.Items.Add(em);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
        }
    }
}

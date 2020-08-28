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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void scheduleTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name != "MainForm")
                {
                    MessageBox.Show("Window already open!", "Message", MessageBoxButtons.OK);
                    return;
                }

            ScheduleMenu sm = new ScheduleMenu();
            sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name != "MainForm")
                {
                    MessageBox.Show("Window already open!", "Message", MessageBoxButtons.OK);
                    return;
                }

            PeopleMenu pm = new PeopleMenu();
            pm.Show();
        }
    }
}

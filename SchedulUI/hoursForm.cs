using ScheduleLibrary;
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
    public partial class hoursForm : Form
    {
        private List<string> peopleHours = new List<string>();

        int lineSize = 40;

        public hoursForm(string date)
        {
            InitializeComponent();

            label1.Text = "Hours For the Week of " + date;

            foreach (PersonModel p in Program.people)
            {
                double hours = p.totalHours;
                string name = p.name;
                int spacing = lineSize - hours.ToString().Length - name.ToString().Length;
                string s = p.name;
                for (int i = 0; i < spacing; i++)
                    s += " ";
                s += hours.ToString();

                peopleHours.Add(s);
            }

            foreach (string f in peopleHours)
                listBox1.Items.Add(f);
        }

        private void hoursForm_Load(object sender, EventArgs e)
        {

        }
    }
}

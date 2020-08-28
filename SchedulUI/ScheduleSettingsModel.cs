using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchedulUI
{
    public class ScheduleSettingsModel
    {

        public string day = "";

        public List<string> lunchExtras = new List<string>();
        public List<string> dinnerExtras = new List<string>();

        // List goes people at 10 am, 11 am, 3-5 pm, 8 pm, 9 pm, 10 pm
        public int[] lunchPeople = new int[] { 0, 0, 0, 0, 0, 0 };
        public int[] dinnerPeople = new int[] { 0, 0, 0, 0, 0, 0 };

        
        public ScheduleSettingsModel(string data)
        {
            // TODO translate data string

            string[] d = data.Split(',');

            day = d[0];

            int inx = Array.IndexOf(d, "d");
            for (int i = 1; i < inx; i++)
                lunchExtras.Add(d[i]);
            int inx2 = Array.IndexOf(d, "p");
            for (int i = inx + 1; i < inx2; i++)
                dinnerExtras.Add(d[i]);

            for (int i = inx2 + 1; i < inx2 + 5; i++)
                lunchPeople[i - inx2 - 1] = int.Parse(d[i]);

            int inx3 = Array.IndexOf(d, "dt");
            for (int i = inx3 + 1; i < inx3 + 5; i++)
                dinnerPeople[i - inx3 - 1] = int.Parse(d[i]);
        }
    }
}

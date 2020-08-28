using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text;

namespace ScheduleLibrary
{
    public class PersonModel
    {

        public string name { get; set; }

        public int totalHours { get; set; }

        public int maxHours;

        public List<string> tags = new List<string>();

        public string[] avail = new string[] { "", "", "", "", "", "", "" };

        public List<string> timeOff = new List<string>();


        public PersonModel(string data)
        {
            string[] s = data.Split(',');

            // name
            name = s[0];

            // max hours
            maxHours = int.Parse(s[1]);

            // tags
            int inx = int.Parse(s[1]) + 2;
            for (int i = 1; i < inx; i++)
            {
                tags.Add(s[i]);
            }

            // Availability
            int id = inx + 2;
            string a = s[id];
            while (a != "t")
            {
                string day = a.Substring(0, 2);
                int di = 0;
                if (day == "Mon")
                    di = 0;
                else if (day == "Tue")
                    di = 1;
                else if (day == "Wed")
                    di = 2;
                else if (day == "Thu")
                    di = 3;
                else if (day == "Fri")
                    di = 4;
                else if (day == "Sat")
                    di = 5;
                else
                    di = 6;

                avail[di] = a;
                id++;
                a = s[id];
            }

            // Time Off
            id++;
            a = s[id];
            while (a != "e")
            {
                timeOff.Add(a);
                id++;
                a = s[id];
            }

        }

        public bool CanWork(string date, string time)
        {
            string[] splitDate = date.Split('/');
            DateTime shiftDate = new DateTime(int.Parse(splitDate[2]), int.Parse(splitDate[0]), int.Parse(splitDate[1]));

            string[] tim = time.Split('-');

            for (int i = 0; i < 6; i++)
            {

                DayOfWeek d = DayOfWeek.Sunday;
                
                if (i == 0)
                    d = DayOfWeek.Sunday;
                else if (i == 1)
                    d = DayOfWeek.Monday;
                else if (i == 2)
                    d = DayOfWeek.Tuesday;
                else if (i == 3)
                    d = DayOfWeek.Wednesday;
                else if (i == 4)
                    d = DayOfWeek.Thursday;
                else if (i == 5)
                    d = DayOfWeek.Friday;
                else if (i == 6)
                    d = DayOfWeek.Saturday;

                if (shiftDate.DayOfWeek == d && avail[i].Length > 0)
                {
                    string[] av = avail[i].Split('-');
                    // time from availability
                    DateTime sdTime = DateTime.ParseExact(avail[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    DateTime edTime = DateTime.ParseExact(avail[2], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    // time for shift
                    DateTime ssdTime = DateTime.ParseExact(tim[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    DateTime sedTime = DateTime.ParseExact(tim[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    if (sdTime < sedTime && ssdTime < edTime)
                        return false;
                }
            }

            // TODO check for time off

            foreach (string to in timeOff)
            {
                string[] timO = new string[0];

                if (to.Contains("-"))
                     timO = to.Split('-');

                if (timO.Length == 2)
                {
                    if (timO[0].Contains(";"))
                    {
                        string[] splitStart = timO[0].Split(';');
                        string[] splitEnd = timO[1].Split(';');

                        DateTime startDate = Convert.ToDateTime(splitStart[0]);
                        DateTime endDate = Convert.ToDateTime(splitEnd[0]);

                        if (startDate < shiftDate && shiftDate < endDate)
                            return false;

                        if (startDate == shiftDate || endDate == shiftDate)
                        {
                            DateTime startTime = DateTime.ParseExact(splitStart[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                            DateTime endTime = DateTime.ParseExact(splitEnd[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                            DateTime ssdTime = DateTime.ParseExact(tim[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                            DateTime sedTime = DateTime.ParseExact(tim[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);

                            if (startDate == shiftDate)
                            {
                                if (startTime < sedTime && ssdTime < endTime)
                                    return false;
                            }
                        }
                    }
                    else
                    {
                        DateTime startDate = Convert.ToDateTime(timO[0]);
                        DateTime endDate = Convert.ToDateTime(timO[1]);

                        if (startDate <= shiftDate && shiftDate <= endDate)
                            return false;
                    }
                }
            }
            
            return true;
        }

    }
}

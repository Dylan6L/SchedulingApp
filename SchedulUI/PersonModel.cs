using SchedulUI;
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

        public string name = "";

        public double totalHours = 0;

        public int maxHours;

        public List<string> tags = new List<string>();

        public string[] avail = new string[] { "", "", "", "", "", "", "" };

        public List<string> timeOff = new List<string>();
        public Dictionary<string, string> shifts = new Dictionary<string, string>();
        public Dictionary<string, string> nightShifts = new Dictionary<string, string>();

        public PersonModel()
        {

        }

        public PersonModel(string data)
        {
            string[] s = data.Split(',');

            // name
            name = s[0];

            // tags
            int inx = int.Parse(s[1]) + 2;
            for (int i = 1; i < inx; i++)
                tags.Add(s[i]);

            // max hours
            maxHours = int.Parse(s[inx]);

            // Availability
            int id = inx + 2;
            string a = s[id];
            while (a != "t")
            {
                string day = a.Substring(0, 3);
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

        public bool CanWork(DateTime date, string time)
        {
            DateTime shiftDate = date;

            string[] tim = time.Split('-');

            // Availability
            for (int i = 0; i < 7; i++)
            {
                // Declare variable, subject to change
                DayOfWeek d = DayOfWeek.Sunday;

                if (i == 0)
                    d = DayOfWeek.Monday;
                else if (i == 1)
                    d = DayOfWeek.Tuesday;
                else if (i == 2)
                    d = DayOfWeek.Wednesday;
                else if (i == 3)
                    d = DayOfWeek.Thursday;
                else if (i == 4)
                    d = DayOfWeek.Friday;
                else if (i == 5)
                    d = DayOfWeek.Saturday;
                else if (i == 6)
                    d = DayOfWeek.Sunday;

                if (shiftDate.DayOfWeek == d && avail[i].Length > 0)
                {
                    string[] av = avail[i].Split('-');

                    if (av[1] == "all day")
                        return false;

                    if (av[1].Length < 11)
                        av[1] = av[1].Insert(0, "0");
                    if (av[2].Length < 11)
                        av[2] = av[2].Insert(0, "0");

                    if (tim[0].Length < 11)
                        tim[0] = tim[0].Insert(0, "0");
                    if (tim[1].Length < 11)
                        tim[1] = tim[1].Insert(0, "0");

                    // time from availability
                    DateTime sdTime = DateTime.ParseExact(av[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    DateTime edTime = DateTime.ParseExact(av[2], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    // time for shift
                    DateTime ssdTime = DateTime.ParseExact(tim[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    DateTime sedTime = DateTime.ParseExact(tim[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                    if (sdTime < sedTime && ssdTime < edTime)
                        return false;
                }
            }

            // Shifts
            if (shifts.ContainsKey(date.ToShortDateString()))
            {
                string[] tim2 = shifts[date.ToShortDateString()].Split('-');

                if (tim2[0].Length < 11)
                    tim2[0] = tim2[0].Insert(0, "0");
                if (tim2[1].Length < 11)
                    tim2[1] = tim2[1].Insert(0, "0");

                if (tim[0].Length < 11)
                    tim[0] = tim[0].Insert(0, "0");
                if (tim[1].Length < 11)
                    tim[1] = tim[1].Insert(0, "0");

                DateTime ssdTime = DateTime.ParseExact(tim[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                DateTime sedTime = DateTime.ParseExact(tim[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);

                DateTime ssdTime2 = DateTime.ParseExact(tim2[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                DateTime sedTime2 = DateTime.ParseExact(tim2[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);

                if (sedTime < sedTime2)
                    return false;

                if (ssdTime2.Hour == 8 && ssdTime.Hour == 5)
                    return false;
            }
            if (nightShifts.ContainsKey(date.ToShortDateString()))
                return false;


            // Time Off
            foreach (string to in timeOff)
            {
                string[] timO = new string[0];

                if (to.Contains("-"))
                    timO = to.Split('-');
                else
                {
                    DateTime dt = Convert.ToDateTime(to);
                    if (dt.Date == shiftDate.Date)
                        return false;
                }

                if (timO.Length == 2)
                {
                    if (timO[0].Contains(";"))
                    {
                        string[] splitStart = timO[0].Split(';');
                        string[] splitEnd = new string[0];

                        if (timO[1].Contains(";"))
                            splitEnd = timO[1].Split(';');
                        else
                        {
                            string[] temp = new string[] { timO[0], timO[0].Substring(timO[0].IndexOf(' ')) + timO[1] };
                            timO = temp;
                        }

                        if (splitStart[1].Length < 11)
                            splitStart[1] = splitStart[1].Insert(0, "0");
                        if (splitEnd[1].Length < 11)
                            splitEnd[1] = splitEnd[1].Insert(0, "0");

                        if (tim[0].Length < 11)
                            tim[0] = tim[0].Insert(0, "0");
                        if (tim[1].Length < 11)
                            tim[1] = tim[1].Insert(0, "0");

                        DateTime startDate = Convert.ToDateTime(splitStart[0]);
                        DateTime endDate = Convert.ToDateTime(splitEnd[0]);

                        if (startDate < shiftDate && shiftDate < endDate)
                            return false;

                        if (startDate == shiftDate || endDate == shiftDate)
                        {
                            DateTime startTime = DateTime.ParseExact(splitStart[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                            DateTime endTime = DateTime.ParseExact(splitEnd[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);

                            if (startDate == shiftDate)
                            {
                                DateTime sedTime = DateTime.ParseExact(tim[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                                if (startTime.TimeOfDay < sedTime.TimeOfDay)
                                    return false;
                            }
                            else
                            {
                                DateTime ssdTime = DateTime.ParseExact(tim[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
                                if (endTime.TimeOfDay < ssdTime.TimeOfDay)
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

        public void EditPersonModel(string data)
        {
            // reset variables
            tags = new List<string>();
            avail = new string[] { "", "", "", "", "", "", "" };
            timeOff = new List<string>();


            string[] s = data.Split(',');

            // name
            if (name != s[0])
                Program.employees[Program.employees.IndexOf(name)] = s[0];
            name = s[0];

            // tags
            int inx = int.Parse(s[1]) + 2;
            for (int i = 1; i < inx; i++)
                tags.Add(s[i]);

            // max hours
            maxHours = int.Parse(s[inx]);

            // Availability
            int id = inx + 2;
            string a = s[id];
            while (a != "t")
            {
                string day = a.Substring(0, 3);
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


        public void AddShift(DateTime date, string time)
        {
            string[] times2 = time.Split('-');

            if (times2[0].Length < 11)
                times2[0] = times2[0].Insert(0, "0");
            if (times2[1].Length < 11)
                times2[1] = times2[1].Insert(0, "0");

            DateTime startTime = DateTime.ParseExact(times2[0], "hh:mm:ss tt", CultureInfo.CurrentCulture);
            DateTime endTime = DateTime.ParseExact(times2[1], "hh:mm:ss tt", CultureInfo.CurrentCulture);

            totalHours += endTime.Hour - startTime.Hour;
            if (endTime.Minute > 0)
                totalHours += 0.75;

            if (times2[0].Substring(0, 2) == "05" || (time == "3:00:00 PM-10:45:00 PM"))
                nightShifts.Add(date.Date.ToShortDateString(), time);

            // TODO check if working that day, if so combine shift times
            if (shifts.ContainsKey(date.Date.ToShortDateString()))
            {
                string[] times = shifts[date.Date.ToShortDateString()].Split('-');
                if (times[0].Length < 11)
                    times[0] = times[0].Insert(0, "0");
                if (times[1].Length < 11)
                    times[1] = times[1].Insert(0, "0");
                if ((times[1].Substring(0, 2) == "03" && times2[0].Substring(0, 2) == "03") || (times[1].Substring(0, 2) == "05" && times2[0].Substring(0, 2) == "05"))
                    shifts[date.Date.ToShortDateString()] = times[0] + "-" + times2[1];
            }
            else
                shifts.Add(date.Date.ToShortDateString(), time);
        }

        public string GetShift(string date, bool isNight)
        {
            string shift = "";

            if (!isNight && shifts.ContainsKey(date))
                shift = shifts[date];
            else if (nightShifts.ContainsKey(date))
                shift = nightShifts[date];
            else if (!shifts.ContainsKey(date))
                shift = "";

            return shift;
        }
    }
}

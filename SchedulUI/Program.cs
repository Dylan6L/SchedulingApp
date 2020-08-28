using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using ScheduleLibrary;

namespace SchedulUI
{
    public static class Program
    {

        // Data for employees
        public static List<string> employees = new List<string>();
        public static List<string> data = new List<string>();

        public static List<PersonModel> people = new List<PersonModel>();

        public static ScheduleSettingsModel[] scheduleSettings = new ScheduleSettingsModel[7];
        public static string[] scheduleSettingsData = new string[] { "", "", "", "", "", "", "" };
        public static string[] savedWeekSchedule = new string[] { "", "", "", "", "", "", "" };

        public static DayScheduleModel[] weekSchedule = new DayScheduleModel[7];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path += @"\ScheduleAppData";
            string filePath = path + @"\ScheduleDatabasePeople.txt";
            string filePath2 = path + @"\ScheduleDatabaseSettings.txt";
            string filePath3 = path + @"\ScheduleDatabaseSave.txt";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(filePath);
                File.Create(filePath2);
                File.Create(filePath3);
            }
            else
            {
                data = File.ReadAllLines(filePath).ToList();
                scheduleSettingsData = File.ReadAllLines(filePath2);
                savedWeekSchedule = File.ReadAllLines(filePath3);
            }

            foreach (string person in data)
            {
                people.Add(new PersonModel(person));
                string[] line = person.Split(',');
                employees.Add(line[0]);
            }

            foreach (string schm in scheduleSettingsData)
            {
                if (schm != "")
                {
                    int inx = GetDayOfWeekNumber(schm.Substring(0, 3));
                    scheduleSettings[inx] = new ScheduleSettingsModel(schm);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void AddNewPerson(string personString)
        {
            people.Add(new PersonModel(personString));
            data.Add(personString);
            employees.Add(people[people.Count - 1].name);
            SaveEmployeesFile();
        }

        public static void SaveEmployeesFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path += @"\ScheduleAppData";
            string filePath = path + @"\ScheduleDatabasePeople.txt";

            File.WriteAllLines(filePath, data);
        }

        public static void SaveScheduleSettingsFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path += @"\ScheduleAppData";
            string filePath = path + @"\ScheduleDatabaseSettings.txt";

            File.WriteAllLines(filePath, scheduleSettingsData);
        }

        public static void EditPerson(string dat, string name, string originalName)
        {
            data[employees.IndexOf(originalName)] = dat;
            people[employees.IndexOf(originalName)].EditPersonModel(dat);
            SaveEmployeesFile();
        }

        public static void DeleteEmployee(string name)
        {
            int inx = employees.IndexOf(name);
            employees.RemoveAt(inx);
            data.RemoveAt(inx);
        }

        public static PersonModel GetEmployee(string name)
        {
            foreach (PersonModel pm in people)
            {
                if (pm.name == name)
                    return pm;
            }
            return null;
        }

        public static void AddNewScheduleSettingsModel(string data)
        {
            string day = data.Substring(0, 3);
            int di = GetDayOfWeekNumber(day);

            scheduleSettings[di] = new ScheduleSettingsModel(data);
            scheduleSettingsData[di] = data;
            SaveScheduleSettingsFile();
        }

        public static int GetDayOfWeekNumber(string day)
        {
            if (day == "Mon")
                return 0;
            else if (day == "Tue")
                return 1;
            else if (day == "Wed")
                return 2;
            else if (day == "Thu")
                return 3;
            else if (day == "Fri")
                return 4;
            else if (day == "Sat")
                return 5;
            else
                return 6;
        }

        public static DayScheduleModel CreateNewDaySchedule(DateTime date)
        {
            List<PersonModel> runners = new List<PersonModel>();
            List<PersonModel> dining = new List<PersonModel>();
            List<PersonModel> cash = new List<PersonModel>();
            List<PersonModel> dtOrder = new List<PersonModel>();
            List<PersonModel> dtCash = new List<PersonModel>();
            List<PersonModel> custardClose = new List<PersonModel>();
            List<PersonModel> diningClose = new List<PersonModel>();
            // for now includes set position
            List<PersonModel> frontManager = new List<PersonModel>();

            List<PersonModel> buns = new List<PersonModel>();
            List<PersonModel> grill = new List<PersonModel>();
            List<PersonModel> fryers = new List<PersonModel>();
            List<PersonModel> middle = new List<PersonModel>();
            List<PersonModel> dishClose = new List<PersonModel>();
            List<PersonModel> kitchenClose = new List<PersonModel>();

            List<PersonModel> porter = new List<PersonModel>();
            List<PersonModel> prep = new List<PersonModel>();
            List<PersonModel> openManager = new List<PersonModel>();
            List<PersonModel> frontlineManager = new List<PersonModel>();
            List<PersonModel> backlineManager = new List<PersonModel>();
            List<PersonModel> frontlineCloser = new List<PersonModel>();

            // Putting people in groups based off of positions
            foreach (PersonModel p in people)
            {
                if (p.tags.Contains("Runner"))
                    runners.Add(p);
                if (p.tags.Contains("Dining"))
                    dining.Add(p);
                if (p.tags.Contains("Cash"))
                    cash.Add(p);
                if (p.tags.Contains("Dining Close"))
                    diningClose.Add(p);
                if (p.tags.Contains("DT Cash"))
                    dtCash.Add(p);
                if (p.tags.Contains("DT Order"))
                    dtOrder.Add(p);
                if (p.tags.Contains("Custard Close"))
                    custardClose.Add(p);

                if (p.tags.Contains("Buns"))
                    buns.Add(p);
                if (p.tags.Contains("Grill"))
                    grill.Add(p);
                if (p.tags.Contains("Fryers"))
                    fryers.Add(p);
                if (p.tags.Contains("Middle"))
                    middle.Add(p);
                if (p.tags.Contains("Dish Close"))
                    dishClose.Add(p);
                if (p.tags.Contains("Kitchen Close"))
                    kitchenClose.Add(p);

                if (p.tags.Contains("Porter"))
                    porter.Add(p);
                if (p.tags.Contains("Prep"))
                    prep.Add(p);
                if (p.tags.Contains("Frontline Manager"))
                    frontlineManager.Add(p);
                if (p.tags.Contains("Backline Manager"))
                    backlineManager.Add(p);
                if (p.tags.Contains("Openner Manager"))
                    openManager.Add(p);
                if (p.tags.Contains("Frontline Closer"))
                    frontlineCloser.Add(p);
                if (p.tags.Contains("Frontline Manager"))
                    frontlineManager.Add(p);
            }

            // Start making schedule

            Debug.WriteLine("");

            DayScheduleModel scheduleDate = new DayScheduleModel();

            scheduleDate.date = date;
            scheduleDate.dayOfWeek = date.DayOfWeek;

            string day = scheduleDate.dayOfWeek.ToString().Substring(0, 3);
            int di = GetDayOfWeekNumber(day);

            ScheduleSettingsModel scheduleSet = scheduleSettings[di];


            Random rnd = new Random();
            PersonModel person = new PersonModel();
            double lowestHours = 200;
            List<PersonModel> overtimePeople = new List<PersonModel>();
            List<string> positions = new List<string>();

            scheduleDate.frontPeople8 = 3;
            scheduleDate.frontPeople9 = 3;
            scheduleDate.backPeople9 = 2;
            scheduleDate.backPeople8 = 2;

            Debug.WriteLine(scheduleDate.dayOfWeek);


            #region Openners


            // Porter
            lowestHours = 100;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in porter)
            {
                if (p.totalHours + 7 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "8:00:00 AM-3:00:00 PM");
            scheduleDate.porter = person;
            if (person.tags.Contains("Frontline Manager"))
            {
                scheduleDate.lunchFrontlineManager = person;
                scheduleDate.frontPeople10++;
            }
            else if (person.tags.Contains("Backline Manager"))
                scheduleDate.lunchBacklineManager = person;
            else
            {
                positions = new List<string>();
                foreach (string tag in person.tags)
                    if (tag == "Buns" || tag == "Grill" || tag == "Fryers")
                        positions.Add(tag);
                string p = positions[rnd.Next(0, positions.Count)];
                if (p == "Grill")
                    scheduleDate.lGrill1 = person;
                else if (p == "Fryers")
                    scheduleDate.lFryers1 = person;
                else
                    scheduleDate.lBuns1 = person;
                Debug.WriteLine(person.name + " is " + p + " from porter");
            }
            scheduleDate.backPeople10++;


            // Prep
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in prep)
            {
                if (p.totalHours + 7 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "8:00:00 AM-3:00:00 PM");
            scheduleDate.prep = person;
            if (person.tags.Contains("Backline Manager") && scheduleDate.lunchBacklineManager.name == "")
                scheduleDate.lunchBacklineManager = person;
            else
            {
                positions = new List<string>();
                foreach (string tag in person.tags)
                    if (tag == "Buns" && scheduleDate.lBuns1.name == "" || tag == "Grill" && scheduleDate.lGrill1.name == "" || tag == "Fryers" && scheduleDate.lFryers1.name == "")
                        positions.Add(tag);
                string p = positions[rnd.Next(0, positions.Count)];
                if (p == "Grill")
                    scheduleDate.lGrill1 = person;
                else if (p == "Fryers")
                    scheduleDate.lFryers1 = person;
                else
                    scheduleDate.lBuns1 = person;
                Debug.WriteLine(person.name + " is " + p + " from prep");
            }
            scheduleDate.backPeople10++;


            // OpennerManager
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in openManager)
            {
                if (p.totalHours + 7 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "8:00:00 AM-3:00:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "8:00:00 AM-3:00:00 PM");
            scheduleDate.oManager = person;
            if (person.tags.Contains("Frontline Manager") && scheduleDate.lunchFrontlineManager.name == "")
                scheduleDate.lunchFrontlineManager = person;
            else if (person.tags.Contains("Backline Manager") && scheduleDate.lunchBacklineManager.name == "")
                scheduleDate.lunchBacklineManager = person;


            #endregion


            #region Closers


            // Frontline Manager Closer
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in frontlineCloser)
            {
                if (p.totalHours + 7.75 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "3:00:00 PM-10:45:00 PM");
            scheduleDate.frontlineCloser = person;
            scheduleDate.dinnerFrontlineManager = person;
            scheduleDate.dSet = person;


            // Kitchen Closer
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in kitchenClose)
            {
                if (p.totalHours + 7.75 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "3:00:00 PM-10:45:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "3:00:00 PM-10:45:00 PM");
            scheduleDate.kitchenCloser = person;
            scheduleDate.dinnerBacklineManager = person;
            scheduleDate.dMiddle = person;


            // Dining Closer
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in diningClose)
            {
                if (p.totalHours + 5.75 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "5:00:00 PM-10:45:00 PM");
            scheduleDate.diningCloser = person;


            // Custard Closer
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in custardClose)
            {
                if (p.totalHours + 5.75 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "5:00:00 PM-10:45:00 PM");
            scheduleDate.custardCloser = person;
            scheduleDate.dCustard1 = person;


            // Dish Close
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in dishClose)
            {
                if (p.totalHours + 5.75 <= p.maxHours)
                {
                    if (p.totalHours < lowestHours)
                    {
                        if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                    }
                    else if (p.totalHours == lowestHours)
                    {
                        if (rnd.Next(0, 2) == 1)
                        {
                            if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                }
                else
                    if (p.CanWork(scheduleDate.date, "5:00:00 PM-10:45:00 PM"))
                    overtimePeople.Add(p);
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, "5:00:00 PM-10:45:00 PM");
            scheduleDate.custardCloser = person;
            positions = new List<string>();
            foreach (string tag in person.tags)
                if (tag == "Buns" || tag == "Grill" || tag == "Fryers")
                    positions.Add(tag);
            string pos = positions[rnd.Next(0, positions.Count)];
            if (pos == "Grill")
                scheduleDate.dGrill1 = person;
            else if (pos == "Fryers")
                scheduleDate.dFryers1 = person;
            else
                scheduleDate.dBuns1 = person;


            #endregion


            #region  Frontline Lunch


            string time = "";
            int hours = 0;

            // set/manager
            if (scheduleDate.lunchFrontlineManager.name != "")
                scheduleDate.lSet = scheduleDate.lunchFrontlineManager;
            else
            {
                // pick a new frontline manager
                time = "";
                if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in frontlineManager)
                {
                    if (p.totalHours + hours <= p.maxHours)
                    {
                        if (p.totalHours < lowestHours)
                        {
                            if (p.CanWork(scheduleDate.date, time))
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                        else if (p.totalHours == lowestHours)
                        {
                            if (rnd.Next(0, 2) == 1)
                            {
                                if (p.CanWork(scheduleDate.date, time))
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                    }
                    else
                        if (p.CanWork(scheduleDate.date, time))
                        overtimePeople.Add(p);
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lSet = person;
                scheduleDate.lunchFrontlineManager = person;
            }


            // Drive Order
            time = "";
            if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
            {
                time = "10:00:00 AM-3:00:00 PM";
                hours = 5;
                scheduleDate.frontPeople10++;
            }
            else
            {
                time = "11:00:00 AM-3:00:00 PM";
                hours = 4;
            }
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in dtOrder)
            {
                if (p.CanWork(scheduleDate.date, time))
                {
                    if (p.totalHours + hours <= p.maxHours)
                    {
                        if (p.totalHours < lowestHours)
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                        else if (p.totalHours == lowestHours)
                        {
                            if (rnd.Next(0, 2) == 1)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                    else
                        overtimePeople.Add(p);
                }
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, time);
            scheduleDate.lDtOrder = person;


            int inx = 1;


            // Cash
            if (scheduleSet.lunchExtras.Contains("Extra Cash"))
                inx = 2;
            else
                inx = 1;
            for (int i = 0; i < inx; i++)
            {
                time = "";
                if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in cash)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.lCash1 = person;
                else
                    scheduleDate.lCash2 = person;
            }


            // DT Cash
            time = "";
            if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
            {
                time = "10:00:00 AM-3:00:00 PM";
                hours = 5;
                scheduleDate.frontPeople10++;
            }
            else
            {
                time = "11:00:00 AM-3:00:00 PM";
                hours = 4;
            }
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in dtCash)
            {
                if (p.CanWork(scheduleDate.date, time))
                {
                    if (p.totalHours + hours <= p.maxHours)
                    {
                        if (p.totalHours < lowestHours)
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                        else if (p.totalHours == lowestHours)
                        {
                            if (rnd.Next(0, 2) == 1)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                    else
                        overtimePeople.Add(p);
                }
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, time);
            scheduleDate.lDtCash = person;


            // Dining
            if (scheduleSet.lunchExtras.Contains("Dining"))
            {
                time = "";
                if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in dining)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lDining = person;
            }


            // Runner
            if (scheduleSet.lunchExtras.Contains("Runner"))
            {
                time = "";
                if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in custardClose)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lRunner = person;
            }



            // Custard
            if (scheduleSet.lunchExtras.Contains("Custard"))
            {
                time = "";
                if (scheduleDate.frontPeople10 < scheduleSet.lunchPeople[0])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in custardClose)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lCustard1 = person;
            }


            #endregion


            #region Backline Lunch


            // Middle
            if (scheduleDate.lunchBacklineManager.name != "")
                scheduleDate.lMiddle = scheduleDate.lunchBacklineManager;
            else
            {
                // pick a new backline manager
                time = "";
                if (scheduleDate.backPeople10 < scheduleSet.lunchPeople[2])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in backlineManager)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lMiddle = person;
                scheduleDate.lunchBacklineManager = person;
            }


            // Fryers
            if (scheduleSet.lunchExtras.Contains("Extra Fryer"))
                inx = 2;
            else
                inx = 1;
            for (int i = 0; i < inx; i++)
            {
                if (i == 0 && scheduleDate.lFryers1.name != "")
                    continue;
                time = "";
                if (scheduleDate.backPeople10 < scheduleSet.lunchPeople[2])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in fryers)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.lFryers1 = person;
                else
                    scheduleDate.lFryers2 = person;
            }


            // Grill
            if (scheduleSet.lunchExtras.Contains("Extra Grill"))
                inx = 2;
            else
                inx = 1;
            for (int i = 0; i < inx; i++)
            {
                if (i == 0 && scheduleDate.lGrill1.name != "")
                    continue;
                time = "";
                if (scheduleDate.backPeople10 < scheduleSet.lunchPeople[2])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in grill)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.lGrill1 = person;
                else
                    scheduleDate.lGrill2 = person;
            }


            // Buns
            if (scheduleSet.lunchExtras.Contains("Extra Buns"))
                inx = 2;
            else
                inx = 1;
            for (int i = 0; i < inx; i++)
            {
                if (i == 0 && scheduleDate.lBuns1.name != "")
                    continue;
                time = "";
                if (scheduleDate.backPeople10 < scheduleSet.lunchPeople[2])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in buns)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.lBuns1 = person;
                else
                    scheduleDate.lBuns2 = person;
            }


            // Float
            if (scheduleSet.lunchExtras.Contains("Float"))
            {
                time = "";
                if (scheduleDate.backPeople10 < scheduleSet.lunchPeople[2])
                {
                    time = "10:00:00 AM-3:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople10++;
                }
                else
                {
                    time = "11:00:00 AM-3:00:00 PM";
                    hours = 4;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in buns)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.lFloat = person;
            }

            // TODO continue from here


            #endregion


            #region Afternoon


            // Frontline
            int needed35 = scheduleSet.lunchPeople[1];
            time = "3:00:00 PM-5:00:00 PM";
            scheduleDate.frontPeople35 = 2;
            scheduleDate.lDtOrder.AddShift(scheduleDate.date, time);

            for (int i = 2; i < needed35; i++)
            {
                if (i == 2)
                    scheduleDate.lCash1.AddShift(scheduleDate.date, time);
                else if (i == 3)
                    scheduleDate.lDtOrder.AddShift(scheduleDate.date, time);
                else if (i == 4)
                {
                    if (scheduleDate.lDining.name != "")
                        scheduleDate.lDining.AddShift(scheduleDate.date, time);
                    else if (scheduleDate.lRunner.name != "")
                        scheduleDate.lRunner.AddShift(scheduleDate.date, time);
                }
                scheduleDate.frontPeople35++;
            }


            // Backline
            needed35 = scheduleSet.lunchPeople[3];
            scheduleDate.backPeople35 = 1;

            List<PersonModel> kitchenPeople3 = new List<PersonModel>() { scheduleDate.lFryers1, scheduleDate.lBuns1, scheduleDate.lGrill1 };

            for (int i = 1; i < needed35; i++)
            {
                int f = rnd.Next(0, kitchenPeople3.Count);
                kitchenPeople3[f].AddShift(scheduleDate.date, time);

                scheduleDate.backPeople35++;
            }


            #endregion


            #region Frontline Dinner


            hours = 0;

            // Drive Order
            time = "5:00:00 PM-10:00:00 PM";
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in dtOrder)
            {
                if (p.CanWork(scheduleDate.date, time))
                {
                    if (p.totalHours + hours <= p.maxHours)
                    {
                        if (p.totalHours < lowestHours)
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                        else if (p.totalHours == lowestHours)
                        {
                            if (rnd.Next(0, 2) == 1)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                    else
                        overtimePeople.Add(p);
                }
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, time);
            scheduleDate.dDtOrder = person;
            scheduleDate.frontPeople9++;
            Debug.WriteLine("dto");


            // Cash
            if (scheduleSet.dinnerExtras.Contains("Extra Cash"))
                inx = 2;
            else
                inx = 1;
            Debug.WriteLine(inx);
            for (int i = 0; i < inx; i++)
            {
                time = "";
                if (scheduleDate.frontPeople9 < scheduleSet.dinnerPeople[1])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople9++;
                    scheduleDate.frontPeople8++;
                }
                else if (scheduleDate.frontPeople8 < scheduleSet.dinnerPeople[0])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.frontPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in cash)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.dCash1 = person;
                else
                    scheduleDate.dCash2 = person;
            }
            Debug.WriteLine("cash");



            // DT Cash
            time = "";
            if (scheduleDate.frontPeople9 < scheduleSet.dinnerPeople[1])
            {
                time = "5:00:00 PM-10:00:00 PM";
                hours = 5;
                scheduleDate.frontPeople9++;
                scheduleDate.frontPeople8++;
            }
            else if (scheduleDate.frontPeople8 < scheduleSet.dinnerPeople[0])
            {
                time = "5:00:00 PM-9:00:00 PM";
                hours = 4;
                scheduleDate.frontPeople8++;
            }
            else
            {
                time = "5:00:00 PM-8:00:00 PM";
                hours = 3;
            }
            lowestHours = 200;
            person = new PersonModel();
            overtimePeople = new List<PersonModel>();
            foreach (PersonModel p in dtCash)
            {
                if (p.CanWork(scheduleDate.date, time))
                {
                    if (p.totalHours + hours <= p.maxHours)
                    {
                        if (p.totalHours < lowestHours)
                        {
                            person = p;
                            lowestHours = p.totalHours;
                        }
                        else if (p.totalHours == lowestHours)
                        {
                            if (rnd.Next(0, 2) == 1)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                        }
                    }
                    else
                        overtimePeople.Add(p);
                }
            }
            if (person.name == "")
                person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
            if (person.name != "")
                person.AddShift(scheduleDate.date, time);
            scheduleDate.dDtCash = person;
            Debug.WriteLine("dtcash");



            // Dining
            if (scheduleSet.dinnerExtras.Contains("Dining"))
            {
                time = "";
                if (scheduleDate.frontPeople9 < scheduleSet.dinnerPeople[1])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople9++;
                    scheduleDate.frontPeople8++;
                }
                else if (scheduleDate.frontPeople8 < scheduleSet.dinnerPeople[0])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.frontPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in dining)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.dDining = person;
            }
            Debug.WriteLine("dining");



            // Runner
            if (scheduleSet.dinnerExtras.Contains("Runner"))
            {
                time = "";
                if (scheduleDate.frontPeople9 < scheduleSet.dinnerPeople[1])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.frontPeople9++;
                    scheduleDate.frontPeople8++;
                }
                else if (scheduleDate.frontPeople8 < scheduleSet.dinnerPeople[0])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.frontPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in runners)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                Debug.WriteLine(date);
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.dRunner = person;
            }
            Debug.WriteLine("runner");



            // Custard 2
            if (scheduleSet.dinnerExtras.Contains("Extra Custard"))
            {
                time = "";
                if (scheduleDate.frontPeople8 < scheduleSet.dinnerPeople[0])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.frontPeople8++;
                }
                else
                {
                    time = "5:00:00 AM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in custardClose)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.dCustard2 = person;
            }


            #endregion


            #region Backline Dinner


            // Fryers
            if (scheduleSet.dinnerExtras.Contains("Extra Fryers") && scheduleDate.dFryers1.name == "")
                inx = 2;
            else if (scheduleDate.dFryers1.name == "")
                inx = 1;
            else
                inx = 0;
            for (int i = 0; i < inx; i++)
            {
                time = "";
                if (scheduleDate.backPeople9 < scheduleSet.dinnerPeople[3])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople9++;
                }
                else if (scheduleDate.backPeople8 < scheduleSet.dinnerPeople[2])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.backPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in fryers)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.dFryers1 = person;
                else
                    scheduleDate.dFryers2 = person;
            }


            // Grill
            if (scheduleSet.dinnerExtras.Contains("Extra Grill") && scheduleDate.dGrill1.name == "")
                inx = 2;
            else if (scheduleDate.dGrill1.name == "")
                inx = 1;
            else
                inx = 0;
            for (int i = 0; i < inx; i++)
            {
                time = "";
                if (scheduleDate.backPeople9 < scheduleSet.dinnerPeople[3])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople9++;
                    scheduleDate.backPeople8++;
                }
                else if (scheduleDate.backPeople8 < scheduleSet.dinnerPeople[2])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.backPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in grill)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.dGrill1 = person;
                else
                    scheduleDate.dGrill2 = person;
            }


            // Buns
            if (scheduleSet.dinnerExtras.Contains("Extra Buns") && scheduleDate.dBuns1.name == "")
                inx = 2;
            else if (scheduleDate.dBuns1.name == "")
                inx = 1;
            else
                inx = 0;
            for (int i = 0; i < inx; i++)
            {
                time = "";
                if (scheduleDate.backPeople9 < scheduleSet.dinnerPeople[3])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople9++;
                    scheduleDate.backPeople8++;
                }
                else if (scheduleDate.backPeople8 < scheduleSet.dinnerPeople[2])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.backPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in buns)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        else
                            overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                if (i == 0)
                    scheduleDate.dBuns1 = person;
                else
                    scheduleDate.dBuns2 = person;
            }


            // Float
            if (scheduleSet.dinnerExtras.Contains("Float"))
            {
                time = "";
                if (scheduleDate.backPeople9 < scheduleSet.dinnerPeople[3])
                {
                    time = "5:00:00 PM-10:00:00 PM";
                    hours = 5;
                    scheduleDate.backPeople9++;
                    scheduleDate.backPeople8++;
                }
                else if (scheduleDate.backPeople8 < scheduleSet.dinnerPeople[2])
                {
                    time = "5:00:00 PM-9:00:00 PM";
                    hours = 4;
                    scheduleDate.frontPeople8++;
                }
                else
                {
                    time = "5:00:00 PM-8:00:00 PM";
                    hours = 3;
                }
                lowestHours = 200;
                person = new PersonModel();
                overtimePeople = new List<PersonModel>();
                foreach (PersonModel p in fryers)
                {
                    if (p.CanWork(scheduleDate.date, time))
                    {
                        if (p.totalHours + hours <= p.maxHours)
                        {
                            if (p.totalHours < lowestHours)
                            {
                                person = p;
                                lowestHours = p.totalHours;
                            }
                            else if (p.totalHours == lowestHours)
                            {
                                if (rnd.Next(0, 2) == 1)
                                {
                                    person = p;
                                    lowestHours = p.totalHours;
                                }
                            }
                        }
                        overtimePeople.Add(p);
                    }
                }
                if (person.name == "")
                    person = overtimePeople[rnd.Next(0, overtimePeople.Count)];
                if (person.name != "")
                    person.AddShift(scheduleDate.date, time);
                scheduleDate.dFloat = person;
            }


            #endregion


            return scheduleDate;

        }


        public static void CreateNewSchedule(DateTime mondayDate, WeekScheduleSelector wss)
        {
            weekSchedule = new DayScheduleModel[7];
            DateTime day = mondayDate;

            foreach (PersonModel p in people)
            {
                p.shifts = new Dictionary<string, string>();
                p.nightShifts = new Dictionary<string, string>();
                p.totalHours = 0;
            }

            for (int i = 0; i < 7; i++)
            {
                weekSchedule[i] = CreateNewDaySchedule(day);

                if (i != 6)
                    day = day.AddDays(1);
            }

            if (MessageBox.Show("Schedule Created!", "Message", MessageBoxButtons.OK) == DialogResult.OK)
            {
                ScheduleViewerForm sv = new ScheduleViewerForm();
                sv.Show();
                wss.Close();
            }
        }
    }
}
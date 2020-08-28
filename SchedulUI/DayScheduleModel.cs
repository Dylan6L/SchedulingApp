using ScheduleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulUI
{
    public class DayScheduleModel
    {

        public DateTime date = new DateTime();
        public DayOfWeek dayOfWeek = new DayOfWeek();

        public PersonModel lunchFrontlineManager = new PersonModel();
        public PersonModel lunchBacklineManager = new PersonModel();

        // 3-5
        public PersonModel afternoonFrontlineManager = new PersonModel();
        public PersonModel afternoonBacklineManager = new PersonModel();

        public PersonModel dinnerFrontlineManager = new PersonModel();
        public PersonModel dinnerBacklineManager = new PersonModel();

        public int frontPeople10 = 0;
        public int frontPeople35 = 0;
        public int backPeople10 = 0;
        public int backPeople35 = 0;

        public int frontPeople8 = 0;
        public int frontPeople9 = 0;
        public int backPeople8 = 0;
        public int backPeople9 = 0;

        public PersonModel oManager = new PersonModel();
        public PersonModel porter = new PersonModel();
        public PersonModel prep = new PersonModel();

        public PersonModel lSet = new PersonModel();
        public PersonModel lCash1 = new PersonModel();
        public PersonModel lCash2 = new PersonModel();
        public PersonModel lDtOrder = new PersonModel();
        public PersonModel lDtCash = new PersonModel();
        public PersonModel lDining = new PersonModel();
        public PersonModel lRunner = new PersonModel();
        public PersonModel lCustard1 = new PersonModel();
        public PersonModel lCustard2 = new PersonModel();

        public PersonModel dSet = new PersonModel();
        public PersonModel dCash1 = new PersonModel();
        public PersonModel dCash2 = new PersonModel();
        public PersonModel dDtOrder = new PersonModel();
        public PersonModel dDtCash = new PersonModel();
        public PersonModel dDining = new PersonModel();
        public PersonModel dRunner = new PersonModel();
        public PersonModel dCustard1 = new PersonModel();
        public PersonModel dCustard2 = new PersonModel();

        public PersonModel lMiddle = new PersonModel();
        public PersonModel lFloat = new PersonModel();
        public PersonModel lGrill1 = new PersonModel();
        public PersonModel lGrill2 = new PersonModel();
        public PersonModel lBuns1 = new PersonModel();
        public PersonModel lBuns2 = new PersonModel();
        public PersonModel lFryers1 = new PersonModel();
        public PersonModel lFryers2 = new PersonModel();

        public PersonModel dMiddle = new PersonModel();
        public PersonModel dFloat = new PersonModel();
        public PersonModel dGrill1 = new PersonModel();
        public PersonModel dGrill2 = new PersonModel();
        public PersonModel dBuns1 = new PersonModel();
        public PersonModel dBuns2 = new PersonModel(); 
        public PersonModel dFryers1 = new PersonModel();
        public PersonModel dFryers2 = new PersonModel();

        public PersonModel kitchenCloser = new PersonModel();
        public PersonModel dishCloser = new PersonModel();
        public PersonModel frontlineCloser = new PersonModel();
        public PersonModel diningCloser = new PersonModel();
        public PersonModel custardCloser = new PersonModel();

    }
}

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
    public partial class ScheduleViewerForm : Form
    {
        private DayScheduleModel[] scheduleWeek = new DayScheduleModel[7];
        DateTime curDate = new DateTime();

        public ScheduleViewerForm()
        {
            InitializeComponent();

            scheduleWeek = Program.weekSchedule;
            curDate = scheduleWeek[0].date;

            shiftDatePicker.Value = curDate;
            shiftDatePicker.MinDate = curDate;
            shiftDatePicker.MaxDate = curDate.AddDays(7);

            ViewDay(0);
        }

        private void ViewDay(int day)
        {
            // TODO display all positions

            DayScheduleModel d = scheduleWeek[day];

            oManagerName.Text = d.oManager.name;
            porterName.Text = d.porter.name;
            prepName.Text = d.prep.name;

            // Front lunch
            setLunchName.Text = d.lSet.name;
            cash1MorningName.Text = d.lCash1.name;
            cash2MorningName.Text = d.lCash2.name;
            dtOrderMorningName.Text = d.lDtOrder.name;
            dtCashLunchName.Text = d.lDtCash.name;
            runnerLunchName.Text = d.lRunner.name;
            diningLunchName.Text = d.lDining.name;
            custard1LunchName.Text = d.lCustard1.name;
            custard2LunchName.Text = d.lCustard2.name;
            // Back lunch
            middleLunchName.Text = d.lMiddle.name;
            floatLunchName.Text = d.lFloat.name;
            grill1LunchName.Text = d.lGrill1.name;
            grill2LunchName.Text = d.lGrill2.name;
            buns1LunchName.Text = d.lBuns1.name;
            buns2LunchName.Text = d.lBuns2.name;
            fryers1LunchName.Text = d.lFryers1.name;
            fryers2LunchName.Text = d.lFryers2.name;

            // Closers
            custardCloserName.Text = d.dCustard1.name;
            frontLineCloserName.Text = d.frontlineCloser.name;
            dishCloserName.Text = d.dishCloser.name;
            kitchenCloserName.Text = d.kitchenCloser.name;

            // Front dinner
            setDinnerName.Text = d.dSet.name;
            cash1DinnerName.Text = d.dCash1.name;
            cash2DinnerName.Text = d.dCash2.name;
            dtOrderDinnerName.Text = d.dDtOrder.name;
            dtCashDinnerName.Text = d.dDtCash.name;
            runnerDinnerName.Text = d.dRunner.name;
            diningDinnerName.Text = d.dDining.name;
            diningCloserName.Text = d.diningCloser.name;
            custard1DinnerName.Text = d.dCustard1.name;
            custard2DinnerName.Text = d.dCustard2.name;
            // Back dinner
            middleDinnerName.Text = d.dMiddle.name;
            floatDinnerName.Text = d.dFloat.name;
            grill1DinnerName.Text = d.dGrill1.name;
            grill2DinnerName.Text = d.dGrill2.name;
            buns1DinnerName.Text = d.dBuns1.name;
            buns2DinnerName.Text = d.dBuns2.name;
            fryers1DinnerName.Text = d.dFryers1.name;
            fryers2DinnerName.Text = d.dFryers2.name;
            dishCloserName.Text = d.dishCloser.name;


            // Shifts

            // frontline lunch
            setLunchShift.Text = d.lSet.GetShift(d.date.ToShortDateString(), false);
            cash1MorningShift.Text = d.lCash1.GetShift(d.date.ToShortDateString(), false);
            cash2MorningShift.Text = d.lCash2.GetShift(d.date.ToShortDateString(), false);
            dtOrderMorningShift.Text = d.lDtOrder.GetShift(d.date.ToShortDateString(), false);
            dtCashLunchShift.Text = d.lDtCash.GetShift(d.date.ToShortDateString(), false);
            diningLunchShift.Text = d.lDining.GetShift(d.date.ToShortDateString(), false);
            runnerLunchShift.Text = d.lRunner.GetShift(d.date.ToShortDateString(), false);
            custard1LunchShift.Text = d.lCustard1.GetShift(d.date.ToShortDateString(), false);
            custard2LunchShift.Text = d.lCustard2.GetShift(d.date.ToShortDateString(), false);
            // Backline lunch
            middleLunchShift.Text = d.lMiddle.GetShift(d.date.ToShortDateString(), false);
            floatLunchShift.Text = d.lFloat.GetShift(d.date.ToShortDateString(), false);
            grill1LunchShift.Text = d.lGrill1.GetShift(d.date.ToShortDateString(), false);
            grill2LunchShift.Text = d.lGrill2.GetShift(d.date.ToShortDateString(), false);
            buns1LunchShift.Text = d.lBuns1.GetShift(d.date.ToShortDateString(), false);
            buns2LunchShift.Text = d.lBuns2.GetShift(d.date.ToShortDateString(), false);
            fryers1LunchShift.Text = d.lFryers1.GetShift(d.date.ToShortDateString(), false);
            fryers2LunchShift.Text = d.lFryers2.GetShift(d.date.ToShortDateString(), false);

            // Frontline dinner
            setDinnerShift.Text = d.dSet.GetShift(d.date.ToShortDateString(), true);
            cash1DinnerShift.Text = d.dCash1.GetShift(d.date.ToShortDateString(), true);
            cash2DinnerShift.Text = d.dCash2.GetShift(d.date.ToShortDateString(), true);
            dtOrderDinnerShift.Text = d.dDtOrder.GetShift(d.date.ToShortDateString(), true);
            dtCashDinnerShift.Text = d.dDtCash.GetShift(d.date.ToShortDateString(), true);
            diningDinnerShift.Text = d.dDining.GetShift(d.date.ToShortDateString(), true);
            runnerDinnerShift.Text = d.dRunner.GetShift(d.date.ToShortDateString(), true);
            custard1DinnerShift.Text = d.dCustard1.GetShift(d.date.ToShortDateString(), true);
            custard2DinnerShift.Text = d.dCustard2.GetShift(d.date.ToShortDateString(), true);
            // Backline dinner
            middleDinnerShift.Text = d.dMiddle.GetShift(d.date.ToShortDateString(), true);
            floatDinnerShift.Text = d.dFloat.GetShift(d.date.ToShortDateString(), true);
            grill1DinnerShift.Text = d.dGrill1.GetShift(d.date.ToShortDateString(), true);
            grill2DinnerShift.Text = d.dGrill2.GetShift(d.date.ToShortDateString(), true);
            buns1DinnerShift.Text = d.dBuns1.GetShift(d.date.ToShortDateString(), true);
            buns2DinnerShift.Text = d.dBuns2.GetShift(d.date.ToShortDateString(), true);
            fryers1DinnerShift.Text = d.dFryers1.GetShift(d.date.ToShortDateString(), true);
            fryers2DinnerShift.Text = d.dFryers2.GetShift(d.date.ToShortDateString(), true);

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int inx = Program.GetDayOfWeekNumber(shiftDatePicker.Value.DayOfWeek.ToString().Substring(0, 3));

            ViewDay(inx);
        }

        private void dayAfterButton_Click(object sender, EventArgs e)
        {
            shiftDatePicker.Value.AddDays(1);
            int inx = Program.GetDayOfWeekNumber(shiftDatePicker.Value.DayOfWeek.ToString().Substring(0, 3));

            ViewDay(inx);
        }

        private void dayBeforeButton_Click(object sender, EventArgs e)
        {
            shiftDatePicker.Value.AddDays(-1);
            int inx = Program.GetDayOfWeekNumber(shiftDatePicker.Value.DayOfWeek.ToString().Substring(0, 3));

            ViewDay(inx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
                if (f.Name == "hoursForm")
                {
                    MessageBox.Show("Window already open!", "Message", MessageBoxButtons.OK);
                    return;
                }

            hoursForm sm = new hoursForm(shiftDatePicker.Value.ToShortDateString());
            sm.Show();
        }
    }
}

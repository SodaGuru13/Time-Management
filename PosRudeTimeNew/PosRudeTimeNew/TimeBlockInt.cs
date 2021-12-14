using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosRudeTimeNew
{
    public partial class TimeBlockInt : Form
    {
        private List<TimeBlock> timeBlockList = new List<TimeBlock>();
        private int element = 0;
        private DateTime AddTime;
        public TimeBlockInt(DateTime recievedFromCalender)
        {
            InitializeComponent();
            this.AddTime = recievedFromCalender;
            this.EnterStartDate.Value = recievedFromCalender;
            this.EnterEndDate.Value = recievedFromCalender;
            this.EnterStart.Value = recievedFromCalender;
            this.EnterEnd.Value = recievedFromCalender;
            List<TimeBlock> returned = TimeBlock.Deserialize();
            foreach(TimeBlock turn in returned)
            {
                timeBlockList.Add(turn);
            }

        }

        public TimeBlockInt(DateTime recievedFromToast, int i)
        {

            InitializeComponent();
            int three = i;

            List<TimeBlock> timeBlock = TimeBlock.Deserialize();

            //List<TimeBlock> timeBlock = SortedList();

            var block = timeBlock.SingleOrDefault(date => date.StartTime == recievedFromToast);

            this.EnterStartDate.Value = block.StartTime.Date;
            this.EnterStart.Value = block.StartTime;
            this.EnterEndDate.Value = block.EndTime.Date;
            this.EnterEnd.Value = block.EndTime;
            this.NameText.Text = block.Name;
            this.DescriptionTextBox.Text = block.Description;
            this.LocationTextBox.Text = block.Location;
            /*
            if (element >= timeBlock.Count)
            {
                return;
            }
            else
            {
                ++element;
                this.EnterStartDate.Value = timeBlock[element - 1].StartTime.Date;
                this.EnterStart.Value = timeBlock[element - 1].StartTime;
                this.EnterEndDate.Value = timeBlock[element - 1].EndTime.Date;
                this.EnterEnd.Value = timeBlock[element - 1].EndTime;
                this.NameText.Text = timeBlock[element - 1].Name;
                this.DescriptionTextBox.Text = timeBlock[element - 1].Description;
                this.LocationTextBox.Text = timeBlock[element - 1].Location;
            }
            */
        }

        private void TimeBlockInt_Load(object sender, EventArgs e)
        {
            
        }
        private void MnDyYr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static IEnumerable<DateTime> EachCalendarDay(DateTime start, DateTime end)
        {
            for (var date = start.Date; date.Date <= end.Date; date = date.AddDays(1))
            {
                yield return date;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (this.EnterEndDate.Value.Date == this.EnterStartDate.Value.Date)
            {
                DateTime start = this.EnterStartDate.Value.Add(this.EnterStart.Value.TimeOfDay);
                DateTime end = this.EnterEndDate.Value.Add(this.EnterEnd.Value.TimeOfDay);
                string name = this.NameText.Text;
                string description = this.DescriptionTextBox.Text;
                string location = this.LocationTextBox.Text;
                TimeBlock.AddBlock(timeBlockList, start, end, name, location, description);
            }
            else
            {
                DateTime start = this.EnterStartDate.Value;
                DateTime end = this.EnterEndDate.Value;
                string name = this.NameText.Text;
                string description = this.DescriptionTextBox.Text;
                string location = this.LocationTextBox.Text;
                foreach (DateTime day in EachCalendarDay(start, end))
                {
                    TimeBlock.AddBlock(timeBlockList, day.Add(this.EnterStart.Value.TimeOfDay), day.Add(this.EnterEnd.Value.TimeOfDay), name, location, description);
                }
            }

            new Alert(DescriptionTextBox.Text, EnterStart.Value, EnterEnd.Value, NameText.Text, LocationTextBox.Text); //To set the Toast alerts, windows popup

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DateTime start = this.EnterStartDate.Value.Add(this.EnterStart.Value.TimeOfDay);
            TimeBlock.DeleteBlock(timeBlockList, start);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DateTime start = this.EnterStartDate.Value.Add(this.EnterStart.Value.TimeOfDay);
            DateTime end = this.EnterEndDate.Value.Add(this.EnterEnd.Value.TimeOfDay);
            string name = this.NameText.Text;
            string description = this.DescriptionTextBox.Text;
            string location = this.LocationTextBox.Text;
            TimeBlock.EditBlock(timeBlockList, start, start, end, name, location, description);
        }
        private List<TimeBlock> SortedList()
        {
            IEnumerable<TimeBlock> ITimeBlock = timeBlockList.OrderBy(timeBlock => timeBlock.StartTime);
            return ITimeBlock.ToList();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            List<TimeBlock> sortedTime = SortedList();
            if (element >= sortedTime.Count)
            {
                Console.WriteLine(sortedTime.Count.ToString() + element);
                return;
            }
            else
            {
                ++element;
                this.EnterStartDate.Value = sortedTime[element-1].StartTime.Date;
                this.EnterStart.Value = sortedTime[element-1].StartTime;
                this.EnterEndDate.Value = sortedTime[element-1].EndTime.Date;
                this.EnterEnd.Value = sortedTime[element-1].EndTime;
                this.NameText.Text = sortedTime[element-1].Name;
                this.DescriptionTextBox.Text = sortedTime[element-1].Description;
                this.LocationTextBox.Text = sortedTime[element-1].Location;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            List<TimeBlock> sortedTime = SortedList();
            if(element > 0)
            {
                --element;
            }


            if (element <= 0)
            {
                this.EnterStartDate.Value = AddTime;
                this.EnterStart.Value = AddTime;
                this.EnterEndDate.Value = AddTime;
                this.EnterEnd.Value = AddTime;
                this.NameText.Text = "";
                this.DescriptionTextBox.Text = "";
                this.LocationTextBox.Text = "";
                return;
            }
            else
            {
                this.EnterStartDate.Value = sortedTime[element].StartTime.Date;
                this.EnterStart.Value = sortedTime[element].StartTime;
                this.EnterEndDate.Value = sortedTime[element].EndTime.Date;
                this.EnterEnd.Value = sortedTime[element].EndTime;
                this.NameText.Text = sortedTime[element].Name;
                this.DescriptionTextBox.Text = sortedTime[element].Description;
                this.LocationTextBox.Text = sortedTime[element].Location;
            }
        }
    }
}

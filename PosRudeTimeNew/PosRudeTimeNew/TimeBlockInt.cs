﻿using System;
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
        public TimeBlockInt(DateTime recievedFromCalender)
        {
            InitializeComponent();
            this.EnterStartDate.Value = recievedFromCalender;
            this.EnterEndDate.Value = recievedFromCalender;
            List<TimeBlock> returned = TimeBlock.Deserialize();
            foreach(TimeBlock turn in returned)
            {
                timeBlockList.Add(turn);
            }
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

        private void Add_Click(object sender, EventArgs e)
        {
            DateTime start = this.EnterStartDate.Value.Add(this.EnterStart.Value.TimeOfDay);
            DateTime end = this.EnterEndDate.Value.Add(this.EnterEnd.Value.TimeOfDay);
            string name = this.NameText.Text;
            string description = this.DescriptionTextBox.Text;
            string location = this.LocationTextBox.Text;
            TimeBlock.AddBlock(timeBlockList, start, end, name, location, description);
            foreach(TimeBlock timeBlock in timeBlockList)
            {
                Console.WriteLine(timeBlock.Name + "\n" + timeBlock.Description + "\n" + timeBlock.Location + "\n" + timeBlock.StartTime.ToLongDateString() + "\n" + timeBlock.EndTime.ToLongDateString());
            }
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
            this.EnterStartDate.Value = sortedTime[element].StartTime.Date;
            this.EnterStart.Value = sortedTime[element].StartTime.ToUniversalTime();

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            List<TimeBlock> sortedTime = SortedList();
        }
    }
}

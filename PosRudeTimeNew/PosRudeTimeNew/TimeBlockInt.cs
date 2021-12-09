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
            foreach(TimeBlock timeBlock in timeBlockList)
            {
                Console.WriteLine(timeBlock.StartTime);
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

        }
    }
}

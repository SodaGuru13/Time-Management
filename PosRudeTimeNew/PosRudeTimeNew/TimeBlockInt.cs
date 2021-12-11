using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PosRudeTimeNew
{
    public partial class TimeBlockInt : Form
    {
       

        public TimeBlockInt()
        {
            InitializeComponent();
        }

        private void TimeBlockInt_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           new Alert(DescriptionTextBox.Text, EnterStart.Value, EnterEnd.Value); // Can take off end value if you you just want to have it alert at the start time
        } 

        private void MnDyYr_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ToastNotificationManagerCompat.History.Clear(); // So that Cancel stops them from happening
        }
    }
}

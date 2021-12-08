using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosRudeTimeNew
{
    public partial class UserControlDays : UserControl
    {
       
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void day(int dayNum)
        {
            labDays.Text = dayNum+""; 
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            
            TimeBlockInt timeBlock = new TimeBlockInt();
            timeBlock.Show();
            Console.WriteLine(labDays.Text);
            
        }
    }
}

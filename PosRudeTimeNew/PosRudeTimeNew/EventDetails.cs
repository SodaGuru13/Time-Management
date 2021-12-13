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
    public partial class EventDetails : Form
    {
        public EventDetails(string name)
        {
            InitializeComponent();
            EventNameBox.Text = name;
            //DescriptionTextBox.Text = text;
            //LocationTextBox.Text = location;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

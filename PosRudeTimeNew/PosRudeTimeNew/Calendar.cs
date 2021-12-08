using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosRudeTimeNew
{
    public partial class Calendar : Form
    {
        int Month, Year; 
 
      

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, System.EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            Month = now.Month;
            Year = now.Year;


            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mnth.Text = monthName;
            Yr.Text = Year.ToString(); 

            

            DateTime startofthemonth = new DateTime(Year, Month, 1); //gets 1st day of the month
            
            int days = DateTime.DaysInMonth(Year, Month); //gets the number of days in a month

            int dayofWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //converts the days of months to an interger value

            for ( int i = 1; i < dayofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);
             
            }
            for ( int i = 1; i<= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.day(i);
                daycontainer.Controls.Add(ucDays); 
            }
        }



        private void Next_Click(object sender, System.EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            if (Month <= 11)
            {
                Month++;

            }
            else
            {
                Month = 1;
                Year++;
            }
            //increment month to go to next month
           
         
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mnth.Text = monthName;
            Yr.Text = Year.ToString(); 
            
            DateTime startofthemonth = new DateTime(Year, Month, 1); //gets 1st day of the month

            int days = DateTime.DaysInMonth(Year, Month); //gets the number of days in a month

            int dayofWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //converts the days of months to an interger value

            for (int i = 1; i < dayofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.day(i);
                daycontainer.Controls.Add(ucDays);
            }
        }

        

        private void Previous_Click(object sender, System.EventArgs e)
        {
            //clear container
            daycontainer.Controls.Clear();
            //increment month to go to next month
            if(Month > 1)
            {
                Month--; 
            }
            else
            {
                Month = 12;
                Year--; 
            }
            
            
           
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            Mnth.Text = monthName;
            Yr.Text = Year.ToString();

            DateTime startofthemonth = new DateTime(Year, Month, 1); //gets 1st day of the month

            int days = DateTime.DaysInMonth(Year, Month); //gets the number of days in a month

            int dayofWeek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1; //converts the days of months to an interger value

            for (int i = 1; i < dayofWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                daycontainer.Controls.Add(ucBlank);

            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.day(i);
                daycontainer.Controls.Add(ucDays);
            }
        }

        
    }
}
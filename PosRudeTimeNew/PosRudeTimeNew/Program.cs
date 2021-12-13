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
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Foundation.Collections;

namespace PosRudeTimeNew
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Listen to notification activation, should be notification click - reference: https://docs.microsoft.com/en-us/windows/apps/design/shell/tiles-and-notifications/send-local-toast?tabs=desktop
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {   // Opens the software even if it were closed so that's good but then we need a way to use this, probably by calling some kind of report?

                //Console.WriteLine("Clicked: " + toastArgs.ToString()); // This doesn't work to show anything that I could find in the console 

                //*** Pretty sure we could use this to trigger pulling the information of the event from the json file storage

                // Obtain the arguments from the notification
                //ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

                // Obtain any user input (text boxes, menu selections) from the notification
                //ValueSet userInput = toastArgs.UserInput;
                Application.Run(new EventDetails());
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calendar());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PosRudeTimeNew
{
    class Alert
    {
        
        public Alert (string text, DateTime start)      //This is the one I was testing and showing off in the discord
        {
            new ToastContentBuilder()
                .AddText(text)
                .Schedule(start);
        }

        public Alert (string text, DateTime start, DateTime end, string name, string location) //This one should allow for the end of an event if that's what we want to do
        {

            new ToastContentBuilder()
                .AddText(name)
                .AddText(text)
                .AddAttributionText(location)
                .AddArgument(name)
                .Schedule(start);
                //.Show(); //For testing if the data is moving correctly

            new ToastContentBuilder()
                .AddText("Task Time Over: " + name)
                .AddText(text)
                .AddAttributionText(location)
                .AddArgument(name)
                .Schedule(end);

        }

    }
}

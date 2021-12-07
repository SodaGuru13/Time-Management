using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosRudeTimeNew
{
    class TimeBlock
    {
        public static string Name;
        public static string Description;
        public static string Location;
        public static DateTime StartTime;
        public static DateTime EndTime;
        TimeBlock(string name, string description, string location, DateTime startime, DateTime endtime)
        {
            Name = name;
            Description = description;
            Location = location; 
            StartTime = startime;
            EndTime = endtime;
        }
        public void Add()
        {

        }
        public void Remove()
        {

        }
    }
}

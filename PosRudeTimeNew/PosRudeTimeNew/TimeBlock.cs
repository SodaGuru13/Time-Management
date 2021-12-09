using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PosRudeTimeNew
{
    public class TimeBlock
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public static void Serialize(List<TimeBlock> timeBlock)
        {
            string username = Environment.UserName;
            // folder name will need to be fixed
            string fileName = @"C:\Users\" + username + "\\source\\repos_new_12082021\\PosRudeTimeNew\\RudeTimeDates.json";

            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string jsonString = JsonSerializer.Serialize(timeBlock, options);
            File.WriteAllText(fileName, JsonConvert.SerializeObject(timeBlock, Formatting.Indented));
        }

        public static List<TimeBlock> Deserialize()
        {
            var timeBlock = new List<TimeBlock>();

            string username = Environment.UserName;
            // folder name here will need to be fixed
            string fileName = @"C:\Users\" + username + "\\source\\repos_new_12082021\\PosRudeTimeNew\\RudeTimeDates.json";
            //string jsonString = File.ReadAllText(fileName);
            timeBlock = JsonConvert.DeserializeObject<List<TimeBlock>>(File.ReadAllText(fileName));

            return timeBlock;
        }

        public static void AddBlock(List<TimeBlock> timeBlock, DateTime startTime, DateTime endTime, string name, string location, string description)
        {
            timeBlock.Add(new TimeBlock
            {
                StartTime = startTime,
                EndTime = endTime,
                Name = name,
                Location = location,
                Description = description
            });

            Serialize(timeBlock);
        }

        public static void DeleteBlock(List<TimeBlock> timeBlock, DateTime editDate)
        {
            var block = timeBlock.SingleOrDefault(date => date.StartTime == editDate);
            if (block != null)
            {
                timeBlock.Remove(block);
            }

            Serialize(timeBlock);
        }

        public static void EditBlock(List<TimeBlock> timeBlock, DateTime editItem, DateTime startTime, DateTime endTime, string name, string location, string description)
        {
            DeleteBlock(timeBlock, editItem);
            AddBlock(timeBlock, startTime, endTime, name, location, description);
        }

    }
}


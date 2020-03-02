using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            //Split original time string to separate hours, minutes and seconds 
            string[] splits = aTime.Split(new char[] { ':' });

            ProcessTime obj = new ProcessTime();

            //Berlin Clock Time will be formed by concatination of processed seconds, hours and minutes strings with nextline char in between.
            return obj.processSeconds(splits[2]) + "\r\n" + obj.processHours(splits[0]) + "\r\n" + obj.processMinutes(splits[1]);
        }
    }
}

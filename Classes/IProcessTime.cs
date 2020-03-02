using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    interface IProcessTime
    {
        string processSeconds(string seconds);
        string processHours(string hours);
        string processMinutes(string minutes);
    }
}

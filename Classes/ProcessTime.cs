using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    class ProcessTime : IProcessTime
    {
        public string processHours(string hours)
        {
            string output = "";
            int iHours = Convert.ToInt16(hours);
            int firstRow = iHours / 5; // No of Lamps to ON in first row
            int secondRow = iHours % 5; // No of Lamps to ON in second row

            //Put 'R' for every ON a Red Lamp 
            for(int i=0; i<firstRow; i++)
            {
                output += "R";
            }

            //Put 'O' for OFF for remaining Lamps in first row
            for(int i=firstRow; i<4; i++)
            {
                output += "O";
            }

            output += "\r\n";

            //Put 'R' for every ON a Red Lamp in second row
            for (int i=0; i<secondRow; i++)
            {
                output += "R";
            }

            //Put 'O' for OFF for remaining Lamps in second row
            for (int i =secondRow; i<4; i++)
            {
                output += "O";
            }

            return output;
        }

        public string processMinutes(string minutes)
        {
            string output = "";
            int iMinutes = Convert.ToInt16(minutes);
            int firstRow = iMinutes / 5; // No of Lamps to ON in first row
            int secondRow = iMinutes % 5; // No of Lamps to ON in second row

            // Put 'R' for every ON Red lamp and 'Y' for every ON Yellow lamp 
            for (int i = 0; i < firstRow; i++)
            {
                if (i == 2 || i == 5 || i == 8) // 3rd, 6th and 9th Lamp are Red
                {
                    output += "R";
                }
                else
                    output += "Y";
            }
            
            //Put 'O' as OFF for remaining lamps in first row.
            for (int i = firstRow; i < 11; i++)
            {
                output += "O";
            }

            output += "\r\n";

            //Put 'Y' for every ON Yellow lamp in second row 
            for (int i=0; i<secondRow; i++)
            {
                output += "Y";
            }

            //Put 'O' as OFF for remaining lamps in second row.
            for (int i=secondRow; i<4; i++)
            {
                output += "O";
            }
            
            return output;
        }

        public string processSeconds(string seconds)
        {
            int iSeconds = Convert.ToInt16(seconds);
            // Seconds lamp is on/Off every 2 seconds. For every even second it is ON, for every odd second it is OFF. 
            if (iSeconds % 2 == 0)
                return "Y";  //Seconds lamp is yellow in color
            else
                return "O";
        }
    }
}

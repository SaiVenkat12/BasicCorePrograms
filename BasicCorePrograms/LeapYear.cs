using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void LeapYearOrNot()
        {
            Console.WriteLine("Enter the Year to Check Leap Year or not: ");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year > 1000 && year < 10000)
            {
                if((year % 100 != 0) && (year % 4 == 0) || (year % 400 == 0))
                {
                    Console.WriteLine("{0} is a LEAP YEAR",year);
                }
                else
                {
                    Console.WriteLine("{0} is Not a LEAP YEAR",year);
                }
            }
            else
            {
                Console.WriteLine("Enter the YEAR Correctly");
            }
        }
    }
}

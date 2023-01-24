using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1.Heads and Tails \n2.Leap Year or not \n11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        HeadsAndTails.HeadandTailPercentage();
                        break;
                    case 2:
                        LeapYear.LeapYearOrNot();
                        break;
                    case 11:
                        flag= false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

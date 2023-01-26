using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenorOdd
    {
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter the Number to check Even or Odd : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("{0} is a Even Number",n);
            }
            else
            {
                Console.WriteLine("{0} is a Odd Number", n);
            }
        }
    }
}

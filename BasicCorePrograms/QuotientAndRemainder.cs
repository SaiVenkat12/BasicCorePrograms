using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public static void Division()
        {
            int remainder, quotient;
            Console.WriteLine("Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor : ");
            int d = Convert.ToInt32(Console.ReadLine());
            remainder = n % d;
            quotient = n / d;
            Console.WriteLine("Quotient = {0}\nRemainder = {1}", quotient, remainder);

        }
    }
}

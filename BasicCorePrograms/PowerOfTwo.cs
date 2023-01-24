using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public static void TwoPower()
        {
            int power = 0;
            Console.WriteLine("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                 power = (int)Math.Pow(2, i);
                Console.WriteLine(power);
            }
            Console.WriteLine("2 power {0} = {1}", n, power);
        }
    }
}

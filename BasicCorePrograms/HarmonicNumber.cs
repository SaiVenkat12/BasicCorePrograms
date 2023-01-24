using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void HarmonicNo()
        {
            double harmonic = 0.0;
            Console.WriteLine("Enter the Nth Term of Harmonic : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n != 0)
            {
                for(int i=1; i<=n; i++)
                {
                    harmonic += 1 / (float)i;
                }
                Console.WriteLine("The sum of first {0} Harmonic Numbers is {1}",n,harmonic);
            }
            else
            {
                Console.WriteLine("Enter the Value Greater than 0");
            }
        }
    }
}

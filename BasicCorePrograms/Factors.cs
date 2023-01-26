using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter the Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i, j;
            int count = 0;
            Console.Write("Prime factor of {0}:\n1\n", n);
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    count = 0;
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        { 
                            count++; 
                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
        }
    }
}

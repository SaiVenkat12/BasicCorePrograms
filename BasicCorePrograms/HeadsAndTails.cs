using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HeadsAndTails
    {
        public static void HeadandTailPercentage()
        {
            Console.WriteLine("Enter the number of times you want to Toss the Coin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int headCount=0, tailCount=0;
            Random random= new Random();  
            for(int i=0;i<n;i++)
            {
                double randomFlip = random.NextDouble();
                if (randomFlip < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Heads= {0} times",headCount);
            Console.WriteLine("Tails= {0} times",tailCount);
            double headPercentage = (headCount * 100) / n;
            double tailPercentage = (tailCount * 100) / n;
            Console.WriteLine("Head Percentage = {0}% \nTail Percentage = {1}%",headPercentage,tailPercentage);
        }

    }
}

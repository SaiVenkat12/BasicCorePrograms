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
            Console.WriteLine("Enter the number of times you want to Toss the Coin: ");
            int n=Convert.ToInt32(Console.ReadLine());
            HeadsAndTails.HeadandTailPercentage(n);
            Console.ReadLine();
        }
    }
}

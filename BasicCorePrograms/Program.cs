using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                Console.WriteLine("1.Heads and Tails \n2.Leap Year or not \n3.Power of 2 \n4.Harmonic Number \n5.Swap 2 Numbers \n6.Prime Factors of a Number \n7.Quotient And Remainder \n8.Even or Odd \n9.Vowel or Consonant \n11.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        HeadsAndTails.HeadandTailPercentage();
                        break;
                    case 2:
                        LeapYear.LeapYearOrNot();
                        break;
                    case 3:
                        PowerOfTwo.TwoPower();
                        break;
                    case 4:
                        HarmonicNumber.HarmonicNo();
                        break;
                    case 5:
                        SwapNumbers.SwapTwoNumber();
                        break;
                    case 6:
                        Factors.PrimeFactors();
                        break;
                    case 7:
                        QuotientAndRemainder.Division();
                        break;
                    case 8:
                        EvenorOdd.EvenOrOdd();
                        break;
                    case 9:
                        VowelOrConsonant.Vowel();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class GreatestNumber
    {
        public static void GreatestAmong3()
        {
            Console.WriteLine("Enter the First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            if ((firstNumber > secondNumber) && (firstNumber > thirdNumber))
            {
                Console.WriteLine("The Greatest Number is " + firstNumber);
            }
            else if((secondNumber > firstNumber) && (secondNumber > thirdNumber))
            {
                Console.WriteLine("The Greatest Number is " + secondNumber);
            }
            else
            {
                Console.WriteLine("The Greatest Number is " + thirdNumber);
            }
        }
    }
}

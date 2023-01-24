using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public static void SwapTwoNumber()
        {
            int temp;
            Console.WriteLine("Enter the First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("After Swaping First Number: {0} second Number: {1}", firstNumber, secondNumber);
        }
    }
}

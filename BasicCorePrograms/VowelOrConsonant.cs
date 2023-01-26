using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonant
    {
        public static void Vowel()
        {
            char ch, ch1;
            Console.WriteLine("Enter the alphabet to check Vowel or Conconent:");
            ch = Convert.ToChar(Console.ReadLine());
            ch1 = ch;
            ch = char.ToLower(ch);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("{0} is vowel", ch1);
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", ch1);
            }

        }
    }
}

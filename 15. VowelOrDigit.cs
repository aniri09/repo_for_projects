using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            bool isDigit = (Char.IsDigit(symbol));
            bool isVowel = "aeiouAEIOU".IndexOf(symbol)>=0;
    
            if (isDigit)
                Console.WriteLine("digit");
            else if(isVowel)
                Console.WriteLine("vowel");
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

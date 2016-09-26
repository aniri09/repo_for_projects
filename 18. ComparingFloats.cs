using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
           decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs(num1 - num2);
            decimal eps = 0.000001m;

            if (diff>=eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
           
        }
    }
}

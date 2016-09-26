using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.DiffIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = (Console.ReadLine());
            bool flag=true;
            try { long longNum = Convert.ToInt64(number); }
            catch {
                flag = false;
                }
            if (flag)
            {
                Console.WriteLine("{0} can fit in:",number);
                try
                {
                    sbyte sbyteNum = Convert.ToSByte(number);
                    Console.WriteLine("* sbyte");
                }
                catch { };

                try
                {
                    byte sbyteNum = Convert.ToByte(number);
                    Console.WriteLine("* byte");
                }
                catch { };
                try { short shortNum = Convert.ToInt16(number);
                    Console.WriteLine("* short");
                }
                catch { };
                try { ushort ushortNum = Convert.ToUInt16(number);
                    Console.WriteLine("* ushort");
                }
                catch { }
                try { int intNum = Convert.ToInt32(number);
                    Console.WriteLine("* int");
                }
                catch
                {
                }
                try { uint uintNum = Convert.ToUInt32(number);
                    Console.WriteLine("* uint");
                }
                catch { }
                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type",number);
            }

            }
    }
}

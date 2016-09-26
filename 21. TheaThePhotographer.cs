using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPictures = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double percentageGood = double.Parse(Console.ReadLine());
            double uploadTime = double.Parse(Console.ReadLine());

            double filteredPics = Math.Ceiling(totalPictures * percentageGood / 100);
            double totalFilterTime = totalPictures * filterTime;
            double totalUploadTime = filteredPics * uploadTime;
            double time = totalFilterTime + totalUploadTime;
            TimeSpan t = TimeSpan.FromSeconds((time));

            string timeString = t.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeString);

        }
    }
}

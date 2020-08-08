using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double snowballValue = 0;
            int snowballSnow1 = 0;
            int snowballTime1 = 0;
            int snowballQuality1 = 0;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                double currentvalue = Math.Pow(snowballSnow / snowballTime, snowballQuality);
                if (currentvalue > snowballValue)
                {
                    snowballSnow1 = snowballSnow;
                    snowballTime1 = snowballTime;
                    snowballQuality1 = snowballQuality;
                    snowballValue = currentvalue;

                }
            }
            Console.WriteLine($"{snowballSnow1} : {snowballTime1} = {snowballValue} ({snowballQuality1})");
        }
    }
}

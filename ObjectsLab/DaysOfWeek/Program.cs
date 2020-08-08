using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DaysOfWeek
{

    class Program
    {
        
        static void Main()
        {
            string datetext = Console.ReadLine();

            DateTime date = DateTime.ParseExact(datetext,"d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);

        }
    }
}

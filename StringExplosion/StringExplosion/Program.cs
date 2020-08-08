using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strength = 0;

            //abv>1>1>2>2asdasd
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    continue;

                }
                if (strength > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    strength--;
                }

            }
            Console.WriteLine(input);

           
            
        }
    }
}

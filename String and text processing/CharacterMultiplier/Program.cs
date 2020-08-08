using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split();
            string first = text[0];
            string second = text[1];
            int firstLength = first.Length;
            int secondLength = second.Length;
            int pr = 1;
            int sum = 0;
            if (firstLength == secondLength)
            {
                for (int i = 0; i < firstLength; i++)
                {

                    pr = (int)first[i] * (int)second[i];
                    sum += pr;
                }
                Console.WriteLine(sum);
            }
            else if (firstLength > secondLength)
            {
                for (int i = 0; i < secondLength; i++)
                {
                    pr = (int)first[i] * (int)second[i];
                    sum += pr;
                }
                string excess = first.Substring(secondLength);
                for (int i = 0; i < excess.Length; i++)
                {
                    sum += (int)excess[i];

                }
                Console.WriteLine(sum);
            }
            else if (secondLength > firstLength)
            {
                for (int i = 0; i < firstLength; i++)
                {
                    pr = (int)first[i] * (int)second[i];
                    sum += pr;
                }
                string excess = second.Substring(firstLength);
                for (int i = 0; i < excess.Length; i++)
                {
                    sum += (int)excess[i];

                }
                Console.WriteLine(sum);
            }

        }
    }
}

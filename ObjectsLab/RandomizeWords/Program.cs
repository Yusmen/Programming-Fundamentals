using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] words = Console.ReadLine().Split();

            Random rnd = new Random();
            /*for (int i = 0; i < words.Length; i++)
            {
                int p = rnd.Next(words.Length);
                var swap = i;
                i = p;
                p = i;


            }
            Console.WriteLine(string.Join(Environment.NewLine, words));*/
            for (int i = 0; i < 100; i++)
            {
                int randomNumbers = rnd.Next(1, 100);
                Console.WriteLine(randomNumbers);
            }
           
            

        }
    }
}

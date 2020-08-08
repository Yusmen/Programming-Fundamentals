using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            var consequence = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            var parameters = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int bomb = parameters[0];
            int strength = parameters[1];

            for (int i = 0; i < consequence.Count; i++)
            {
                if (consequence[i] == bomb) 
                {

                    for (int j = i - strength; j <= i - 1; j++) 
                    {                     
                        consequence[j] = 0;
                    }
                    for (int k = i ; k <= i + strength; k++) 
                    {
                        
                        consequence[k] = 0;
                        if (k >= consequence.Count - 1)
                        {
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(consequence.Sum());

        }
    }
}

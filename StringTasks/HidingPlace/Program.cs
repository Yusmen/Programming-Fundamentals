using System;
using System.Linq;

namespace HidingPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            string consequence = Console.ReadLine();

            while (true)
            {
                var parameters = Console.ReadLine().Split(" ").ToList();
                char symbol = char.Parse(parameters[0]);
                int length = int.Parse(parameters[1]);
                for (int i = 0; i < consequence.Length; i++)
                {
                    if (consequence[i] == symbol) 
                    {
                        int j = i;
                        while (consequence[j] == symbol) 
                        {
                            j++;
                        }
                        if (j - i >= length) 
                        {
                            Console.WriteLine($"Hideout found at index {i} and it is with size {j-i}!");
                            return;


                        }


                    }
                }

            }
        }
    }
}

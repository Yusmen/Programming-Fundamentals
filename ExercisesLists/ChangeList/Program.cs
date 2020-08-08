using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                if (tokens[0] == "Delete")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] == numberToRemove)
                        {
                            numbers.Remove(numbers[i]);
                        }

                    }

                }
                else if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert);

                }




            }
            Console.WriteLine(string.Join(" ", numbers));               


        }
    }
}

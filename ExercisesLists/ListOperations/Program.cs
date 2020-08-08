using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;

                }

                string[] tokens = line.Split();
                if (tokens[0] == "Add")
                {
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd);
                }
                else if (tokens[0] == "Insert")
                {
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    if (indexToInsert < 0 || indexToInsert > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(indexToInsert, numberToInsert);

                }
                else if (tokens[0] == "Remove")
                {
                    int indexToRemoveAt = int.Parse(tokens[1]);
                    if (indexToRemoveAt < 0 || indexToRemoveAt > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(indexToRemoveAt);
                }
                else if (tokens[0] == "Shift" && tokens[1] == "left")
                {
                    int rotations = int.Parse(tokens[2]);
                    for (int i = 0; i < rotations % numbers.Count; i++)
                    {
                        int firstNumber = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }

                        numbers[numbers.Count - 1] = firstNumber;
                    }
                }
                else if (tokens[0] == "Shift" && tokens[1] == "right")
                {

                    int rotations = int.Parse(tokens[2]);
                    for (int i = 0; i < rotations % numbers.Count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1] ;
                        for (int j = numbers.Count - 1; j > 0; j--) 
                        {
                            numbers[j] = numbers[j - 1];
                        }

                        numbers[0] = lastNumber;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));



        }
    }
}

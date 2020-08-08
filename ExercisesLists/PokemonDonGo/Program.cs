using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDonGo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            while (numbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                
                if (index < 0)
                {
                    int firstElement = numbers[0];
                    numbers.RemoveAt(0);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= firstElement)
                        {
                            numbers[i] += firstElement;

                        }
                        else
                        {
                            numbers[i] -= firstElement;
                        }
                    }

                    sum += firstElement;
                    numbers.Insert(0, numbers[numbers.Count - 1]);
                }
                else if (index > numbers.Count - 1)
                {
                    int lastElement = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= lastElement)
                        {
                            numbers[i] += lastElement;

                        }
                        else
                        {
                            numbers[i] -= lastElement;
                        }
                    }

                    sum += lastElement;
                    numbers.Add(numbers[0]);
                }
                else
                {
                    int element = numbers[index];
                    sum += element;
                    numbers.RemoveAt(index);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= element)
                        {
                            numbers[i] += element;

                        }
                        else
                        {
                            numbers[i] -= element;
                        }
                    }
                }
              
            }
           Console.WriteLine(sum);
        }
    }
}

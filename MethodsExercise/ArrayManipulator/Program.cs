using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);

                    if (index > arr.Length - 1 || index < 0) 
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);
                }
                else if (command == "max")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMaxEvenOrODd(arr, 1);
                    }
                    else
                    {
                        index = GetMaxEvenOrODd(arr, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(index);
                }

                else if (command == "min")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {

                        index = GetMinEvenOrODd(arr, 1);
                    }
                    else
                    {
                        index = GetMinEvenOrODd(arr, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(index);
                }

                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int[] result = new int[0];
                    if (typeNumber == "odd")
                    {
                        result = GetFirstCountEvenOrOdd(arr, count, 1);
                    }
                    else
                    {
                        result = GetFirstCountEvenOrOdd(arr, count, 0);
                    }
                    Console.WriteLine("["+string.Join(",", result)+"]");
                }

                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int[] result = new int[0];
                    if (typeNumber == "odd")
                    {
                        result = GetLastCountEvenOrOdd(arr, count, 1);
                    }
                    else
                    {
                        result = GetLastCountEvenOrOdd(arr, count, 0);
                    }
                    Console.WriteLine("[" + string.Join(",", result) + "]");
                }
                    
            }
            Console.WriteLine($"[{string.Join(",", arr)}]");

        }

        private static int[] GetLastCountEvenOrOdd(int[] arr, int count, int v)
        {
            int[] arrResult = new int[count];
            int currentCount = 0;

            for (int i = arr.Length - 1; i >= 0; i++) 
            {
                if (arr[i] % 2 == v && currentCount < count)
                {
                    arrResult[currentCount] = arr[i];
                    currentCount++;
                }

            }
            if (currentCount >= count)
            {
                return arrResult.Reverse().ToArray();
            }
            else
            {
                int[] temp = new int[currentCount];
                Array.Copy(arrResult, temp, currentCount);
                return temp.Reverse().ToArray();
            }

        }

        private static int[] GetFirstCountEvenOrOdd(int[] arr, int count, int v)
        {
            int[] arrResult = new int[count];
            int currentCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == v && currentCount < count) 
                {
                    arrResult[currentCount] = arr[i];
                    currentCount++;
                }

            }
            if (currentCount >= count)
            {
                return arrResult;
            }
            else
            {
                int[] temp = new int[currentCount];
                Array.Copy(arrResult, temp, currentCount);
                return temp;
            }
        }

        private static int GetMinEvenOrODd(int[] arr, int division)
        {

            int minNumber = int.MinValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minNumber && arr[i] % 2 == division)
                {
                    minNumber = arr[i];
                    index = i;

                }
            }
            return index;
        }

        private static int GetMaxEvenOrODd(int[] arr,int division)
        {

            int maxNumber = int.MinValue;
            int index = -1;
            for (int i = 0; i <= arr.Length; i++)
            {
                if(arr[i]>maxNumber&&arr[i]%2==division)
                {
                    maxNumber = arr[i];
                    index = i;
                }
            }
            return index;
        }

        private static void Exchange(int[] arr, int index)
        {
            for (int i = 0; i < index + 1; i++)
            {
                int firstNumber = arr[0];
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstNumber;

            }
        }
    }
}

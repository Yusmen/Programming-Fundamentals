using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int length = 0;
            int sum = 0;
            int startindex = -1;
            int row = 0;
            int currentrow = 1;
            int[] DNA = new int[n];
            while(true)
            {
                
                string line = Console.ReadLine();
                if (line == "Clone them!")
                {
                    break;
                }
              
                int[] currentDNA = line.Split(new char[]{'!'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).
                    ToArray();
                

                int currentSum = 0;


                for (int i = 0; i < currentDNA.Length; i++) 
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }
                if (currentrow == 1)
                {
                    DNA = currentDNA;
                    row = currentrow;
                    sum = currentSum;
                }

                int currentStartIndex = -1;
                int currentLength = 0;
                bool isfound = false;


                for (int i = 0; i < currentDNA.Length; i++)
                {

                    if (currentDNA[i] == 1)
                    {   
                        if(!isfound)
                        {
                            currentStartIndex = i;

                        }
                        currentLength++;
                        if (currentLength > length)
                        {
                            length = currentLength;
                            startindex = currentStartIndex;
                            sum = currentSum;
                            row = currentrow;
                            DNA = currentDNA;
                        }
                        else if (currentLength == length)
                        {
                            if (currentStartIndex < startindex)
                            {
                                length = currentLength;
                                startindex = currentStartIndex;
                                sum = currentSum;
                                row = currentrow;
                                DNA = currentDNA;
                            }
                            else if (currentSum > sum)
                            {
                                length = currentLength;
                                startindex = currentStartIndex;
                                sum = currentSum;
                                row = currentrow;
                                DNA = currentDNA;
                            }

                        }

                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentLength = 0;
                        isfound = false;
                    }
                    

                    
                }


                currentrow++;
            }
            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));


        }
    }
}

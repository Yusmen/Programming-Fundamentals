using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptSortPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int currentsum = 0;
            for (int i = 0; i < n; i++) 
            {
                string line = Console.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    
                    if(line[j]=='a'||line[j]=='e'|| line[j]=='o'|| line[j]=='i'||line[j]=='u'||
                        line[j] == 'A' || line[j] == 'E' || line[j] == 'O' || line[j] == 'I' || line[j] == 'U')
                    {
                        currentsum += (int)line[j] * line.Length; 
                    }
                    else
                    {
                        currentsum += (int)line[j] / line.Length;
                    }
                }
                numbers[i] = currentsum;
                currentsum = 0;
            }
            for (int i = 0; i < n; i++)
            {
                int firstelement = numbers[i];
                int index = i;
                for (int j = i; j < n; j++)
                {
                    if (firstelement > numbers[j])
                    {
                        firstelement = numbers[j];
                        index = j;
;                    }
                }
                numbers[index] = numbers[i];
                numbers[i] = firstelement;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
 
                 

        }
    }
}

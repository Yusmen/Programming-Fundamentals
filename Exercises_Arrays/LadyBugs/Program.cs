using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main()
        {
            int fieldRange = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string first = string.Empty;
            string secondCommand = string.Empty;
            int thirdCommand = 0;
            int[] field = new int[fieldRange];
            for (int i = 0; i < indexes.Length; i++)
            {
                field[indexes[i]] = 1;

            }

            while(true)
            {

                first=Console.ReadLine();
                if(first=="end")
                {
                    break;
                }
                int firstCommand = int.Parse(first);
                secondCommand = Console.ReadLine();
                thirdCommand = int.Parse(Console.ReadLine());
                if(secondCommand=="right")
                {
                    for (int i = 0; i < fieldRange - 1; i++)
                    {
                        if (field[thirdCommand] != 0 && (field[thirdCommand + 1] == 0 || field[thirdCommand + 1] == 1))
                        {
                            field[thirdCommand] = field[firstCommand];
                            field[firstCommand] = 0;
                            field[thirdCommand + 1] = field[thirdCommand];

                        }
                        else
                        {

                        }
                       

                    }
                   
                }
                else if(secondCommand=="left")
                {

                }




            }
                   

        }
    }
}

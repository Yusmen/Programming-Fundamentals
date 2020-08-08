using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
           
            
            for (int i = 0; i < length; i++) 
            {


                string line = Console.ReadLine();
                string[] tokens = line.Split();
              
                if (tokens[2] == "going!")
                {
                    int f = 0;
                    for (int k = 0; k < names.Count; k++)
                    {
                        if (tokens[0] == names[k])
                        {
                            f = 1;
                            break;
                        }
                        else
                        {
                            f = 0;
                        }
                    }
                    if (f == 0)
                    {
                        names.Add(tokens[0]);
                    }
                    else if (f == 1) 
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    
                    

                }
                else if (tokens[2] == "not")
                {
                    int flag = 0;

                    for (int j = 0; j < names.Count; j++)
                    {
                        
                        if (names[j] == tokens[0])
                        {
                            names.Remove(names[j]);
                            flag = 0;
                            break;
                            
                           
                        }
                        else
                        {
                            flag = 1;

                        }
                    }
                    if (flag == 1)
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                }
                
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

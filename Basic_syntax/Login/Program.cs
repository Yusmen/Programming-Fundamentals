using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string realpassword = Console.ReadLine();
            string pass = string.Empty;
            for(int i=realpassword.Length-1;i>=0;i--)
            {
                pass += realpassword[i];
            }
            int br = 0;
            while(true)
            {

                string password = Console.ReadLine();
                br++;
                if (password != pass)
                {
                    if (br == 4)
                    {
                        Console.WriteLine($"User {realpassword} blocked!"); break;
                    }
                    else
                    {

                        Console.WriteLine("Incorrect password. Try again.");

                    }

                }
                if(password==pass&&br<=4)
                {
                    Console.WriteLine($"User {realpassword} logged in.");
                    break;
                }
            }
        }
    }
}

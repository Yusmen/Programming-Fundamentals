using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUserNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = { ", " };
            string[] passwords = Console.ReadLine().Split(symbols,StringSplitOptions.RemoveEmptyEntries);
            bool isBetween = false;
            bool isValid = false;
            foreach (var password in passwords)
            {
                if (password.Length >= 3 && password.Length <= 16)
                {
                    isBetween = true;
                }
                else
                {
                    isBetween = false;
                }

                for (int i = 0; i < password.Length; i++)
                {

                    if (char.IsLetterOrDigit(password[i])||password[i]=='-'||password[i]=='_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isBetween && isValid == true)
                {
                    Console.WriteLine(password);
                }
            }
                
                    
        }
    }
}

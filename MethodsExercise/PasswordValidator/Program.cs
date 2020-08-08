using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool a = NumberOfCharacters(password);
            bool b = LettersDigits(password);
            bool c = NumberDigits(password);
            if (a == true && b == true && c == true) 
            {
                Console.WriteLine("Password is valid");
            }
            if(a==false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if(b==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (c == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            } 



        }
        public static bool NumberOfCharacters(string password)
        {
            if(password.Length>=6&&password.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool LettersDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol)) 
                {
                    return false;
                }
            }
            return true;
                
        }
        public static bool NumberDigits(string password)
        {
            int br = 0;
            for(int i=0;i<password.Length;i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    br++;
                }
            }
            if (br >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
            
            
        
    }
}

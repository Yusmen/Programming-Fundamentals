using System;

namespace Merlah
{
    class Program
    {
        static void Main(string[] args)
        {

            string randomSymbols = Console.ReadLine();
            string shablon = Console.ReadLine();

            int count = 0;
            while (true)
            {

                while (randomSymbols.Contains(shablon))
                {
                    //if (shablon.Length == 0)
                    //{
                    //    break;
                    //}
                    //if (randomSymbols.Length < shablon.Length)
                    //{
                    //    break;
                    //}
          
                    randomSymbols = randomSymbols.Remove(randomSymbols.IndexOf(shablon), shablon.Length);                
                    count++;
                  
                }
                shablon = shablon.Remove(shablon.Length / 2, shablon.Length / 2);
                if (count >= 2)
                {
                    Console.WriteLine("Shaked it.");
                    count = 0;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomSymbols);
                    return ;
                }
             
                
            }


        }
    }
}

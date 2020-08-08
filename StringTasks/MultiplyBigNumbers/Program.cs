using System;

namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());

            int onMind = 0;
            string result = string.Empty;

            for (int i = bigNumber.Length - 1; i >= 0; i--) 
            {
                int pr = smallNumber * ((int)bigNumber[i] - 48);
                if (onMind > 0) 
                {
                    pr += onMind;
                    onMind = 0;
                }
                if (pr > 9) 
                {                 
                    onMind = pr / 10;
                    pr %= 10;

                }
                result += pr.ToString();

            }
            if (onMind > 0) 
            {
                result += onMind;
            }
            var endResult = result.ToCharArray();
            Array.Reverse(endResult);

            Console.WriteLine(endResult);
        }
    }
}

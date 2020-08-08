using System;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length < secondNumber.Length) 
            {
                firstNumber = new string('0', secondNumber.Length - firstNumber.Length) + firstNumber;
            }
            else if(firstNumber.Length > secondNumber.Length)
            {
                secondNumber = new string('0', firstNumber.Length - secondNumber.Length) + secondNumber;
              
            }

            int onMind = 0;
            string result = string.Empty;

            for (int i = firstNumber.Length - 1; i >= 0; i--) 
            {
                int sum = (int)firstNumber[i] + (int)secondNumber[i] - 96;
                if (onMind > 0)
                {
                    sum += onMind;
                    onMind = 0;
                }
                if (sum > 9) 
                {
                    onMind = sum / 10;
                    sum = sum % 10;
                  

                }
                result += sum.ToString();


            }
            var endResult = result.ToCharArray();
            Array.Reverse(endResult);
         
          
            
            Console.WriteLine($"{onMind}"+
            string.Join("",endResult));
            
        }
    }
}

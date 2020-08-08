using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            while(true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }


                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > words.Count - 1)
                    {
                        continue;
                    }
                    if (endIndex > words.Count - 1)
                    {
                        endIndex = words.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        continue;
                    }
                    Merge(words, startIndex, endIndex);
                }
                else if (command == "divide") 
                {
                    int indexOfWord = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);
                    
                    string element = words[indexOfWord];
                    words.RemoveAt(indexOfWord);

                    List<string> newWords= Divide(element, parts);
                    words.InsertRange(indexOfWord, newWords);

                }


            }
            Console.WriteLine(string.Join(" ", words));
              

        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partlenght = element.Length / parts;
            int lastpartlength = partlenght + element.Length % parts;

            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * partlenght, partlenght);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partlenght);

                }

                newWords.Add(newWord);
;            }


            return newWords;

        }

        private static void Merge(List<string> words, int startIndex, int endIndex)
        {

            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                sb.Append(words[i]);
            }

            words.RemoveRange(startIndex, endIndex - startIndex + 1);
            words.Insert(startIndex, sb.ToString());
        }
    }
}

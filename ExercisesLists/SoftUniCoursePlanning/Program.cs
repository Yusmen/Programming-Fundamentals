using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = {' ',',' };
            List<string> lessons = Console.ReadLine().Split(symbols,StringSplitOptions.RemoveEmptyEntries).ToList();
          
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "course start")
                {
                    break;
                }
             
                string[] tokens = line.Split(':');
                string command = tokens[0];

                if (command == "Add")
                {
                  
                    string lessonToAdd = tokens[1];
                    if (!lessons.Contains(lessonToAdd))
                    {
                        lessons.Add(lessonToAdd);
                    }
                        
                            
               
                }
                else if (command == "Insert")
                {
                
                    string lessonTitle = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }
                        
                            

                }
                else if (command == "Remove")
                {
               
                    string lessonToRemove = tokens[1];
                    if (lessons.Contains(lessonToRemove))
                    {
                        lessons.Remove(lessonToRemove);
                    }

                }
                else if (command == "Swap")
                {
                 
                    string firstLesson = tokens[1];
                    string secondLesson = tokens[2];
                    string firstLessonWithExercise = firstLesson + "-Exercise";
                    string secondLessonWithExercise = secondLesson + "-Exercise";

                    if (lessons.Contains(firstLesson) && lessons.Contains(secondLesson))
                    {
                        Swap(lessons, firstLesson, secondLesson);
                    }
                    if (lessons.Contains(firstLessonWithExercise))
                    {
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if(lessons[i]==firstLesson)
                            {
                                lessons.Remove(firstLessonWithExercise);
                                lessons.Insert(i + 1, firstLessonWithExercise);
                            }
                        }
                    }
                    if (lessons.Contains(secondLessonWithExercise))
                    {
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if (lessons[i] == secondLesson)
                            {
                                lessons.Remove(secondLessonWithExercise);
                                lessons.Insert(i + 1, secondLessonWithExercise);
                            }
                        }
                    }



                }
                else if (command == "Exercise")
                {
                    int flag = 0;
                    string lessonExercise = tokens[1];
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == lessonExercise)
                        {
                            string insertExercise = lessonExercise + "-Exercise";
                            lessons.Insert(i + 1, insertExercise);
                           
                        }
                        else
                        {
                            flag = 1;
                        }
                    }


                    if (flag == 1)
                    {
                        string insertExercise = lessonExercise + "-Exercise";
                        lessons.Add(lessonExercise);
                        lessons.Add(insertExercise);
                    }
                       
                }
              
                    
                   
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
                
                    
        }

        private static void Swap(List<string> lessons, string firstLesson, string secondLesson)
        {
            int firstindex = 0;
            int secondindex = 0;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == firstLesson)
                {
                    firstindex = i;
                }
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == secondLesson)
                {
                    secondindex = i;
                }
            }
            string a = string.Empty;
            a = lessons[firstindex];
            lessons[firstindex] = lessons[secondindex];
            lessons[secondindex] = a;
        }
    }
}

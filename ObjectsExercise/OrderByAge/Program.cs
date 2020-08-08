using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string line = Console.ReadLine();
                if(line=="End")
                {
                    break;
                }
                string[] input = line.Split(' ');
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);
                Person person = new Person(name, id, age);
                people.Add(person);
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }

        }
    }
    class Person
    {
        public Person(string name,string id,int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name{ get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
               
                if (command == "register")
                {
                    string username = input[1];
                    string plateNumber = input[2];
                    if (users.ContainsKey(username) == false)
                    {
                        users[username] = plateNumber;
                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string username = input[1];
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        users.Remove(username);

                    }
                }

            }

            foreach(var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
     
        }
    }
}

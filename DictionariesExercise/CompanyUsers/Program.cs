using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            var users = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                char[] symbols = { '-', '>',' ' };
                string[] tokens = input.Split(symbols,StringSplitOptions.RemoveEmptyEntries);
                string company = tokens[0];
                string user = tokens[1];

                
                if(!users.ContainsKey(company))
                {
                    users[company] = new List<string>();
                }
                int flag = 0;
                foreach (var kvp in users)
                {
                    List<string> list = kvp.Value;
                    string name = kvp.Key;

                    if (list.Contains(user)&&name==company)
                    {
                        flag = 1;
                    }
                    else if(name==company)
                    {
                        flag = 0;
                    }
                   
                }
                if (flag == 0) 
                {
                    users[company].Add(user);
                }
                    
              
       
            }
            foreach (var kvp in users)
            {
                string companyName = kvp.Key;
                List<string> companyUser = kvp.Value;
                Console.WriteLine(companyName);
                foreach(var item in companyUser)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
                
                    
        }
    }
}

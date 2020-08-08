using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creatorName = input[0];
                string name = input[1];
                bool isTeamExist = teams.Any(x => x.Name == name);
                bool isCreatorNameExists = teams.Any(x => x.CreatorName == creatorName);

                if (isTeamExist == false && isCreatorNameExists == false)
                {
                    Team team = new Team(name, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creatorName}!");
                }
                else if(isTeamExist)
                {
                    Console.WriteLine($"Team {name} was already created!");
                }
                else if(isCreatorNameExists)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }
            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end of assignment")
                {
                    break;
                }
                string[] symbols = { "->" };
                string[] input = line.Split(symbols,StringSplitOptions.RemoveEmptyEntries);
                string user = input[0];
                string teamname = input[1];
                bool isTeamExists = teams.Any(x => x.Name == teamname);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user)||x.CreatorName==user);
                if (!isTeamExists)
                {
                    Console.WriteLine($"Team {teamname} does not exist!");
                    continue;
                }
                if(isAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamname}!");
                    continue;
                }
                if (isTeamExists && isAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamname);
                    teams[indexOfTeam].Members.Add(user);
                   
                }
            }
            List<Team> teamsWithMemebrs = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x=>x.Members.Count)
                .ThenBy(x=>x.Name)
                .ToList();
            List<Team> teamsWithoutMemebrs = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var team in teamsWithMemebrs)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.CreatorName}");
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x=>$"-- {x}")));
            }
            Console.WriteLine("Teams to disband:");
            foreach(var team in teamsWithoutMemebrs)
            {
                Console.WriteLine(team.Name);
            }

        }
    }

    class Team
    {
        public Team(string name,string creatorName)
        {
            Name = name;
            CreatorName = creatorName;
            Members = new List<string>();
        }
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}

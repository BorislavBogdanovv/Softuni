using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                string[] registerTeam = Console.ReadLine()
                    .Split("-");

                string user = registerTeam[0];

                string teamName = registerTeam[1];

                if (!teams.Any(s => s.TeamName == teamName))
                {
                    if (!teams.Any(s => s.Creator == user))
                    {
                        Teams newTeam = new Teams(user, teamName);

                        teams.Add(newTeam);

                        Console.WriteLine($"Team {teamName} has been created by {user}!");
                    }
                    else
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] input = command
                    .Split("->");

                string user = input[0];

                string teamName = input[1];

                if (!teams.Any(s => s.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                else if (teams.Any(s => s.Creator == user) || teams.Any(m => m.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }
                else
                {
                    Teams currentTeamMember = teams.First(s => s.TeamName == teamName);
                    currentTeamMember.Members.Add(user);
                }
            }

            List<Teams> haveMember = teams.Where(s => s.Members.Count > 0)
                .OrderByDescending(k => k.Members.Count)
                .ThenBy(f => f.TeamName)
                .ToList();

            List<Teams> zeroTeams = teams.Where(s => s.Members.Count == 0)
                .OrderBy(n => n.TeamName)
                .ToList();

            for (int j = 0; j < haveMember.Count; j++)
            {
                Teams currentTeam = haveMember[j];

                currentTeam.Members = currentTeam.Members
                    .OrderBy(n => n)
                    .ToList();

                Console.WriteLine($"{currentTeam.TeamName}");
                Console.WriteLine($"- {currentTeam.Creator}");

                for (int i = 0; i < currentTeam.Members.Count; i++)
                {
                    Console.WriteLine($"-- {currentTeam.Members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");

            for (int i = 0; i < zeroTeams.Count; i++)
            {
                Teams zeroTeam1 = zeroTeams[i];
                Console.WriteLine($"{zeroTeam1.TeamName}");
            }
        }
    }

    public class Teams
    {
        public Teams(string creator, string teamName)
        {
            this.Creator = creator;

            this.TeamName = teamName;
        }

        public List<string> Members = new List<string>();

        public string Creator { get; set; }

        public string TeamName { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArneNgoNivå1
{
    public abstract class Team
    {
        string Name { get; set; }
        int Players {  get; set; }
        public static List<Team> teams = new(); 

        public Team(string name, int players)
        {
            Name = name;
            Players = players;
            teams.Add(this);
        }
        public override string ToString()
        {
            return $"#{Players},{Name}";
        }
        public static void PrintTeam() 
        {
            Console.WriteLine("Team OoogaBooga!\n-----------------");
            List<Team> CopyTeams = teams;
            foreach (var team in CopyTeams) { Console.WriteLine(team); }
        
        }
    }
}

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
        public static bool Equals(Team player1, Team player2) 
        {
            if (player1.ToString() == player2.ToString())
            { return true; }
            else { return false; }
        }
        public override bool Equals(object? obj) 
        {
            if(obj is Team other) 
            { return Team.Equals(this, other); }
            else { return false; }
        }
        public Team NumberUpgrade() 
        {
            Players += 1;
            return this;
        }
        public static Team operator ++(Team player1)
        {
            return player1.NumberUpgrade();
        }
        public Team NumberDegrade()
        {
            Players -= 1;
            return this;
        }
        public static Team operator --(Team player1)
        {
            return player1.NumberDegrade();
        }
        public static bool operator ==(Team p1,Team p2) 
        {
            return Team.Equals(p1,p2);
        }
        public static bool operator !=(Team p1, Team p2) 
        {
            if (Team.Equals(p1, p2)) { return false; }
            else { return true; }
        }


    }
}

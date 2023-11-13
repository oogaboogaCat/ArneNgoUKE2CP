using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArneNgoNivå1
{
    public abstract class Team
    { 
        public abstract string Name { get; set; }
        List<int> teams = new(); 

        public Team(string name, int Player)
        {
            Name = name;
            teams.Add(Player);
            
        }
    }
}

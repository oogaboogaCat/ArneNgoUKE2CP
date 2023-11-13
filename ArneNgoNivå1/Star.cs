using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArneNgoNivå1
{
    public class Star : Team
    {
        string Description { get; set; }
        public Star(string name, int number, string descprption = "") : base(name,number) 
        {
            Description = descprption;
        }

    }
}

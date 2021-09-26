using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    //Plain old C# Object
    public class Developers
    {
        //id
        //name
        //bool onlime learning tool: Pluralsight
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Pluralsight { get; set; }
        public Developers() {}

        public Developers(int id, string name, bool pluralsight)
        {
            Id = id;
            Name = name;
            Pluralsight = pluralsight;
        }
    }
    
}

using DeveloperRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepo
{
    public class DevTeam
    {
        //Developers person = new Developers();
        public List<Developers> _developers = new List<Developers>();
        public int Id { get; set; }
        public List<Developers> Dev { get; set; }

        public string TeamName { get; set; }

        public DevTeam() { }
        public DevTeam(int id, List<Developers> dev,string teamName) 
        {
            Id = id;
            Dev = dev;
            TeamName = teamName;
        }
        
    }
}

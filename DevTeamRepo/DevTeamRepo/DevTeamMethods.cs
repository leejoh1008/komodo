using DeveloperRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamRepo
{
    public class DevTeamMethods
    {
        List<DevTeam> _teams = new List<DevTeam>();

        //create
        public void AddTeam( DevTeam team)
        {
            _teams.Add(team);
        }

        //read
        public List<DevTeam> GetTeams()
        {
            return _teams;
        }

        //update
        public bool UpdateTeam(int id, DevTeam newTeam)
        {
            //find the developer by id
            DevTeam oldteam = GetDevTeamById(id);

            //update the developer by id
            if (oldteam != null)
            {
                oldteam.TeamName = newTeam.TeamName;
                oldteam.Id = newTeam.Id;

                return true;
            }
            else
            {
                return false;
            }  
        }
        
        public void AddTeamMember(Developers dev, int teamId)
        {
            DevTeam theTeam = GetDevTeamById(teamId);
            theTeam._developers.Add(dev);
        }
        public void RemoveTeamMember(Developers dev, int teamId)
        {
            DevTeam theTeam = GetDevTeamById(teamId);
            theTeam._developers.Remove(dev);
        }
        //helper method
        private DevTeam GetDevTeamById(int id)
            {
                foreach (DevTeam devTeamRepo in _teams)
                {
                    if (devTeamRepo.Id == id)
                    {
                        return devTeamRepo;
                    }
                }
                return null;
            }
    }
}

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
        List<DevTeamRepo> _teams = new List<DevTeamRepo>();

        //create
        public void AddTeam( DevTeamRepo team)
        {
            _teams.Add(team);
        }

        //read
        public List<DevTeamRepo> GetTeams()
        {
            return _teams;
        }

        //update
        public bool UpdateTeam(int id, DevTeamRepo newTeam)
        {
            //find the developer by id
            DevTeamRepo oldteam = GetDevTeamById(id);

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
            DevTeamRepo theTeam = GetDevTeamById(teamId);
            theTeam._developers.Add(dev);
        }
        public void RemoveTeamMember(Developers dev, int teamId)
        {
            DevTeamRepo theTeam = GetDevTeamById(teamId);
            theTeam._developers.Remove(dev);
        }
        //helper method
        private DevTeamRepo GetDevTeamById(int id)
            {
                foreach (DevTeamRepo devTeamRepo in _teams)
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

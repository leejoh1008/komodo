using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperRepo
{
    public class DeveloperClass
    {
        private List<Developers> _developers = new List<Developers>();

        //create
        public void AddDeveloper(Developers developer)
        {
            _developers.Add(developer);
        }
        //read
        public List<Developers> GetDeveloperList()
        {
            return _developers;
        }

        //update
        public bool UpdateDeveloper(int id, Developers newDeveloper)
        {
            //find the developer by id
            Developers oldDeveloper = GetDeveloperById(id);

            //update the developer by id
            if(oldDeveloper !=null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.Id = newDeveloper.Id;
                oldDeveloper.Pluralsight = newDeveloper.Pluralsight;

                return true;
            }
            else
            {
                return false;
            }

        }

        //delete
        public bool RemoveDeveloperFromList(int id)
        {
            Developers developers = GetDeveloperById(id);

            if(developers == null)
            {
                return false;
            }
            int initialCount = _developers.Count;
            _developers.Remove(developers);

            if(initialCount > _developers.Count)
            {
                return true;
            }
            else { return false; }
        }

        //helper method
        private Developers GetDeveloperById(int id)
        {
            foreach(Developers developers in _developers)
            {
                if(developers.Id == id)
                {
                    return developers;
                }
            }
            return null;
        }
    }
}

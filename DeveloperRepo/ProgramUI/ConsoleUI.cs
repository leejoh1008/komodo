using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperRepo;
using DevTeamRepo;


namespace ProgramUI
{
    class ConsoleUI
    {
        private DeveloperClass _developerClass = new DeveloperClass();
        private Developers _developers = new Developers();
        private DevTeamMethods _devTeamMethods = new DevTeamMethods();

        public void Run()
        {
            //     Beginning();
            // }
            // private void Beginning()
            // {
            //    Console.WriteLine("TYPE ENTER TO CONTINUE.");
            //   string response = Console.ReadLine();

            //   switch (response)
            //  {
            //     case "enter":
            //         Console.WriteLine("WELCOME\n What would you like to modify?:\n" +
            //               "1:Developers\n" +
            //               "2:Teams");
            //          Menu();
            //           break;
            //      default:
            //         Console.Clear();
            //         Console.WriteLine("Try again.");
            //         Beginning();
            //         Console.ReadLine();
            //          break;
            //  }
            ListofDev();
            Menu();
        }
        private void Menu()
        {
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine("WELCOME\n What would you like to modify?:\n" +
                         "1:Developers\n" +
                         "2:Teams");
                string userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        Console.Clear();
                        DevActions();
                        break;
                    case "2":
                        Console.Clear();
                        TeamActions();
                        break;
                    default:

                        Console.WriteLine("Please try again.");
                        Console.ReadLine();

                        break;
                }

            }

        }
        
        private void DevActions()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n" +
                "1.Add a Developer.\n" +
                "2.A List of Developers. \n" +
                "3.Update a Developer.\n" +
                "4.Delete a Developer.\n" +
                "Spacebar: Go Back.");

            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    AddDev();
                    break;
                case "2":
                    ReadDev();
                    break;
                case "3":
                    UpdateDev();
                    break;
                case "4":
                    DeleteDev();
                    break;
                case " ":
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        //beginning of DevActions
        private void AddDev()               //adding dev     C    
        {
            Developers newDev = new Developers();
            Console.WriteLine("Enter their ID");
            newDev.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the full name");
            newDev.Name = Console.ReadLine();
            Console.WriteLine("Does this person have PluralSight? y/n");
            string pluralSight = Console.ReadLine().ToLower();
            if (pluralSight == "y")
            {
                newDev.Pluralsight = true;
            }
            else
            {
                newDev.Pluralsight = false;
            }
            _developerClass.AddDeveloper(newDev);
            DevActions();
            }

        //                                                          //
             private void ReadDev()               //reading dev  R    
             {
            List<Developers> listOfDevs = _developerClass.GetDeveloperList();
            
            foreach (Developers dev in listOfDevs)
            {
                Console.WriteLine($"ID: {dev.Id}\n" +
                    $"Name:{dev.Name}\n" +
                    $"PluralSight:{dev.Pluralsight}");
            }
                
                }
        private void UpdateDev()    //updating developer by id and name  U  
        {
            Console.Clear();
            ReadDev();
            Console.WriteLine("Who would you like to update? Please specify by their id");
            int input = int.Parse(Console.ReadLine());
            Developers newDev = new Developers();
            Console.WriteLine("Enter their ID again");
            newDev.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the full name");
            newDev.Name = Console.ReadLine();
            Console.WriteLine("Does this person have PluralSight? y/n");
            string pluralSight = Console.ReadLine().ToLower();
            if (pluralSight == "y")
            {
                newDev.Pluralsight = true;
            }
            else
            {
                newDev.Pluralsight = false;
            }
           bool wasUpdated= _developerClass.UpdateDeveloper(input,newDev);   //if dev was updated or not
            if (wasUpdated)
            {
                Console.WriteLine("The person was successfully updated.");
            }
            else
            {
                Console.WriteLine("Something went wrong! Please try again");
            }
        }

                             private void ListofDev()           //helper method to test list of devlopers            
                             {
                                    Developers john = new Developers(12, "John Fenny", true);
                                    Developers amanda = new Developers(3, "Amanda Bliss", false);
                                    Developers rob = new Developers(40, "Robby Smith", true);

                                    _developerClass.AddDeveloper(john);
                                    _developerClass.AddDeveloper(amanda);
                                    _developerClass.AddDeveloper(rob);
                                }
            private void DeleteDev()                    //deletion of developer by id    D
        {
            ReadDev();
            Console.WriteLine("Please enter the ID number corresponding to the person that you would like to delete:");
            int input = int.Parse(Console.ReadLine());
            bool wasDelete = _developerClass.RemoveDeveloperFromList(input);
            if(wasDelete)
            {
                Console.WriteLine("The person was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Something went wrong! Please try again");
            }


        }

            private void TeamActions()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n" +
                "1.Add a Developer.\n" +
                "2.A List of Developers. \n" +
                "3.Update a Developer.\n" +
                "4.Delete a Developer.\n");
        }
        //beginning of TeamActions


    }
}

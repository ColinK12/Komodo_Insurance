
using KomodoLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoProgram3
{
    public class KomodoProgram3UI
    {

        //Class  Repositor/Lirbary   List       
        private KomodoDevTeamRepo3 _devTeamRepo = new KomodoDevTeamRepo3();

        private KomodoDevRepo3 _devRepo = new KomodoDevRepo3();

        //Method that runs and starts the app.
        public void Run()
        {
            Menu();
        }
        //Menue Methods (Most will be private)
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                //Display Otions
                Console.WriteLine("Select Menu Option:\n" +
                    "1. CreateNewDeveloper:\n" +
                    "2. Remove Developer from List:" +
                    "3. Create New Team:\n" +
                    "4. Add Team Member to Team:" +
                    //  "5. Update list\n" + future Change?
                    "5. Exit Program");

                //User Input
                string input = Console.ReadLine();
                {

                }
                //Evaluation of Input- then act (Output)
                switch (input)
                {
                    case "1":
                        //Create New Developer
                        CreateNewDeveloper();
                        break;
                    case "2":
                        //Remove Devoloper From list
                        DeleteExistingDeveloper();
                        break;
                    case "3":
                        //Creates New Team
                        CreateNewTeam();
                        break;
                    case "4":
                        //Add Team Member
                        AddTeamMember();
                        break;
                    case "5":
                        //ExitProgram();
                        Console.WriteLine("Thanks, and Goodbye!");
                        keepRunning = false;
                        //Exit Program
                        break;
                    default:
                        Console.WriteLine("Please ENTER as Valid NUMBER Choice.");
                        break;
                }
                {
                    Console.WriteLine("Please press any key to continue.:");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        //Method Create Developer
        private void CreateNewDeveloper()
        {
            KomodoDevPoco3 newDev = new KomodoDevPoco3();
            //Note:---------var newDev = new KomodoDevPoco3();------ Equal Statements^

            //Dev Name - Create
            Console.WriteLine("Enter First, Last name of Developer to Create:");
            newDev.DevName = Console.ReadLine();

            //Dev ID Num - Create
           Console.WriteLine("Enter Developer ID Number to Create:");
           newDev.DevIdNum = int.Parse(Console.ReadLine());

            _devRepo.AddDevNameToList(newDev);
        }
        //Method Removes Devoloper from list - Delete
        private void DeleteExistingDeveloper()
        {
            //Dev Name
            //Console.WriteLine("Enter First, Last name of Developer to remove:");// "Enter Name or ID# of Developer that you want to Remove:"

            //Dev ID Num
            Console.WriteLine("Enter ID# of Developer to Remove:");
            int devIdNum = int.Parse(Console.ReadLine());
            bool wasDeleted = _devRepo.RemoveDevFromList(devIdNum);
            if (wasDeleted) 
            {
                Console.WriteLine("Developer was Removed:");
            }
            else 
            {
                Console.WriteLine("Developer Has Not Been Removed from List:");
            }


        }           

        //Method Creates New Team - Create
        private void CreateNewTeam()
        {
            var newTeam = new KomodoDevTeamPoco3();
            //TeamName Create
            Console.WriteLine("Enter Name of Team to Create:");
            newTeam.DevTeamName = Console.ReadLine();

            //Team ID Num Create
            Console.WriteLine("Enter Team Id# to Create:");
            newTeam.TeamIdNum = int.Parse(Console.ReadLine());

            // Dev ID# to Add to Team
            Console.WriteLine("Enter Developer ID# to Add to Team");
            int devIdNum = int.Parse(Console.ReadLine());
            newTeam.TeamMembers.Add(_devRepo.GetDevByDevIdNum(devIdNum));

        }            

        //Add Team Member - Adding to Team
        private void AddTeamMember()
        {
            //Team ID Num - Should this get a  list? Should I set this up differently from the others newTeamName isntead of newTeam for ex.
            KomodoDevTeamPoco3 team = new KomodoDevTeamPoco3();
            Console.WriteLine("Enter Team ID Number to Add:");
            int input = int.Parse(Console.ReadLine());
            _devTeamRepo.GetDevbyTeamIdNum(input);

            Console.WriteLine("Enter Dev ID# to Add:");
            int devID = int.Parse(Console.ReadLine());

            team.TeamMembers.Add(_devRepo.GetDevByDevIdNum(devID));
        }
        //See Method
        private void SeedContentList()
        {

        }
    }

}

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json.Linq;


namespace MamaLis
{
    class EmployeesSystem
    {
        /*
            This class containing and managing the functions of the system
        */


        public enum JobTitles
        {
            cleaner = 1,
            cleanerToxics = 2,
            headCleaner = 3,
            cleanerShiftManager = 4,
            cooker = 5,
            chef = 6,
            soChef = 7,
            foodDistributer = 8,
            headOfAdministration = 9,
            medic = 10,
            paramedic = 11,
            nurse = 12,
            headNurse = 13,
            midwife = 14,
            buttockMidwife = 15,
            staserDoctor = 16,
            buttocStaserDoctor = 17,
            doctor = 18,
            seniorDoctor = 19,
            expertDoctor = 20,
            deputyDirectorOfDepartment = 21,
            directorOfDepartment = 22
        };



        public Dictionary<string, Employee> employeeStock = new Dictionary<string, Employee>();//contains all the employee in the system.

        //this function gets id of employee and prints his/her details
        public void ShowEmployee()
        {
            string id;
            Console.Write("Please enter the id of the employee: ");
            id = Console.ReadLine();
            if (this.employeeStock.ContainsKey(id))
            {
                Employee e = this.employeeStock[id];
                e.PrintEmployee();
            }
            else
            {
                Console.WriteLine("There is no employee with this ID in MamaLis.");
            }
        }

        // TUI to add hours to an employee.
        public void AddHours()
        {
            string id;
            Console.Write("Please enter the id of the employee: ");
            id = Console.ReadLine();
            if (this.employeeStock.ContainsKey(id))
            {
                Employee e = this.employeeStock[id];
                e.SetHoursOfWork();
            }
            else
            {
                Console.WriteLine("There is no employee with this ID in MamaLis.");
            }
        }

        //This function is a TUI of adding new employee to MamaLis
        public void GetEmoloyeeDetails()
        {
            string id, name;
            bool ifIdExist = true;
            int jobTitleCode;
            Console.WriteLine("Welcome to Mamalis !");
            do
            {
                Console.Write("Enter your ID: ");
                id = Console.ReadLine();
                if (employeeStock.ContainsKey(id))
                {
                    Console.WriteLine("this id is alredy exist, please enter another id for employee");
                }
                else
                {
                    ifIdExist = false;
                }

            } while (ifIdExist == true);
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            jobTitleCode = GetJobTitle();
            CreateNewEmployee(id, name, jobTitleCode, 0); //new employee always continued with 0 hours of work.
        }


        //this function Gets Employee parameters and create new employee
        public void CreateNewEmployee(string id, string name, int jobTitleCode, double hoursOfWork)
        {
            
            string jobTitle = Enum.GetName(typeof(JobTitles), jobTitleCode);
            bool ifExpert = GetIfExpert(jobTitleCode);
            bool ifMakeDesicions = GetIfMakeDecisions(jobTitleCode);
            double extraRisk = GetExtraRisk(jobTitleCode);
            //Managers
            if (jobTitleCode == (int)JobTitles.headOfAdministration || jobTitleCode == (int)JobTitles.deputyDirectorOfDepartment || jobTitleCode == (int)JobTitles.directorOfDepartment)
            {
                Employee m = new Manager(name, id, jobTitle, ifExpert, ifMakeDesicions, extraRisk, hoursOfWork); //Polymorphism
                this.employeeStock.Add(id, m);
            }

            else if (jobTitleCode == (int)JobTitles.headCleaner || jobTitleCode == (int)JobTitles.cooker || jobTitleCode == (int)JobTitles.soChef || jobTitleCode == (int)JobTitles.chef || jobTitleCode == (int)JobTitles.buttockMidwife || jobTitleCode == (int)JobTitles.buttocStaserDoctor || jobTitleCode == (int)JobTitles.seniorDoctor)
            {
                Employee s = new SeniorEmployee(name, id, jobTitle, ifExpert, ifMakeDesicions, extraRisk, hoursOfWork); //Polymorphism
                this.employeeStock.Add(id, s);
            }
            else
            {
                Employee j = new JuniorEmployee(name, id, jobTitle, ifExpert, ifMakeDesicions, extraRisk, hoursOfWork); //Polymorphism
                this.employeeStock.Add(id, j);
            }
        }



        //in this function the user choose the gob title
        public int GetJobTitle()
        {
            int choise = 0;
            while (choise == 0)
            {
                Console.WriteLine("Please choose your number of job title");
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.cleaner);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.cleanerToxics);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.headCleaner);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.cleanerShiftManager);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.cooker);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.chef);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.soChef);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.foodDistributer);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.headOfAdministration);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.medic);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.paramedic);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.nurse);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.headNurse);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.midwife);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.buttockMidwife);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.staserDoctor);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.buttocStaserDoctor);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.doctor);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.seniorDoctor);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.expertDoctor);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.deputyDirectorOfDepartment);
                Console.WriteLine("{0:D} {0}", EmployeesSystem.JobTitles.directorOfDepartment);

                choise = int.Parse(Console.ReadLine());
                if (choise >= 1 && choise <= 22) //we have 22 options
                {
                    return choise;
                }

                Console.WriteLine("please enter a valid job title number");
                choise = 0;
            }
            return 0;//never happendb  

        }

        //The Main Menu TUI For The Users.
        public void MainMenu()
        {
            int choise = 0;
            do
            {
                Console.WriteLine("Welcome to MamaLis !");
                Console.WriteLine("please choose the action you want to perform :");
                Console.WriteLine("to add new employee - enter 1");
                Console.WriteLine("to enter work hours to an employee - enter 2");
                Console.WriteLine("to print an employee's salary - enter 3");
                Console.WriteLine("to exit - enter 9");
                Console.Write("Your choise: ");
                choise = int.Parse(Console.ReadLine());

                if (choise != 1 && choise != 2 && choise != 3 && choise != 9)
                {
                    Console.WriteLine("please enter a valid number from the menu :)");
                }
                else
                {

                    if (choise == 1)
                    {
                        GetEmoloyeeDetails();
                    }

                    if (choise == 2)
                    {
                        AddHours();
                    }

                    if (choise == 3)
                    {
                        ShowEmployee();
                    }
                    if (choise == 9)
                    {
                        Console.WriteLine("Goodbye and have a nice day");
                    }
                }
                Console.WriteLine("\n \n \n");
            } while (choise != 9);

        }

        //this function gets jobTitleCode and returns if this job is an expert.
        public bool GetIfExpert(int jobTitleCode)
        {
            bool ifExpert = false;
            if (jobTitleCode == (int)(JobTitles.cleanerToxics) || jobTitleCode == (int)JobTitles.buttockMidwife || jobTitleCode == (int)JobTitles.expertDoctor || jobTitleCode == (int)JobTitles.buttocStaserDoctor || jobTitleCode == (int)JobTitles.soChef || jobTitleCode == (int)(JobTitles.chef))
            {
                ifExpert = true;
            }

            return ifExpert;
        }

        //this function gets jobTitleCode and returns if this job is making decisions.
        public bool GetIfMakeDecisions(int jobTitleCode)
        {
            bool ifMakeDesicion = false;
            if (jobTitleCode == (int)JobTitles.cleanerToxics || jobTitleCode == (int)JobTitles.cleanerShiftManager || jobTitleCode == (int)JobTitles.expertDoctor || jobTitleCode == (int)JobTitles.chef || jobTitleCode == (int)JobTitles.headOfAdministration || jobTitleCode == (int)JobTitles.headNurse || jobTitleCode == (int)JobTitles.seniorDoctor || jobTitleCode == (int)JobTitles.deputyDirectorOfDepartment || jobTitleCode == (int)JobTitles.directorOfDepartment)
            {
                ifMakeDesicion = true;
            }

            return ifMakeDesicion;
        }

        //this function gets jobTitleCode and returns the extra risk adding to the salary.
        public double GetExtraRisk(int jobTitleCode)
        {
            double extraRisk = 0;//by default there is no extra risk.
            if (jobTitleCode == (int)JobTitles.cleanerToxics)
            {
                extraRisk = 0.2;
            }
            if (jobTitleCode == (int)JobTitles.directorOfDepartment)
            {
                extraRisk = 1;
            }

            return extraRisk;
        }


        //This function initialized Employees To the system
        public void initializeEmployees()
        {
            CreateNewEmployee("00000001", "Nikita",1, 26);
            CreateNewEmployee("00000002", "Hadba Ra", 2,19);
            CreateNewEmployee("00000003", "Mav Rick", 3, 4);
            CreateNewEmployee("00000004", "Sa Bon", 4, 26);
            CreateNewEmployee("00000005", "Ma Rit", 5, 26);
            CreateNewEmployee("00000006", "Mishlen Star", 6, 26);
            CreateNewEmployee("00000007", "Mishlen Moon", 7, 6);
            CreateNewEmployee("00000008", "Gastro Nom", 8, 26);
            CreateNewEmployee("00000009", "Shali Shoot", 9, 26);
            CreateNewEmployee("00000010", "Balada La", 10, 12);
            CreateNewEmployee("00000012", "Kovea Mavet", 11, 26);
            CreateNewEmployee("00000013", "Sis Ter", 12, 26);
            CreateNewEmployee("00000014", "Expensive Sister", 13, 32);
            CreateNewEmployee("00000015", "Tilche Tzi", 14, 45);
            CreateNewEmployee("00000016", "Tichetzi Hazak", 15, 54);
            CreateNewEmployee("00000017", "Nechfaf", 16, 43);
            CreateNewEmployee("00000018", "Nechfaf Acuz", 17, 42);
            CreateNewEmployee("00000019", "Gime Lim", 18, 43);
            CreateNewEmployee("00000020", "Ram Shtaim", 19, 14);
            CreateNewEmployee("00000021", "Ram Daled", 20, 56);
            CreateNewEmployee("00000022", "Saran 750", 21, 60);
            CreateNewEmployee("00000023", "Rahan 750", 22, 50);
            CreateNewEmployee("00000024", "Boss Chabshan", 4, 10);


        }
            
    }
}


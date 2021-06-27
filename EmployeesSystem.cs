using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class EmployeesSystem
    {
        /*
         * This class containing and managing the functions of the system
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
            directorOfDepartment=22
        };

        

        public Dictionary<string, Employee> employeeStock = new Dictionary<string, Employee>();

        //this function gets id of employee and prints his/her details
        public void ShowEmployee(string id)
        {
            if(this.employeeStock.ContainsKey(id))
            {
                Employee e = this.employeeStock[id];
                e.PrintEmployee();
            }
            else
            {
                Console.WriteLine("There is no employee with this ID in MAmaLis.");
            }
        }

        //This function is a TUI of adding new employee to MamaLis
        public void AddEmployee()
        {
            string id, name;
            bool ifExpert = false; //initilaized with false
            bool ifMakeDesicions = false; //initilaized with false
            int jobTitleCode;
            string jobTitle;
            double extraRisk = 0; //default thereis no extra risk
            Console.WriteLine("Welcome to Mamalis !");
            Console.Write("Enter your ID: ");
            id = Console.ReadLine();
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            jobTitleCode = GetJobTitle();
            jobTitle = Enum.GetName(typeof(JobTitles), jobTitleCode);
            if(jobTitleCode == (int)(JobTitles.cleanerToxics) || jobTitleCode == (int) JobTitles.buttockMidwife || jobTitleCode==(int)JobTitles.expertDoctor || jobTitleCode == (int) JobTitles.buttocStaserDoctor || jobTitleCode==(int)JobTitles.soChef || jobTitleCode == (int)(JobTitles.chef))
            {
                ifExpert = true;
            }
            if(jobTitleCode==(int)JobTitles.cleanerToxics || jobTitleCode==(int)JobTitles.cleanerShiftManager || jobTitleCode==(int)JobTitles.expertDoctor || jobTitleCode==(int)JobTitles.chef || jobTitleCode==(int)JobTitles.headOfAdministration || jobTitleCode==(int)JobTitles.headNurse || jobTitleCode==(int)JobTitles.seniorDoctor || jobTitleCode==(int)JobTitles.deputyDirectorOfDepartment || jobTitleCode==(int)JobTitles.directorOfDepartment)
            {
                ifMakeDesicions = true;    
            } 
            if(jobTitleCode==(int)JobTitles.cleanerToxics)
            {
                extraRisk = 0.2;
            }
            if (jobTitleCode == (int)JobTitles.directorOfDepartment)
            {
                extraRisk = 1;
            }
            //Console.WriteLine("extra risk : {0}, expert: {1}, make decisions: {2}", extraRisk.ToString(), ifExpert.ToString(), ifMakeDesicions.ToString()); // for debug

          //  Employee a = new Employee(name, id, jobTitle, ifExpert, ifMakeDesicions, extraRisk);

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

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class EmployeesSystem
    {
        /*
         * This class containing and managing the functions 
         */

        public Dictionary<string, Employee> employeeStock = new Dictionary<string, Employee>();

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

    }
}

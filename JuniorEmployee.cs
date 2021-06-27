using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class JuniorEmployee : Employee
    {


        public JuniorEmployee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, double extraRisk) : base(employeeName, employeeID, jobTitle, ifExpert, ifMakeDecisions, extraRisk)
        {
            //
        }
        public override float GetSalary() 
        {
            return (1999);
        } 
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class JuniorEmployee : Employee
    {


        public JuniorEmployee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, double extraRisk, double horsOfWork) : base(employeeName, employeeID, jobTitle, ifExpert, ifMakeDecisions, extraRisk, horsOfWork)
        {
            //
        }
        public override double GetSalary() 
        {
            double baseSalary;
            baseSalary = base.GetSalary();
            return (baseSalary + (this._employeeDegree.GetExtraRisk()*baseSalary ));
        } 
    }
}
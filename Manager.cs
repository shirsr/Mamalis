using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class Manager : Employee
    {


        public Manager(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, double extraRisk) : base(employeeName, employeeID, jobTitle, ifExpert, ifMakeDecisions, extraRisk)
        {
            //
        }
        public override double GetSalary() 
        {
            double baseSalary =  Consts.managerSalary;
            return (baseSalary + (this._employeeDegree.GetExtraRisk()));

        }
    }
}

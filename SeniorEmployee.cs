using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class SeniorEmployee : Employee
    {


    public SeniorEmployee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, double extraRisk, double horsOfWork) : base(employeeName, employeeID, jobTitle, ifExpert, ifMakeDecisions, extraRisk, horsOfWork)
        {
            //
        }
     public override double GetSalary() 
        {
            double baseSalary;
            double bonus = 0.05; //Senior bonus

            if(this._employeeDegree.GetIfExpert())
            {
                bonus += 0.3; //expert bonus
            }
            if(this._employeeDegree.GetIfMakeDecisions())
            {
                bonus += 0.5;
            }
            baseSalary = Consts.hourSalaryAvg * this._hoursOfWork;
            if ((this._hoursOfWork > 50) &&(this._employeeDegree.GetIfMakeDecisions()) )
            {
                baseSalary = Consts.managerSalary;
            }

            baseSalary += (baseSalary * bonus);
            return (baseSalary + (this._employeeDegree.GetExtraRisk() * baseSalary));

        }

    }
}

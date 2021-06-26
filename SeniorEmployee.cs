using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class SeniorEmployee : Employee
    {


    public SeniorEmployee(string employeeName, string employeeID, string jobTitle, bool ifExpert, bool ifMakeDecisions, float extraRisk) : base(employeeName, employeeID, jobTitle, ifExpert, ifMakeDecisions, extraRisk)
        {
            //
        }
     public override float GetSalary() { return 179999; }
    }
}

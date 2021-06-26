using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class JuniorEmployee : Employee
    {
        public override float GetSalary() { return this._salary; } 
    }
}
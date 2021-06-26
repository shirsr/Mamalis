using System;
using System.Collections.Generic;
using System.Text;

namespace MamaLis
{
    class Manager : Employee
    {
        public override float GetSalary() { return this._salary; }
    }
}

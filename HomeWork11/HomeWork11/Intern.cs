using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Intern : Employee
    {
        public Intern(string firstName, string lastName, Department department) 
            : base(firstName, lastName, department)
        {
        }

        public override string GetPosition()
        {
            return "Интерн";
        }

        public override decimal GetSalary()
        {
            return 400;
        }
    }
}

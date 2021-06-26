using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Worker : Employee
    {
        public Worker(string firstName, string lastName, Department department) 
            : base(firstName, lastName, department)
        {
        }

        public override decimal GetSalary()
        {
            return 100 * new Random().Next(2,9);
        }

        public override string GetPosition()
        {
            return "Рабочий";
        }
    }
}

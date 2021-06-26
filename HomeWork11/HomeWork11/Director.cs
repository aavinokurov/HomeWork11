using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Director : Employee
    {
        public Director(string firstName, string lastName, Department department) 
            : base(firstName, lastName, department)
        {
        }

        public override string GetPosition()
        {
            return "Руководитель";
        }

        public override decimal GetSalary()
        {
            decimal salary = GetSalaryEmployeesInDepartment(Department);

            salary *= 0.15m;

            return salary <= 1300 ? 1300 : salary;
        }

        private decimal GetSalaryEmployeesInDepartment(Department department)
        {
            decimal salary = 0;
            var employees = department.Employees;            

            foreach (var employee in employees)
            {
                if (employee != this)
                {
                    salary += employee.GetSalary();
                }
            }

            var subDepartments = department.SubDepartments;

            if (subDepartments != null && subDepartments.Count > 0)
            {
                foreach (var subDepartment in subDepartments)
                {
                    salary += GetSalaryEmployeesInDepartment(subDepartment);
                }
            }

            return salary;
        }
    }
}

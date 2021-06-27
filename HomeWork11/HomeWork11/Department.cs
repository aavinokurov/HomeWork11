using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Department
    {
        #region Свойства

        public string Name { get; private set; }

        public ObservableCollection<Department> SubDepartments { get; private set; }

        public ObservableCollection<Employee> Employees { get; private set; }

        #endregion

        #region Конструктор

        public Department(string name)
        {
            this.Name = name;
            this.SubDepartments = new ObservableCollection<Department>();
            this.Employees = new ObservableCollection<Employee>();
        }

        #endregion

        #region Методы 

        public void AddEmployee(EmployeeEnum employeeType, string firstName, string lastName)
        {
            if (Employees.Any(e => e is Director) && employeeType == EmployeeEnum.Director)
            {
                return;
            }
            Employee employee = null;
            switch (employeeType)
            {
                case EmployeeEnum.Director:
                    employee = new Director(firstName, lastName, this);
                    break;
                case EmployeeEnum.Worker:
                    employee = new Worker(firstName, lastName, this);
                    break;
                case EmployeeEnum.Intern:
                    employee = new Intern(firstName, lastName, this);
                    break;
                default:
                    break;
            }
            if (employee == null)
            {
                return;
            }
            this.Employees.Add(employee);
        }

        public void AddSubDepartment(Department department)
        {
            SubDepartments.Add(department);
        }

        #endregion
    }
}

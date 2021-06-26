using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public abstract class Employee
    {
        #region Свойства

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Department Department { get; private set; }

        #endregion

        #region Конструкторы

        public Employee(string firstName, string lastName, Department department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            
        }

        #endregion

        #region Методы

        public abstract decimal GetSalary();

        public abstract string GetPosition();

        #endregion
    }
}

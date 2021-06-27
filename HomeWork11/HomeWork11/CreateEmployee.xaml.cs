using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeWork11
{
    /// <summary>
    /// Логика взаимодействия для CreateEmployee.xaml
    /// </summary>
    public partial class CreateEmployee : Window
    {
        Department department;
        public CreateEmployee()
        {
            InitializeComponent();
        }

        public CreateEmployee(Department department)
        {
            InitializeComponent();
            this.department = department;
        }

        private void CreateNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeType == null || EmployeeType.SelectedValue == null)
            {
                return;
            }
            var employeeType = (EmployeeEnum)EmployeeType.SelectedValue;
            var firstName = FirstName.Text;
            var lastName = LastName.Text;
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                return;
            }
            department.AddEmployee(employeeType, firstName, lastName);
            this.Close();
        }
    }
}

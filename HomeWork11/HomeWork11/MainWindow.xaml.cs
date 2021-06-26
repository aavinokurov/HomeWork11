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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Organization organization;
        Department currentDepartment;
        public MainWindow()
        {
            InitializeComponent();

            organization = new Organization("Организация");

            var department1 = new Department("department1");
            department1.AddSubDepartment(new Department("department1_1"));
            var department1_2 = new Department("department1_2");
            department1_2.AddSubDepartment(new Department("department1_2_1"));
            department1.AddSubDepartment(department1_2);
            department1.AddSubDepartment(new Department("department1_3"));
            var department2 = new Department("department2");
            department2.AddSubDepartment(new Department("department2_1"));
            department1.AddEmployee(EmployeeEnum.Director, "Петр", "Петров");
            department1.AddEmployee(EmployeeEnum.Intern, "Иван", "Иванов");
            organization.Departments.Add(department1);
            organization.Departments.Add(department2);
            Departments.ItemsSource = organization.Departments;
        }

        private void treeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            currentDepartment = (sender as TreeView).SelectedItem as Department;
            var employeesView = currentDepartment.Employees.Select(emoloyee => new EmployeeViewModel 
                                                        { 
                                                            FirstName = $"Имя : {emoloyee.FirstName}",
                                                            LastName = $"Фамилия : {emoloyee.LastName}",
                                                            NameDepartment = $"Департамент : {emoloyee.Department.Name}",
                                                            Position = $"Позиция : {emoloyee.GetPosition()}",
                                                            Salary = $"Зарплата : {emoloyee.GetSalary()}"
                                                        });
            Employees.ItemsSource = employeesView;
        }

        private void CreateDepartment_Click(object sender, RoutedEventArgs e)
        {
            if (currentDepartment == null)
            {
                return;
            }
            var createDepartmentWindow = new CreateDepartmentWindow(currentDepartment.SubDepartments);
            createDepartmentWindow.Show();
        }

        private void CreateEmployee_Click(object sender, RoutedEventArgs e)
        {
            var createEmployeeWindow = new CreateEmployee();
            createEmployeeWindow.Show();
        }
    }
}

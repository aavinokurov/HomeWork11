using System;
using System.Collections.Generic;
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
        public CreateEmployee()
        {
            InitializeComponent();
        }

        private void CreateNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            var employeeType = (EmployeeEnum)EmployeeType.SelectedValue;
            MessageBox.Show(employeeType.ToString());
        }
    }
}

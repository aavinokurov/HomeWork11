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
    /// Логика взаимодействия для CreateDepartmentWindow.xaml
    /// </summary>
    public partial class CreateDepartmentWindow : Window
    {
        ObservableCollection<Department> departments;
        public CreateDepartmentWindow()
        {
            InitializeComponent();
        }

        public CreateDepartmentWindow(ObservableCollection<Department> departments)
        {
            InitializeComponent();
            this.departments = departments;
        }

        private void CreateDepartment_Click(object sender, RoutedEventArgs e)
        {
            var nameDepartment = NameDepartment.Text;
            if (string.IsNullOrWhiteSpace(nameDepartment))
            {
                return;
            }
            departments.Add(new Department(nameDepartment));
            this.Close();
        }
    }
}

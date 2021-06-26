using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    public class Organization
    {
        public string Name { get; private set; }
        public ObservableCollection<Department> Departments { get; private set; }

        public Organization(string name)
        {
            this.Name = name;
            this.Departments = new ObservableCollection<Department>();
        }
    }
}

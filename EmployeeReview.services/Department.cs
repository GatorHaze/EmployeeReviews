using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview.services
{
    class Department
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Name { get; set; }

        public Employee AddEmployee(string name, string email, string phoneNum, double salary)
    }
}

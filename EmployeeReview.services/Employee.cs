using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview.services
{
    public class Employee : Department
    {
         public List<Employee> Employees { get; set; } = new List<Employee>();

        public string Name { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Salary { get; set; } 
        public string Department { get; set; }

        public Department Infor { get; set; } = new Department();
        public Reviews Review { get; set; } = new Reviews();
        public string Emps { get; set; } = String.Empty;
        public Employee AddEmployee(string name, string email, string phoneNum, string salary)
        {
            var employee = new Employee
            {
                Name = name,
                Email = email,
                PhoneNum = phoneNum,
                Salary = salary
            };
            Employees.Add(employee);
            return employee;
            
        }

        public void DeleteEmployee(Guid selectedEmployee)
        {
            var selected = Employees
                .FirstOrDefault(employee => employee.Id == selectedEmployee);
            if (selected != null)
            {
                Employees.Remove(selected);
            }
        }

        public void UpdateEmployee(Guid selectedEmployee, string salary, string review, string department)
        {
            var employee = Employees.FirstOrDefault(f => f.Id == selectedEmployee);
            Employees.Remove(employee);
            employee.Infor.Departments = department;
            employee.Infor.Review = review;
            Employees.Add(employee);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO

namespace EmployeeReview.services
{
    class Program : Employee
    {
        
        static void Main(string[] args)
        {
            var filePath = "employees.csv";
            
            using( var sw = new StreamWriter("employees.csv")
            {
            foreach (var Employee in employee) 
                {
                    sw.WriteLine($"{Employee.Name}, {Employee.Email}, {Employee.Phonenum}, {Employee.Salary}, {Employee.Department}, {Employee.Review}");
                }

            var newEmp = new List<Employee>();
            using (var sr = new StreamReader("employee.csv"))
            {
                while (sr.Peek() > 0)
                {
                    var line = sr.ReadLine().Split(',');
                    var Name = line[0];
                    var Email = line[1];
                    var Phonenum = line[2];
                    var Salary = line[3];
                    var Department = line[4];
                    var Review = line[5];


                }
            }
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeReview.services;


namespace EmployeeReviews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Guid SelectedEmployee { get; set; } = Guid.Empty;
        public Employee Employees { get; set; } = new Employee();
        public MainWindow()
        {
            InitializeComponent();
            this.EmployeesListed.ItemsSource = Employees.Employees;
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            var name = this.nameinput.Text;

        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {
            var email = this.email.Text;
        }

        private void ClearRefresh(object sender, RoutedEventArgs e)
        {

        }

        private void addinfo_Click(object sender, RoutedEventArgs e)
        {
            //Add new employee
            if (SelectedEmployee == Guid.Empty)
            {
                var name = this.nameinput.Text;
                var email = this.email.Text;
                var phoneNum = this.phone_number.Text;
                var salary = this.Salary.Text;
                var department = this.department.Text;
                var review = this.review.Text;

                var newEmployee = Employees.AddEmployee(name, email, phoneNum, salary);

                SelectedEmployee = newEmployee.Id;
                this.EmployeesListed.Items.Refresh();
            }
        }
        private void EmployeeSelected(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var employee = btn.DataContext as Employee;
                this.nameinput.Text = employee.Name;
                this.email.Text = employee.Email;
                this.phone_number.Text = employee.PhoneNum;
                this.Salary.Text = employee.Salary;
                this.department.Text = employee.Department;
                SelectedEmployee = employee.Id;

            }
        }

        //Remove Employee from database
        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedEmployee != Guid.Empty)
            {
                Employees.DeleteEmployee(SelectedEmployee);

                SelectedEmployee = Guid.Empty;
                this.EmployeesListed.Items.Refresh();
            }
        }

        //Update option 
        private void update_click(object sender, RoutedEventArgs e)
        {
            var name = this.nameinput.Text;
            var email = this.email.Text;
            var phoneNum = this.phone_number.Text;
            var salary = this.Salary.Text;
            var department = this.department.Text;
            var review = this.review.Text;

            Employees.UpdateEmployee(SelectedEmployee, name, email, phoneNum, salary, department, review);
        }
    }
}

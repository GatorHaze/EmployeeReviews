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



namespace EmployeeReviews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Guid 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            var name = this.nameinput.Text;
            var 
        }

        private void email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ClearRefresh(object sender, RoutedEventArgs e)
        {
            
        }

        private void addinfo_Click(object sender, RoutedEventArgs e)
        {
            //Add new employee
            var name = this.nameinput.Text;
            var email = this.email.Text;
            var phoneNum = this.phone_number.Text;
            var salary = this.Salary.Text;
            var department = this.department.Text;
            var review = this.review.Text;

            var newEmployee = department.AddEmployee(name, email, phoneNum, salary, department, review);


        }
    }
}

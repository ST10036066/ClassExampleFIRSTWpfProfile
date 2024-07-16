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

namespace ClassExampleFIRSTWpfProfile
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    { //list stores student objects 
       List<Student> students= new List<Student>();
        public Register()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //check the name of text boxes when using them to get input for user. Do this 
            string name = NameBox.Text;
            string lastName = lastNameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Password;
            string confrimPass = confirmPassword.Password;
            string address = addressTextBox.Text;

            if(passwordBox.Password != confirmPassword.Password)
            {
                clearData();
                MessageBox.Show("Password to match");
            }
            else
            {
                Student student = new Student( name, lastName, email, password, address);
               
                students.Add(student);
                MessageBox.Show("Data save");
                clearData();

            }
        }
         public void clearData ()
        {
            //another way can use string.Empty;
            //so do this when we want to clear useer input in the textboxs, password etc
            NameBox.Text = "";
            lastNameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Password = "";
            confirmPassword.Password = "";   
            addressTextBox.Text = "";

         }


        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //parse student //main window must have a constructor that recieces the stiudent list 
            MainWindow log = new MainWindow (students);
            this.Hide();
            log.Show();
        }
        Register registration = new Register();
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = NameBox.Text.ToString();
            string password = passwordBox.Password.ToString();
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lastNameTextbox(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void NameBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        //checking if password is the same as the one as the one in register.
    }
}

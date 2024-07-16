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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassExampleFIRSTWpfProfile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        private List<Student> students = new List<Student>(); 

        
        public MainWindow(List<Student> student)
        {
            students = student;
            

            InitializeComponent();
            //must have , its by default for all buttons to work...
        }
        public MainWindow()
        {
            InitializeComponent();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("clicked succesfully");
            string username = loginNameTextBox.Text;
            string conPassword = LoginPasswordTextBox.Password;

           foreach(Student st in students)
            {

                if (st.EmailID == username && st.Password == conPassword)
                {
                    MessageBox.Show("sucessful");
                    LayoutDesign ptd = new LayoutDesign();
                    ptd.Show();
                    this.Close();
                }


               
                //checks if the username and password matches 
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //to add this method , double click. to add listener  
        //option 2: use properties. when there's not method.
        //click on button , right click , properties, double click on the button with empty space 




    }
}

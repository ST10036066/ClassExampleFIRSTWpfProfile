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

namespace ClassExampleFIRSTWpfProfile
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private List<Student> students = new List<Student>();

        public Login()
        {
            InitializeComponent();
        }

        
        public Login (List<Student> students)
        {
            this.students = students;
            //Student student = new Student();
            InitializeComponent();
        }
        private void login_Name_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = login_Textbox.Text.ToString();    
            string password = password_login_tetbox.ToString();

            for(int cnt = 0; cnt < students.Count; cnt++)
            {
                LayoutDesign lay = new LayoutDesign();
                lay.Close();
                lay.Show();
            }
        }
    }
}

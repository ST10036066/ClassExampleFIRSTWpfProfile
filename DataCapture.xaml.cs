using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DataCapture.xaml
    /// </summary>
    public partial class DataCapture : Window
    {
        public DataCapture()
        {
            InitializeComponent();//this line helps to be able see UI
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataCapture dataCapture = new DataCapture();
            dataCapture.Show();
            this.Close();   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

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
    /// Interaction logic for LayoutDesign.xaml
    /// </summary>
    public partial class LayoutDesign : Window
    {
        //an object of validation class 
        validation validation = new validation();
        public LayoutDesign()
        {
            InitializeComponent();
        }

        public void btnAdd_Click (object sender, RoutedEventArgs e)
        {
            string input = textName.Text;
            bool val = validation.valid(input);
            //code to add name to list box
            if(!string.IsNullOrWhiteSpace(textName.Text) && val)
            {
                //adding items need to listbox

                lstNames.Items.Add(input);
                //clear the text box after adding the name
                textName.Clear();
            }
        }
        private void lstNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            inputValidation.Content = "Please Enter a Valid Number";
            textName.Clear();
        }

        private void textName_TextChanged(object sender, TextChangedEventArgs e)
        {
            inputValidation.Content = "";
        }

        private void lstNames_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

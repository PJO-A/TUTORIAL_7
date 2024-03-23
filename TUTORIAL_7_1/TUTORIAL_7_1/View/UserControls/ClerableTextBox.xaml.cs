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

namespace TUTORIAL_7_1.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClerableTextBox.xaml
    /// </summary>
    public partial class ClerableTextBox : UserControl
    {
        public ClerableTextBox()
        {
            InitializeComponent();
        }

        private string  placeholder;

        public string  Placeholder
        {
            get { return placeholder; }
            set { 
                placeholder = value;
                //do not do this
                tbPlaceholder.Text = placeholder;
                //should be done ON PROPERTY CHANGED
            }
        }




        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}

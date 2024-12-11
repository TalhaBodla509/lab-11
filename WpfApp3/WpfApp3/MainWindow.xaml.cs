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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                textBox1.Text = $"{checkBox.Content} is checked.";
                UpdateTextBoxBasedOnCheckBoxes();
            }
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                textBox1.Text = $"{checkBox.Content} is unchecked.";
                UpdateTextBoxBasedOnCheckBoxes();
            }
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                textBox1.Text = $"{checkBox.Content} is in an indeterminate state.";
            }
        }

        private void UpdateTextBoxBasedOnCheckBoxes()
        {
            if (checkBox1.IsChecked == true)
            {
                textBox2.Text = "CheckBox 1 is checked.";
            }
            else if (checkBox2.IsChecked == true)
            {
                textBox2.Text = "CheckBox 2 is checked.";
            }
            else
            {
                textBox2.Text = "No checkboxes are checked.";
            }
        }
    }
}
    


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

namespace WpfApp_Participation
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
          //  MessageBox.Show("bananarama");

            MessageBox.Show("You're Welcome!", "You've been blessed", MessageBoxButton.OK);
            lblMessage.Content = "Hellow World";
            lblOUtput.Content
        }
    }
}

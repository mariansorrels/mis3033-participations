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

namespace FirstWPFApplication
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            string txbe = txbBirthdate.Text;
            string naem = txbName.Text;
            DateTime BirthDate = Convert.ToDateTime(txbe);
            TimeSpan Age = DateTime.Now - BirthDate;
            //TimeSpan ageinyears = Age / 365;
            double ageinyears = Age.Days / 365;
            //Convert.ToString(ageinyears);

            MessageBox.Show($"{naem}, your age is {ageinyears.ToString("N2")}");
            //MessageBox.Show($"{naem}, your age is {ageinyears}");
            //lblmsg.Content = $"{naem}, your age is {ageinyears}! You're an old banana!";
            Environment.Exit(0);
        }

     

        private void Calculate_MouseEnter(object sender, MouseEventArgs e)
        {
            Calculate.Background = Brushes.DarkGoldenrod; 
        }
    }



}

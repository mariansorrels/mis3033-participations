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

namespace WpfInclass_Classes
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
            Pet myPet = new Pet()
            {
                Breed = txbBreed.Text,
                    Name = txbName.Text,
                    PictureURL = txbURL.Text
            };
            // myBet.Breed = txbBreed.Text;

            //how to add object to listbox
            lstPets.Items.Add(myPet);



        }

        private void lstPets_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this is the default event for the listbox. just double click on it. you need this for the hw
            //this is already built in

            Pet selectedPet = (Pet)lstPets.SelectedItem;

            //the pet in parenthesis helps with the error that helps convert object to pet
            //uri is a more defined type of url

            Uri petURI = new Uri(selectedPet.PictureURL);
            //convert into bitmap first
            BitmapImage pic = new BitmapImage(petURI);
            imgPet.Source = pic;
            

        }
    }
}

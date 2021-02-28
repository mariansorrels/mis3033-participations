using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Participation_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            pokeapi api;
            string url = "https://pokeapi.co/api/v2/pokemon?offset=20&limit=1200";

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                api = JsonConvert.DeserializeObject<pokeapi>(json);

            }
            foreach (var item in api.results.OrderBy(x => x.name).ToList())

            {
                lstPokemon.Items.Add(item);
            }

        }

        private void lstPokemon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

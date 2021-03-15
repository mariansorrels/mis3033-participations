using System.Collections.Generic;

namespace NewPokemonAPI
{
    public class pokeapi
    {
        public List<ResultObject> results { get; set; }
    }
    public class ResultObject
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public ResultObject()
        {
            Name = string.Empty;
            Url = string.Empty;
            Weight = string.Empty;
            Height = string.Empty;
        }
        public ResultObject(string name, string url, string weight, string height)
        {
            Name = name;
            Url = url;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
    public class urlpokemon
    {
        public string SelectedUrl { get; set; }

        public urlpokemon()
        {
            SelectedUrl = string.Empty;
        }
        public urlpokemon(string selectedurl)
        {
            SelectedUrl = selectedurl;
        }
        public void selecturl(ResultObject ro)
        {
            SelectedUrl = ro.Url;
        }
    }
}
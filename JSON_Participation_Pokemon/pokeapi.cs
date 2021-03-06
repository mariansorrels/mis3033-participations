﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Participation_Pokemon
{
    public class pokeapi
    {
        public List<ResultObject> results { get; set; }

    }

    public class ResultObject
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public ResultObject()
        {
            Name = string.Empty;
            Url = string.Empty;
        }
        public ResultObject(string name, string url)
        {
            Name = name;
            Url = url;
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

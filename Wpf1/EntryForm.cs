using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf1
{
    public class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }

        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            Zipcode = 0;
        }
        public EntryForm(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            Zipcode = zipcode;
        }
        public override string ToString()
        {
            return $"{Name}, {Address}, {Convert.ToString(Zipcode)}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WpfInclass_Classes
{
    public class Pet
    {
       public string Name { get; set; }
        public string Breed { get; set; }
        public string PictureURL { get; set; }

        public Pet()
        {
            Name = string.Empty;
            Breed = string.Empty;
            PictureURL = string.Empty;
        }

        //Converting this to string below so it prints in listbox right
        //this is called implicitely when it wants to put something in the listbox
        public override string ToString()
        {
            return $"{Name} ({Breed})";

        }



    }
}

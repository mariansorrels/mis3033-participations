using System;
using System.Collections.Generic;
using System.Text;

namespace Participation1_MarianSorrels
{
    public class Student
    {
        //read first column of uml
        // + means public - private
        //put get and set in curly brackets for public 

        public int64 ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FavoriteColor { get; set; }

        //constructers make new rows in the proverbial table
        //provide starting values for proparties
        //type ctor is shortcut for constructor
        //methods need something inside them, even for your empty one

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Student()
        {
            ID = 0;
            FirstName = "";
            //you can also say string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        //why is there another constructor? to allow for choice
        //like making a new row in the table, but with already known values in the cells

        /// <summary>
        /// overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="color"></param>
        public Student(int64 id, string first, string last, string color)
        {
            // the thing you want to change has to be on the left side, you can't put the lowercase stuff on the left side
            //or you're only changing the lowercase id
            ID = id;
            FirstName = first;
            LastName = last;
            FavoriteColor = color;
        }


        public Student(int64 id) : this()
        {
            ID = id;
            //this() is calling back the default/empty constructor
            //so everything other than ID is gonna be the default empty constructor
        }

        public string CreateFullName()
        {
            //below is easier way to put the values in
            return $"{LastName}, {FirstName}";
        }

    }
}

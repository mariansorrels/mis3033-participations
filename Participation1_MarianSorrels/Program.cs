using System;
using System.Collections.Generic;
using System.IO;
/// <summary>
/// @Author Marian Sorrels's Project
/// </summary>

namespace Participation1_MarianSorrels
{
    class Program
    {
        List<Student> students = new List<Student>();
        static void Main(string[] args)
        {

            //absolute reference: full location thing, program can find it wherever it is, even on internet
            //relative reference: this is like the path where you just put how to find it from one path

            string[] lines = File.ReadAllLines("studentDataRandom100Rows.csv.");
            // you need to add the thing on line 2 for file
            //parenthesis means you're using a method
            //to add your file, you go to the solution explorer, right click on project then add exisitng file
            //then you go to properties on the imported files and copy to output 

          



          //  foreach (var line in lines)
          //  {
            //    Console.WriteLine(line);
                //this will print out each line in the lines array
            //}

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                var pieces = line.Split(',');
                int id = Convert.ToInt(pieces[0]);

                Student currentStudent =   new Student(Convert.ToInt32)
            }

            PrintStudentswithFavoriteColor("Blue"); ;
          //  Student s = new Student();
          //  s.FirstName = "Joe";
          //  s.LastName = "Joe";
            //calls constructor with default values
          //  Student s2 = new Student(5, "Joe", "Joe", "blue");
            //calls constructor with data already known


        }

        private static void PrintStudentswithFavoriteColor(string color)
        {
            throw new NotImplementedException();
            foreach (var student in students)
            {

            }
        }
    }
}


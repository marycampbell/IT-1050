using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_two
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(LastName + "," + FirstName + " (" + Age + ") ");
        }

    }
}

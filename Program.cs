using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p1Spouse = new Person();
            Person p2Spouse = new Person();



            System.Console.WriteLine("Information about Person 1 :    ");
            System.Console.WriteLine();
            System.Console.Write("What is your first name?            ");
            p1.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your last name?             ");
            p1.LastName = System.Console.ReadLine();

            System.Console.Write("What is your age?                   ");
            p1.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges = Person.SumOfAllAges + p1.Age;

            System.Console.Write("What is your spouse's first name?   ");
            p1Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your spouse's age?          ");
            p1Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges = Person.SumOfAllAges + p1Spouse.Age;

            p1Spouse.LastName = p1.LastName;


            System.Console.WriteLine();
            System.Console.WriteLine("Information about Person 2 :    ");
            System.Console.WriteLine();
            System.Console.Write("What is your first name?            ");
            p2.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your last name?             ");
            p2.LastName = System.Console.ReadLine();

            System.Console.Write("What is your age?                   ");
            p2.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges = Person.SumOfAllAges + p2.Age;

            System.Console.Write("What is your spouse's first name?   ");
            p2Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your spouse's age?          ");
            p2Spouse.Age = int.Parse(System.Console.ReadLine());

            Person.SumOfAllAges = Person.SumOfAllAges + p2Spouse.Age;

            p2Spouse.LastName = p2.LastName;

            Person.SumOfAllAges = Person.SumOfAllAges / 4;

            System.Console.WriteLine();

            System.Console.WriteLine("Printing Results;");


            p1.PrintNameAndAge();
            p1Spouse.PrintNameAndAge();
            p2.PrintNameAndAge();
            p2Spouse.PrintNameAndAge();

            System.Console.WriteLine("Average Age = " + Person.SumOfAllAges);



            System.Console.WriteLine("Press any key to continue ");
            System.Console.ReadKey();


        }
    }
}

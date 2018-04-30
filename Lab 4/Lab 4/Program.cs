using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool eveningFlag = true;

            const double priceOfChildMatinee = 3.99;  
            const double priceOfAdultMatinee = 5.99;
            const double priceOfSeniorMatinee = 4.50;

            
            const double priceOfChildEvening = 6.99;
            const double priceOfAdultEvening = 10.99;
            const double priceOfSeniorEvening = 8.50;

            const double priceOfSmallSoda = 3.50;
            const double priceOfLargeSoda = 5.99;
            const double priceOfHotDog = 3.99;
            const double priceOfPopcorn = 4.50;
            const double priceOfCandy = 1.99;

            double totalCost = 0;
            double totalDiscount = 0;

            int numberOfAdults = 0;
            int numberOfSeniors = 0;
            int numberOfChildren = 0;

            int numberOfSmallSoda = 0;
            int numberOfLargeSoda = 0;
            int numberOfHotDog = 0;
            int numberOfPopcorn = 0;
            int numberOfCandy = 0;

            int minimumNumber = 0;

            string timeOfMovie;

            System.Console.WriteLine("Night At The Movies Cost Calculator");
            System.Console.WriteLine();

            System.Console.Write("When are you going? (Enter E for Evening or M for Matinee) ");
            timeOfMovie = System.Console.ReadLine();

            System.Console.Write("Enter number of adults: ");
            numberOfAdults = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of seniors: ");
            numberOfSeniors = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of children: ");
            numberOfChildren = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of small sodas you will be purchasing: ");
            numberOfSmallSoda = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of large sodas you will be purchasing: ");
            numberOfLargeSoda = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of hot dogs you will be purchasing: ");
            numberOfHotDog = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of popcorns you will be purchasing: ");
            numberOfPopcorn = Int32.Parse(System.Console.ReadLine());

            System.Console.Write("Enter number of candies you will be purchasing: ");
            numberOfCandy = Int32.Parse(System.Console.ReadLine());

            if (timeOfMovie.ToLower().StartsWith("e"))
            {
                totalCost = (numberOfAdults * priceOfAdultEvening) + (numberOfSeniors * priceOfSeniorEvening) + (numberOfChildren * priceOfChildEvening);
                eveningFlag = true;
            }
            else 
            {
                totalCost = (numberOfAdults * priceOfAdultMatinee) + (numberOfSeniors * priceOfSeniorMatinee) + (numberOfChildren * priceOfChildMatinee);
                eveningFlag = false;
            }

            totalCost = totalCost + (numberOfSmallSoda * priceOfSmallSoda);
            totalCost = totalCost + (numberOfLargeSoda * priceOfLargeSoda);
            totalCost = totalCost + (numberOfHotDog * priceOfHotDog);
            totalCost = totalCost + (numberOfPopcorn * priceOfPopcorn);
            totalCost = totalCost + (numberOfCandy * priceOfCandy);

            //$2.00 discount for purchasing a large soda and popcorn with a movie ticket
            if (numberOfPopcorn > 0 & numberOfLargeSoda > 0)
            {
                minimumNumber = Math.Min(numberOfPopcorn, numberOfLargeSoda);
                totalDiscount = minimumNumber * 2.00;
            }

            //3 or more tickets gets a free popcorn 
            if (eveningFlag)
            {
                if (numberOfPopcorn > 0)
                {
                    totalDiscount = totalDiscount + priceOfPopcorn;
                }
            }
            
            //For every 3 candies you buy, you get a 4th for free
            if (numberOfCandy > 3)
            {
                totalDiscount = totalDiscount + ((numberOfCandy / 4) * 1.99);
            }

            //Get final cost
            totalCost = totalCost - totalDiscount;

            //Display results
            System.Console.Write("Your total cost for a night at the movies is ");
            System.Console.WriteLine(totalCost);
            System.Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Please enter a temperate in F, this program with convert it to C");

            int fTemp = int.Parse(Console.ReadLine());

            int cTemp = (fTemp - 32) * 5 / 9;

            Console.WriteLine(fTemp + " fahrenhiet is " + cTemp + " in celcius.");
            Console.WriteLine();





            // Problem 2
            Console.WriteLine("Please enter a price less than $1");
            Console.WriteLine("Price");

            int price = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int change = 100 - price;

            int quarters = change / 25;

            change = change - quarters * 25;

            int dimes = change / 10;

            change = change - dimes * 10;

            int nickles = change / 5;

            change = change - nickles * 5;

            int pennies = change / 1;

            change = change - pennies * 1;

            Console.WriteLine("The change is " + quarters + " quarters, " + dimes + " dimes, " + nickles + " nickles, " + pennies + " pennies.");
            Console.WriteLine();

            // Problem 3
            int defaultCookies = 60;

            Console.WriteLine("Please enter the number of cookies you would like to make.");
            int numCookies = int.Parse(Console.ReadLine());

            if(numCookies > 60)
            {
                int moreCookies = numCookies - 60;
                numCookies = moreCookies + 60;
                Console.WriteLine(numCookies);
            }
            else if (numCookies < 60)
            {
                int lessCookies = 60 - numCookies;
                Console.WriteLine(numCookies);
            }
            Console.WriteLine();



            // Problem 4

            Console.WriteLine("Please enter the total number of students in the class.");
            double numStudents = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of Programing Majors in the class.");
            double numProgrammers = double.Parse(Console.ReadLine());

            double percProg = numStudents - numProgrammers * .10;

            Console.WriteLine("The percentage of Programing Majors is " + percProg + "%.");
            Console.WriteLine();

            // Problem 5

            decimal mexPesos;
            decimal euros;
            decimal canDollars;
           

            Console.WriteLine("Enter a US Dollar ammount");
            decimal usDollars = decimal.Parse(Console.ReadLine());

            mexPesos = decimal.Multiply(usDollars, 18.00m);
            euros = decimal.Multiply(usDollars, 0.90m);
            canDollars = decimal.Multiply(usDollars, 0.31m);

            Console.WriteLine(usDollars + " US Dollars is " + mexPesos + " Mexican Pesos.");
            Console.WriteLine(usDollars + " US Dollars is " + euros + " Euros.");
            Console.WriteLine(usDollars + " US Dollars is " + canDollars + " Canadian Dollars.");
            Console.WriteLine();

            // Problem 6

            int firstNum = Generator.Next(10, 1000);
            int secNum = Generator.Next(10, 1000);
            int ans = firstNum + secNum;

            Console.WriteLine("The first number is " + firstNum + " the second number is " + secNum );
            Console.WriteLine("What is the sum of both numbers?");

            int numGuess = int.Parse(Console.ReadLine());

            if (numGuess == ans)
                Console.WriteLine("Thats Right!");
            else
                Console.WriteLine("Sorry, the correct answer is " + ans);

            Console.WriteLine();




        }
    }
}

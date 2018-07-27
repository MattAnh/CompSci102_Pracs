using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your monthly salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enetr your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (0 <= salary && salary <= 4999)
            {
                double payableTax = 0;
                Console.WriteLine("Your monthly tax is " + payableTax);
            }
            else if (5000 <= salary && salary <= 6499)
            {
                if (age < 65)
                {
                    double payableTax = 13;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (6500 <= salary && salary <= 7799)
            {
                if (age < 65)
                {
                    double payableTax = 250;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (7800 <= salary && salary <= 9999)
            {
                if (age < 65)
                {
                    double payableTax = 620;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (10000 <= salary && salary <= 13499)
            {
                if (age < 65)
                {
                    double payableTax = 1200;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 600;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 400;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (13500 <= salary && salary <= 17899)
            {
                if (age < 65)
                {
                    double payableTax = 2100;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 1500;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 1200;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (17900 <= salary && salary <= 19999)
            {
                if (age < 65)
                {
                    double payableTax = 2700;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 2000;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 1800;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (20000 <= salary && salary <= 39999)
            {
                if (age < 65)
                {
                    double payableTax = 8000;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 7500;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 7300;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else if (40000 <= salary && salary <= 59999)
            {
                if (age < 65)
                {
                    double payableTax = 16000;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 15600;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 15400;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }
            else
            {
                if (age < 65)
                {
                    double payableTax = 20000;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (65 <= age && age <= 75)
                {
                    double payableTax = 17050;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
                else if (age > 75)
                {
                    double payableTax = 17000;
                    Console.WriteLine("Your monthly tax is " + payableTax);
                }
            }

            Console.ReadLine();

        }
    }
}

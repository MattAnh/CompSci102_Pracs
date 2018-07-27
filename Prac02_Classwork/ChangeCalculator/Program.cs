using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount: ");
            string amount = Console.ReadLine();

            double theAmount;

            //input validation
            if (Double.TryParse(amount, out theAmount))
            {                                               //THE COMMENTS APPLY FOR THE WHOLE CODE
                double remainder1 = theAmount % 200;        //calculating the remainder from the user input
                double note200 = theAmount - remainder1;    //finding the exact multiple of the note/coin by subtracting remainder from initial amount
                double count1 = note200 / 200;              //using count to find how many of a certain note/coin there is in the given amount
                if (count1 > 0)                             //checking if the certain note/coin was found
                {
                    Console.WriteLine("Return " + count1 +  " x R200 note(s).");
                }

                double remainder2 = remainder1 % 100;
                double note100 = remainder1 - remainder2;
                double count2 = note100 / 100;
                if (count2 > 0)
                {
                    Console.WriteLine("Return " + count2 + " x R100 note(s).");
                }

                double remainder3 = remainder2 % 50;
                double note50 = remainder2 - remainder3;
                double count3 = note50 / 50;
                if (count3 > 0)
                {
                    Console.WriteLine("Return " + count3 + " x R50 note(s).");
                }

                double remainder4 = remainder3 % 20;
                double note20 = remainder3 - remainder4;
                double count4 = note20 / 20;
                if (count4 > 0)
                {
                    Console.WriteLine("Return " + count4 + " x R20 note(s).");
                }

                double remainder5 = remainder4 % 10;
                double note10 = remainder4 - remainder5;
                double count5 = note10 / 10;
                if (count5 > 0)
                {
                    Console.WriteLine("Return " + count5 + " x R10 note(s).");
                }

                double remainder6 = remainder5 % 5;
                double coin1 = remainder5 - remainder6;
                double count6 = coin1 / 5;
                if (count6 > 0)
                {
                    Console.WriteLine("Return " + count6 + " x R5 coin(s).");
                }

                double remainder7 = remainder6 % 2;
                double coin2 = remainder6 - remainder7;
                double count7 = coin2 / 2;
                if (count7 > 0)
                {
                    Console.WriteLine("Return " + count7 + " x R2 coin(s).");
                }

                double remainder8 = remainder7 % 1;
                double coin3 = remainder7 - remainder8;
                double count8 = coin3 / 1;
                if (count8 > 0)
                {
                    Console.WriteLine("Return " + count8 + " x R1 coin(s).");
                }

                double remainder9 = remainder8 % 0.5;
                double coin4 = remainder8 - remainder9;
                double count9 = coin4 / 0.5;
                if (count9 > 0)
                {
                    Console.WriteLine("Return " + count9 + " x 50c coin(s).");
                }

                double remainder10 = remainder9 % 0.2;
                double coin5 = remainder9 - remainder10;
                double count10 = coin5 / 0.2;
                if (count10 > 0)
                {
                    Console.WriteLine("Return " + count10 + " x 20c coin(s).");
                }

                double remainder11 = remainder10 % 0.1;
                double coin6 = remainder10 - remainder11;
                double count11 = coin6 / 0.1;
                if (count11 > 0)
                {
                    Console.WriteLine("Return " + count11 + " x 10c coin(s).");
                }

                double remainder12 = remainder11 % 0.05;
                double coin7 = remainder11 - remainder12;
                double count12 = coin7 / 0.05;
                if (count12 > 0)
                {
                    Console.WriteLine("Return " + count12 + " x 5c coin(s).");
                }

                double remainder13 = remainder12 % 0.02;
                double coin8 = remainder12 - remainder13;
                double count13 = coin8 / 0.02;
                if (count13 > 0)
                {
                    Console.WriteLine("Return " + count13 + " x 2c coin(s).");
                }

                double remainder14 = remainder13 % 0.01;        //this part of the code does not run for numbers greater than 1000
                double coin9 = remainder13 - remainder14;
                double count14 = coin9 / 0.01;
                if (count14 > 0)
                {
                    Console.WriteLine("Return " + count14 + " x 1c coin(s).");
                }

            }
            else
            {
               Console.WriteLine("You entered an invalid amount! Please try again.");
            }

            Console.ReadLine();
            
        }
    }
}

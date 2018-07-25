using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many times does your tap drip a second?");
            string answer = Console.ReadLine();

            int theAnswer;
            if (Int32.TryParse(answer, out theAnswer))
            {
                double day = 86400 / theAnswer * 0.00025;
                double glasses = day / 0.25;
                glasses = Math.Floor(glasses);  //rounds off the number to an integer

                Console.WriteLine(glasses + " glasses full of water will be wasted.");

            }
            else
	        {
                Console.WriteLine("You entered invalid input. Please enter a whole number.");
            }

            Console.ReadLine();
        }
    }
}

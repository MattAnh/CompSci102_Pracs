using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeGlasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many times does your tap drip a second?");
			int answer = Convert.ToInt32(Console.ReadLine());

			double day = 86400 / answer * 0.00025;
			double glasses = day / 0.25;
			glasses = Math.Floor(glasses);

			Console.WriteLine(glasses + " full glasses of water are wasted.");
			Console.ReadLine();
		}
	}
}

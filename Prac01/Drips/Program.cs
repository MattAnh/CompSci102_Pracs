using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How often do hear a drip from the tap? (in seconds)");
			int answer = Convert.ToInt32(Console.ReadLine());

			double hour = 3600 / answer * 0.00025;
			double day = 86400 / answer * 0.00025;
			double week = 604800 / answer * 0.00025;

			Console.WriteLine("This wastes " + hour + " litres of water every hour.");
			Console.WriteLine("This wastes " + day + " litres of water every day.");
			Console.WriteLine("This wastes " + week + " litres of water every week.");

			Console.ReadLine();

		}
	}
}

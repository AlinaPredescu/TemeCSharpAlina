using System;

namespace Flow_3
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Curs 2 - Tema 2");

			string aNr = Console.ReadLine();
			double pounds = Convert.ToDouble(aNr);

			double kilo;

			double rata = 2.205;

			kilo = pounds / rata;

			Console.WriteLine("numarul de kilograme este: " + kilo);
			Console.ReadKey();

		}
	}
}

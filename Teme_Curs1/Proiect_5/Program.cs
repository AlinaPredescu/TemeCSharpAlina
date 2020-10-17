using System;

namespace Proiect_5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Curs C# - Proiectul 5");

			int numar = int.Parse(Console.ReadLine());
			int numarBck = numar;

			int rest1 = numar % 10;
			numar = numar / 10;

			int rest2 = numar % 10;
			numar = numar / 10;

			int rest3 = numar % 10;
			numar = numar / 10;

			int rest4 = numar % 10;
			numar = numar / 10;

			int rest5 = numar % 10;
			numar = numar / 10;

			
			Console.WriteLine("Descompunerea numarului " + numarBck + " este: " +
				rest5+ " X 10000 "+ " + "+
				rest4+ " X 1000 "+ " + " +
				rest3+ " X 100 "+ " + " +
				rest2+ " X 10" + " + " +
				rest1+ " X 1");
			Console.ReadKey();

		}
	}
}

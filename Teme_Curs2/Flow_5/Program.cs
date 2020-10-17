using System;

namespace Flow_5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tema curs 2 proiect flow 5");

			string n_mesaj = Console.ReadLine();
			int n = Convert.ToInt32(n_mesaj);

				double medie = ((n * (n + 1)) / 2)/n;
			Console.WriteLine("media primelor n numere naturale: " + medie);

			Console.ReadKey();

		}
	}
}

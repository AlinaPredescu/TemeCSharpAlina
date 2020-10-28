using System;

namespace curs2
{
	class Program
	{
		static void Main(string[] args)
		{

//exercitiul din curs de la pseudocod dat la bac, punct d
			string x_mesaj;
			x_mesaj = Console.ReadLine();
			int x = Convert.ToInt32(x_mesaj);
			string y_mesaj;
			int y;
			string rezultat="";
			while (x > 0)
			{
				 y_mesaj = Console.ReadLine();
				 y = Convert.ToInt32(y_mesaj);

				if (x > y)
				{
					rezultat += x % 10;
				}
				else
				{
					rezultat += y % 10;
				}
				x = y;
			}

			Console.WriteLine(rezultat);
			Console.ReadKey();
		}
	}
}

using System;

namespace Flow_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tema 2 exercitiu suplimentar proiect flow7");

			int nr = new Random().Next(0, 10);
			Console.WriteLine("Ghiciti numarul: "+ nr);

			string numarGhicit_mesaj;
			int numarGhicit=-1;

			int x = 0;

			while (nr != numarGhicit)
			{
				 numarGhicit_mesaj = Console.ReadLine();
				 numarGhicit = Convert.ToInt32(numarGhicit_mesaj);
				x++;

				if (nr != numarGhicit)
				{
					Console.Write("Numarul nu a fost ghicit.Vreti sa incercati din nou ? 1 = DA, 0= NU: ");
				
					int da = int.Parse(Console.ReadLine());
					if (da == 1)
					{
						continue;
					}
					else
					{
						return;
					}
				}
				else
				{
					Console.WriteLine("Ati ghicit numarul din " + x + " incercari");
					Console.WriteLine("Press any key to continue...");
					break;
				}
			}
				Console.ReadKey();

		}
	}
}

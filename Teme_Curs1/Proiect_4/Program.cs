using System;

namespace Proiect_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Curs C# - Proiectul 4");

//1) se citeste de la tastatura latura unui patrat (poate fi un numar cu virgula)
			double latura = double.Parse(Console.ReadLine());

			Console.WriteLine("Latura patratului este: " + latura);

//2) sa se afiseze pe ecran perimetrul si aria patratului

			double perimetru = 4 * latura;
			double aria = Math.Pow(latura,2);

			Console.WriteLine("Perimetrul este: " + perimetru + ", aria este: " + aria);

//3) se citeste de la tastatura diametrul unui cerc
			double diametru = double.Parse(Console.ReadLine());

			Console.WriteLine("Diametrul cercului este: " + diametru);

//4) sa se afiseze pe ecran lungimea si aria cercului (sa se foloseasca Math.PI pentru voaloarea lui PI)

			double lungimeCerc = 2 * Math.PI * (diametru / 2);
			double arieCerc = Math.PI * Math.Pow(diametru / 2,2);

			Console.WriteLine("Lungimea cercului este: " + lungimeCerc + "Aria cercului este: " + arieCerc);

/*5) se citeste de la tastatura raza unei sfere
6) sa se afiseze pe ecran aria si volumul sferei */

			double raza = double.Parse(Console.ReadLine());

			Console.WriteLine("Raza sferei este: " + raza);

			double arieSfera = 4 * Math.PI * Math.Pow(raza, 2);
			double volumSfera = 4 * Math.PI * Math.Pow(raza, 3) / 3;

			Console.WriteLine("Arie sfera=" + arieSfera + " volum sfera=" + volumSfera);
		
			Console.ReadKey();
		}
	}
}

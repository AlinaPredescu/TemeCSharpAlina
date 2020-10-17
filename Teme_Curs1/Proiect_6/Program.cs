using System;
using System.Collections.Generic;

namespace Proiect_6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Curs C# - Proiectul 6");

			int a = int.Parse(Console.ReadLine());
			int b= int.Parse(Console.ReadLine());

			int c = a;
			a = b;
			b = c;

			Console.WriteLine("pentru a=" +a + " si b="+b + " valoarea lui a va fi " + b +  " valoarea lui b va fi " +a);
			Console.ReadKey();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4_exercitiu1Constructori
{
	class Program
	{
		static void Main(string[] args)
		{
			Persoana pers1 = new Persoana("NumeA", "PrenumeA", 21);
			pers1.DisplayInfo();
//param se pot scrie si in alta ordine:
			Persoana pers2 = new Persoana(prenume: "PrenumeA", nume: "NumeA", varsta: 21);

			Console.ReadKey();
		}
	
	}
}

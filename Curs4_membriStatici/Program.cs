using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs4_exercitiu1Constructori;

namespace Curs4_membriStatici
{
	class Program
	{
		static void Main(string[] args)
		{
			Persoana pers1 = new Persoana("NumeA", "PrenumeA", 21);

			//ConvertorValutar cv = new ConvertorValutar(); --metoda fiind static crearea unui obiect convertor este inutila,
															//daca si clasa e statica nu vom mai putea scrie asa
			//double sumaRon=cv.ConvertEurToRon(50);


			double sumaRon = ConvertorValutar.ConvertEurToRon(50);
			double sumaRon2 = ConvertorValutar.ConvertEurToRon(50);

			Console.WriteLine(sumaRon);
			Console.WriteLine(sumaRon2);
			Console.ReadKey();
		}
	}
}

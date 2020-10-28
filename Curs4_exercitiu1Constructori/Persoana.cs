using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4_exercitiu1Constructori
{
	class Persoana
	{
		public string Nume { get; set; }

		public string Prenume { get; set; }

		public int Varsta { get; set; }


		public Persoana(string nume, string prenume, int varsta)
		{
			Nume = nume;
			Prenume = prenume;
			Varsta = varsta; 
		}


		public void  DisplayInfo()

		{
			Console.WriteLine(Nume + " " + Prenume + " are varsta: " + Varsta);

		}
		//destructor
		~Persoana()
		{
			Console.WriteLine("desctructorul clasei a fost apelat");

		}
	}
}

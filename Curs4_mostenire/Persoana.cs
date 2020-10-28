using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs4_mostenire;

namespace Curs4_exercitiu1Constructori
{
	class Persoana
	{
		public string Nume { get; set; }

		public string Prenume { get; set; }

		public int Varsta { get; set; }
		protected string CNP { get; set; }
//ca sa pot apela in clasa student tb sa declar un constructor fara param:
		public Persoana()
		{
		}
//constructor
		public Persoana(string nume, string prenume, int varsta)
		{
			Console.WriteLine("am apelat constr");
			Nume = nume;
			Prenume = prenume;
			Varsta = varsta;
		}

//polimorfism
		public virtual void DisplayInfo()

		{
			Console.WriteLine(Nume + " " + Prenume + " are varsta: " + Varsta);

		}

	}
}

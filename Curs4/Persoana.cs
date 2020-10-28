using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
	class Persoana
	{


		public string Nume { get; set; }

		public string Prenume { get; set; }


		//public void SetInfo(string nume, string prenume)
		//{
		//	Nume = nume;
		//	Prenume = prenume;

		//}


//constructori
		public Persoana(string nume, string prenume)
		{
			Nume = nume;
			Prenume = prenume;

		}


	}
}

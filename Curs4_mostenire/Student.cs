using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs4_exercitiu1Constructori;

namespace Curs4_mostenire
{
	class Student:Persoana
	{
		public string Facultate { get; set; }
		public float Medie { get; set; }
//mostenire constructor
		public Student():base("Nume", "Prenume", 23)
		{
			Facultate="Facultate";
			Medie = 0;
		}

		//constructor prin care apelam un constructor din clasa persoana (cel cu 3 param)
		public Student(string nume, string prenume, int varsta, string CNP, string Facultate, float Medie):base (nume, prenume, varsta)
		{
			this.CNP = CNP;
			this.Facultate = Facultate;
			this.Medie = Medie;
		}

		public void PrinteazaInformatiiComplete()
		{
			Console.WriteLine("Studentul " + this.Nume + " " + this.Prenume + ", " + CNP +
				" , cu varsta de " + Varsta + "ani este student al facultatii " + Facultate + " avand media " + Medie);
						}
//polimorfism
		public override void DisplayInfo()

		{
			Console.WriteLine(Nume + " " + Prenume + " are varsta: " + Varsta + " este la facultatea: " + Facultate+" si are media " + Medie);

		}


	}
}

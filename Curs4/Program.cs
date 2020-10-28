using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Persoana persoana1 = new Persoana();
			//////varianta 1
			//persoana1.Nume = "Popescu";
			//persoana1.Prenume = "ion";

			////varianta 2: acelasi lucru se poate scrie si astfel:
			//persoana1.SetInfo("Popescu", "ion");

			//Persoana persoana2 = new Persoana();
			//persoana2.Nume = "Popescu2";
			//persoana2.Prenume = "ion2";

			//persoana2.SetInfo("Popescu2", "ion2");


			Persoana persoana=new Persoana("popescu", "ion");



		}
	}
}

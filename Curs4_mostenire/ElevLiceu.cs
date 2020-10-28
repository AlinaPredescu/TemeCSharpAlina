using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs4_exercitiu1Constructori;

namespace Curs4_mostenire
{
	class ElevLiceu:Persoana
	{
		public string Liceu { get; set; }
		public float MedieCapacitate { get; set; }

		public ElevLiceu(string nume, string prenume, int varsta, string CNP, string Liceu, float MedieCapacitate) : base(nume, prenume, varsta)
		{
			this.CNP = CNP;
			this.Liceu = Liceu;
			this.MedieCapacitate = MedieCapacitate;
		}


	}
}

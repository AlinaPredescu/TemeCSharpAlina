using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6_Magazin
{
	public  class Product
	{
		public int Id { get; set; }
		public string Nume { get; set; }
		public string Descriere { get; set; }
		public double Pret { get; set; }

		//ca sa pot scrie in xml am nevoie de un constructor gol
		public Product()
		{

		}

		public Product(int id, string nume, string descriere, double pret)
		{
			this.Id = id;
			this.Nume = nume;
			this.Descriere = descriere;
			this.Pret = pret;
		}
	}
}

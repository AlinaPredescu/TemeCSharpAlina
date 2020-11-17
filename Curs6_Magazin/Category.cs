using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Curs6_Magazin
{
		public class Category
	{
		public int Id { get; set; }
		public string Nume { get; set; }
		public string Descriere { get; set; }
//ca sa pot scrie in xml am nevoie de un constructor gol
		//public Category()
		//{

		//}

		public Category(int id, string nume, string descriere)
		{
			Id = id;
			Nume = nume;
			Descriere = descriere;
		}
	}
}

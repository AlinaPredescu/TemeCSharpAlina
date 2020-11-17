using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitContainer
{
	public class Autor
	{
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public string Cetatenie { get; set; }
		public string DataNasterii { get; set; }

		public Autor(string nume, string prenume, string cetatenie, string datanasterii)
		{
			Nume = nume;
			Prenume = prenume;
			Cetatenie = cetatenie;
			DataNasterii = datanasterii;
		}
	
	
	
	}
}

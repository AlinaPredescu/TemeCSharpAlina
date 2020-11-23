using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuzland
{
	public class Carte
	{
		
		public string Titlu { get; set; }
		public string Autor { get; set; }
		public int AnAparitie { get; set; }
		public string Tip { get; set; }
		public bool Citita { get; set; }
		public bool CuAutograf { get; set; }
		public bool Imprumutata { get; set; }
		public string Comentarii { get; set; }

//pentru a scrie in xml am nevoie si de un constructort gol:

		public Carte()
		{ 
		}

//constructor:
		public Carte(string titlu, string autor, int anAparitie, string tip,
			bool citita, bool cuAutograf, bool imprumutata, string comentarii)
		{
			this.Titlu = titlu;
			this.Autor = autor;
			this.AnAparitie = anAparitie;
			this.Tip = tip;
			this.Citita = citita;
			this.CuAutograf = cuAutograf;
			this.Imprumutata = imprumutata;
			this.Comentarii = comentarii;
		}

	}
}

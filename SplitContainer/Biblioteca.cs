using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitContainer
{
	public class Biblioteca
	{
		public List<Autor> Autori { get; set; }
		public List<Carte> Carti { get; set; }


		public Biblioteca()
		{
			Autori = new List<Autor>();
			Carti = new List<Carte>();
		}
	}
}

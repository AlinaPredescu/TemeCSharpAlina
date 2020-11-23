using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuzland
{
	public class Biblioteca

	//creez lista
	{
		public List<Carte> Carti { get; set; }

//fac constructorul si initializez lista
	public Biblioteca()
		{
			Carti = new List<Carte>();
		}
}
}

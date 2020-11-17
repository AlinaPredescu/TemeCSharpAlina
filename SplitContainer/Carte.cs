using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitContainer
{
	public class Carte
	{
		public string Titlu { get; set; }
		public string Tip { get; set; }
		public string Limba { get; set; }
		public int AnAparitie { get; set; }
		public bool Autograf { get; set; }


		public Carte(string titlu, string tip, string limba, int anAparitie, bool autograf)
		{
			{
				Titlu = titlu;
				Tip = tip;
				Limba = limba;
				AnAparitie = anAparitie;
				Autograf = autograf;
			}

		}
	}
}

	
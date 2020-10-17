using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
	public class Cerc
	{
		public string Nume { get; set; }
		public double Raza { get; set; }

		public double CalculeazaAria()
		{
			return Math.PI * Math.Pow(Raza, 2);
		}

		public double CalculeazaPerimetrul()
		{
			return 2 * Math.PI * Raza;
		}

		public void AfiseazaAria()
		{
			Console.WriteLine("Aria cercului este: " + CalculeazaAria());
		}

		public void AfiseazaPerimetrul()
		{
			Console.WriteLine("Lungimea cercului este: " + CalculeazaPerimetrul());
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
	public class Dreptunghi
	{
		public string Nume { get; set; }

		public double Lungime { get; set; }

		public double Latime { get; set; }

		public double CalculeazaAria()
		{
			return Lungime * Latime;
		}

		public double CalculeazaPerimetrul()
		{
			return 2 * (Lungime + Latime);
		}

		public void AfiseazaAria()
		{
			Console.WriteLine("Aria dreptunghiului este: " + CalculeazaAria());
		}


		public void AfiseazaPerimetrul()
		{
			Console.WriteLine("Perimetrul dreptunghiului este: " + CalculeazaPerimetrul());
		}
	}
}

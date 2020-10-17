using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
	public class TriunghiDreptunghic
	{
		public string Nume { get; set; }
		public double Cateta1 { get; set; }
		public double Cateta2{ get; set; }

		public double CalculeazaAria()
		{
			return (Cateta1 - Cateta2) / 2;
		}


		public double CalculeazaPerimetrul()

		{
			return Cateta1 + Cateta1 + Math.Sqrt(Math.Pow(Cateta1, 2) + Math.Pow(Cateta1, 2));
		}


		public void AfiseazaAria()
		{
			Console.WriteLine("Aria triungiului dreptunghic este: " + CalculeazaAria());
		}

		public void AfiseazaPerimetrul()
		{
			Console.WriteLine("Aria triungiului dreptunghic este: " + CalculeazaPerimetrul());
		}



	}
}

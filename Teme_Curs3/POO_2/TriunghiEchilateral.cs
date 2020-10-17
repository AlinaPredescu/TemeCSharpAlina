using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
	public class TriunghiEchilateral
	{
		public string Nume { get; set; }

		public double Latura { get; set; }

		public double CalculeazaAria()
		{
			return (Math.Pow(Latura, 2) * Math.Sqrt(3) )/ 4;
		}

		public double CalculeazaPerimetrul()
		{
			return 3 * Latura;
		}

		public void AfiseazaAria()
		{
			Console.WriteLine("Aria triunghiului echilateral este: " + CalculeazaAria());
		}

		public void AfiseazaPerimetrul()
		{
			Console.WriteLine("Perimetrul triunghiului echilateral este: " + CalculeazaPerimetrul());
		}
	}
}

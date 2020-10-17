using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2
{
	class Program
	{
		static void Main(string[] args)
		{
			TriunghiEchilateral te1=new TriunghiEchilateral();
			te1.Nume = "triunghi echilateral 1";
			te1.Latura = 5.5;

			TriunghiEchilateral te2 = new TriunghiEchilateral();
			te2.Nume = "triunghi echilateral 2";
			te2.Latura = 20;


			TriunghiDreptunghic td1 = new TriunghiDreptunghic();
			td1.Nume = "triunghi dreptunghic 1";
			td1.Cateta1 = 10;
			td1.Cateta2 = 5;

			Cerc c1 = new Cerc();
			c1.Nume = "cerc 1";
			c1.Raza = 7.8;

			Dreptunghi dr1 = new Dreptunghi();
			dr1.Nume = "dreptunghi 1";
			dr1.Lungime = 10;
			dr1.Latime = 2;

			Dreptunghi dr2 = new Dreptunghi();
			dr2.Nume = "dreptunghi 1";
			dr2.Lungime = 5;
			dr2.Latime = 2;

			te1.AfiseazaAria();
			te1.AfiseazaPerimetrul();

			Console.WriteLine(" ");

			te2.AfiseazaAria();
			te2.AfiseazaPerimetrul();

			Console.WriteLine(" ");

			td1.AfiseazaAria();
			td1.AfiseazaPerimetrul();

			Console.WriteLine(" ");
			
			c1.AfiseazaAria();
			c1.AfiseazaPerimetrul();

			Console.WriteLine(" ");

			dr1.AfiseazaAria();
			dr1.AfiseazaPerimetrul();

			Console.WriteLine(" ");

			dr2.AfiseazaAria();
			dr2.AfiseazaPerimetrul();
			Console.ReadKey();
		}
	}
}

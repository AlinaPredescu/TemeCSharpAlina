using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs4_exercitiu1Constructori;

namespace Curs4_mostenire
{
	class Program
	{
		static void Main(string[] args)
		{
			Persoana pers1 = new Persoana("NumeA", "PrenumeA", 21);
			//pers1.Facultate();

			Student s = new Student();
			s.Nume = "Predescu";
			s.Prenume = "Alina";
			s.Varsta = 34;
			s.Facultate = "ASE";
			s.Medie = 9.5F;
//s.CNP = "2987432432"; //este protected nu se poate apela
			s.DisplayInfo();
			s.PrinteazaInformatiiComplete();

//polimorfism

			Student s1 = new Student();
			Persoana pers2 = new Student();

//conversii
			int d = 40000;
			short a = (short)(d);
			short c = 4;
			int b = c;


			Calculator calculator = new Calculator();
			calculator.CalculeazaSuma(3, 5);
			calculator.CalculeazaSuma(3, 5, 6);

			Persoana persoana = new Persoana();
				persoana.DisplayInfo();

			Student student = new Student();
			student.DisplayInfo();

			Persoana p1 = new Student();
			p1.DisplayInfo();

			Console.ReadKey();

		}
	}
}

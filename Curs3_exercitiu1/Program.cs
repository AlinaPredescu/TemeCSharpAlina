using System;
using System.Runtime.CompilerServices;

namespace Curs3_exercitiu1
{
	//public class Persoana
	//{
	//	//caracteristici persoana
	//	private class Masina
	//	{
	//		//caracteristici masina
	//	}
	//}
	class Program
	{//"main" este intr-o singura clasa, cea in care incepe programul
		static void Main(string[] args)
		{
			//exercitiul 1 din curs
			Student s1; 
			Student s2 = new Student();
			s1 = new Student();
			Elev e1 = new Elev();

			Persoana p1;
			//Masina nu pot declara pt ca nu e vizibila, e private

			//s1.Nume = "Popescu";
			//s1.Prenume = "Ion";

			//s1.CNP = "32323"; nu se paote pt ca e private, nu-l pot modifica

			Persoana p3 = new Persoana();
			p3.adresa = "bucuresti"; //o putem afisa pt ca este publica
			
			Console.WriteLine(p3.adresa);
			

			p3.AfiseazaNume();
			p3.SpuneVarstaPesteNAni(9);


		//	p3.SchimbaPrenumele("Ion");
			p3.SchimbaPrenumele("Ion", "ionescu");

			p3.PrintNumeComplet(); //afiseaza direct numele

			string rezultat =p3.GetNumeComplet(); //returneaza ceva si tb sa il salvam , reutneaza o info pe care o stocam si putem sa o modificam ulterior

			Console.WriteLine(rezultat);

			p3.SchimbaNumePrenumeCNP("popescu", "ion", "3455");

			p3.SchimbaNumePrenumeCNP(noulPrenume: "ion",noulNume:"ppredxe", noulCNP:" 3455");

			p3.PrintNumeComplet();

			p3.SetNume("popescu");

			Console.WriteLine(p3.GetNume());

			Persoana p4 = new Persoana();
			p4.SetPrenume("cursant");
			p4.SetVarsta(20);
			p4.SetNume("do it academy");

			Console.WriteLine(p4.GetPrenume() + "  " + p4.GetNume() + "  " + p4.GetVarsta());

			//p4.Nume="do it aca";

			//Console.WriteLine(p4.GetPrenume() + "  " + p4.Nume + "  " + p4.GetVarsta());



			Console.ReadKey();
		}
	}
}

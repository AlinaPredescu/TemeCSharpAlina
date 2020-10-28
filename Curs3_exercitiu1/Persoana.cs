using System;
using System.Runtime.CompilerServices;

namespace Curs3_exercitiu1
{
	class Persoana
	{
		private string nume;
		private string prenume;
		private int varsta;
		private string cnp;
		private bool esteBarbat;
		public string adresa;

		public string GetNume()
		{
			return this.nume;
		}


		public void SetNume(string nume)
		{
			this.nume = nume;
		}

		//SAU:

		//public string Nume
		//{
		//	get {
		//		return this.nume;
		//			}
		//	set 
		//	{
		//		this.nume = value;
		//	}
		//}

		//SAU:
		//public string Nume { get; set; }  se sterge campul string privat declarat la inceput



		public string GetPrenume()
		{
			return this.prenume;
		}


		public void SetPrenume(string prenume)
		{
			this.prenume = prenume;
		}


		//SAU:
		//public string Prenume { get; set; } - se sterge campul string declatrat la inceput si in program modific din "prenume" in Prenume

		public int  GetVarsta()
		{
			return this.varsta;
		}


		public void SetVarsta(int varsta)
		{
			this.varsta = varsta;
		}


		public int SpunaVarsta()
		{
			return varsta; //returneaza varsta
		}


		public int SpuneVarstaPesteNAni(int n)
		{
			return varsta + n;
		}

		public void AfiseazaNume()
		{
			//aici apelam numele
			Console.WriteLine(this.prenume); //=metoda, nu returneaza nimic= este de tip void unde this=insemana ca e campul din clasa aceasta, nu se foloseste
			Console.WriteLine(this.nume);



		}

//metoda afisare nume + prenume: metoda publica care nu returneaza
		public void  PrintNumeComplet()

		{

			//string mesaj=GetNumeComplet()
			//Console.WriteLine(prenume + " " + nume);


			string mesaj = GetNumeComplet();
			Console.WriteLine(mesaj);
		}

//metoda privata care afiseaza ceva
		public string GetNumeComplet()
		{
			return prenume + " " + nume;
		}

//metoda prin care atribuie un prenume 
		public void SchimbaPrenumele(string noulPrenume, string noulNume="popescu")  
		{
			prenume = noulPrenume;
			nume =noulNume;
		}


		//parametrul optional int vasrta sau string noulNume="popescu" pe care il si intializez si o sa pot apela metoda cu un singur param

		//daca ii initializez sunt param optionali, daca nu le dau vbaloare sunt obligatorii

		public void SchimbaNumePrenumeCNP(string noulNume, 
										string noulPrenume="prenume", 
										string noulCNP="CNP")
		{
			prenume = noulPrenume;
			nume = noulNume;
			cnp = noulCNP;
		}

	}
}

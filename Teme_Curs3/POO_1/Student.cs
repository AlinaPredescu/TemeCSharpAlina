using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static POO_1.Program;

namespace POO_1
{
	public class Student
	{
		private string nume;
		private string prenume;
		private short varsta;
		private string cnp;
		private string facultate;
		private SpecializareFacultate specializare;
		private float medie;

		public string GetNume()
		{
			return this.nume;
		}

		public void SetNume(string nume)
		{
			this.nume = nume;
		}

		public string GetPrenume()
		{
			return this.prenume;
		}


		public void SetPrenume(string prenume)
		{
			this.prenume = prenume;
		}

		public short GetVarsta()
		{
			return this.varsta;
		}

		public void SetVarsta(short varsta)
		{
			this.varsta = varsta;
		}


		public string GetCnp()
		{
			return this.cnp;
		}

		public void SetCnp(string cnp)
		{
			this.cnp = cnp;
		}


		public string GetFacultate()
		{
			return this.facultate;
		}

		public void SetFacultate(string facultate)
		{
			this.facultate = facultate;
		}

		public SpecializareFacultate GetSpecializare()
		{
			return this.specializare;
		}

		public void SetSpecializare(SpecializareFacultate specializare)
		{
			this.specializare = specializare;
		}

		public float GetMedie()
		{
			return this.medie;
		}

		public void SetMedie(float medie)
		{
			this.medie = medie;
		}


		public void PrinteazaInformatiiComplete()
		{
			Console.WriteLine("Studentul " + nume + " " + prenume + 
				", " + cnp + ", cu varsta de " + varsta + "ani este student al facultatii " +
				facultate + ", specializarea "+ specializare + ", avand media: "+ medie
				);
		}

	}
}

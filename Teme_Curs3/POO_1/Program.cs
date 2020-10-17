using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
	public  class Program
	{
		public enum SpecializareFacultate
		{Automatica=1,
			Electronica=2,
			Comunicatii=3,
			Auto=4,
			Finante=5,
			Contabilitate=6
		}
		static void Main(string[] args)
		{
			Student stud1 = new Student();

			stud1.SetNume("Ionescu");
			stud1.SetPrenume("Ion");
			stud1.SetVarsta(30);
			stud1.SetCnp("1901220171705");
			stud1.SetFacultate("ASE");
			stud1.SetSpecializare(SpecializareFacultate.Finante);
			stud1.SetMedie((float)9.57);

			stud1.PrinteazaInformatiiComplete();
			Console.WriteLine(" ");

			Student stud2 = new Student();

			stud2.SetNume("Popescu");
			stud2.SetPrenume("Ion");
			stud2.SetVarsta(25);
			stud2.SetCnp("1800518171704");
			stud2.SetFacultate("Politehnica");
			stud2.SetSpecializare(SpecializareFacultate.Automatica);
			stud2.SetMedie((float)8.45);

			stud2.PrinteazaInformatiiComplete();


			Console.ReadKey();
		}
	
	}
}

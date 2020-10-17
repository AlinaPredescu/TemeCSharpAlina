using System;


namespace Flow_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Curs 2 - Tema 2");
//PROIECT FLOW_1: se citeste un numar intreg de la tastatura; sa se afiseze daca numarul este par sau impar

			string xNr = Console.ReadLine();
			int x = Convert.ToInt32(xNr);

			bool par= x%2==0;

			Console.WriteLine(par);

			Console.ReadKey();

			}
	}
}

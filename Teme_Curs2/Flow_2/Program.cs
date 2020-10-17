using System;

namespace Flow_2
{
	class Program
	{
		static void Main(string[] args)
		{

			/*PROIECT FLOW_2: se citesc 2 numere intregi de la tastatura: sa se afiseze catul si restul impartirii lui a la b; 
			daca b este 0 atunci sa se afiseze un mesaj sugestiv, de ex: “Impartirea nu se poate realiza pentru ca b este 0”*/

			Console.WriteLine("Curs 2 - Tema 2");

			string aNr = Console.ReadLine();
			int a = Convert.ToInt32(aNr);

			string bNr = Console.ReadLine();
			int b = Convert.ToInt32(bNr);

			
			if (b == 0)
			{
				Console.WriteLine("Impartirea nu se poate realiza pentru ca b este 0");
			}
			else
			{
				int cat = a / b;
				Console.WriteLine("catul este: " + cat);
				int rest = a % b;
				Console.WriteLine("restul este: " + rest);
			}

			Console.ReadKey();
		}
	}
}

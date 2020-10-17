using System;
using System.Diagnostics.CodeAnalysis;

namespace Proiect_3
{
	class Program
	{
		static void Main(string[] args)
		{
//1) sa se afiseze pe ecran, pe o linie, mesajul “Curs C# - Proiectul 3”
			Console.WriteLine("Curs C# - Proiectul 3");

//2) se citesc de la tastatura 3 numere de tip short; sa se stocheze valorile citite in 3 variabile: var_a, var_b si var_c (de tip short);
			short var_a=short.Parse(Console.ReadLine());
			
			short var_b = short.Parse(Console.ReadLine());

			short var_c = short.Parse(Console.ReadLine());

//	3) sa se afiseze pe ecran pe o linie noua suma celor 3 variabile:
			
			Console.WriteLine("Suma celor 3 numere este: "+ (var_a + var_b + var_c));
//4) sa se afiseze pe ecran produsul dintre var_a si var_b:
			Console.WriteLine("Produsul este: " + var_a * var_b);

//5) sa se afiseze pe ecran pe o linie noua catul impartirii lui var_c la var_a
			Console.WriteLine("Catul este: " + var_c / var_a);

//6) sa se afiseze pe ecran pe o linie noua restul impartirii lui var_a la var_b
			Console.WriteLine("Restul este: " + var_a % var_b);

			/*7) sa se modifice valoarea variabilei var_a: sa se adauge valoarea lui var_b si sa se scada valoarea lui var_c
			8) sa se afiseze pe ecran noua valoare a lui var_a: */
			var_a = (short)(var_a + var_b - var_c);
			
			Console.WriteLine("Noua valoarea a lui a este: " + var_a);

/* 9) sa se declare o noua variabila de tip bool numita var_d initializata cu valoarea expresiei: (var_a > 0) && (var_b > 0) && (var_c > 0)
10) sa se afiseze pe ecran valoarea lui var_d: */

			bool var_d = (var_a > 0) && (var_b > 0) && (var_c > 0);

			Console.WriteLine("var_a, var_b, var_c sunt toate pozitive: " +var_d);

/*11) sa se declare o noua variabila de tip bool numita var_e initializata cu valoarea expresiei:
(var_a > 0) || (var_b > 0)
12) sa se afiseze pe ecran valoarea lui var_e: */

			bool var_e = (var_a > 0) || (var_b > 0);

			Console.WriteLine("cel putin una din variabilele var_a si var_b este pozitiva: " + var_e);

//13) sa se incrementeze valoarea lui var_a folosind operatorul ++

			var_a++;
			Console.WriteLine(var_a);

//14) folosind operatorul *= sa se inmulteasca noua valoare a lui var_a cu 5
//15) sa se afiseze pe ecran noua valoare a lui var_a:
			var_a *= 5;

			Console.WriteLine("noua valoare a lui a este: "+ var_a);


			Console.ReadKey();


		}
	}
}

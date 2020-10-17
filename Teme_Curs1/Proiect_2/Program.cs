using System;
using System.ComponentModel;

namespace Proiect_2
{
	class Program
	{
		static void Main(string[] args)
		{
//1) sa se afiseze pe ecran, pe o linie, mesajul “Curs C# - Proiectul 2”
			Console.WriteLine(" Curs C# - Proiectul 2");

/*2) sa se declare o variabila de tip int numita var_a
3) pe o linie separata sa se intializeze variabila cu valoarea -5
4) sa se afiseze pe ecran pe o linie noua valoarea variabilei var_a */
			int var_a;
			var_a = -5;

			Console.WriteLine("valoarea lui var_a este: "+ var_a);

/*5) sa se declare o variabila de tip bool numita var_b; variabila va fi initializata pe aceeasi linie de cod cu valoarea true
6) sa se modifice valoarea lui var_b; var_b va fi egal cu rezultatul testului: var_a > 0
7) sa se afiseze pe ecran daca var_a este mai mare ca 0 */

			//bool var_b = true;
			bool var_b = var_a > 0;

			Console.WriteLine("var_a este mai mare ca 0: "+ var_b);

// 8) sa se modifice valoarea varibilei var_a: sa se adauge valoarea 20
			var_a = var_a + 20;
			Console.WriteLine(var_a);

/*9) sa se modifice valoarea varibilei var_a: sa se imparta la 6
10) sa se afiseze pe ecran noua valoare a variabilei var_a */
			var_a = var_a / 6;
			Console.WriteLine("noua valoare a var_a este: " +var_a);

/*11) sa se declare o noua variabila var_c de tip float; variabila va fi initializata cu valoarea 1.25
12) sa se modifice valoarea variabilei var_c: sa se inmulteasca cu variabila var_a
13) sa se afiseze pe ecran noua valoare a variabilei var_c */

			float c = 1.25F;

			Console.WriteLine("valoarea variabilei c este: " + var_a * c);

/*14) sa se declare o noua variabila de tip short numita var_d; sa se initialize variabila cu valoarea 40000
15) ce observati? de ce?
16) comentati linia de cod scrisa la punctul 14 */

			//short var_d = 40000;// => short are valori intre -32768 si 32767

//17) sa se declare o noua variabila de tip uint numita var_d; tinand cont de faptul ca o alta variabila cu acelasi nume a fost declarata la punctul 14,
//explicati de ce programul nu da eroare de compilare

			uint var_d; //pt ca am comentat var_d la punctul 14

/*18) sa se asigneze valoarea -10 variabilei var_d
19) ce observati? de ce?
20) comentati linia de cod scrisa la punctul 18 */

//var_d = -10; //uint - are doar valori pozitive

/*21) pe aceeasi linie de cod declarati 3 variabile de tip long: var_e intializata cu valoarea 10, var_f neinitializata si var_g initializata cu valoarea 11
22) pe aceeasi linie de cod declarati 2 variabile: var_h de tip bool initializata cu valoarea false si var_i de tip char initializata cu valoarea ‘B’ */
		long var_e = 10, var_f, var_g = 11;

		bool var_h = false; char var_i = 'B';


Console.ReadKey();

}
}
}

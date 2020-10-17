using System;

namespace Flow_6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tema curs 2 proiect flow 6");

			int n = int.Parse(Console.ReadLine());
			int i;

			for (i = 1; i <= 10; i++)
			{
				Console.WriteLine( n + "X" + i + "="+ n * i);
		
			}
			Console.ReadKey();
		}
	}
}

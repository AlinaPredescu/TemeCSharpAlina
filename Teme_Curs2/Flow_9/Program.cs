using System;


namespace Flow_9
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Curs 2 - tema suplimentara - flow 9");

			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Pentru x= " + x);

			int nr0 = 0, nr1 = 1, fNr;

			for (int i = 0	; i < x; i++)
			{
				fNr = nr0 + nr1;
				nr1 = nr0;
				nr0 = fNr;

				Console.Write(fNr + ", ");
			}
			Console.ReadKey();

		}
	}
}

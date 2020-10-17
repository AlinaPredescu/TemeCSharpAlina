using System;


namespace Flow_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Curs 2 tema suplimentara - flow 8");

			int n  = int.Parse(Console.ReadLine());
			int i = 0;
			int j = 0;

			for (i = 0; i <= n; i++)
			{
				Console.WriteLine();

				for (j = 0; j < i; j++)
				{
					Console.Write(i);

				}
			}

			Console.ReadKey();
		}
	}
}

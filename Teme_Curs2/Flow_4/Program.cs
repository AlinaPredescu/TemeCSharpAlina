using System;


namespace Flow_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Proiect flow 4");

			string a =Console.ReadLine();
			double nr_a = Convert.ToDouble(a);

			string b = Console.ReadLine();
			double nr_b = Convert.ToDouble(b);

			double c = Math.Pow(nr_a, nr_b);
			Console.WriteLine("a la puterea b este: " + c);

			Console.ReadKey();
		}
	}
}

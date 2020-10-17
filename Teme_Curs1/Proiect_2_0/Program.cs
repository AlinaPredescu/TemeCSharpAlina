using System;

namespace Proiect_2_0
{
	class Program
	{
		static void Main(string[] args)
		{
			string zStr = Console.ReadLine();
			int z = Convert.ToInt32(zStr);

			string xStr= Console.ReadLine();
			int x = Convert.ToInt32(xStr);
			string yStr;
			int y;
			string rezultat = "";
			while (x > 0)
			{
				yStr = Console.ReadLine();
				y = Convert.ToInt32(yStr);

				if (z<y-x)
				{
					rezultat += " "+ x % 10;
				}
				else
				{
					rezultat += " " + y % 10;
				}
				x = y;
			}

			Console.WriteLine(rezultat);
			Console.ReadKey();
		}
	}
}




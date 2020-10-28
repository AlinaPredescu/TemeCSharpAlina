using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4_membriStatici
{
public static class ConvertorValutar
	{
		private static double rataEurRon = 4.6;
		public static double ConvertEurToRon(double sumaEur)
		{
			return sumaEur * rataEurRon;
		}

		//public double ConvertEurToDoubleRon(double sumaEur)
		//{
		//	return sumaEur*2* rataEurRon;
		//}

	}
}

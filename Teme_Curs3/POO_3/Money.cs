using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
	public class Money
	{
		public decimal Amount { get; set; }
		public string Currency { get; set; }


		public string GetAmountWithCurrency()
		{
			return Amount + " " + Currency;
		}

		public void MultiplyAmount(int factor)
		{
			Console.WriteLine(factor * Amount);
		}

	}
}

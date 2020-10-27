using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
	public class Money
	{
		//2 proprietati publice auto-implementate: Amount de tip decimal si Currency de tip string
		public decimal Amount { get; set; }
		public string Currency { get; set; }

		//1 constructor implicit care intializeaza Amount cu 0 si Currency cu “RON”
		public Money()
		{
			this.Amount = 0;
			this.Currency = "RON";
		}

		//1 constructor explicit cu 2 parametri amount si currency (parametrul currency este optional, valoare default = “EUR”)
		//cu care sunt initializate proprietatile clasei
		public Money(decimal amount, string currency)
		{
			this.Amount = amount;
			this.Currency = "EUR";
		}
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

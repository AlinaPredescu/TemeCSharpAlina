using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Curs4
{
	//creati clasa publica Money identica cu cea de curs, fara metoda de MultiplyAmount (nu va fi folosita);
	public class Money
	{
		public double Amount { get; set; }
		public string Currency { get; set; }


		public Money(double amount, string currency)
		{
			this.Amount = amount;
			this.Currency = currency;
		}
		public string GetAmountWithCurrency()
		{
			return Amount + " " + Currency;
		}

	}
}

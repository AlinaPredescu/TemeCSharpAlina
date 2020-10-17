using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
	class BankAccount
	{
		//o proprietate publica auto-implementata Balance de tip Money;
		public Money Balance { get; set; }

		//o metoda publica numita HasPositiveBalance fara parametri; metoda va returna True daca amountul balance-ului este mai mare ca 0, altfel va returna False;
		public bool HasPositiveBalance()
		{
			if (Balance.Amount >= 0)
			{ return true; }
			else
			{ return false; };
		}

		//o metoda privata numita HasEnoughAmount care primeste ca parametru o suma de bani (tip decimal); 
		//returneaza True daca amountul balance-ului este mai mare sau egal cu suma primita ca parametru; False in caz contrar;

		private bool HasEnoughAmount(decimal sumaPrimita1)
		{
			if (Balance.Amount >= sumaPrimita1)
			{ return true; }
			else
			{ return false; }
		}

		//o metoda publica numita DepositAmount care nu returneaza nimic; 
		//metoda primeste ca parametru un amount de tip decimal; se va adauga suma primita ca parametru la amountul balance-ului;

		public void DepositAmount(decimal sumaPrimita2)
		{
			Console.WriteLine(sumaPrimita2 + Balance.Amount);
		}


		//o metoda publica numita WithdrawAmount care nu returneaza nimic; metoda primeste ca parametru suma (tip decimal) de retras; 
		//se va scadea suma primita ca parametru din amountul balance-ului doar daca exista suficienti bani in cont (se va folosi metoda HasEnoughAmount)
		//=> daca nu exista suficienti bani in cont se va afisa un mesaj pe ecran: Contul nu dispune de <suma de retras> <currency-ul balance-ului>;

		public void WithdrawAmount(decimal sumaDeRetras)
		{
			if (HasEnoughAmount(sumaDeRetras))
			{
				decimal sold = Balance.Amount -= sumaDeRetras;
				Console.WriteLine("Soldul curent este: " + sold);
			}
			else
			{
				Console.WriteLine("Contul nu dispune de " + sumaDeRetras + ", soldul este de " + Balance.GetAmountWithCurrency());
			}		
			
		}

		//o metoda publica numita PrintCurrentBalance fara parametri; metoda nu returneaza nimic; metoda va afisa pe ecran mesajul: 
		//“In acest moment in cont aveti: <amount> <currency>”. Pentru afisare amount cu currency folositi metoda GetAmountWithCurrency a clasei Money;

		public void PrintCurrentBalance()
		{
			Console.WriteLine("In acest moment in cont aveti: " + Balance.GetAmountWithCurrency());
		}

	}
}

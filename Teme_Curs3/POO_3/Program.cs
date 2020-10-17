using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
	class Program
	{
				static void Main(string[] args)
		{

			/*sa se creeze un obiect de tip Money (numit myBalance):
			-setati proprietatile obiectului: Amount => 20, Currency => „EUR‟ */

			Money myBalance = new Money();
			myBalance.Amount = 20;
			myBalance.Currency = "EUR";

			//sa se creeze un obiect de tip BankAccount numit myAccount; setati proprietatea Balance cu obiectul myBalance
			BankAccount myAccount = new BankAccount();
			myAccount.Balance = myBalance;

			//sa se afiseze cati bani sunt in cont folosind metoda PrintCurrentBalance a clasei BankAccount;
			myAccount.PrintCurrentBalance();

			//sa se depuna in cont suma de 10 euro (folosind metoda DepositAmount);
			//sa se afiseze noua suma de bani care exista in cont;
			myAccount.DepositAmount(10);

			//sa se retraga din cont 100 euro (folosind metoda WithdrawAmount);
			//g. sa se afiseze noul cont pe ecran;
			myAccount.WithdrawAmount(100);

			//	sa se retraga din cont 15.5 euro;
			//sa se afiseze pe ecran valoarea currenta a contului;

			myAccount.WithdrawAmount((decimal)15.5);

			Console.ReadKey();
		}
	}
}

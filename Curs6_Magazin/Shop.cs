using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6_Magazin
{
	 class Shop
	{
		public List<Category> Categories { get; set; }
		public List<Product> Products	{ get; set; }
//constructorul
		public Shop()
		{
			//initializare lista
	Categories = new List<Category>();
	Products = new List<Product>();

		}

	}
}

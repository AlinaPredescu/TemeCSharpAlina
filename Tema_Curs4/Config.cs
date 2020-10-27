using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Curs4
{ /*
    creati o clasa publica statica numita Config; clasa are:
a. 3 proprietati publice statice auto-implementate:
 CategoriesFolder – string
 ProductsFolder – string
 DatabaseFolder – string */

	public static class Config
	{
		public static string CategoriesFolder { get; set; }
		public static string ProductsFolder { get; set; }
		public static string DatabaseFolder { get; set; }

		/*b. constructor static care initializeaza proprietatile clasei astfel:
 CategoriesFolder = “categories”
 ProductsFolder = “products”
 DatabaseFolder = “database” */

		static Config()
		{
			CategoriesFolder = "categories";
			ProductsFolder="products";
			DatabaseFolder = "database";
		}

	}
}

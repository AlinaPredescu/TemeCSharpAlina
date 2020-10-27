using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Curs4
{
	/*creati o clasa publica numita Product; clasa are:
a. 6 proprietati publice auto-implementate:
 Id - int
 Name - string
 Image - string
 CaterogyId - int
 Price – Money
 WeightInKg - float */

	class Product
	{
		public int Id { get; set; }
		public string  Name { get; set; }
		public string Image { get; set; }
		public int CategoryId { get; set; }

		public Money Price { get; set; }
		public float WeightInKg { get; set; }

		//b. 1 constructor explicit (cu parametri) care primeste 6 parametri id, name, 
		//image, categoryId, price si weight cu care sunt initializate proprietatile clasei;
		public Product(int id, string name, string image, int categoryId, Money price, float weight)
		{
			this.Id = id;
			this.Name = name;
			this.Image = image;
			this.CategoryId = categoryId;
			this.Price = price;
			this.WeightInKg = weight;
		}

	}
}

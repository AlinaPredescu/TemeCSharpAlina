using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Curs4
{
	/*creati o clasa publica numita Category; clasa are:
a. 4 proprietati publice auto-implementate:
 Id - int
 Name - string
 Image - string
 IsNew - bool */

	class Category
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Image { get; set; }
		public  bool IsNew { get; set; }
		
		//b. 1 constructor implicit (fara parametri) care intializeaza Id cu 0, Name cu “”, Image cu “” si IsNew cu True;

		public Category()
		{
			Id = 0;
			Name = "";
			Image = "";
			IsNew = true;
		}
		//c. 1 constructor explicit (cu parametri) care primeste 4 parametri id, name, image si isNew cu care sunt initializate proprietatile clasei;
		public Category(int id, string name, string image, bool isNew)
		{
			this.Id = id;
			this.Name = name;
			this.Image = image;
			this.IsNew = isNew;
		}

	}
}

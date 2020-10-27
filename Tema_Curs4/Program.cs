using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Curs4
{
	class Program
	{
		static void Main(string[] args)
		{
//a. sa se creeze un obiect de tip Category (numit categ1) folosind constructorul explicit: 1, “Prima Categorie”, “categorie_1.jpg”, True;
			Category categ1 = new Category(id: 1, name: "Prima Categorie", image:"categorie_1.jpg", isNew: true ) ;

//b. sa se creeze un obiect de tip Category (numit categ2) folosind constructorul explicit: 2, “A Doua Categorie”, “categorie_2.jpg”, False;
			Category categ2 = new Category(id: 2, name: "A doua Categorie", image: "categorie_2.jpg", isNew: false);

//	c.sa se creeze un obiect de tip Money(numit priceProd1) folosind constructorul explicit: 10, RON;

			Money priceProd1=new Money(amount: 10, currency: "RON");

//d. sa se creeze un obiect de tip Product (numit prod1) folosind constructorul explicit: 1, “Produs 1”, “produs_1.jpg”, 1, priceProd1, 0.5;
			Product prod1 = new Product(id:1, name:"Produs 1", image:"produs_1.jpg", categoryId:1, price: priceProd1, weight: 0.5F);

//e. sa se creeze un obiect de tip Money (numit priceProd2) folosind constructorul explicit: 15.5, RON;
			Money priceProd2 = new Money(amount: 15.5, currency: "RON");

//f. sa se creeze un obiect de tip Product (numit prod2) folosind constructorul explicit: 2, “Produs 2”, “produs_2.jpg”, 1, priceProd2, 0.75;
			Product prod2 = new Product(id: 2, name: "Produs 2", image: "produs_2.jpg", categoryId: 1, price: priceProd2, weight: 0.75F);

//g. sa se creeze un obiect de tip Money (numit priceProd3) folosind constructorul explicit: 7.5, RON;
			Money priceProd3 = new Money(amount: 7.5, currency: "RON");

//h. sa se creeze un obiect de tip Product (numit prod3) folosind constructorul explicit: 3, “Produs 3”, “produs_3.jpg”, 2, priceProd3, 1.25;
			Product prod3 = new Product(id: 3, name: "Produs 3", image: "produs_3.jpg", categoryId: 2, price: priceProd2, weight:1.25F);
		}
	}
}

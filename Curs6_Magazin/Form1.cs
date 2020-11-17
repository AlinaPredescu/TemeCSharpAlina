using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace Curs6_Magazin
{
	public partial class Form1 : Form
	{
		//declarare camp
		private Shop _coffeeShop;
		//constructorul form 1 este cel de mai jos:
		public Form1()
		{
			//creare obiect
			_coffeeShop = new Shop();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Category category1 = new Category(0, "tchibo", "cafea macinata proaspat");
			Category category2 = new Category(1, "elite", "cafea boabe");
			Category category3 = new Category(2, "nesscaffe", "cafea la kg");
			//adaugare categorie1 in lista mea
			_coffeeShop.Categories.Add(category1);
			_coffeeShop.Categories.Add(category2);
			_coffeeShop.Categories.Add(category3);

			RefreshComboBox();
			////	//in combobox se va prelua lista noua (mai inati golesc, apoi afisez)
			//comboBox1.DataSource = null;
			//comboBox1.DataSource = _coffeeShop.Categories;
			//comboBox1.DisplayMember = "Nume";
			//comboBox1.ValueMember = "Id";

			comboBox1.DataSource = _coffeeShop.Categories;
			comboBox1.DisplayMember = "Nume";
			comboBox1.ValueMember = "Id";

			//mai scurt scris:
			//_coffeeShop.Categories.Add(new Category(0, "tchibo", "cafea macinata proaspat"));

			_coffeeShop.Products.Add(new Product(0, "Espressor automat",
				"Espressor automat DeLonghi Magnifica ESAM3000B, 1450 W, 1.8 L, 15 bar, Negru; Compatibil atat cu cafea boabe si cat si macinata; Tehnologia CRF asigura macinarea instanta a cafelei necesara fix pentru cafeaua ta pentru un plus de savoare, " +
		         "Sistemul Thermoblock incalzeste rapid apa la temperatura perfecta, Camera duala permite prepararea a doua bauturi simultan",
				2699.99));


			_coffeeShop.Products.Add(new Product(1, "Macinator cafea",
				"Motor puternic: Sistemul de frezare FlatBurr cu disc de polizor din otel inoxidabil si putere de 200 de wati." +
				" Grosier pana la foarte fin: 18 grade de macinare selectabile pentru specialitati din pulbere din presa franceza pana la Espresso." +
				"Cafeaua mereu proaspata: dozator de cantitate practică pentru 2 - 12 cupe", 
				229));

			_coffeeShop.Products.Add(new Product(2, "Excelsa cafetiera",
				"Unul pentru toti: masina de cafea mare pentru aplicatii versatile. Populara pentru toata lumea: potrivita pentru cantine, hoteluri, intreprinderi mici si conferinte. Sigur si protejat: " +
				"datorita capacului din otel inoxidabil cu dispozitiv de inchider",
				349));

			_coffeeShop.Products.Add(new Product(3, "Filtru cafea",
				"Filtru cafea/ceai, sticlă/inox1 l",
				49.90));

			_coffeeShop.Products.Add(new Product(4, "Capsule cafea",
				" Acest espresso este menit sa incante toate simturile - aromele dulci-amarui de migdale si vanilie completeaza minunat notele de cereale" +
				" si malt specifice boabelor de cafea Arabica din America de Sud.",
				2.40));
				}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (Category item in _coffeeShop.Categories)
			{
				label1.Text += item.Nume + " ";
				RefreshComboBox();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			frmAddCategory addForm = new frmAddCategory();
			DialogResult raspuns = addForm.ShowDialog();

			if (raspuns == DialogResult.OK)
			{
				_coffeeShop.Categories.Add(addForm.CategorieAdaugata);

			}
		}


		private void afiseazaProdusButton_Click(object sender, EventArgs e)
		{
			//ca sa pot vedea denumirea intreaga a numelui in list box
			listView1.View = System.Windows.Forms.View.List;

			foreach (Product item in _coffeeShop.Products)
			{  
				listView1.Items.Add(item.Nume);
			}

		}

		private void adaugaProdusButton_Click(object sender, EventArgs e)
		{
			frmAddProduct addForm = new frmAddProduct();
			DialogResult raspuns = addForm.ShowDialog();

			if (raspuns == DialogResult.OK)
			{
				_coffeeShop.Products.Add(addForm.ProdusAdaugat);
			}
		}

		public void RefreshComboBox()
		{
			//in combobox se va prelua lista noua (mai inati golesc, apoi afisez)
			comboBox1.DataSource = null;
			comboBox1.DataSource = _coffeeShop.Categories;
			comboBox1.DisplayMember = "Nume";
			comboBox1.ValueMember = "Id";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//afisez daca a fost selectat produsl nescafe
//cauta doar daca e scris cu litera mica

			comboBox1.BackColor =  Color.MidnightBlue;
			Category cat = (Category)comboBox1.SelectedItem;
				if (cat.Nume == "nesscafe")
			{
				MessageBox.Show ("bravo");
			}
//poate fi si cu litera mare, de acceea se uita la index
			if ((int)comboBox1.SelectedValue == 2)
			{
				MessageBox.Show("bravo");
			
			}
		}
//XML scriu in xml
		private void button4_Click(object sender, EventArgs e)
		{
			Product prod1 = new Product();
			prod1.Id = 5;
			prod1.Nume = "bicicleta";
			prod1.Descriere = "aceasta este o bicicleta";
			prod1.Pret = 7;

		Product	prod2 = new Product();
			prod2.Id = 6;
			prod2.Nume = "motocicleta";
			prod2.Descriere = "aceasta este o moto";
			prod2.Pret = 17;

			_coffeeShop.Products.Add(prod1);
			_coffeeShop.Products.Add(prod2);


			XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
			StreamWriter streamWriter = new StreamWriter("C:/Users/alina/Desktop/curs8 destinatie/prod1.xml");
			xml.Serialize(streamWriter, _coffeeShop.Products);
			streamWriter.Close();
					}
//deserializeaza = preia informatia din xml
		private void button5_Click(object sender, EventArgs e)
		{
			XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
			StreamReader streamReader = new StreamReader("C:/Users/alina/Desktop/curs8 destinatie/prod1.xml");
			List<Product>products = (List<Product>)(xml.Deserialize(streamReader));
			streamReader.Close();

			tabel.DataSource = _coffeeShop.Products;

		}

		private void button6_Click(object sender, EventArgs e)
		{
			XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
			StreamWriter streamWriter = new StreamWriter("C:/Users/alina/Desktop/curs8 destinatie/prod1.xml");
			xml.Serialize(streamWriter, tabel.DataSource);
			streamWriter.Close();
		}
	}
}

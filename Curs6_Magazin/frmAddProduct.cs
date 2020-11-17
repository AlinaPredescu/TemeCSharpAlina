using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6_Magazin
{
	public partial class frmAddProduct : Form
	{
		public Product ProdusAdaugat { get; set; }
		public frmAddProduct()
		{
			InitializeComponent();
		}

		
		 
		private void adaugaProdusButton_Click(object sender, EventArgs e)
		{
			int id=(int)produsNumericUpDown.Value;
			string nume = numeProdusTextBox.Text;
			string descriere = descriereProdusTextBox.Text;
			double pret;
			pret = double.Parse(pretProdusTextBox.Text);
			ProdusAdaugat = new Product(id, nume, descriere, pret);

			DialogResult = DialogResult.OK;
		}
	}
}

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
	public partial class frmAddCategory : Form
	{
		public Category CategorieAdaugata { get; set; }
		public frmAddCategory()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int id = (int)numericUpDown1.Value;
			string nume = textBox1.Text;
			string descriere = textBox2.Text;
			CategorieAdaugata = new Category(id, nume, descriere);

			DialogResult = DialogResult.OK;

			}
	}
}

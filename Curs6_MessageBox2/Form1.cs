using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6_MessageBox2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string masina1 = "nissan";
			string masina2 = "ford";
			string masina3 = "audi";
//array
			string[] masini = new string[3] { "nisan", "ford", "audi" };
			int[] numere = new int[2] { 0, 1 };
			string[] masini2 = new string[3];
			masini2[0] = "nissan";
			masini2[1] = "ford";
			masini2[2] = "audi";
//afisam ford:
			MessageBox.Show(masini[1]);

//lungime array
			MessageBox.Show("lungime array este " + masini.Length);


			for (int i = 0; i < masini.Length; i++)
			{
				label1.Text += masini[i] + " - ";
			}

			//eroare - indexul nu este in array
			//	MessageBox.Show(numere[193].ToString());

			//un for mai compact
			foreach (string item in masini)
			{
				label1.Text += item + " - ";
			}

			Category[] categorii = new Category[3];
//declarare lista de masini
			List<string> listaDeMasini = new List<string>();
			listaDeMasini.Add("nissan");
			listaDeMasini.Add("ford");
			listaDeMasini.Add("audi");
			listaDeMasini.Add("vw");
//dimensiunea listei
			MessageBox.Show("dimensiunea listei este " + listaDeMasini.Count);
//accesarea unui element din lista
			MessageBox.Show("dimensiunea listei este " + listaDeMasini[1]);
			listaDeMasini.Sort();
			MessageBox.Show(listaDeMasini[0]);
//sterge din lista indexul 1 (dupa ce au fost sortate)
			listaDeMasini.RemoveAt(1);

			foreach (string item in listaDeMasini)
			{
				label1.Text += item;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			CustomDialog customDialog = new CustomDialog();
			//customDialog.ShowDialog();
			DialogResult raspuns = customDialog.ShowDialog();

			if (raspuns == DialogResult.Yes)
			{
				label1.Text = "bine";
			}

			else
			{
				label1.Text = "rau";
			}
		}
	}
}

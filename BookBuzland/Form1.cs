using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace BookBuzland
{
	public partial class Form1 : Form
	{
		private readonly object carteDataGridView;
		public Biblioteca biblioteca;
		public Form1()
		{
			biblioteca = new Biblioteca();
			InitializeComponent();
		}
//adauga carte
		private void adaugaCartiButton_Click(object sender, EventArgs e)
		{
			frmAdaugaCarte addForm = new frmAdaugaCarte();
			DialogResult raspuns = addForm.ShowDialog();

			if (raspuns == DialogResult.OK)
			{
				biblioteca.Carti.Add(addForm.CarteAdaugata);

				XmlSerializer xml = new XmlSerializer(typeof(List<Carte>));
				StreamWriter streamWriter = new StreamWriter("C:/Users/alina/Desktop/curs8 destinatie/carti.xml");
				xml.Serialize(streamWriter, biblioteca.Carti);
				streamWriter.Close();

			}
		}
//afisare carti in data grid form afisare
		private void afisareCartiButton_Click(object sender, EventArgs e)
		{
			frmAfisareCarti addForm = new frmAfisareCarti();
			Control[] controls = addForm.Controls.Find("afisareCartiDataGridView", true);
			DataGridView afisareCarti = (DataGridView)controls[0];
			afisareCarti.DataSource = biblioteca.Carti;
			DialogResult raspuns = addForm.ShowDialog();

		}
//ca sa nu suprascriu xml-ul:
		private void Form1_Load(object sender, EventArgs e)
		{
			XmlSerializer xml = new XmlSerializer(typeof(List<Carte>));
			StreamReader streamReader = new StreamReader("C:/Users/alina/Desktop/curs8 destinatie/carti.xml");
			biblioteca.Carti = (List<Carte>)xml.Deserialize(streamReader);
			streamReader.Close();
		}

		private void cautaButton_Click(object sender, EventArgs e)
		{
			string carteCautata = cautaTextBox.Text;

			BindingList<Carte> cartiFiltrate = new BindingList<Carte>();

			foreach (Carte carte2 in biblioteca.Carti)
			{
				if (carte2.Titlu == carteCautata)
				{
					cartiFiltrate.Add(carte2);

				}

			}

			if (cartiFiltrate.Count == 0)
			{
				MessageBox.Show("Cartea nu a fost gasita");
			}
			else
			{
				frmAfisareCarti addForm = new frmAfisareCarti();
				Control[] controls = addForm.Controls.Find("afisareCartiDataGridView", true);
				DataGridView afisareCarti = (DataGridView)controls[0];
				afisareCarti.DataSource = cartiFiltrate;
				DialogResult raspuns = addForm.ShowDialog();
			}
		}
	}
}

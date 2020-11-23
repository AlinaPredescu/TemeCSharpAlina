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


		//private readonly object carteDataGridView;
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

//pt a-si face refresh gridul dupa ce adaug o carte noua				
				StreamReader streamReader = new StreamReader("C:/Users/alina/Desktop/curs8 destinatie/carti.xml");
				biblioteca.Carti = (List<Carte>)xml.Deserialize(streamReader);
				streamReader.Close();
				dataGridView.DataSource = biblioteca.Carti;


				Form1_Load(null,null);

			}
		}
//afisare carti in data grid form afisare - disable
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
			dataGridView.DataSource = biblioteca.Carti;

//afisare numar total carti
			totalCartiTextBox.Text = dataGridView.Rows.Count.ToString();

//afisare nr carti citite
			int nrCartiCitite = 0;

			foreach (Carte carteCitita in biblioteca.Carti)
			{
				if (carteCitita.Citita == true)
				{
					nrCartiCitite++;
										
				}
			}
			nrCartiCititeTextBox.Text = nrCartiCitite.ToString();

//afisare nr carti cu autograf
			int nrCartiAutograf = 0;

			foreach (Carte carteCuAutograf in biblioteca.Carti)
			{
				if (carteCuAutograf.CuAutograf == true)
				{
					nrCartiAutograf++;
				}
			}
			cuAutografTextBox.Text = nrCartiAutograf.ToString();

//afisare nr carti imprumutate
			int nrCartiImprumutate = 0;
			foreach (Carte carteImprumutata in biblioteca.Carti)
			{
				if (carteImprumutata.Imprumutata == true)
				{
					nrCartiImprumutate++;
				}
			}
			imprumutataTextBox.Text = nrCartiImprumutate.ToString();
		}


//cauta
		private void cautaTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			string carteCautata = cautaTextBox.Text;
			
			BindingList<Carte> cartiFiltrate = new BindingList<Carte>();

			foreach (Carte carte2 in biblioteca.Carti)
			{
				if (carte2.Titlu.StartsWith(carteCautata))
				{
					cartiFiltrate.Add(carte2);
				}
			}

			if (cartiFiltrate.Count == 0)
			{
				cautaTextBox.BackColor = Color.Red;
			}
			else
			{
				dataGridView.DataSource = cartiFiltrate;
				cautaTextBox.BackColor = Color.White;
				totalCartiTextBox.Text = dataGridView.Rows.Count.ToString();
			}
		}

//la editare casuta din grid view vreau sa se actualizeze xml-ul		
		private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			XmlSerializer xml = new XmlSerializer(typeof(List<Carte>));
			StreamWriter streamWriter = new StreamWriter("C:/Users/alina/Desktop/curs8 destinatie/carti.xml");
			xml.Serialize(streamWriter, biblioteca.Carti);
			streamWriter.Close();
		}
	}
}

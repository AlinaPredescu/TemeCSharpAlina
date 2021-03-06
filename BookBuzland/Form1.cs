﻿using System;
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

//creare xml in folderul unde am aplicatia
		string path=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Carti.xml");

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
				StreamWriter streamWriter = new StreamWriter(path);
				xml.Serialize(streamWriter, biblioteca.Carti);
				streamWriter.Close();

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
			StreamReader streamReader = new StreamReader(path);
			biblioteca.Carti = (List<Carte>)xml.Deserialize(streamReader);
			streamReader.Close();
			dataGridView.DataSource = biblioteca.Carti;

//afisare numar total carti
			totalCartiTextBox.Text = dataGridView.Rows.Count.ToString();
			int totalCarti = dataGridView.Rows.Count;

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
//valoare progress bar
			
			toolStripProgressBar.Maximum = totalCarti;
			toolStripProgressBar.Value = nrCartiCitite;

		}


//cauta dupa titlu, autor si tip
		private void cautaTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			string carteCautata = cautaTextBox.Text;
			
			BindingList<Carte> cartiFiltrate = new BindingList<Carte>();

			foreach (Carte carte2 in biblioteca.Carti)
			{
				if (carte2.Titlu.StartsWith(carteCautata) || carte2.Autor.StartsWith(carteCautata)
					|| carte2.Tip.StartsWith(carteCautata))
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
			StreamWriter streamWriter = new StreamWriter(path);
			xml.Serialize(streamWriter, biblioteca.Carti);
			streamWriter.Close();

			Form1_Load(null, null);
		}

//afisare carti imprumutate
		private void imprumutataCheckBox_CheckedChanged(object sender, EventArgs e)
		{			
			BindingList<Carte> cartiFiltrateImprumutate = new BindingList<Carte>();

			foreach (Carte carte3 in biblioteca.Carti)
			{
				if (carte3.Imprumutata ==true || imprumutataCheckBox.Checked==false)
					{
					cartiFiltrateImprumutate.Add(carte3);
				}
			}

			if (cartiFiltrateImprumutate.Count == 0)
			{
				MessageBox.Show("Nu aveti carti imprumutate");
				imprumutataCheckBox.Checked = false;
			}
			else
			{
				dataGridView.DataSource = cartiFiltrateImprumutate;
			}
		
		}

//afisare carti cu autograf
		private void cuAutografCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			BindingList<Carte> cartiFiltrateCuAutograf = new BindingList<Carte>();

			foreach (Carte carte3 in biblioteca.Carti)
			{
				if (carte3.CuAutograf == true || cuAutografCheckBox.Checked == false)
				{
					cartiFiltrateCuAutograf.Add(carte3);
				}
			}

			if (cartiFiltrateCuAutograf.Count == 0)
			{
				MessageBox.Show("Nu aveti carti cu autograf");
				cuAutografCheckBox.Checked = false;
			}
			else
			{
				dataGridView.DataSource = cartiFiltrateCuAutograf;
			}
		}

//afisare necitite

		private void necititeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			BindingList<Carte> CartiNecitite = new BindingList<Carte>();

			foreach (Carte carte4 in biblioteca.Carti)
			{
				if (carte4.Citita == false || necititeCheckBox.Checked == false)
				{
					CartiNecitite.Add(carte4);
				}
			}

			if (CartiNecitite.Count == 0)
			{
				MessageBox.Show("Nu aveti carti necitite");
				necititeCheckBox.Checked = false;
			}
			else
			{
				dataGridView.DataSource = CartiNecitite;
			}
		}

//sterge carte

		private int rowIndex = 0;
		private void dataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{

			if (e.Button == MouseButtons.Right)
			{
				this.dataGridView.Rows[e.RowIndex].Selected = true;
				this.rowIndex = e.RowIndex;
				this.dataGridView.CurrentCell = this.dataGridView.Rows[e.RowIndex].Cells[1];
				this.contextMenuStrip1.Show(this.dataGridView, e.Location);
				contextMenuStrip1.Show(Cursor.Position);
			}
		}
				
		private void contextMenuStrip1_Click_1(object sender, EventArgs e)
		{
			if (!this.dataGridView.Rows[this.rowIndex].IsNewRow)
			{
				Carte carte = (Carte)this.dataGridView.Rows[rowIndex].DataBoundItem;
				biblioteca.Carti.Remove(carte);
				dataGridView_CellValueChanged(null, null);
			}
		}
	}
}

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
	public partial class frmAdaugaCarte : Form
	{
		private object carteDataGridView1;

		public Carte CarteAdaugata { get; set; }


		public frmAdaugaCarte()
		{
			InitializeComponent();
		}

		public frmAdaugaCarte(object carteDataGridView1)
		{
			this.carteDataGridView1 = carteDataGridView1;
		}

		private void carteAdaugataButton_Click(object sender, EventArgs e)
		{
			string titlu = titluTextBox.Text;
			string autor = autorTextBox.Text;
			int anAparitie;
			anAparitie = int.Parse(anAparitieTextBox.Text);
			string tip = tipComboBox.Text;
			bool citita = cititaCheckBox.Checked;
			bool cuAutograf = cuAutografCheckBox.Checked;
			bool imprumutata = imprumutataCheckBox.Checked;
			string comentarii = comentariiRichTextBox.Text;

			CarteAdaugata = new Carte(titlu, autor, anAparitie, tip, citita, cuAutograf,imprumutata,comentarii);
			DialogResult = DialogResult.OK;

			
			}

		private void comentariiRichTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void imprumutataCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void cuAutografCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void cititaCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void comentariiLabel_Click(object sender, EventArgs e)
		{

		}

		private void imprumutataLabel_Click(object sender, EventArgs e)
		{

		}

		private void cititaLabel_Click(object sender, EventArgs e)
		{

		}

		private void anuleazaButton_Click(object sender, EventArgs e)
		{

			titluTextBox.Text="";
			autorTextBox.Text="";
			anAparitieTextBox.Text="";
			tipComboBox.Text="";
			cititaCheckBox.Checked=false;
			cuAutografCheckBox.Checked = false;
			imprumutataCheckBox.Checked=false;
			comentariiRichTextBox.Text="";
			Close();
		}
	}
}

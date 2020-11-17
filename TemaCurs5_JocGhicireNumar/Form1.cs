using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TemaCurs5_JocGhicireNumar
{
	public partial class GhicesteNumarulForm : Form
	{
		public int nr { get; set; }
		public int x = 0;
		public GhicesteNumarulForm()
		{
			InitializeComponent();
		}

		private void GhicesteNumarulForm_Load(object sender, EventArgs e)
		{ 
			nr = new Random().Next(0, 10);
					
			numarGeneratLabel.Text = "numarul generat este " + nr;
		
		}


		private void verificaButton_Click(object sender, EventArgs e)
		{
			try
			{

				string numarGhicit_mesaj = numarTextBox.Text;
				int numarGhicit = Convert.ToInt32(numarGhicit_mesaj);
				x++;

				if (numarGhicit<0 || numarGhicit >10)
					{
					afiseazaErrorForm();
				}

				else if	(nr != numarGhicit)
				{
					mesaj1Label.Text = "Numarul nu a fost ghicit, reincearca!";
					refreshButton.Visible = true;
					verificaButton.Visible = false;
					numarTextBox.Text = "";
					numarLabel.Visible = false;
					numarTextBox.Visible = false;
					BackColor = Color.LightYellow;
				}
				else if (nr == numarGhicit && x == 1)
				{
					mesaj2Label.MaximumSize = new Size(250, 0);
					mesaj2Label.AutoSize = true;
					mesaj2Label.Text = "Felicitari, ai ghicit numarul din prima incercare!";
					x = 0;
					refreshButton.Visible = false;
					verificaButton.Visible = false;
					this.BackgroundImage = global::TemaCurs5_JocGhicireNumar.Properties.Resources.emoji;
					numarLabel.Visible = false;
					numarTextBox.Visible = false;
					jocNouButton.Visible = true;
				}
				else
				{
					mesaj2Label.MaximumSize = new Size(250, 0);
					mesaj2Label.AutoSize = true;
					mesaj2Label.Text = "Felicitari, ai ghicit numarul din " + x + " incercari!";
					x = 0;
					refreshButton.Visible = false;
					verificaButton.Visible = false;
					this.BackgroundImage = global::TemaCurs5_JocGhicireNumar.Properties.Resources.emoji;
					numarLabel.Visible = false;
					numarTextBox.Visible = false;
					jocNouButton.Visible = true;
				}
			}
			catch (Exception)

			{
				afiseazaErrorForm();
			}

		}

		public void afiseazaErrorForm()
		{
			errorForm settingsForm = new errorForm();
			settingsForm.Show();
			numarTextBox.BackColor = Color.Red;
		}


			private void numarTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		
		private void refreshButton_Click_1(object sender, EventArgs e)
		{
			numarTextBox.Text = "";
			mesaj1Label.Text = "";
			mesaj2Label.Text = "";
		//	nr = new Random().Next(0, 10);
			numarGeneratLabel.Text = "numarul generat este " + nr;
			verificaButton.Visible = true;
			numarLabel.Visible = true;
			numarTextBox.Visible = true;
			refreshButton.Visible = false;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
		}

		private void jocNouButton_Click(object sender, EventArgs e)
		{
			nr = new Random().Next(0, 10);
			numarGeneratLabel.Text = "numarul generat este " + nr;
			x = 0;
			numarLabel.Visible = true;
			numarTextBox.Visible = true;
			BackColor =System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			verificaButton.Visible = true;
			numarTextBox.Text = "";
			this.BackgroundImage = null;
			mesaj2Label.Text = "";
			jocNouButton.Visible = false;
		}
	}
}

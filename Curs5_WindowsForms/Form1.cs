using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs5_WindowsForms
{
	public partial class Aplicatie : Form
	{
		public Aplicatie()
		{
			InitializeComponent();
		}

		private void ClickButton_Click(object sender, EventArgs e)

		{
//setare proprietate text box
			//NameTextBox.Multiline = true;

//afisare nume in pop-up
			//MessageBox.Show("Bine ai venit, "+ NameTextBox.Text);

//afisare nume in label
			//MessageLabel.Text = "Bine ai venit, " + NameTextBox.Text;

//afisare mesaj in label  + preluare din combo box + mesaj radio button
			MessageLabel.Text = "Bine ai venit, " + NameTextBox.Text+ " din " + CountriesComboBox.SelectedItem;
			if (radioButton1.Checked)
			{
				MessageBox.Show("welcome");
			}
			else if (radioButton2.Checked == true)
			{
				MessageBox.Show("Bine ai venit");
			}

			else
			{
				MessageBox.Show("nimic");
			}

//Sterge ce am scris in textBox
			NameTextBox.Text = "";
//debifare radio Button
			radioButton1.Checked = false;
			radioButton2.Checked = false;

//preluare in label textul din text box
			//label1.Text = NameTextBox.Text;

		}

		private void NameLabel_Click(object sender, EventArgs e)
		{

		}

		private void Aplicatie_Load(object sender, EventArgs e)
		{

		}

		//private void Aplicatie_MouseClick(object sender, MouseEventArgs e)
		//{
		//	MessageBox.Show("ati dat primul mouse click in aplicatie");
		//	MessageBox.Show("mesaj2");
		//}

		//private void Aplicatie_MouseClick2(object sender, MouseEventArgs e)
		//{
		//	MessageBox.Show("mesaj2");
		//}


	}

}

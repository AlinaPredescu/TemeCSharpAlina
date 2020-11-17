using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaCurs5_Declaratie
{
	public partial class declaratieForm : Form
	{
		public declaratieForm()
		{
			InitializeComponent();
		}

		private void declaratieForm_Load(object sender, EventArgs e)
		{
			dataDeclaratieiFillLabel.Text = dataDeclartieiDateTimePicker.Text;
		}

		
		private void numeTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			numeFillLabel.Text = numeTextBox.Text;
		}

		private void prenumeTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			prenumeFillLabel.Text = prenumeTextBox.Text;

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			dataNasteriiFillLabel.Text = DNdateTimePicker.Text;
		}

		private void adresaLocuintaTextBox1_KeyUp(object sender, KeyEventArgs e)
		{
			adresaLocuintaFillLabel1.Text = adresaLocuintaTextBox1.Text;
		}

		private void adresaLocuintaTextBox2_KeyUp(object sender, KeyEventArgs e)
		{
			adresaLocuintaFillLabel2.Text = adresaLocuintaTextBox2.Text;
		}

		private void loculDeplasariiTextBox_KeyUp(object sender, KeyEventArgs e)
		{
			loculDeplasariiFillLabel.Text = loculDeplasariiTextBox.Text;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			//radioButton1FillLabel.Text = radioButton1.Checked;
		}

		

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox1.Checked = checkBox1.Checked;
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox2.Checked = checkBox2.Checked;
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox3.Checked = checkBox3.Checked;
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox4.Checked = checkBox4.Checked;
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox5.Checked = checkBox5.Checked;
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox6.Checked = checkBox6.Checked;
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox7.Checked = checkBox7.Checked;
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox8.Checked = checkBox8.Checked;
		}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox9.Checked = checkBox9.Checked;
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			FillcheckBox10.Checked = checkBox10.Checked;
		}

		private void dataDeclartieiDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			dataDeclaratieiFillLabel.Text = dataDeclartieiDateTimePicker.Text;
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6_MessageBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult rezultat = new DialogResult();
			rezultat=MessageBox.Show("mesaj ce trebuie afisat","titlu" , 
				MessageBoxButtons.YesNoCancel, 
				MessageBoxIcon.Exclamation,
				MessageBoxDefaultButton.Button1);

			if (rezultat == DialogResult.Yes)
			{
				label1.Text = "ati dat yes";
			}

			else if (rezultat == DialogResult.No)
			{
				label1.Text = "ati dat no";
			}
			else
			{
				label1.Text = "ati inchis";
			}

			}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				//checkBox4.Visible = true;
				//label1.Visible = true;
				//button1.Visible = true;
				panel1.Visible = true;
			}
			else
			{
				//checkBox4.Visible = false;
				//label1.Visible = false;
				//button1.Visible = false;
				panel1.Visible = false;
			}

			}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("load");
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			MessageBox.Show("shown");
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			MessageBox.Show("aplicatia se inchide");
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			MessageBox.Show("aplicatia s-a inchis");
		}
	}
}

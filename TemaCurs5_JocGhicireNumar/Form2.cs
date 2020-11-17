using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaCurs5_JocGhicireNumar
{
	public partial class errorForm : Form
	{
		public errorForm()
		{
			InitializeComponent();
		}

		private void errorForm_Load(object sender, EventArgs e)
		{

		}

		private void errorForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			GhicesteNumarulForm f1 = (GhicesteNumarulForm)Application.OpenForms["GhicesteNumarulForm"];
			Control tb= f1.Controls["numarTextBox"];
			tb.BackColor = Color.White;
			tb.Text = "";
		}
	}
}

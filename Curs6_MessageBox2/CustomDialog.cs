using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Curs6_MessageBox2
{
	public partial class CustomDialog : Form
	{
		public CustomDialog()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			this.DialogResult = DialogResult.Yes;
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
		}
	}
}

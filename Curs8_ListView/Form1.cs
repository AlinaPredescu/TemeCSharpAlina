using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs8_ListView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			listView1.GridLines = true;
			listView1.Columns.Add("Locatie", -2, HorizontalAlignment.Left);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textName.Text != "" && textPrenume.Text != "")
			{
				ListViewItem item = new ListViewItem(textName.Text);
				item.SubItems.Add(textPrenume.Text);
				item.SubItems.Add(textName.Text);
				item.SubItems.Add(textLocatie.Text);
				listView1.Items.Add(item);
				textName.Clear();
				textPrenume.Clear();
				textLocatie.Clear();
			}
		
		}
	}
}

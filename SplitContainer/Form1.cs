using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitContainer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

//adaugare noduri
			treeView1.Nodes.Add("obiect 0");
//adaugare copii
			treeView1.Nodes[1].Nodes.Add("copil ob 0");
			treeView1.Nodes[1].Nodes.Add("copil ob 1");
		}

		private void adaugaCartiButton_Click(object sender, EventArgs e)
		{
			//treeView1.Nodes[1].Nodes.Add("alina");		
	 }
	}
}

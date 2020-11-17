using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Curs8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string path = "C:/Users/alina/Desktop/curs8 sursa/document.txt";
			StreamReader streamReader = new StreamReader(path);
//citeste prima linie, returneaza un string
			//string primaLinie=streamReader.ReadLine();

//citire mai multe date din fisier
			//string adouaLinie=streamReader.ReadLine();
			//string atreiaLinie = streamReader.ReadLine();
			//streamReader.ReadLine();
			//string acinceaLinie= streamReader.ReadLine();

//citeste tot fisierul
			richTextBox1.Text = streamReader.ReadToEnd();

			//richTextBox1.Text = primaLinie;
			streamReader.Close();

		}
//aleg ce fisier sa deschid
		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result= openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string path = openFileDialog.FileName;
				StreamReader streamReader = new StreamReader(path);
				richTextBox1.Text = streamReader.ReadToEnd();
				streamReader.Close();
			}
			else
			{
				richTextBox1.Text = "nu ai selectat nimic";
			}
		}
//scrie in fisier
		private void button3_Click(object sender, EventArgs e)
		{
			string path= "C:/Users/alina/Desktop/curs8 sursa/documentScriere.txt";
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.Write(richTextBox1.Text);
			streamWriter.Close();
		}
//salvez intr0un anumit fisier
		private void button4_Click(object sender, EventArgs e)
		{
		DialogResult result=saveFileDialog1.ShowDialog();

			if (result == DialogResult.OK)
			{
				string path = saveFileDialog1.FileName;

//sa nu suprascrie fisierul	salvez ce e scris in variabila
				StreamReader streamReader = new StreamReader(path);
				string mesajInitial = streamReader.ReadToEnd();
				streamReader.Close();
				string mesajFinal = mesajInitial + richTextBox1.Text;
								
				StreamWriter streamWriter = new StreamWriter(path);
				//streamWriter.Write(richTextBox1.Text);
				streamWriter.WriteLine(mesajFinal);
				streamWriter.Close();

			}

		}
//sa copiez in alt folder
		private void button5_Click(object sender, EventArgs e)
		{
			string caleSursa = "C:/Users/alina/Desktop/curs8 sursa/documentScriere.txt";
			string caleDestinatie = "C:/Users/alina/Desktop/curs8 destinatie/documentScriere.txt";

			File.Copy(caleSursa, caleDestinatie,true);
		}
//muta fisierul
		private void button6_Click(object sender, EventArgs e)
		{
			string caleSursa = "C:/Users/alina/Desktop/curs8 sursa/document.txt";
			string caleDestinatie = "C:/Users/alina/Desktop/curs8 destinatie/document.txt";

			File.Move(caleSursa, caleDestinatie);
		}

		//sterge fisier
		private void button7_Click(object sender, EventArgs e)
		{
			string caleDestinatie = "C:/Users/alina/Desktop/curs8 destinatie/document.txt";
			File.Delete(caleDestinatie);
		}

	}
}

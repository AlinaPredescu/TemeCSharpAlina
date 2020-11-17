namespace Curs6_Magazin
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.adaugaProdusButton = new System.Windows.Forms.Button();
			this.afiseazaProdusButton = new System.Windows.Forms.Button();
			this.afiseazaProdusLabel = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.tabel = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.tabel)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(43, 102);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(217, 42);
			this.button1.TabIndex = 0;
			this.button1.Text = "Afiseaza categorii";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(438, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(43, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(240, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "Adauga categorie";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// adaugaProdusButton
			// 
			this.adaugaProdusButton.Location = new System.Drawing.Point(43, 202);
			this.adaugaProdusButton.Name = "adaugaProdusButton";
			this.adaugaProdusButton.Size = new System.Drawing.Size(142, 31);
			this.adaugaProdusButton.TabIndex = 3;
			this.adaugaProdusButton.Text = "Adauga produs";
			this.adaugaProdusButton.UseVisualStyleBackColor = true;
			this.adaugaProdusButton.Click += new System.EventHandler(this.adaugaProdusButton_Click);
			// 
			// afiseazaProdusButton
			// 
			this.afiseazaProdusButton.Location = new System.Drawing.Point(43, 254);
			this.afiseazaProdusButton.Name = "afiseazaProdusButton";
			this.afiseazaProdusButton.Size = new System.Drawing.Size(170, 33);
			this.afiseazaProdusButton.TabIndex = 4;
			this.afiseazaProdusButton.Text = "Afiseaza produs";
			this.afiseazaProdusButton.UseVisualStyleBackColor = true;
			this.afiseazaProdusButton.Click += new System.EventHandler(this.afiseazaProdusButton_Click);
			// 
			// afiseazaProdusLabel
			// 
			this.afiseazaProdusLabel.AutoSize = true;
			this.afiseazaProdusLabel.Location = new System.Drawing.Point(232, 267);
			this.afiseazaProdusLabel.Name = "afiseazaProdusLabel";
			this.afiseazaProdusLabel.Size = new System.Drawing.Size(0, 20);
			this.afiseazaProdusLabel.TabIndex = 5;
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(248, 241);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(251, 150);
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(344, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(331, 28);
			this.comboBox1.TabIndex = 7;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(372, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 46);
			this.button3.TabIndex = 8;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(504, 120);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(111, 34);
			this.button4.TabIndex = 9;
			this.button4.Text = "Serializeaza";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(504, 161);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(127, 31);
			this.button5.TabIndex = 10;
			this.button5.Text = "Deserializeaza";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// tabel
			// 
			this.tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tabel.Location = new System.Drawing.Point(562, 241);
			this.tabel.Name = "tabel";
			this.tabel.RowHeadersWidth = 62;
			this.tabel.RowTemplate.Height = 28;
			this.tabel.Size = new System.Drawing.Size(417, 150);
			this.tabel.TabIndex = 11;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(675, 151);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 12;
			this.button6.Text = "salveaza";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 450);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.tabel);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.afiseazaProdusLabel);
			this.Controls.Add(this.afiseazaProdusButton);
			this.Controls.Add(this.adaugaProdusButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button adaugaProdusButton;
		private System.Windows.Forms.Button afiseazaProdusButton;
		private System.Windows.Forms.Label afiseazaProdusLabel;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.DataGridView tabel;
		private System.Windows.Forms.Button button6;
	}
}


namespace Curs6_Magazin
{
	partial class frmAddProduct
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
			this.idProdusLabel = new System.Windows.Forms.Label();
			this.numeProdusTextBox = new System.Windows.Forms.TextBox();
			this.pretProdusTextBox = new System.Windows.Forms.TextBox();
			this.descriereProdusTextBox = new System.Windows.Forms.TextBox();
			this.numeProdusLabel = new System.Windows.Forms.Label();
			this.descriereProdusLabel = new System.Windows.Forms.Label();
			this.pretProdusLabel = new System.Windows.Forms.Label();
			this.adaugaProdusButton = new System.Windows.Forms.Button();
			this.produsNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.produsNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// idProdusLabel
			// 
			this.idProdusLabel.AutoSize = true;
			this.idProdusLabel.Location = new System.Drawing.Point(30, 30);
			this.idProdusLabel.Name = "idProdusLabel";
			this.idProdusLabel.Size = new System.Drawing.Size(27, 20);
			this.idProdusLabel.TabIndex = 0;
			this.idProdusLabel.Text = "Id:";
			// 
			// numeProdusTextBox
			// 
			this.numeProdusTextBox.Location = new System.Drawing.Point(113, 82);
			this.numeProdusTextBox.Name = "numeProdusTextBox";
			this.numeProdusTextBox.Size = new System.Drawing.Size(100, 26);
			this.numeProdusTextBox.TabIndex = 2;
			// 
			// pretProdusTextBox
			// 
			this.pretProdusTextBox.Location = new System.Drawing.Point(113, 259);
			this.pretProdusTextBox.Name = "pretProdusTextBox";
			this.pretProdusTextBox.Size = new System.Drawing.Size(100, 26);
			this.pretProdusTextBox.TabIndex = 3;
			// 
			// descriereProdusTextBox
			// 
			this.descriereProdusTextBox.Location = new System.Drawing.Point(113, 137);
			this.descriereProdusTextBox.Multiline = true;
			this.descriereProdusTextBox.Name = "descriereProdusTextBox";
			this.descriereProdusTextBox.Size = new System.Drawing.Size(587, 98);
			this.descriereProdusTextBox.TabIndex = 4;
			// 
			// numeProdusLabel
			// 
			this.numeProdusLabel.AutoSize = true;
			this.numeProdusLabel.Location = new System.Drawing.Point(12, 85);
			this.numeProdusLabel.Name = "numeProdusLabel";
			this.numeProdusLabel.Size = new System.Drawing.Size(55, 20);
			this.numeProdusLabel.TabIndex = 5;
			this.numeProdusLabel.Text = "Nume:";
			// 
			// descriereProdusLabel
			// 
			this.descriereProdusLabel.AutoSize = true;
			this.descriereProdusLabel.Location = new System.Drawing.Point(12, 137);
			this.descriereProdusLabel.Name = "descriereProdusLabel";
			this.descriereProdusLabel.Size = new System.Drawing.Size(81, 20);
			this.descriereProdusLabel.TabIndex = 6;
			this.descriereProdusLabel.Text = "Descriere:";
			// 
			// pretProdusLabel
			// 
			this.pretProdusLabel.AutoSize = true;
			this.pretProdusLabel.Location = new System.Drawing.Point(15, 265);
			this.pretProdusLabel.Name = "pretProdusLabel";
			this.pretProdusLabel.Size = new System.Drawing.Size(42, 20);
			this.pretProdusLabel.TabIndex = 7;
			this.pretProdusLabel.Text = "Pret:";
			// 
			// adaugaProdusButton
			// 
			this.adaugaProdusButton.Location = new System.Drawing.Point(543, 322);
			this.adaugaProdusButton.Name = "adaugaProdusButton";
			this.adaugaProdusButton.Size = new System.Drawing.Size(89, 41);
			this.adaugaProdusButton.TabIndex = 8;
			this.adaugaProdusButton.Text = "Adauga";
			this.adaugaProdusButton.UseVisualStyleBackColor = true;
			this.adaugaProdusButton.Click += new System.EventHandler(this.adaugaProdusButton_Click);
			// 
			// produsNumericUpDown
			// 
			this.produsNumericUpDown.Location = new System.Drawing.Point(113, 30);
			this.produsNumericUpDown.Name = "produsNumericUpDown";
			this.produsNumericUpDown.Size = new System.Drawing.Size(120, 26);
			this.produsNumericUpDown.TabIndex = 9;
			// 
			// frmAddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 375);
			this.Controls.Add(this.produsNumericUpDown);
			this.Controls.Add(this.adaugaProdusButton);
			this.Controls.Add(this.pretProdusLabel);
			this.Controls.Add(this.descriereProdusLabel);
			this.Controls.Add(this.numeProdusLabel);
			this.Controls.Add(this.descriereProdusTextBox);
			this.Controls.Add(this.pretProdusTextBox);
			this.Controls.Add(this.numeProdusTextBox);
			this.Controls.Add(this.idProdusLabel);
			this.Name = "frmAddProduct";
			this.Text = "frmAddProduct";
			((System.ComponentModel.ISupportInitialize)(this.produsNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label idProdusLabel;
		private System.Windows.Forms.TextBox numeProdusTextBox;
		private System.Windows.Forms.TextBox pretProdusTextBox;
		private System.Windows.Forms.TextBox descriereProdusTextBox;
		private System.Windows.Forms.Label numeProdusLabel;
		private System.Windows.Forms.Label descriereProdusLabel;
		private System.Windows.Forms.Label pretProdusLabel;
		private System.Windows.Forms.Button adaugaProdusButton;
		private System.Windows.Forms.NumericUpDown produsNumericUpDown;
	}
}
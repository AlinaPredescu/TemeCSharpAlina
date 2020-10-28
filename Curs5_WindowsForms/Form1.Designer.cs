namespace Curs5_WindowsForms
{
	partial class Aplicatie
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
			this.ClickButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.MessageLabel = new System.Windows.Forms.Label();
			this.CountriesComboBox = new System.Windows.Forms.ComboBox();
			this.CountryLabel = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ClickButton
			// 
			this.ClickButton.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClickButton.Location = new System.Drawing.Point(138, 311);
			this.ClickButton.Name = "ClickButton";
			this.ClickButton.Size = new System.Drawing.Size(219, 48);
			this.ClickButton.TabIndex = 0;
			this.ClickButton.Text = "ClickButton";
			this.ClickButton.UseVisualStyleBackColor = false;
			this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.NameLabel.Location = new System.Drawing.Point(38, 97);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(51, 20);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Nume";
			this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
			// 
			// NameTextBox
			// 
			this.NameTextBox.BackColor = System.Drawing.Color.Yellow;
			this.NameTextBox.Location = new System.Drawing.Point(115, 97);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(308, 26);
			this.NameTextBox.TabIndex = 2;
			// 
			// MessageLabel
			// 
			this.MessageLabel.AutoSize = true;
			this.MessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.MessageLabel.Location = new System.Drawing.Point(50, 55);
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Size = new System.Drawing.Size(0, 20);
			this.MessageLabel.TabIndex = 3;
			// 
			// CountriesComboBox
			// 
			this.CountriesComboBox.FormattingEnabled = true;
			this.CountriesComboBox.Items.AddRange(new object[] {
            "Romania",
            "Elvetia",
            "Spania",
            "Franta"});
			this.CountriesComboBox.Location = new System.Drawing.Point(605, 100);
			this.CountriesComboBox.Name = "CountriesComboBox";
			this.CountriesComboBox.Size = new System.Drawing.Size(121, 28);
			this.CountriesComboBox.TabIndex = 4;
			// 
			// CountryLabel
			// 
			this.CountryLabel.AutoSize = true;
			this.CountryLabel.Location = new System.Drawing.Point(547, 103);
			this.CountryLabel.Name = "CountryLabel";
			this.CountryLabel.Size = new System.Drawing.Size(41, 20);
			this.CountryLabel.TabIndex = 5;
			this.CountryLabel.Text = "Tara";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(115, 179);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(90, 24);
			this.radioButton1.TabIndex = 6;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "engleza";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(115, 230);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(88, 24);
			this.radioButton2.TabIndex = 7;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "romana";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Curs5_WindowsForms.Properties.Resources.ou;
			this.pictureBox1.Location = new System.Drawing.Point(538, 206);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 135);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(485, 300);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 20);
			this.label1.TabIndex = 9;
			// 
			// Aplicatie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.CountryLabel);
			this.Controls.Add(this.CountriesComboBox);
			this.Controls.Add(this.MessageLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.ClickButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Aplicatie";
			this.Text = "Aplicatie";
			this.Load += new System.EventHandler(this.Aplicatie_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ClickButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Label MessageLabel;
		private System.Windows.Forms.ComboBox CountriesComboBox;
		private System.Windows.Forms.Label CountryLabel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}


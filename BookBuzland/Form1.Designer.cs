namespace BookBuzland
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.raftCartiPictureBox = new System.Windows.Forms.PictureBox();
			this.titluCartiPictureBox = new System.Windows.Forms.PictureBox();
			this.adaugaCartiButton = new System.Windows.Forms.Button();
			this.afisareCartiButton = new System.Windows.Forms.Button();
			this.cautaTextBox = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.totalCartiTextBox = new System.Windows.Forms.TextBox();
			this.totalCartiLabel = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.nrCartiCititeTextBox = new System.Windows.Forms.TextBox();
			this.cartiCititeLabel = new System.Windows.Forms.Label();
			this.cAutografLabel = new System.Windows.Forms.Label();
			this.cuAutografTextBox = new System.Windows.Forms.TextBox();
			this.imprumutatLabel = new System.Windows.Forms.Label();
			this.imprumutataTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.raftCartiPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.titluCartiPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// raftCartiPictureBox
			// 
			this.raftCartiPictureBox.BackColor = System.Drawing.Color.White;
			this.raftCartiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raftCartiPictureBox.Image")));
			this.raftCartiPictureBox.Location = new System.Drawing.Point(60, 0);
			this.raftCartiPictureBox.Name = "raftCartiPictureBox";
			this.raftCartiPictureBox.Size = new System.Drawing.Size(523, 72);
			this.raftCartiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.raftCartiPictureBox.TabIndex = 0;
			this.raftCartiPictureBox.TabStop = false;
			// 
			// titluCartiPictureBox
			// 
			this.titluCartiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("titluCartiPictureBox.Image")));
			this.titluCartiPictureBox.Location = new System.Drawing.Point(531, 97);
			this.titluCartiPictureBox.Name = "titluCartiPictureBox";
			this.titluCartiPictureBox.Size = new System.Drawing.Size(222, 60);
			this.titluCartiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.titluCartiPictureBox.TabIndex = 1;
			this.titluCartiPictureBox.TabStop = false;
			// 
			// adaugaCartiButton
			// 
			this.adaugaCartiButton.Location = new System.Drawing.Point(70, 179);
			this.adaugaCartiButton.Name = "adaugaCartiButton";
			this.adaugaCartiButton.Size = new System.Drawing.Size(168, 62);
			this.adaugaCartiButton.TabIndex = 2;
			this.adaugaCartiButton.Text = "Adauga carte";
			this.adaugaCartiButton.UseVisualStyleBackColor = true;
			this.adaugaCartiButton.Click += new System.EventHandler(this.adaugaCartiButton_Click);
			// 
			// afisareCartiButton
			// 
			this.afisareCartiButton.Location = new System.Drawing.Point(1332, 12);
			this.afisareCartiButton.Name = "afisareCartiButton";
			this.afisareCartiButton.Size = new System.Drawing.Size(100, 61);
			this.afisareCartiButton.TabIndex = 3;
			this.afisareCartiButton.Text = "Afisare carti";
			this.afisareCartiButton.UseVisualStyleBackColor = true;
			this.afisareCartiButton.Visible = false;
			this.afisareCartiButton.Click += new System.EventHandler(this.afisareCartiButton_Click);
			// 
			// cautaTextBox
			// 
			this.cautaTextBox.Location = new System.Drawing.Point(407, 197);
			this.cautaTextBox.Name = "cautaTextBox";
			this.cautaTextBox.Size = new System.Drawing.Size(453, 26);
			this.cautaTextBox.TabIndex = 6;
			this.cautaTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cautaTextBox_KeyUp);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeight = 34;
			this.dataGridView.Location = new System.Drawing.Point(26, 293);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 62;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView.ShowCellToolTips = false;
			this.dataGridView.Size = new System.Drawing.Size(1228, 315);
			this.dataGridView.TabIndex = 9;
			this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(688, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(506, 72);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::BookBuzland.Properties.Resources.lupa;
			this.pictureBox2.Location = new System.Drawing.Point(880, 197);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(44, 26);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// totalCartiTextBox
			// 
			this.totalCartiTextBox.Location = new System.Drawing.Point(150, 611);
			this.totalCartiTextBox.Name = "totalCartiTextBox";
			this.totalCartiTextBox.Size = new System.Drawing.Size(66, 26);
			this.totalCartiTextBox.TabIndex = 12;
			// 
			// totalCartiLabel
			// 
			this.totalCartiLabel.AutoSize = true;
			this.totalCartiLabel.Location = new System.Drawing.Point(126, 614);
			this.totalCartiLabel.Name = "totalCartiLabel";
			this.totalCartiLabel.Size = new System.Drawing.Size(18, 20);
			this.totalCartiLabel.TabIndex = 13;
			this.totalCartiLabel.Text = "#";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// nrCartiCititeTextBox
			// 
			this.nrCartiCititeTextBox.Location = new System.Drawing.Point(688, 610);
			this.nrCartiCititeTextBox.Name = "nrCartiCititeTextBox";
			this.nrCartiCititeTextBox.Size = new System.Drawing.Size(66, 26);
			this.nrCartiCititeTextBox.TabIndex = 14;
			// 
			// cartiCititeLabel
			// 
			this.cartiCititeLabel.AutoSize = true;
			this.cartiCititeLabel.Location = new System.Drawing.Point(664, 616);
			this.cartiCititeLabel.Name = "cartiCititeLabel";
			this.cartiCititeLabel.Size = new System.Drawing.Size(18, 20);
			this.cartiCititeLabel.TabIndex = 15;
			this.cartiCititeLabel.Text = "#";
			// 
			// cAutografLabel
			// 
			this.cAutografLabel.AutoSize = true;
			this.cAutografLabel.Location = new System.Drawing.Point(812, 616);
			this.cAutografLabel.Name = "cAutografLabel";
			this.cAutografLabel.Size = new System.Drawing.Size(18, 20);
			this.cAutografLabel.TabIndex = 16;
			this.cAutografLabel.Text = "#";
			// 
			// cuAutografTextBox
			// 
			this.cuAutografTextBox.Location = new System.Drawing.Point(836, 611);
			this.cuAutografTextBox.Name = "cuAutografTextBox";
			this.cuAutografTextBox.Size = new System.Drawing.Size(66, 26);
			this.cuAutografTextBox.TabIndex = 17;
			// 
			// imprumutatLabel
			// 
			this.imprumutatLabel.AutoSize = true;
			this.imprumutatLabel.Location = new System.Drawing.Point(946, 615);
			this.imprumutatLabel.Name = "imprumutatLabel";
			this.imprumutatLabel.Size = new System.Drawing.Size(18, 20);
			this.imprumutatLabel.TabIndex = 18;
			this.imprumutatLabel.Text = "#";
			// 
			// imprumutataTextBox
			// 
			this.imprumutataTextBox.Location = new System.Drawing.Point(971, 611);
			this.imprumutataTextBox.Name = "imprumutataTextBox";
			this.imprumutataTextBox.Size = new System.Drawing.Size(66, 26);
			this.imprumutataTextBox.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1478, 1050);
			this.Controls.Add(this.imprumutataTextBox);
			this.Controls.Add(this.imprumutatLabel);
			this.Controls.Add(this.cuAutografTextBox);
			this.Controls.Add(this.cAutografLabel);
			this.Controls.Add(this.cartiCititeLabel);
			this.Controls.Add(this.nrCartiCititeTextBox);
			this.Controls.Add(this.totalCartiLabel);
			this.Controls.Add(this.totalCartiTextBox);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.cautaTextBox);
			this.Controls.Add(this.afisareCartiButton);
			this.Controls.Add(this.adaugaCartiButton);
			this.Controls.Add(this.titluCartiPictureBox);
			this.Controls.Add(this.raftCartiPictureBox);
			this.Name = "Form1";
			this.Text = "BookBuzland";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.raftCartiPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.titluCartiPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox raftCartiPictureBox;
		private System.Windows.Forms.PictureBox titluCartiPictureBox;
		private System.Windows.Forms.Button adaugaCartiButton;
		private System.Windows.Forms.Button afisareCartiButton;
		private System.Windows.Forms.TextBox cautaTextBox;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox totalCartiTextBox;
		private System.Windows.Forms.Label totalCartiLabel;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TextBox nrCartiCititeTextBox;
		private System.Windows.Forms.Label cartiCititeLabel;
		private System.Windows.Forms.Label cAutografLabel;
		private System.Windows.Forms.TextBox cuAutografTextBox;
		private System.Windows.Forms.Label imprumutatLabel;
		private System.Windows.Forms.TextBox imprumutataTextBox;
	}
}


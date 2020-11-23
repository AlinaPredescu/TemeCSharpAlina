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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.raftCartiPictureBox = new System.Windows.Forms.PictureBox();
			this.titluCartiPictureBox = new System.Windows.Forms.PictureBox();
			this.adaugaCartiButton = new System.Windows.Forms.Button();
			this.afisareCartiButton = new System.Windows.Forms.Button();
			this.cautaTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.raftCartiPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.titluCartiPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// raftCartiPictureBox
			// 
			this.raftCartiPictureBox.BackColor = System.Drawing.Color.White;
			this.raftCartiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raftCartiPictureBox.Image")));
			this.raftCartiPictureBox.Location = new System.Drawing.Point(3, 1);
			this.raftCartiPictureBox.Name = "raftCartiPictureBox";
			this.raftCartiPictureBox.Size = new System.Drawing.Size(523, 72);
			this.raftCartiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.raftCartiPictureBox.TabIndex = 0;
			this.raftCartiPictureBox.TabStop = false;
			// 
			// titluCartiPictureBox
			// 
			this.titluCartiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("titluCartiPictureBox.Image")));
			this.titluCartiPictureBox.Location = new System.Drawing.Point(184, 88);
			this.titluCartiPictureBox.Name = "titluCartiPictureBox";
			this.titluCartiPictureBox.Size = new System.Drawing.Size(171, 50);
			this.titluCartiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.titluCartiPictureBox.TabIndex = 1;
			this.titluCartiPictureBox.TabStop = false;
			// 
			// adaugaCartiButton
			// 
			this.adaugaCartiButton.Location = new System.Drawing.Point(127, 232);
			this.adaugaCartiButton.Name = "adaugaCartiButton";
			this.adaugaCartiButton.Size = new System.Drawing.Size(100, 62);
			this.adaugaCartiButton.TabIndex = 2;
			this.adaugaCartiButton.Text = "Adauga carte";
			this.adaugaCartiButton.UseVisualStyleBackColor = true;
			this.adaugaCartiButton.Click += new System.EventHandler(this.adaugaCartiButton_Click);
			// 
			// afisareCartiButton
			// 
			this.afisareCartiButton.Location = new System.Drawing.Point(296, 233);
			this.afisareCartiButton.Name = "afisareCartiButton";
			this.afisareCartiButton.Size = new System.Drawing.Size(100, 61);
			this.afisareCartiButton.TabIndex = 3;
			this.afisareCartiButton.Text = "Afisare carti";
			this.afisareCartiButton.UseVisualStyleBackColor = true;
			this.afisareCartiButton.Click += new System.EventHandler(this.afisareCartiButton_Click);
			// 
			// cautaTextBox
			// 
			this.cautaTextBox.Location = new System.Drawing.Point(76, 191);
			this.cautaTextBox.Name = "cautaTextBox";
			this.cautaTextBox.Size = new System.Drawing.Size(269, 26);
			this.cautaTextBox.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::BookBuzland.Properties.Resources.lupa;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(378, 186);
			this.button1.Name = "cautaButton";
			this.button1.Size = new System.Drawing.Size(45, 36);
			this.button1.TabIndex = 8;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.cautaButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(528, 494);
			this.Controls.Add(this.button1);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox raftCartiPictureBox;
		private System.Windows.Forms.PictureBox titluCartiPictureBox;
		private System.Windows.Forms.Button adaugaCartiButton;
		private System.Windows.Forms.Button afisareCartiButton;
		private System.Windows.Forms.TextBox cautaTextBox;
		private System.Windows.Forms.Button button1;
	}
}


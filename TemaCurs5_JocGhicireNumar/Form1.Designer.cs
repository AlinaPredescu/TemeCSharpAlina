namespace TemaCurs5_JocGhicireNumar
{
	partial class GhicesteNumarulForm
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
			this.numarTextBox = new System.Windows.Forms.TextBox();
			this.numarLabel = new System.Windows.Forms.Label();
			this.refreshButton = new System.Windows.Forms.Button();
			this.mesaj1Label = new System.Windows.Forms.Label();
			this.verificaButton = new System.Windows.Forms.Button();
			this.numarGeneratLabel = new System.Windows.Forms.Label();
			this.mesaj2Label = new System.Windows.Forms.Label();
			this.jocNouButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// numarTextBox
			// 
			this.numarTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.numarTextBox.Location = new System.Drawing.Point(114, 51);
			this.numarTextBox.Name = "numarTextBox";
			this.numarTextBox.Size = new System.Drawing.Size(169, 26);
			this.numarTextBox.TabIndex = 0;
			this.numarTextBox.TextChanged += new System.EventHandler(this.numarTextBox_TextChanged);
			// 
			// numarLabel
			// 
			this.numarLabel.AutoSize = true;
			this.numarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numarLabel.Location = new System.Drawing.Point(34, 57);
			this.numarLabel.Name = "numarLabel";
			this.numarLabel.Size = new System.Drawing.Size(61, 20);
			this.numarLabel.TabIndex = 1;
			this.numarLabel.Text = "Numar";
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshButton.ForeColor = System.Drawing.Color.Indigo;
			this.refreshButton.Location = new System.Drawing.Point(159, 93);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(146, 53);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "Reincearca";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Visible = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
			// 
			// mesaj1Label
			// 
			this.mesaj1Label.AutoSize = true;
			this.mesaj1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mesaj1Label.ForeColor = System.Drawing.Color.Red;
			this.mesaj1Label.Location = new System.Drawing.Point(77, 37);
			this.mesaj1Label.Name = "mesaj1Label";
			this.mesaj1Label.Size = new System.Drawing.Size(0, 20);
			this.mesaj1Label.TabIndex = 3;
			// 
			// verificaButton
			// 
			this.verificaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.verificaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.verificaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.verificaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.verificaButton.Location = new System.Drawing.Point(312, 51);
			this.verificaButton.Name = "verificaButton";
			this.verificaButton.Size = new System.Drawing.Size(125, 32);
			this.verificaButton.TabIndex = 4;
			this.verificaButton.Text = "Verifica";
			this.verificaButton.UseVisualStyleBackColor = false;
			this.verificaButton.Click += new System.EventHandler(this.verificaButton_Click);
			// 
			// numarGeneratLabel
			// 
			this.numarGeneratLabel.AutoSize = true;
			this.numarGeneratLabel.Location = new System.Drawing.Point(90, 243);
			this.numarGeneratLabel.Name = "numarGeneratLabel";
			this.numarGeneratLabel.Size = new System.Drawing.Size(0, 20);
			this.numarGeneratLabel.TabIndex = 5;
			// 
			// mesaj2Label
			// 
			this.mesaj2Label.AutoSize = true;
			this.mesaj2Label.BackColor = System.Drawing.Color.White;
			this.mesaj2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mesaj2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.mesaj2Label.Location = new System.Drawing.Point(56, 77);
			this.mesaj2Label.Name = "mesaj2Label";
			this.mesaj2Label.Size = new System.Drawing.Size(0, 29);
			this.mesaj2Label.TabIndex = 6;
			// 
			// jocNouButton
			// 
			this.jocNouButton.AutoEllipsis = true;
			this.jocNouButton.BackColor = System.Drawing.Color.White;
			this.jocNouButton.Location = new System.Drawing.Point(257, 182);
			this.jocNouButton.Name = "jocNouButton";
			this.jocNouButton.Size = new System.Drawing.Size(200, 36);
			this.jocNouButton.TabIndex = 7;
			this.jocNouButton.Text = "Joaca din nou!";
			this.jocNouButton.UseVisualStyleBackColor = false;
			this.jocNouButton.Visible = false;
			this.jocNouButton.Click += new System.EventHandler(this.jocNouButton_Click);
			// 
			// GhicesteNumarulForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(473, 230);
			this.Controls.Add(this.jocNouButton);
			this.Controls.Add(this.mesaj2Label);
			this.Controls.Add(this.numarGeneratLabel);
			this.Controls.Add(this.verificaButton);
			this.Controls.Add(this.mesaj1Label);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.numarLabel);
			this.Controls.Add(this.numarTextBox);
			this.Name = "GhicesteNumarulForm";
			this.Text = "Ghiceste Numarul";
			this.Load += new System.EventHandler(this.GhicesteNumarulForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numarTextBox;
		private System.Windows.Forms.Label numarLabel;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.Label mesaj1Label;
		private System.Windows.Forms.Button verificaButton;
		private System.Windows.Forms.Label numarGeneratLabel;
		private System.Windows.Forms.Label mesaj2Label;
		private System.Windows.Forms.Button jocNouButton;
	}
}


namespace Curs7_listview
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nume = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.perBucata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.sterge = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nume,
            this.perBucata,
            this.sterge});
			this.dataGridView1.Location = new System.Drawing.Point(112, 53);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1000, 304);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Id
			// 
			this.Id.Frozen = true;
			this.Id.HeaderText = "Id";
			this.Id.MinimumWidth = 50;
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.ToolTipText = "alina";
			this.Id.Width = 150;
			// 
			// Nume
			// 
			this.Nume.HeaderText = "Nume";
			this.Nume.Items.AddRange(new object[] {
            "alina",
            "ioana"});
			this.Nume.MinimumWidth = 8;
			this.Nume.Name = "Nume";
			this.Nume.Width = 150;
			// 
			// perBucata
			// 
			this.perBucata.HeaderText = "per Bucata";
			this.perBucata.MinimumWidth = 8;
			this.perBucata.Name = "perBucata";
			this.perBucata.Width = 150;
			// 
			// sterge
			// 
			this.sterge.HeaderText = "sterge";
			this.sterge.MinimumWidth = 8;
			this.sterge.Name = "sterge";
			this.sterge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.sterge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.sterge.Width = 150;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1478, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewComboBoxColumn Nume;
		private System.Windows.Forms.DataGridViewCheckBoxColumn perBucata;
		private System.Windows.Forms.DataGridViewButtonColumn sterge;
	}
}


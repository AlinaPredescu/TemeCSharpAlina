namespace Curs8_ListView
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Admin", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Standard", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Sorin",
            "Iulian"}, -1);
			this.listView1 = new System.Windows.Forms.ListView();
			this.c1Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.c2Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.textName = new System.Windows.Forms.TextBox();
			this.textPrenume = new System.Windows.Forms.TextBox();
			this.textLocatie = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1Name,
            this.c2Prenume});
			this.listView1.GridLines = true;
			listViewGroup1.Header = "Admin";
			listViewGroup1.Name = "Admin";
			listViewGroup2.Header = "Standard";
			listViewGroup2.Name = "Standard";
			this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			this.listView1.HideSelection = false;
			listViewItem1.Group = listViewGroup1;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(54, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(369, 300);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// c1Name
			// 
			this.c1Name.Text = "Name";
			// 
			// c2Prenume
			// 
			this.c2Prenume.Text = "Prenume";
			this.c2Prenume.Width = 84;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(522, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(226, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add User";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(522, 153);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(100, 26);
			this.textName.TabIndex = 2;
			// 
			// textPrenume
			// 
			this.textPrenume.Location = new System.Drawing.Point(522, 220);
			this.textPrenume.Name = "textPrenume";
			this.textPrenume.Size = new System.Drawing.Size(100, 26);
			this.textPrenume.TabIndex = 3;
			// 
			// textLocatie
			// 
			this.textLocatie.Location = new System.Drawing.Point(522, 285);
			this.textLocatie.Name = "textLocatie";
			this.textLocatie.Size = new System.Drawing.Size(100, 26);
			this.textLocatie.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textLocatie);
			this.Controls.Add(this.textPrenume);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader c1Name;
		private System.Windows.Forms.ColumnHeader c2Prenume;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textPrenume;
		private System.Windows.Forms.TextBox textLocatie;
	}
}


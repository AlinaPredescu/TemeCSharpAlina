namespace SplitContainer
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Autori");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Carti");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Biblioteca mea", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.adaugaAutorButton = new System.Windows.Forms.Button();
			this.dataNasteriiDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dataNasteriilabel = new System.Windows.Forms.Label();
			this.cetatenieLabel = new System.Windows.Forms.Label();
			this.prenumeAutorLabel = new System.Windows.Forms.Label();
			this.cetatenieTextBox = new System.Windows.Forms.TextBox();
			this.prenumeAutorTextBox = new System.Windows.Forms.TextBox();
			this.numeAutorTextBox = new System.Windows.Forms.TextBox();
			this.numeAutorLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.adaugaCartiButton = new System.Windows.Forms.Button();
			this.anAparitieTextBox = new System.Windows.Forms.TextBox();
			this.autografRadioButton = new System.Windows.Forms.RadioButton();
			this.limbaComboBox = new System.Windows.Forms.ComboBox();
			this.tipComboBox = new System.Windows.Forms.ComboBox();
			this.tiltluTextBox = new System.Windows.Forms.TextBox();
			this.autografLabel = new System.Windows.Forms.Label();
			this.anAparitieLabel = new System.Windows.Forms.Label();
			this.limbaLabel = new System.Windows.Forms.Label();
			this.tipLabel = new System.Windows.Forms.Label();
			this.titluLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AllowDrop = true;
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(826, 487);
			this.splitContainer1.SplitterDistance = 250;
			this.splitContainer1.SplitterWidth = 3;
			this.splitContainer1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "AutoriNode";
			treeNode1.Text = "Autori";
			treeNode2.Name = "CartiNode";
			treeNode2.Text = "Carti";
			treeNode3.Name = "BibliotecaNode";
			treeNode3.Text = "Biblioteca mea";
			treeNode3.ToolTipText = "Alina";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
			this.treeView1.Size = new System.Drawing.Size(246, 483);
			this.treeView1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.IsSplitterFixed = true;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.splitContainer2.Panel1.Controls.Add(this.adaugaAutorButton);
			this.splitContainer2.Panel1.Controls.Add(this.dataNasteriiDateTimePicker);
			this.splitContainer2.Panel1.Controls.Add(this.dataNasteriilabel);
			this.splitContainer2.Panel1.Controls.Add(this.cetatenieLabel);
			this.splitContainer2.Panel1.Controls.Add(this.prenumeAutorLabel);
			this.splitContainer2.Panel1.Controls.Add(this.cetatenieTextBox);
			this.splitContainer2.Panel1.Controls.Add(this.prenumeAutorTextBox);
			this.splitContainer2.Panel1.Controls.Add(this.numeAutorTextBox);
			this.splitContainer2.Panel1.Controls.Add(this.numeAutorLabel);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.splitContainer2.Panel2.Controls.Add(this.button1);
			this.splitContainer2.Panel2.Controls.Add(this.adaugaCartiButton);
			this.splitContainer2.Panel2.Controls.Add(this.anAparitieTextBox);
			this.splitContainer2.Panel2.Controls.Add(this.autografRadioButton);
			this.splitContainer2.Panel2.Controls.Add(this.limbaComboBox);
			this.splitContainer2.Panel2.Controls.Add(this.tipComboBox);
			this.splitContainer2.Panel2.Controls.Add(this.tiltluTextBox);
			this.splitContainer2.Panel2.Controls.Add(this.autografLabel);
			this.splitContainer2.Panel2.Controls.Add(this.anAparitieLabel);
			this.splitContainer2.Panel2.Controls.Add(this.limbaLabel);
			this.splitContainer2.Panel2.Controls.Add(this.tipLabel);
			this.splitContainer2.Panel2.Controls.Add(this.titluLabel);
			this.splitContainer2.Size = new System.Drawing.Size(573, 487);
			this.splitContainer2.SplitterDistance = 157;
			this.splitContainer2.SplitterWidth = 3;
			this.splitContainer2.TabIndex = 0;
			// 
			// adaugaAutorButton
			// 
			this.adaugaAutorButton.Location = new System.Drawing.Point(413, 107);
			this.adaugaAutorButton.Name = "adaugaAutorButton";
			this.adaugaAutorButton.Size = new System.Drawing.Size(112, 34);
			this.adaugaAutorButton.TabIndex = 8;
			this.adaugaAutorButton.Text = "Adauga";
			this.adaugaAutorButton.UseVisualStyleBackColor = true;
			// 
			// dataNasteriiDateTimePicker
			// 
			this.dataNasteriiDateTimePicker.CustomFormat = "";
			this.dataNasteriiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dataNasteriiDateTimePicker.Location = new System.Drawing.Point(128, 115);
			this.dataNasteriiDateTimePicker.Name = "dataNasteriiDateTimePicker";
			this.dataNasteriiDateTimePicker.Size = new System.Drawing.Size(200, 26);
			this.dataNasteriiDateTimePicker.TabIndex = 7;
			this.dataNasteriiDateTimePicker.Value = new System.DateTime(2020, 11, 9, 14, 52, 26, 0);
			// 
			// dataNasteriilabel
			// 
			this.dataNasteriilabel.AutoSize = true;
			this.dataNasteriilabel.Location = new System.Drawing.Point(19, 120);
			this.dataNasteriilabel.Name = "dataNasteriilabel";
			this.dataNasteriilabel.Size = new System.Drawing.Size(103, 20);
			this.dataNasteriilabel.TabIndex = 6;
			this.dataNasteriilabel.Text = "Data nasterii:";
			// 
			// cetatenieLabel
			// 
			this.cetatenieLabel.AutoSize = true;
			this.cetatenieLabel.Location = new System.Drawing.Point(19, 89);
			this.cetatenieLabel.Name = "cetatenieLabel";
			this.cetatenieLabel.Size = new System.Drawing.Size(78, 20);
			this.cetatenieLabel.TabIndex = 5;
			this.cetatenieLabel.Text = "Cetatenie";
			// 
			// prenumeAutorLabel
			// 
			this.prenumeAutorLabel.AutoSize = true;
			this.prenumeAutorLabel.Location = new System.Drawing.Point(19, 56);
			this.prenumeAutorLabel.Name = "prenumeAutorLabel";
			this.prenumeAutorLabel.Size = new System.Drawing.Size(77, 20);
			this.prenumeAutorLabel.TabIndex = 4;
			this.prenumeAutorLabel.Text = "Prenume:";
			// 
			// cetatenieTextBox
			// 
			this.cetatenieTextBox.Location = new System.Drawing.Point(126, 82);
			this.cetatenieTextBox.Name = "cetatenieTextBox";
			this.cetatenieTextBox.Size = new System.Drawing.Size(202, 26);
			this.cetatenieTextBox.TabIndex = 3;
			// 
			// prenumeAutorTextBox
			// 
			this.prenumeAutorTextBox.Location = new System.Drawing.Point(126, 50);
			this.prenumeAutorTextBox.Name = "prenumeAutorTextBox";
			this.prenumeAutorTextBox.Size = new System.Drawing.Size(202, 26);
			this.prenumeAutorTextBox.TabIndex = 2;
			// 
			// numeAutorTextBox
			// 
			this.numeAutorTextBox.Location = new System.Drawing.Point(126, 18);
			this.numeAutorTextBox.Name = "numeAutorTextBox";
			this.numeAutorTextBox.Size = new System.Drawing.Size(202, 26);
			this.numeAutorTextBox.TabIndex = 1;
			// 
			// numeAutorLabel
			// 
			this.numeAutorLabel.AutoSize = true;
			this.numeAutorLabel.Location = new System.Drawing.Point(19, 24);
			this.numeAutorLabel.Name = "numeAutorLabel";
			this.numeAutorLabel.Size = new System.Drawing.Size(55, 20);
			this.numeAutorLabel.TabIndex = 0;
			this.numeAutorLabel.Text = "Nume:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(300, 204);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 30);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// adaugaCartiButton
			// 
			this.adaugaCartiButton.Location = new System.Drawing.Point(413, 156);
			this.adaugaCartiButton.Name = "adaugaCartiButton";
			this.adaugaCartiButton.Size = new System.Drawing.Size(112, 33);
			this.adaugaCartiButton.TabIndex = 10;
			this.adaugaCartiButton.Text = "Adauga";
			this.adaugaCartiButton.UseVisualStyleBackColor = true;
			this.adaugaCartiButton.Click += new System.EventHandler(this.adaugaCartiButton_Click);
			// 
			// anAparitieTextBox
			// 
			this.anAparitieTextBox.Location = new System.Drawing.Point(126, 128);
			this.anAparitieTextBox.Name = "anAparitieTextBox";
			this.anAparitieTextBox.Size = new System.Drawing.Size(100, 26);
			this.anAparitieTextBox.TabIndex = 9;
			// 
			// autografRadioButton
			// 
			this.autografRadioButton.AutoSize = true;
			this.autografRadioButton.Location = new System.Drawing.Point(128, 169);
			this.autografRadioButton.Name = "autografRadioButton";
			this.autografRadioButton.Size = new System.Drawing.Size(21, 20);
			this.autografRadioButton.TabIndex = 8;
			this.autografRadioButton.TabStop = true;
			this.autografRadioButton.UseVisualStyleBackColor = true;
			// 
			// limbaComboBox
			// 
			this.limbaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.limbaComboBox.FormattingEnabled = true;
			this.limbaComboBox.Items.AddRange(new object[] {
            "Romana",
            "Engleza"});
			this.limbaComboBox.Location = new System.Drawing.Point(126, 91);
			this.limbaComboBox.Name = "limbaComboBox";
			this.limbaComboBox.Size = new System.Drawing.Size(202, 28);
			this.limbaComboBox.TabIndex = 7;
			// 
			// tipComboBox
			// 
			this.tipComboBox.FormattingEnabled = true;
			this.tipComboBox.Items.AddRange(new object[] {
            "Fictiune",
            "Jurnal",
            "Dezvoltare personala",
            "Business",
            "Turism",
            "Economie"});
			this.tipComboBox.Location = new System.Drawing.Point(126, 51);
			this.tipComboBox.Name = "tipComboBox";
			this.tipComboBox.Size = new System.Drawing.Size(202, 28);
			this.tipComboBox.TabIndex = 6;
			// 
			// tiltluTextBox
			// 
			this.tiltluTextBox.Location = new System.Drawing.Point(126, 15);
			this.tiltluTextBox.Name = "tiltluTextBox";
			this.tiltluTextBox.Size = new System.Drawing.Size(202, 26);
			this.tiltluTextBox.TabIndex = 5;
			// 
			// autografLabel
			// 
			this.autografLabel.AutoSize = true;
			this.autografLabel.Location = new System.Drawing.Point(19, 169);
			this.autografLabel.Name = "autografLabel";
			this.autografLabel.Size = new System.Drawing.Size(102, 20);
			this.autografLabel.TabIndex = 4;
			this.autografLabel.Text = "Cu autograf?";
			// 
			// anAparitieLabel
			// 
			this.anAparitieLabel.AutoSize = true;
			this.anAparitieLabel.Location = new System.Drawing.Point(19, 134);
			this.anAparitieLabel.Name = "anAparitieLabel";
			this.anAparitieLabel.Size = new System.Drawing.Size(89, 20);
			this.anAparitieLabel.TabIndex = 3;
			this.anAparitieLabel.Text = "An aparitie:";
			// 
			// limbaLabel
			// 
			this.limbaLabel.AutoSize = true;
			this.limbaLabel.Location = new System.Drawing.Point(19, 92);
			this.limbaLabel.Name = "limbaLabel";
			this.limbaLabel.Size = new System.Drawing.Size(56, 20);
			this.limbaLabel.TabIndex = 2;
			this.limbaLabel.Text = "Limba:";
			// 
			// tipLabel
			// 
			this.tipLabel.AutoSize = true;
			this.tipLabel.Location = new System.Drawing.Point(19, 59);
			this.tipLabel.Name = "tipLabel";
			this.tipLabel.Size = new System.Drawing.Size(34, 20);
			this.tipLabel.TabIndex = 1;
			this.tipLabel.Text = "Tip:";
			// 
			// titluLabel
			// 
			this.titluLabel.AutoSize = true;
			this.titluLabel.Location = new System.Drawing.Point(19, 21);
			this.titluLabel.Name = "titluLabel";
			this.titluLabel.Size = new System.Drawing.Size(42, 20);
			this.titluLabel.TabIndex = 0;
			this.titluLabel.Text = "Titlu:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 487);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Biblioteca mea";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.DateTimePicker dataNasteriiDateTimePicker;
		private System.Windows.Forms.Label dataNasteriilabel;
		private System.Windows.Forms.Label cetatenieLabel;
		private System.Windows.Forms.Label prenumeAutorLabel;
		private System.Windows.Forms.TextBox cetatenieTextBox;
		private System.Windows.Forms.TextBox prenumeAutorTextBox;
		private System.Windows.Forms.TextBox numeAutorTextBox;
		private System.Windows.Forms.Label numeAutorLabel;
		private System.Windows.Forms.TextBox anAparitieTextBox;
		private System.Windows.Forms.RadioButton autografRadioButton;
		private System.Windows.Forms.ComboBox limbaComboBox;
		private System.Windows.Forms.ComboBox tipComboBox;
		private System.Windows.Forms.TextBox tiltluTextBox;
		private System.Windows.Forms.Label autografLabel;
		private System.Windows.Forms.Label anAparitieLabel;
		private System.Windows.Forms.Label limbaLabel;
		private System.Windows.Forms.Label tipLabel;
		private System.Windows.Forms.Label titluLabel;
		private System.Windows.Forms.Button adaugaAutorButton;
		private System.Windows.Forms.Button adaugaCartiButton;
		private System.Windows.Forms.Button button1;
	}
}


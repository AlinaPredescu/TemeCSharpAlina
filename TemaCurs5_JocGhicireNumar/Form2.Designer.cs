namespace TemaCurs5_JocGhicireNumar
{
	partial class errorForm
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
			this.errorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Location = new System.Drawing.Point(28, 20);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(184, 20);
			this.errorLabel.TabIndex = 0;
			this.errorLabel.Text = "Nu ai introdus ce trebuie!";
			// 
			// errorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(230, 79);
			this.Controls.Add(this.errorLabel);
			this.Location = new System.Drawing.Point(1000, 1000);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "errorForm";
			this.Text = "Error";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.errorForm_FormClosed);
			this.Load += new System.EventHandler(this.errorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label errorLabel;
	}
}
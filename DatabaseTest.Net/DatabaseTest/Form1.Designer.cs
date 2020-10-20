namespace DatabaseTest
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
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnShowCategories = new System.Windows.Forms.Button();
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnShowCategories
			// 
			this.btnShowCategories.Location = new System.Drawing.Point(13, 13);
			this.btnShowCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnShowCategories.Name = "btnShowCategories";
			this.btnShowCategories.Size = new System.Drawing.Size(165, 34);
			this.btnShowCategories.TabIndex = 0;
			this.btnShowCategories.Text = "Zeige Kategorien";
			this.btnShowCategories.UseVisualStyleBackColor = true;
			this.btnShowCategories.Click += new System.EventHandler(this.btnShowCategories_Click);
			// 
			// lstCategories
			// 
			this.lstCategories.FormattingEnabled = true;
			this.lstCategories.ItemHeight = 19;
			this.lstCategories.Location = new System.Drawing.Point(13, 54);
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(467, 213);
			this.lstCategories.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 359);
			this.Controls.Add(this.lstCategories);
			this.Controls.Add(this.btnShowCategories);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShowCategories;
		private System.Windows.Forms.ListBox lstCategories;
	}
}


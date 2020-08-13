namespace StringBenchmark
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtStringsCount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.prbString = new System.Windows.Forms.ProgressBar();
			this.prbStringBuilder = new System.Windows.Forms.ProgressBar();
			this.lblResultString = new System.Windows.Forms.Label();
			this.lblResultStringBuilder = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(638, 51);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "String-Benchmark";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nutze";
			// 
			// txtStringsCount
			// 
			this.txtStringsCount.Location = new System.Drawing.Point(64, 138);
			this.txtStringsCount.Name = "txtStringsCount";
			this.txtStringsCount.Size = new System.Drawing.Size(100, 27);
			this.txtStringsCount.TabIndex = 2;
			this.txtStringsCount.Text = "10000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Strings für Benchmark";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(12, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(614, 49);
			this.label4.TabIndex = 4;
			this.label4.Text = "Vergleicht die Geschwindigkeit beim Zusammensetzen von Strings zwischen dem Daten" +
    "typ string und der Klasse StringBuilder";
			// 
			// btnRun
			// 
			this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRun.Location = new System.Drawing.Point(14, 183);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(612, 33);
			this.btnRun.TabIndex = 5;
			this.btnRun.Text = "Run";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.RunButtonClicked);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 287);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 19);
			this.label5.TabIndex = 6;
			this.label5.Text = "String:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 316);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 19);
			this.label6.TabIndex = 7;
			this.label6.Text = "StringBuilder:";
			// 
			// prbString
			// 
			this.prbString.Location = new System.Drawing.Point(118, 287);
			this.prbString.Name = "prbString";
			this.prbString.Size = new System.Drawing.Size(408, 22);
			this.prbString.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prbString.TabIndex = 8;
			// 
			// prbStringBuilder
			// 
			this.prbStringBuilder.Location = new System.Drawing.Point(118, 315);
			this.prbStringBuilder.Name = "prbStringBuilder";
			this.prbStringBuilder.Size = new System.Drawing.Size(408, 22);
			this.prbStringBuilder.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prbStringBuilder.TabIndex = 9;
			// 
			// lblResultString
			// 
			this.lblResultString.AutoSize = true;
			this.lblResultString.Location = new System.Drawing.Point(533, 288);
			this.lblResultString.Name = "lblResultString";
			this.lblResultString.Size = new System.Drawing.Size(49, 19);
			this.lblResultString.TabIndex = 10;
			this.lblResultString.Text = "label7";
			// 
			// lblResultStringBuilder
			// 
			this.lblResultStringBuilder.AutoSize = true;
			this.lblResultStringBuilder.Location = new System.Drawing.Point(532, 316);
			this.lblResultStringBuilder.Name = "lblResultStringBuilder";
			this.lblResultStringBuilder.Size = new System.Drawing.Size(49, 19);
			this.lblResultStringBuilder.TabIndex = 11;
			this.lblResultStringBuilder.Text = "label7";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(13, 251);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(50, 19);
			this.lblInfo.TabIndex = 12;
			this.lblInfo.Text = "lblInfo";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 233);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lblResultStringBuilder);
			this.Controls.Add(this.lblResultString);
			this.Controls.Add(this.prbStringBuilder);
			this.Controls.Add(this.prbString);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtStringsCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "String-Benchmark";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStringsCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ProgressBar prbString;
		private System.Windows.Forms.ProgressBar prbStringBuilder;
		private System.Windows.Forms.Label lblResultString;
		private System.Windows.Forms.Label lblResultStringBuilder;
		private System.Windows.Forms.Label lblInfo;
	}
}


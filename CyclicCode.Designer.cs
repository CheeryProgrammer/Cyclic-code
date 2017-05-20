namespace Lab_4
{
	partial class CyclicCode
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbN = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbK = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbH = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbToEncode = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.btnEncode = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tbGeneration = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "n";
			// 
			// tbN
			// 
			this.tbN.Location = new System.Drawing.Point(156, 12);
			this.tbN.Name = "tbN";
			this.tbN.Size = new System.Drawing.Size(100, 20);
			this.tbN.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "k";
			// 
			// tbK
			// 
			this.tbK.Location = new System.Drawing.Point(156, 38);
			this.tbK.Name = "tbK";
			this.tbK.Size = new System.Drawing.Size(100, 20);
			this.tbK.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Checking polynomial (H(x))";
			// 
			// tbH
			// 
			this.tbH.Location = new System.Drawing.Point(156, 90);
			this.tbH.Name = "tbH";
			this.tbH.ReadOnly = true;
			this.tbH.Size = new System.Drawing.Size(100, 20);
			this.tbH.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(271, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Word to encode";
			// 
			// tbToEncode
			// 
			this.tbToEncode.Location = new System.Drawing.Point(359, 12);
			this.tbToEncode.Name = "tbToEncode";
			this.tbToEncode.Size = new System.Drawing.Size(100, 20);
			this.tbToEncode.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(271, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "F(x)";
			// 
			// tbResult
			// 
			this.tbResult.Location = new System.Drawing.Point(359, 38);
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.Size = new System.Drawing.Size(100, 20);
			this.tbResult.TabIndex = 1;
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(356, 88);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(100, 23);
			this.btnEncode.TabIndex = 2;
			this.btnEncode.Text = "Encode";
			this.btnEncode.UseVisualStyleBackColor = true;
			this.btnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(139, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Generation polynomial (G(x))";
			// 
			// tbGeneration
			// 
			this.tbGeneration.Location = new System.Drawing.Point(156, 64);
			this.tbGeneration.Name = "tbGeneration";
			this.tbGeneration.Size = new System.Drawing.Size(100, 20);
			this.tbGeneration.TabIndex = 1;
			// 
			// CyclicCode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 123);
			this.Controls.Add(this.btnEncode);
			this.Controls.Add(this.tbH);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbGeneration);
			this.Controls.Add(this.tbK);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbToEncode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbN);
			this.Controls.Add(this.label1);
			this.Name = "CyclicCode";
			this.Text = "Cyclic code";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbToEncode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbGeneration;
	}
}


namespace 二十四点猜解 {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "检测";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.MaxLength = 2;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(38, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(56, 12);
			this.textBox2.MaxLength = 2;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(38, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "2";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(100, 12);
			this.textBox3.MaxLength = 2;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(38, 21);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "3";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(143, 12);
			this.textBox4.MaxLength = 2;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(38, 21);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "4";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(12, 112);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox5.Size = new System.Drawing.Size(170, 251);
			this.textBox5.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(190, 375);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "24点";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox5;
	}
}


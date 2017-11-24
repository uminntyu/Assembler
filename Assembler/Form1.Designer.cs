namespace Assembler
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(30, 115);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(169, 155);
			this.textBox1.TabIndex = 0;
			this.textBox1.WordWrap = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button1.Location = new System.Drawing.Point(205, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "アセンブル";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(288, 115);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(206, 36);
			this.textBox2.TabIndex = 2;
			this.textBox2.TabStop = false;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox3.Enabled = false;
			this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textBox3.Location = new System.Drawing.Point(30, 92);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(114, 19);
			this.textBox3.TabIndex = 3;
			this.textBox3.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(150, 89);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(49, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "開く";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(288, 92);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(125, 19);
			this.textBox4.TabIndex = 5;
			this.textBox4.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(333, 157);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(124, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "保存";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(288, 206);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(206, 64);
			this.textBox5.TabIndex = 7;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox6.Enabled = false;
			this.textBox6.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox6.ForeColor = System.Drawing.Color.Black;
			this.textBox6.Location = new System.Drawing.Point(37, 26);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(261, 29);
			this.textBox6.TabIndex = 8;
			this.textBox6.TabStop = false;
			this.textBox6.Text = "GMC-4アセンブラ";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox7.Enabled = false;
			this.textBox7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox7.HideSelection = false;
			this.textBox7.Location = new System.Drawing.Point(30, 75);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(100, 16);
			this.textBox7.TabIndex = 9;
			this.textBox7.TabStop = false;
			this.textBox7.Text = "入力";
			// 
			// textBox8
			// 
			this.textBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox8.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox8.Enabled = false;
			this.textBox8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox8.HideSelection = false;
			this.textBox8.Location = new System.Drawing.Point(288, 75);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(100, 16);
			this.textBox8.TabIndex = 10;
			this.textBox8.TabStop = false;
			this.textBox8.Text = "出力";
			// 
			// textBox9
			// 
			this.textBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox9.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox9.Enabled = false;
			this.textBox9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox9.HideSelection = false;
			this.textBox9.Location = new System.Drawing.Point(288, 188);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(100, 16);
			this.textBox9.TabIndex = 11;
			this.textBox9.TabStop = false;
			this.textBox9.Text = "メッセージ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(520, 294);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "GMC-4アセンブラ";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}


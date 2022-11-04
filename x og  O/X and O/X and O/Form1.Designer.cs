namespace X_and_O
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
            this.button1 = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TR = new System.Windows.Forms.Button();
            this.ML = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.BL = new System.Windows.Forms.Button();
            this.BM = new System.Windows.Forms.Button();
            this.BR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TL
            // 
            this.TL.Location = new System.Drawing.Point(110, 49);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(180, 152);
            this.TL.TabIndex = 1;
            this.TL.UseVisualStyleBackColor = true;
            this.TL.Click += new System.EventHandler(this.X_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(735, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(735, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Player 1 = X";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(735, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Player 2 = O";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 152);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TR
            // 
            this.TR.Location = new System.Drawing.Point(482, 49);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(180, 152);
            this.TR.TabIndex = 6;
            this.TR.UseVisualStyleBackColor = true;
            this.TR.Click += new System.EventHandler(this.button3_Click);
            // 
            // ML
            // 
            this.ML.Location = new System.Drawing.Point(110, 207);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(180, 152);
            this.ML.TabIndex = 7;
            this.ML.UseVisualStyleBackColor = true;
            this.ML.Click += new System.EventHandler(this.button4_Click);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(296, 207);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(180, 152);
            this.MM.TabIndex = 8;
            this.MM.UseVisualStyleBackColor = true;
            this.MM.Click += new System.EventHandler(this.MM_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(482, 207);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(180, 152);
            this.MR.TabIndex = 9;
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // BL
            // 
            this.BL.Location = new System.Drawing.Point(110, 365);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(180, 152);
            this.BL.TabIndex = 10;
            this.BL.UseVisualStyleBackColor = true;
            this.BL.Click += new System.EventHandler(this.BL_Click);
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(296, 365);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(180, 152);
            this.BM.TabIndex = 11;
            this.BM.UseVisualStyleBackColor = true;
            this.BM.Click += new System.EventHandler(this.BM_Click);
            // 
            // BR
            // 
            this.BR.Location = new System.Drawing.Point(482, 365);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(180, 152);
            this.BR.TabIndex = 12;
            this.BR.UseVisualStyleBackColor = true;
            this.BR.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 536);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TR;
        private System.Windows.Forms.Button ML;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button BL;
        private System.Windows.Forms.Button BM;
        private System.Windows.Forms.Button BR;
    }
}


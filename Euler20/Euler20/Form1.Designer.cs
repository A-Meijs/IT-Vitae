namespace Euler20
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FactLabel = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.Nlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.B_D7 = new System.Windows.Forms.Button();
            this.B_D8 = new System.Windows.Forms.Button();
            this.B_Clear = new System.Windows.Forms.Button();
            this.B_D0 = new System.Windows.Forms.Button();
            this.B_D4 = new System.Windows.Forms.Button();
            this.B_D5 = new System.Windows.Forms.Button();
            this.B_D2 = new System.Windows.Forms.Button();
            this.B_D1 = new System.Windows.Forms.Button();
            this.B_D3 = new System.Windows.Forms.Button();
            this.B_D6 = new System.Windows.Forms.Button();
            this.B_Calculate = new System.Windows.Forms.Button();
            this.B_D9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "n!:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sum of digits:";
            // 
            // FactLabel
            // 
            this.FactLabel.AutoSize = true;
            this.FactLabel.Location = new System.Drawing.Point(12, 96);
            this.FactLabel.Name = "FactLabel";
            this.FactLabel.Size = new System.Drawing.Size(13, 13);
            this.FactLabel.TabIndex = 3;
            this.FactLabel.Text = "0";
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(12, 146);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(13, 13);
            this.SumLabel.TabIndex = 4;
            this.SumLabel.Text = "0";
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Location = new System.Drawing.Point(12, 46);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(13, 13);
            this.Nlabel.TabIndex = 8;
            this.Nlabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "n:";
            // 
            // B_D7
            // 
            this.B_D7.Location = new System.Drawing.Point(15, 191);
            this.B_D7.Name = "B_D7";
            this.B_D7.Size = new System.Drawing.Size(75, 23);
            this.B_D7.TabIndex = 9;
            this.B_D7.Text = "7";
            this.B_D7.UseVisualStyleBackColor = true;
            this.B_D7.Click += new System.EventHandler(this.B_D7_Click);
            // 
            // B_D8
            // 
            this.B_D8.Location = new System.Drawing.Point(96, 191);
            this.B_D8.Name = "B_D8";
            this.B_D8.Size = new System.Drawing.Size(75, 23);
            this.B_D8.TabIndex = 10;
            this.B_D8.Text = "8";
            this.B_D8.UseVisualStyleBackColor = true;
            this.B_D8.Click += new System.EventHandler(this.B_D8_Click);
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(96, 278);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 23);
            this.B_Clear.TabIndex = 12;
            this.B_Clear.Text = "Clear";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // B_D0
            // 
            this.B_D0.Location = new System.Drawing.Point(15, 278);
            this.B_D0.Name = "B_D0";
            this.B_D0.Size = new System.Drawing.Size(75, 23);
            this.B_D0.TabIndex = 11;
            this.B_D0.Text = "0";
            this.B_D0.UseVisualStyleBackColor = true;
            this.B_D0.Click += new System.EventHandler(this.B_D0_Click);
            // 
            // B_D4
            // 
            this.B_D4.Location = new System.Drawing.Point(15, 220);
            this.B_D4.Name = "B_D4";
            this.B_D4.Size = new System.Drawing.Size(75, 23);
            this.B_D4.TabIndex = 11;
            this.B_D4.Text = "4";
            this.B_D4.UseVisualStyleBackColor = true;
            this.B_D4.Click += new System.EventHandler(this.B_D4_Click);
            // 
            // B_D5
            // 
            this.B_D5.Location = new System.Drawing.Point(96, 220);
            this.B_D5.Name = "B_D5";
            this.B_D5.Size = new System.Drawing.Size(75, 23);
            this.B_D5.TabIndex = 12;
            this.B_D5.Text = "5";
            this.B_D5.UseVisualStyleBackColor = true;
            this.B_D5.Click += new System.EventHandler(this.B_D5_Click);
            // 
            // B_D2
            // 
            this.B_D2.Location = new System.Drawing.Point(96, 249);
            this.B_D2.Name = "B_D2";
            this.B_D2.Size = new System.Drawing.Size(75, 23);
            this.B_D2.TabIndex = 14;
            this.B_D2.Text = "2";
            this.B_D2.UseVisualStyleBackColor = true;
            this.B_D2.Click += new System.EventHandler(this.B_D2_Click);
            // 
            // B_D1
            // 
            this.B_D1.Location = new System.Drawing.Point(15, 249);
            this.B_D1.Name = "B_D1";
            this.B_D1.Size = new System.Drawing.Size(75, 23);
            this.B_D1.TabIndex = 13;
            this.B_D1.Text = "1";
            this.B_D1.UseVisualStyleBackColor = true;
            this.B_D1.Click += new System.EventHandler(this.B_D1_Click);
            // 
            // B_D3
            // 
            this.B_D3.Location = new System.Drawing.Point(177, 249);
            this.B_D3.Name = "B_D3";
            this.B_D3.Size = new System.Drawing.Size(75, 23);
            this.B_D3.TabIndex = 18;
            this.B_D3.Text = "3";
            this.B_D3.UseVisualStyleBackColor = true;
            this.B_D3.Click += new System.EventHandler(this.B_D3_Click);
            // 
            // B_D6
            // 
            this.B_D6.Location = new System.Drawing.Point(177, 220);
            this.B_D6.Name = "B_D6";
            this.B_D6.Size = new System.Drawing.Size(75, 23);
            this.B_D6.TabIndex = 16;
            this.B_D6.Text = "6";
            this.B_D6.UseVisualStyleBackColor = true;
            this.B_D6.Click += new System.EventHandler(this.B_D6_Click);
            // 
            // B_Calculate
            // 
            this.B_Calculate.Location = new System.Drawing.Point(177, 278);
            this.B_Calculate.Name = "B_Calculate";
            this.B_Calculate.Size = new System.Drawing.Size(75, 23);
            this.B_Calculate.TabIndex = 17;
            this.B_Calculate.Text = "Calculate";
            this.B_Calculate.UseVisualStyleBackColor = true;
            this.B_Calculate.Click += new System.EventHandler(this.B_Calculate_Click);
            // 
            // B_D9
            // 
            this.B_D9.Location = new System.Drawing.Point(177, 191);
            this.B_D9.Name = "B_D9";
            this.B_D9.Size = new System.Drawing.Size(75, 23);
            this.B_D9.TabIndex = 15;
            this.B_D9.Text = "9";
            this.B_D9.UseVisualStyleBackColor = true;
            this.B_D9.Click += new System.EventHandler(this.B_D9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 309);
            this.Controls.Add(this.B_D3);
            this.Controls.Add(this.B_D6);
            this.Controls.Add(this.B_Calculate);
            this.Controls.Add(this.B_D9);
            this.Controls.Add(this.B_D2);
            this.Controls.Add(this.B_D1);
            this.Controls.Add(this.B_D5);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.B_D4);
            this.Controls.Add(this.B_D0);
            this.Controls.Add(this.B_D8);
            this.Controls.Add(this.B_D7);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.FactLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sum of factorial digits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FactLabel;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button B_D7;
        private System.Windows.Forms.Button B_D8;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_D0;
        private System.Windows.Forms.Button B_D4;
        private System.Windows.Forms.Button B_D5;
        private System.Windows.Forms.Button B_D2;
        private System.Windows.Forms.Button B_D1;
        private System.Windows.Forms.Button B_D3;
        private System.Windows.Forms.Button B_D6;
        private System.Windows.Forms.Button B_Calculate;
        private System.Windows.Forms.Button B_D9;
    }
}


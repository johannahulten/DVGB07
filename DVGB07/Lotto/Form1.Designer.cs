
namespace Lotto
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
            this.txb_nbr_1 = new System.Windows.Forms.TextBox();
            this.txb_nbr_6 = new System.Windows.Forms.TextBox();
            this.txb_nbr_5 = new System.Windows.Forms.TextBox();
            this.txb_nbr_4 = new System.Windows.Forms.TextBox();
            this.txb_nbr_3 = new System.Windows.Forms.TextBox();
            this.txb_nbr_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_iterations = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_nbr_7 = new System.Windows.Forms.TextBox();
            this.lbl_error_guess = new System.Windows.Forms.Label();
            this.lbl_error_iterations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Din lottorad: ";
            // 
            // txb_nbr_1
            // 
            this.txb_nbr_1.Location = new System.Drawing.Point(182, 75);
            this.txb_nbr_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_1.MaxLength = 2;
            this.txb_nbr_1.Name = "txb_nbr_1";
            this.txb_nbr_1.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_1.TabIndex = 1;
            this.txb_nbr_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_1.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // txb_nbr_6
            // 
            this.txb_nbr_6.Location = new System.Drawing.Point(807, 75);
            this.txb_nbr_6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_6.Name = "txb_nbr_6";
            this.txb_nbr_6.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_6.TabIndex = 6;
            this.txb_nbr_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_6.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // txb_nbr_5
            // 
            this.txb_nbr_5.Location = new System.Drawing.Point(682, 75);
            this.txb_nbr_5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_5.Name = "txb_nbr_5";
            this.txb_nbr_5.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_5.TabIndex = 5;
            this.txb_nbr_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_5.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // txb_nbr_4
            // 
            this.txb_nbr_4.Location = new System.Drawing.Point(557, 75);
            this.txb_nbr_4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_4.Name = "txb_nbr_4";
            this.txb_nbr_4.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_4.TabIndex = 4;
            this.txb_nbr_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_4.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // txb_nbr_3
            // 
            this.txb_nbr_3.Location = new System.Drawing.Point(432, 75);
            this.txb_nbr_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_3.Name = "txb_nbr_3";
            this.txb_nbr_3.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_3.TabIndex = 3;
            this.txb_nbr_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_3.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // txb_nbr_2
            // 
            this.txb_nbr_2.Location = new System.Drawing.Point(307, 75);
            this.txb_nbr_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_nbr_2.Name = "txb_nbr_2";
            this.txb_nbr_2.Size = new System.Drawing.Size(88, 26);
            this.txb_nbr_2.TabIndex = 2;
            this.txb_nbr_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_nbr_2.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antal dragningar";
            // 
            // txb_iterations
            // 
            this.txb_iterations.Location = new System.Drawing.Point(304, 191);
            this.txb_iterations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_iterations.Name = "txb_iterations";
            this.txb_iterations.Size = new System.Drawing.Size(148, 26);
            this.txb_iterations.TabIndex = 8;
            this.txb_iterations.TextChanged += new System.EventHandler(this.iterations_Changed);
            // 
            // start_btn
            // 
            this.start_btn.Enabled = false;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(550, 189);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(213, 35);
            this.start_btn.TabIndex = 9;
            this.start_btn.Text = "Starta Lotto";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 415);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "5 rätt: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(696, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "7 rätt: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "6 rätt: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 415);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "1160";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 415);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "27";
            // 
            // tbx_nbr_7
            // 
            this.tbx_nbr_7.Location = new System.Drawing.Point(932, 75);
            this.tbx_nbr_7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_nbr_7.Name = "tbx_nbr_7";
            this.tbx_nbr_7.Size = new System.Drawing.Size(88, 26);
            this.tbx_nbr_7.TabIndex = 7;
            this.tbx_nbr_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_nbr_7.TextChanged += new System.EventHandler(this.guess_Changed);
            // 
            // lbl_error_guess
            // 
            this.lbl_error_guess.AutoSize = true;
            this.lbl_error_guess.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_guess.Location = new System.Drawing.Point(182, 133);
            this.lbl_error_guess.Name = "lbl_error_guess";
            this.lbl_error_guess.Size = new System.Drawing.Size(51, 20);
            this.lbl_error_guess.TabIndex = 16;
            this.lbl_error_guess.Text = "label9";
            this.lbl_error_guess.Visible = false;
            // 
            // lbl_error_iterations
            // 
            this.lbl_error_iterations.AutoSize = true;
            this.lbl_error_iterations.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_iterations.Location = new System.Drawing.Point(300, 234);
            this.lbl_error_iterations.Name = "lbl_error_iterations";
            this.lbl_error_iterations.Size = new System.Drawing.Size(51, 20);
            this.lbl_error_iterations.TabIndex = 17;
            this.lbl_error_iterations.Text = "label9";
            this.lbl_error_iterations.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lbl_error_iterations);
            this.Controls.Add(this.lbl_error_guess);
            this.Controls.Add(this.tbx_nbr_7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.txb_iterations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_nbr_2);
            this.Controls.Add(this.txb_nbr_3);
            this.Controls.Add(this.txb_nbr_4);
            this.Controls.Add(this.txb_nbr_5);
            this.Controls.Add(this.txb_nbr_6);
            this.Controls.Add(this.txb_nbr_1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_nbr_1;
        private System.Windows.Forms.TextBox txb_nbr_6;
        private System.Windows.Forms.TextBox txb_nbr_5;
        private System.Windows.Forms.TextBox txb_nbr_4;
        private System.Windows.Forms.TextBox txb_nbr_3;
        private System.Windows.Forms.TextBox txb_nbr_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_iterations;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_nbr_7;
        private System.Windows.Forms.Label lbl_error_guess;
        private System.Windows.Forms.Label lbl_error_iterations;
    }
}


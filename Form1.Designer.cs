namespace Equazioni
{
    partial class Risolutore
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Risolutore));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.input_coef_1 = new System.Windows.Forms.TextBox();
            this.input_coef_2 = new System.Windows.Forms.TextBox();
            this.output_x1 = new System.Windows.Forms.TextBox();
            this.output_x2 = new System.Windows.Forms.TextBox();
            this.input_coef_3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.io = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.io)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "coef.1 (x^2)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(311, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "coef.2 (x)";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x1.Location = new System.Drawing.Point(153, 416);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(26, 20);
            this.x1.TabIndex = 2;
            this.x1.Text = "x1";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x2.Location = new System.Drawing.Point(433, 407);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(26, 20);
            this.x2.TabIndex = 3;
            this.x2.Text = "x2";
            // 
            // input_coef_1
            // 
            this.input_coef_1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_coef_1.Location = new System.Drawing.Point(174, 62);
            this.input_coef_1.Name = "input_coef_1";
            this.input_coef_1.ShortcutsEnabled = false;
            this.input_coef_1.Size = new System.Drawing.Size(100, 27);
            this.input_coef_1.TabIndex = 4;
            this.input_coef_1.TextChanged += new System.EventHandler(this.input_coef_1_TextChanged);
            this.input_coef_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_coef_1_KeyDown);
            this.input_coef_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_coef_1_KeyPress);
            // 
            // input_coef_2
            // 
            this.input_coef_2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_coef_2.Location = new System.Drawing.Point(393, 62);
            this.input_coef_2.Name = "input_coef_2";
            this.input_coef_2.ShortcutsEnabled = false;
            this.input_coef_2.Size = new System.Drawing.Size(100, 27);
            this.input_coef_2.TabIndex = 5;
            this.input_coef_2.TextChanged += new System.EventHandler(this.input_coef_2_TextChanged);
            this.input_coef_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_coef_1_KeyDown);
            // 
            // output_x1
            // 
            this.output_x1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output_x1.Location = new System.Drawing.Point(197, 407);
            this.output_x1.Name = "output_x1";
            this.output_x1.Size = new System.Drawing.Size(100, 27);
            this.output_x1.TabIndex = 6;
            // 
            // output_x2
            // 
            this.output_x2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output_x2.Location = new System.Drawing.Point(477, 407);
            this.output_x2.Name = "output_x2";
            this.output_x2.Size = new System.Drawing.Size(100, 27);
            this.output_x2.TabIndex = 7;
            // 
            // input_coef_3
            // 
            this.input_coef_3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_coef_3.Location = new System.Drawing.Point(598, 62);
            this.input_coef_3.Name = "input_coef_3";
            this.input_coef_3.Size = new System.Drawing.Size(100, 27);
            this.input_coef_3.TabIndex = 9;
            this.input_coef_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_coef_1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(538, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "coef.3";
            // 
            // solve
            // 
            this.solve.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solve.Location = new System.Drawing.Point(348, 153);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(75, 28);
            this.solve.TabIndex = 10;
            this.solve.Text = "solve";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(695, 458);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 26);
            this.close.TabIndex = 11;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(40, 458);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 26);
            this.clear.TabIndex = 12;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // io
            // 
            this.io.BackColor = System.Drawing.Color.DarkMagenta;
            this.io.Image = ((System.Drawing.Image)(resources.GetObject("io.Image")));
            this.io.Location = new System.Drawing.Point(337, 385);
            this.io.Name = "io";
            this.io.Size = new System.Drawing.Size(86, 89);
            this.io.TabIndex = 13;
            this.io.TabStop = false;
            // 
            // Risolutore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.io);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.close);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.input_coef_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.output_x2);
            this.Controls.Add(this.output_x1);
            this.Controls.Add(this.input_coef_2);
            this.Controls.Add(this.input_coef_1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Risolutore";
            this.Text = "Risolutore Equazioni";
            ((System.ComponentModel.ISupportInitialize)(this.io)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label x1;
        private Label x2;
        private TextBox input_coef_1;
        private TextBox input_coef_2;
        private TextBox output_x1;
        private TextBox output_x2;
        private TextBox input_coef_3;
        private Label label5;
        private Button solve;
        private Button close;
        private Button clear;
        private PictureBox io;
    }
}
namespace triangulos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLadoA = new System.Windows.Forms.TextBox();
            this.inputLadoB = new System.Windows.Forms.TextBox();
            this.inputLadoC = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgTriangulo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado A :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lado C :";
            // 
            // inputLadoA
            // 
            this.inputLadoA.Location = new System.Drawing.Point(18, 43);
            this.inputLadoA.Name = "inputLadoA";
            this.inputLadoA.Size = new System.Drawing.Size(100, 20);
            this.inputLadoA.TabIndex = 3;
            // 
            // inputLadoB
            // 
            this.inputLadoB.Location = new System.Drawing.Point(143, 43);
            this.inputLadoB.Name = "inputLadoB";
            this.inputLadoB.Size = new System.Drawing.Size(100, 20);
            this.inputLadoB.TabIndex = 4;
            // 
            // inputLadoC
            // 
            this.inputLadoC.Location = new System.Drawing.Point(268, 43);
            this.inputLadoC.Name = "inputLadoC";
            this.inputLadoC.Size = new System.Drawing.Size(100, 20);
            this.inputLadoC.TabIndex = 5;
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(136, 85);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(112, 36);
            this.verificar.TabIndex = 6;
            this.verificar.Text = "Classificar Triangulo";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(51, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulo";
            // 
            // imgTriangulo
            // 
            this.imgTriangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTriangulo.InitialImage = null;
            this.imgTriangulo.Location = new System.Drawing.Point(6, 16);
            this.imgTriangulo.Name = "imgTriangulo";
            this.imgTriangulo.Size = new System.Drawing.Size(276, 200);
            this.imgTriangulo.TabIndex = 0;
            this.imgTriangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.inputLadoC);
            this.Controls.Add(this.inputLadoB);
            this.Controls.Add(this.inputLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Classificar triângulo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputLadoA;
        private System.Windows.Forms.TextBox inputLadoB;
        private System.Windows.Forms.TextBox inputLadoC;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgTriangulo;
    }
}


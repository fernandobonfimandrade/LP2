namespace Calculo_volume_Cilindro
{
    partial class volume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(volume));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raio = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "R :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "H :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // raio
            // 
            this.raio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raio.Location = new System.Drawing.Point(46, 154);
            this.raio.Name = "raio";
            this.raio.Size = new System.Drawing.Size(92, 26);
            this.raio.TabIndex = 3;
            this.raio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // altura
            // 
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(175, 154);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(97, 26);
            this.altura.TabIndex = 4;
            this.altura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.Location = new System.Drawing.Point(96, 246);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(95, 30);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(70, 203);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(148, 26);
            this.resultado.TabIndex = 6;
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.raio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "volume";
            this.Text = "Volume Cilindro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox raio;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.TextBox resultado;
    }
}


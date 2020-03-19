namespace calculoPesoIdeal
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
            this.inputPeso = new System.Windows.Forms.MaskedTextBox();
            this.inputAltura = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.inputPesoIdeal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso (Kg)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura (m)";
            // 
            // inputPeso
            // 
            this.inputPeso.AllowPromptAsInput = false;
            this.inputPeso.HidePromptOnLeave = true;
            this.inputPeso.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.inputPeso.Location = new System.Drawing.Point(128, 33);
            this.inputPeso.Mask = "999.00";
            this.inputPeso.Name = "inputPeso";
            this.inputPeso.PromptChar = ' ';
            this.inputPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputPeso.Size = new System.Drawing.Size(119, 20);
            this.inputPeso.TabIndex = 2;
            this.inputPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputPeso.ValidatingType = typeof(System.DateTime);
            // 
            // inputAltura
            // 
            this.inputAltura.AllowPromptAsInput = false;
            this.inputAltura.HidePromptOnLeave = true;
            this.inputAltura.Location = new System.Drawing.Point(128, 64);
            this.inputAltura.Mask = "9.00";
            this.inputAltura.Name = "inputAltura";
            this.inputAltura.PromptChar = ' ';
            this.inputAltura.Size = new System.Drawing.Size(119, 20);
            this.inputAltura.TabIndex = 3;
            this.inputAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputAltura.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFem);
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Location = new System.Drawing.Point(68, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Checked = true;
            this.radioMasc.Location = new System.Drawing.Point(16, 32);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            this.radioMasc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Location = new System.Drawing.Point(98, 32);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(67, 17);
            this.radioFem.TabIndex = 1;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // inputPesoIdeal
            // 
            this.inputPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPesoIdeal.Location = new System.Drawing.Point(68, 279);
            this.inputPesoIdeal.Name = "inputPesoIdeal";
            this.inputPesoIdeal.ReadOnly = true;
            this.inputPesoIdeal.Size = new System.Drawing.Size(179, 20);
            this.inputPesoIdeal.TabIndex = 5;
            this.inputPesoIdeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peso Ideal :";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(118, 202);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 367);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPesoIdeal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputAltura);
            this.Controls.Add(this.inputPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cálculo Peso Ideal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox inputPeso;
        private System.Windows.Forms.MaskedTextBox inputAltura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.TextBox inputPesoIdeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcular;
    }
}


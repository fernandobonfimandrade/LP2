namespace inss_irpf
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemino = new System.Windows.Forms.RadioButton();
            this.checkCasado = new System.Windows.Forms.CheckBox();
            this.inputNome = new System.Windows.Forms.MaskedTextBox();
            this.inputSalario = new System.Windows.Forms.MaskedTextBox();
            this.inputQtdFilhos = new System.Windows.Forms.MaskedTextBox();
            this.calcularBT = new System.Windows.Forms.Button();
            this.msgSobre = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.outAliqInss = new System.Windows.Forms.MaskedTextBox();
            this.outAliqIrpf = new System.Windows.Forms.MaskedTextBox();
            this.outSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.outSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.outValorInss = new System.Windows.Forms.MaskedTextBox();
            this.outValorIrpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Filhos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFemino);
            this.groupBox1.Controls.Add(this.radioMasculino);
            this.groupBox1.Location = new System.Drawing.Point(332, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Checked = true;
            this.radioMasculino.Location = new System.Drawing.Point(24, 26);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioMasculino.TabIndex = 0;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFemino
            // 
            this.radioFemino.AutoSize = true;
            this.radioFemino.Location = new System.Drawing.Point(24, 58);
            this.radioFemino.Name = "radioFemino";
            this.radioFemino.Size = new System.Drawing.Size(67, 17);
            this.radioFemino.TabIndex = 1;
            this.radioFemino.Text = "Feminino";
            this.radioFemino.UseVisualStyleBackColor = true;
            // 
            // checkCasado
            // 
            this.checkCasado.AutoSize = true;
            this.checkCasado.Location = new System.Drawing.Point(233, 108);
            this.checkCasado.Name = "checkCasado";
            this.checkCasado.Size = new System.Drawing.Size(62, 17);
            this.checkCasado.TabIndex = 4;
            this.checkCasado.Text = "Casado";
            this.checkCasado.UseVisualStyleBackColor = true;
            this.checkCasado.CheckedChanged += new System.EventHandler(this.checkCasado_CheckedChanged);
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(128, 23);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(167, 20);
            this.inputNome.TabIndex = 5;
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(128, 64);
            this.inputSalario.Mask = "99990.00";
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.Size = new System.Drawing.Size(53, 20);
            this.inputSalario.TabIndex = 6;
            this.inputSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSalario.ValidatingType = typeof(int);
            // 
            // inputQtdFilhos
            // 
            this.inputQtdFilhos.Location = new System.Drawing.Point(128, 105);
            this.inputQtdFilhos.Mask = "90";
            this.inputQtdFilhos.Name = "inputQtdFilhos";
            this.inputQtdFilhos.Size = new System.Drawing.Size(21, 20);
            this.inputQtdFilhos.TabIndex = 7;
            this.inputQtdFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputQtdFilhos.ValidatingType = typeof(int);
            // 
            // calcularBT
            // 
            this.calcularBT.Location = new System.Drawing.Point(173, 168);
            this.calcularBT.Name = "calcularBT";
            this.calcularBT.Size = new System.Drawing.Size(143, 42);
            this.calcularBT.TabIndex = 8;
            this.calcularBT.Text = "Calcular Descontos";
            this.calcularBT.UseVisualStyleBackColor = true;
            this.calcularBT.Click += new System.EventHandler(this.calcularBT_Click);
            // 
            // msgSobre
            // 
            this.msgSobre.BackColor = System.Drawing.SystemColors.Control;
            this.msgSobre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msgSobre.Location = new System.Drawing.Point(11, 24);
            this.msgSobre.Name = "msgSobre";
            this.msgSobre.ReadOnly = true;
            this.msgSobre.Size = new System.Drawing.Size(448, 41);
            this.msgSobre.TabIndex = 9;
            this.msgSobre.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outValorIrpf);
            this.groupBox2.Controls.Add(this.outValorInss);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.outSalLiquido);
            this.groupBox2.Controls.Add(this.outSalFamilia);
            this.groupBox2.Controls.Add(this.outAliqIrpf);
            this.groupBox2.Controls.Add(this.outAliqInss);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.msgSobre);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 252);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aliquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aliquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salário Família";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salário Líquido";
            // 
            // outAliqInss
            // 
            this.outAliqInss.Location = new System.Drawing.Point(134, 90);
            this.outAliqInss.Name = "outAliqInss";
            this.outAliqInss.Size = new System.Drawing.Size(53, 20);
            this.outAliqInss.TabIndex = 14;
            this.outAliqInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outAliqInss.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // outAliqIrpf
            // 
            this.outAliqIrpf.Location = new System.Drawing.Point(134, 131);
            this.outAliqIrpf.Name = "outAliqIrpf";
            this.outAliqIrpf.Size = new System.Drawing.Size(53, 20);
            this.outAliqIrpf.TabIndex = 15;
            this.outAliqIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outSalFamilia
            // 
            this.outSalFamilia.Location = new System.Drawing.Point(134, 172);
            this.outSalFamilia.Name = "outSalFamilia";
            this.outSalFamilia.Size = new System.Drawing.Size(53, 20);
            this.outSalFamilia.TabIndex = 16;
            this.outSalFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outSalLiquido
            // 
            this.outSalLiquido.Location = new System.Drawing.Point(134, 213);
            this.outSalLiquido.Name = "outSalLiquido";
            this.outSalLiquido.Size = new System.Drawing.Size(53, 20);
            this.outSalLiquido.TabIndex = 17;
            this.outSalLiquido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Desconto INSS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Desconto IRPF";
            // 
            // outValorInss
            // 
            this.outValorInss.Location = new System.Drawing.Point(381, 90);
            this.outValorInss.Name = "outValorInss";
            this.outValorInss.Size = new System.Drawing.Size(55, 20);
            this.outValorInss.TabIndex = 20;
            this.outValorInss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outValorIrpf
            // 
            this.outValorIrpf.Location = new System.Drawing.Point(381, 131);
            this.outValorIrpf.Name = "outValorIrpf";
            this.outValorIrpf.Size = new System.Drawing.Size(55, 20);
            this.outValorIrpf.TabIndex = 21;
            this.outValorIrpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.calcularBT);
            this.Controls.Add(this.inputQtdFilhos);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.checkCasado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculo INSS IRPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.CheckBox checkCasado;
        private System.Windows.Forms.MaskedTextBox inputNome;
        private System.Windows.Forms.MaskedTextBox inputSalario;
        private System.Windows.Forms.MaskedTextBox inputQtdFilhos;
        private System.Windows.Forms.Button calcularBT;
        private System.Windows.Forms.RichTextBox msgSobre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox outSalLiquido;
        private System.Windows.Forms.MaskedTextBox outSalFamilia;
        private System.Windows.Forms.MaskedTextBox outAliqIrpf;
        private System.Windows.Forms.MaskedTextBox outAliqInss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox outValorIrpf;
        private System.Windows.Forms.MaskedTextBox outValorInss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}


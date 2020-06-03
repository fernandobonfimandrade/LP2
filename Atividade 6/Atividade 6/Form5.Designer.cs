namespace Atividade_6
{
    partial class Form5
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
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.boxGratif = new System.Windows.Forms.TextBox();
            this.boxProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Salário Bruto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxSalario
            // 
            this.boxSalario.Location = new System.Drawing.Point(110, 71);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(100, 20);
            this.boxSalario.TabIndex = 1;
            // 
            // boxGratif
            // 
            this.boxGratif.Location = new System.Drawing.Point(533, 71);
            this.boxGratif.Name = "boxGratif";
            this.boxGratif.Size = new System.Drawing.Size(100, 20);
            this.boxGratif.TabIndex = 2;
            // 
            // boxProd
            // 
            this.boxProd.Location = new System.Drawing.Point(326, 71);
            this.boxProd.Name = "boxProd";
            this.boxProd.Size = new System.Drawing.Size(100, 20);
            this.boxProd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salario Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gratificação";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxProd);
            this.Controls.Add(this.boxGratif);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxSalario;
        private System.Windows.Forms.TextBox boxGratif;
        private System.Windows.Forms.TextBox boxProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
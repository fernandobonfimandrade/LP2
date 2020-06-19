namespace P30481923015
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
            this.EntradaDados = new System.Windows.Forms.Button();
            this.BoxSaida = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EntradaDados
            // 
            this.EntradaDados.Location = new System.Drawing.Point(156, 184);
            this.EntradaDados.Name = "EntradaDados";
            this.EntradaDados.Size = new System.Drawing.Size(125, 60);
            this.EntradaDados.TabIndex = 0;
            this.EntradaDados.Text = "Informar Vendas";
            this.EntradaDados.UseVisualStyleBackColor = true;
            this.EntradaDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoxSaida
            // 
            this.BoxSaida.FormattingEnabled = true;
            this.BoxSaida.Location = new System.Drawing.Point(434, 23);
            this.BoxSaida.Name = "BoxSaida";
            this.BoxSaida.Size = new System.Drawing.Size(344, 394);
            this.BoxSaida.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BoxSaida);
            this.Controls.Add(this.EntradaDados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EntradaDados;
        private System.Windows.Forms.ListBox BoxSaida;
    }
}


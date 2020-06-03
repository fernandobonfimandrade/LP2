namespace Atividade_6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividade2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade2ToolStripMenuItem,
            this.atividade3ToolStripMenuItem,
            this.atividade4ToolStripMenuItem,
            this.atividade5ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividade2ToolStripMenuItem
            // 
            this.atividade2ToolStripMenuItem.Name = "atividade2ToolStripMenuItem";
            this.atividade2ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade2ToolStripMenuItem.Text = "Atividade 1";
            this.atividade2ToolStripMenuItem.Click += new System.EventHandler(this.atividade2ToolStripMenuItem_Click);
            // 
            // atividade3ToolStripMenuItem
            // 
            this.atividade3ToolStripMenuItem.Name = "atividade3ToolStripMenuItem";
            this.atividade3ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.atividade3ToolStripMenuItem.Text = "Atividade2";
            this.atividade3ToolStripMenuItem.Click += new System.EventHandler(this.atividade3ToolStripMenuItem_Click);
            // 
            // atividade4ToolStripMenuItem
            // 
            this.atividade4ToolStripMenuItem.Name = "atividade4ToolStripMenuItem";
            this.atividade4ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade4ToolStripMenuItem.Text = "Atividade 3";
            this.atividade4ToolStripMenuItem.Click += new System.EventHandler(this.atividade4ToolStripMenuItem_Click);
            // 
            // atividade5ToolStripMenuItem
            // 
            this.atividade5ToolStripMenuItem.Name = "atividade5ToolStripMenuItem";
            this.atividade5ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.atividade5ToolStripMenuItem.Text = "Atividade 4";
            this.atividade5ToolStripMenuItem.Click += new System.EventHandler(this.atividade5ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividade2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade5ToolStripMenuItem;
    }
}


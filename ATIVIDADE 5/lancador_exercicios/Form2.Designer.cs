namespace lancador_exercicios
{
    partial class formExe2
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
            System.Windows.Forms.Button button1;
            this.palavra1 = new System.Windows.Forms.TextBox();
            this.palavra2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(97, 224);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(91, 70);
            button1.TabIndex = 2;
            button1.Text = "Comparar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // palavra1
            // 
            this.palavra1.Location = new System.Drawing.Point(68, 58);
            this.palavra1.Name = "palavra1";
            this.palavra1.Size = new System.Drawing.Size(260, 20);
            this.palavra1.TabIndex = 0;
            // 
            // palavra2
            // 
            this.palavra2.Location = new System.Drawing.Point(392, 58);
            this.palavra2.Name = "palavra2";
            this.palavra2.Size = new System.Drawing.Size(285, 20);
            this.palavra2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Inserir Palavra1 na Palavra2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 70);
            this.button3.TabIndex = 4;
            this.button3.Text = "Insere ** na Palavra1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formExe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(button1);
            this.Controls.Add(this.palavra2);
            this.Controls.Add(this.palavra1);
            this.Name = "formExe2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox palavra1;
        private System.Windows.Forms.TextBox palavra2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lancador_exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercício2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formExe2 form_Exe2 = new formExe2();
            form_Exe2.MdiParent = this;
            form_Exe2.WindowState = FormWindowState.Maximized;
            form_Exe2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form_Exe3 = new Form3();
            form_Exe3.MdiParent = this;
            form_Exe3.WindowState = FormWindowState.Maximized;
            form_Exe3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form_Exe4 = new Form4();
            form_Exe4.MdiParent = this;
            form_Exe4.WindowState = FormWindowState.Maximized;
            form_Exe4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form_Exe5 = new Form5();
            form_Exe5.MdiParent = this;
            form_Exe5.WindowState = FormWindowState.Maximized;
            form_Exe5.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form_Exe2 = new Form2();
            form_Exe2.MdiParent = this;
            form_Exe2.WindowState = FormWindowState.Maximized;
            form_Exe2.Show();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form_Exe3 = new Form3();
            form_Exe3.MdiParent = this;
            form_Exe3.WindowState = FormWindowState.Maximized;
            form_Exe3.Show();
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form_Exe4 = new Form4();
            form_Exe4.MdiParent = this;
            form_Exe4.WindowState = FormWindowState.Maximized;
            form_Exe4.Show();
        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form_Exe5 = new Form5();
            form_Exe5.MdiParent = this;
            form_Exe5.WindowState = FormWindowState.Maximized;
            form_Exe5.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente tt = new frmCliente();
            tt.MdiParent = this;
            tt.Show();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario tt = new frmFuncionario();
            tt.MdiParent = this;
            tt.Show();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarro tt = new frmCarro();
            tt.MdiParent = this;
            tt.Show();
        }

        private void carroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSCarro tt = new frmSCarro();
            tt.MdiParent = this;
            tt.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSCliente tt = new frmSCliente();
            tt.MdiParent = this;
            tt.Show();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSFuncionario tt = new frmSFuncionario();
            tt.MdiParent = this;
            tt.Show();
        }

        private void carroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUCliente tt = new frmUCliente();
            tt.MdiParent = this;
            tt.Show();
        }

        private void funcionarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUFuncionario tt = new frmUFuncionario();
            tt.MdiParent = this;
            tt.Show();
        }

        private void carroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUCarro tt = new frmUCarro();
            tt.MdiParent = this;
            tt.Show();
        }
    }
}

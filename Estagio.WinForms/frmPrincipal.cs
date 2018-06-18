using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Estagio.WinForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbraFormulario(new frmAterrissagemCliente());
        }

        private void AbraFormulario(Form frm)
        {
            frm.Icon = Icon;
            frm.MdiParent = this;
            frm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbraFormulario(new frmAterrissagemFornecedor());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbraFormulario(new frmAterrissagemProduto());
        }

    }
}

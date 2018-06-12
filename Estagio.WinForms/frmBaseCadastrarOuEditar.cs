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
    public partial class frmBaseCadastrarOuEditar : frmBase
    {
        public frmBaseCadastrarOuEditar()
        {
            InitializeComponent();
        }

        protected virtual void btnConfirmar_Click(object sender, EventArgs e)
        {
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}

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
    public partial class FrmBaseCadastrarOuEditar : frmBase
    {
        public FrmBaseCadastrarOuEditar()
        {
            InitializeComponent();
        }


        protected virtual void btnConfirmar_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



    }
}

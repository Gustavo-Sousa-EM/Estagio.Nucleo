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


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!PodeConfirmar())
            {
                return;
            }
            Grave();
            ExibaMensagemDeSucesso();
            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void ExibaMensagemDeSucesso()
        {
            MessageBox.Show("Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected virtual void Grave()
        {
            throw new NotImplementedException();
        }

        protected virtual bool PodeConfirmar()
        {
            throw new NotImplementedException();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }



    }
}

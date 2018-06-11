using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo
{
    public partial class frmCadastroDeProduto : Form
    {
        private Produto novoProduto = new Produto();

        public frmCadastroDeProduto()
        {
            InitializeComponent();
            tbDescricao.MaxLength = 50;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void InsiraAtributosDeProduto()
        {

            novoProduto.Id = Repositorios.RepositorioDoProduto.Instancia.GetAllId() + 1;
            novoProduto.Descricao = tbDescricao.Text;
            novoProduto.PrecoUnitario = Convert.ToDecimal(tbPrecoUnitario.Text);
            novoProduto.QuantidadeMinimaEstoque = int.Parse(tbQtdeMinimaDeEstoque.Text);
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            var teclaBackSpace = 8;
            var teclaVirgula = 44;
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != teclaBackSpace && e.KeyChar != teclaVirgula)
            {
                e.Handled = true;
            }

        }

        private void tbQtdeMinimaDeEsqoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void valideCamposNulosOuVazios()
        {
            if (String.IsNullOrWhiteSpace(tbDescricao.Text) || String.IsNullOrWhiteSpace(tbPrecoUnitario.Text) || String.IsNullOrWhiteSpace(tbQtdeMinimaDeEstoque.Text))
            {
                throw new Exception();
            }
        }

        private void tbPrecoUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                tbPrecoUnitario.Text = String.Format("{0:0.00}", Convert.ToDecimal(tbPrecoUnitario.Text));
            }
            catch (Exception)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                valideCamposNulosOuVazios();
                InsiraAtributosDeProduto();
                Repositorios.RepositorioDoProduto.Instancia.Add(novoProduto);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Produto Cadastrado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Campos vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo
{
    public partial class frmCadastroDeProdutoEditar : Form
    {
        public frmCadastroDeProdutoEditar()
        {
            InitializeComponent();
        }

        public Produto Produto { get; set; }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            PreenchaOsCamposDoFormulario();
        }

        private void PreenchaOsCamposDoFormulario()
        {
            tbDescricao.Text = Produto?.Descricao ?? String.Empty;
            tbPrecoUnitario.Text = Produto?.PrecoUnitario.ToString() ?? String.Empty;
            tbQtdeMinimaDeEsqoque.Text = Produto?.QuantidadeMinimaEstoque.ToString() ?? String.Empty;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AtualizeAtributosDeProduto();
            Repositorios.RepositorioDoProduto.Instancia.Update(Produto);
            DialogResult = DialogResult.OK;
            MessageBox.Show("Produto Cadastrado");
        }

        private void AtualizeAtributosDeProduto()
        {
            Produto.Descricao = tbDescricao.Text;
            Produto.PrecoUnitario = Convert.ToDecimal(tbPrecoUnitario.Text);
            Produto.QuantidadeMinimaEstoque = int.Parse(tbQtdeMinimaDeEsqoque.Text);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44)
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

        private void frmCadastroDeProdutoEditar_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                tbPrecoUnitario.Text = String.Format("{0:0.00}", Convert.ToDecimal(tbPrecoUnitario.Text));
            }
            catch (Exception)
            {

            }
        }
    }
}

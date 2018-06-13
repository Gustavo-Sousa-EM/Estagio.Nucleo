using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagio.Nucleo;

namespace Estagio.WinForms
{
    public partial class frmCadastrarOuEditarProduto : FrmBaseCadastrarOuEditar
    {
        private Produto novoProduto { get; set; }
        public frmCadastrarOuEditarProduto(Produto produto)
        {

            InitializeComponent();
            PreenchaTableBoxDoFormulario(produto);
        }

        private void PreenchaTableBoxDoFormulario(Produto produto)
        {
            if (produto != null)
            {
                novoProduto = produto;
                tbDescricao.Text = novoProduto.Descricao;
                tbPrecoUnitario.Text = novoProduto.PrecoUnitario.ToString();
                tbQtdeMinima.Text = novoProduto.QuantidadeMinimaEstoque.ToString();
            }
        }


        public override void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                valideCamposNulosOuVazios();
                if (EhNovoProduto())
                {
                    InsiraNovoId();
                    insiraAtributosDeProduto();
                    Nucleo.Repositorios.RepositorioDoProduto.Instancia.Add(novoProduto);
                    MessageBox.Show("Produto Cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    insiraAtributosDeProduto();
                    Nucleo.Repositorios.RepositorioDoProduto.Instancia.Update(novoProduto);
                    MessageBox.Show("Produto Atualizado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InsiraNovoId()
        {
            novoProduto.Id = Nucleo.Repositorios.RepositorioDoProduto.Instancia.GetAllId() + 1;
        }

        private void insiraAtributosDeProduto()
        {
            novoProduto.Descricao = tbDescricao.Text;
            novoProduto.PrecoUnitario = Convert.ToDecimal(tbPrecoUnitario.Text);
            novoProduto.QuantidadeMinimaEstoque = int.Parse(tbQtdeMinima.Text);
        }

        private bool EhNovoProduto()
        {
            return novoProduto.Descricao == null;
        }

        private void valideCamposNulosOuVazios()
        {
            ValidacaoDeCampos.CampoEhVazioOuNulo(tbPrecoUnitario.Text);
            ValidacaoDeCampos.CampoEhVazioOuNulo(tbDescricao.Text);
            ValidacaoDeCampos.CampoEhVazioOuNulo(tbQtdeMinima.Text);
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

        private void tbQtdeMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbPrecoUnitario_Leave(object sender, EventArgs e)
        {
            try
            {
                tbPrecoUnitario.Text = ValidacaoDeCampos.formateStringEmDecimal(tbPrecoUnitario.Text);
            }
            catch (Exception)
            {

            }

        }
    }
}

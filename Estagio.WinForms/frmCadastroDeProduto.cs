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
        Produto novoProduto = new Produto();
        public frmCadastroDeProduto()
        {
            InitializeComponent();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private Produto InsiraAtributosDeProduto()
        {
            
            var idProduto = Convert.ToInt32(Repositorios.RepositorioDoProduto.Instancia.GetAll().Count().ToString());
            novoProduto.Id = idProduto++;
            novoProduto.Descricao = tbDescricao.Text;
            novoProduto.PrecoUnitario = Convert.ToDecimal(tbPrecoUnitario.Text);
            novoProduto.QuantidadeMinimaEstoque = int.Parse(tbQtdeMinimaDeEsqoque.Text);
            return novoProduto;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Repositorios.RepositorioDoProduto.Instancia.Add(novoProduto);
            DialogResult = DialogResult.OK;
            MessageBox.Show("Produto Cadastrado");
        }

   

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

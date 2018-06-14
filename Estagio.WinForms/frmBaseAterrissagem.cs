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
    public partial class frmBaseAterrissagem : frmBase
    {
        public Object objeto { get; set; }


        public frmBaseAterrissagem()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //if (DesignMode) return;
            MonteColunasELinhasDoDataGrid();
        }

        //
        protected virtual void MonteColunasELinhasDoDataGrid()
        {
        }



        protected object ObtenhaProdutoSelecionado()
        {
            return bsDgv.Current;
        }

        protected virtual Form CrieFormulario(object objeto)
        {
            throw new NotImplementedException();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frmCadastro = CrieFormulario(objeto);
            var resultado = frmCadastro.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                AtualizeTelaDeAterrissagem();
            }
        }

        protected virtual void AtualizeTelaDeAterrissagem()
        {
            throw new NotImplementedException();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var produtoSelecionado = ObtenhaProdutoSelecionado();
                if (produtoSelecionado != null)
                {
                    var frmEditarProduto = CrieFormulario(produtoSelecionado);
                    var resultado = frmEditarProduto.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        AtualizeTelaDeAterrissagem();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é Possível editar um produto inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                var produtoSelecionado = bsDgv.Current;
                if (resultado == DialogResult.Yes)
                {
                    excluaProduto();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é Possível excluir um produto inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        protected virtual void excluaProduto()
        {
            throw new NotImplementedException();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltroDoGrid_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            bsDgv.DataSource = ConsulteComFiltro(textBox);
        }

        protected virtual object ConsulteComFiltro(TextBox textBox)
        {
            throw new NotImplementedException();
        }
    }
}

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


        private void frmBaseAterrissagem_Load(object sender, EventArgs e)
        {
            CrieColunasELinhasDoDataGrid();
        }

        //
        private void CrieColunasELinhasDoDataGrid()
        {
            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = Convert.ToString(AdquiraNomeDaPrimeiraColuna()),
                Name = Convert.ToString(AdquiraNomeDaPrimeiraColuna())
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = Convert.ToString(AdquiraNomeDaSegundaColuna()),
                Name = Convert.ToString(AdquiraNomeDaSegundaColuna())
            });
        }

        protected virtual object AdquiraNomeDaPrimeiraColuna()
        {
            return new object();
        }
        protected virtual object AdquiraNomeDaSegundaColuna()
        {
            return new object();
        }



        protected object ObtenhaProdutoSelecionado()
        {
            return bsDgvProdutos.Current;
        }

        protected virtual Form CrieFormulario(object objeto)
        {
            return new Form();
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

        private void AtualizeTelaDeAterrissagem()
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = ObtenhaProdutoSelecionado();
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um Produto!");
                return;
            }
            var frmEditarProduto = CrieFormulario(ObtenhaProdutoSelecionado());
            var resultado = frmEditarProduto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                var produtoSelecionado = bsDgvProdutos.Current;
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
            throw new Exception();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

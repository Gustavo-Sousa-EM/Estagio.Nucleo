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
        public frmBaseAterrissagem()
        {
            InitializeComponent();
        }

        private void frmBaseAterrissagem_Load(object sender, EventArgs e)
        {
            CrieColunasELinhasDoDataGrid();
        }


        protected virtual void CrieColunasELinhasDoDataGrid()
        {
            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = nameof(Object),
                Name = nameof(Object)
            });

            dgvProdutos.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = nameof(Object),
                Name = nameof(Object)
            });
        }

        protected virtual Object selecionaProduto()
        {
            return bsDgvProdutos.Current;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frmCadastroDeProduto = inicializeFrmNulo();
            var resultado = frmCadastroDeProduto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                OnShown(e);
            }
        }
        protected virtual Form inicializeFrmNulo()
        {
            return new Form();
        }

       

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = selecionaProduto();
            if (produtoSelecionado == null)
            {
                MessageBox.Show("Algo");
                return;
            }
            var frmEditarProduto = InicializeFrmComObjeto();

            InicializeFrmComObjeto();
            var resultado = frmEditarProduto.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                OnShown(e);
            }
        }
        protected virtual Form InicializeFrmComObjeto()
        {
            return new Form();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                var produtoSelecionado = bsDgvProdutos.Current;
                if (resultado == DialogResult.Yes)
                {
                    OnShown(e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é Possível excluir um produto inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

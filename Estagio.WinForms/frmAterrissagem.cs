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
using Estagio.Nucleo.Repositorios;

namespace Estagio.WinForms
{
    public partial class frmAterrissagem : frmBase
    {
        public frmAterrissagem()
        {
            InitializeComponent();
        }

        private void frmWinNucleo_Load(object sender, EventArgs e)
        {
            Produto produto01 = new Produto();
            produto01.Id = 1;
            produto01.PrecoUnitario = 15.50m;
            produto01.QuantidadeMinimaEstoque = 10;
            produto01.Descricao = "Pão";


            Produto produto02 = new Produto();
            produto02.Id = 2;
            produto02.PrecoUnitario = 30;
            produto02.QuantidadeMinimaEstoque = 20;
            produto02.Descricao = "Batata";

            Cliente cliente01 = new Cliente();
            cliente01.Id = 1;
            cliente01.Nome = "Josivaldo";
            CPFCNPJ cPFCNPJCliente01 = new CPFCNPJ("447.685.060-03");
            cliente01.CPFCNPJ = cPFCNPJCliente01;

            RepositorioDeCliente.Instancia.Add(cliente01);

            RepositorioDoProduto.Instancia.Add(produto01);
            RepositorioDoProduto.Instancia.Add(produto02);

        }

        protected override void CrieColunasELinhasDoDataGrid()
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = nameof(Produto.Id),
                HeaderText = "ID",
                Name = nameof(Produto.Id)
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 100,
                DataPropertyName = nameof(Produto.Descricao),
                HeaderText = "Descricao",
                Name = nameof(Produto.Descricao)
            });
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bsDataGrid.DataSource = RepositorioDoProduto.Instancia.GetAll();
            bsDataGrid.ResetBindings(false);
        }

        //private void tbTop_KeyDown(object sender, KeyEventArgs e)
        //{
        //    tbTop.MaxLength = 100;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        bsDataGridProduto.DataSource = RepositorioDoProduto.Instancia.GetAll().Where(p => p.Descricao.Contains(tbTop.Text) || p.Id.ToString() == tbTop.Text).ToList();
        //        bsDataGridProduto.ResetBindings(false);
        //    }
        //}

        //private void btnNovo_Click(object sender, EventArgs e)
        //{
        //    var frmCadastroDeProduto = new frmCadastroDeProduto();
        //    var resultado = frmCadastroDeProduto.ShowDialog();
        //    if (resultado == DialogResult.OK)
        //    {
        //        OnShown(e);
        //    }
        //}


        protected override void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var produtoSelecionado = (Produto)bsDataGrid.Current;
                var frmCadastroDeProdutoEditar = crieFormularioEdicao();
                frmCadastroDeProdutoEditar.Produto = produtoSelecionado;
                var resultado = frmCadastroDeProdutoEditar.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    dataGridView.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é Possível editar um produto inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem Certeza que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            try
            {
                var produtoSelecionado = (Produto)bsDataGrid.Current;
                if (resultado == DialogResult.Yes)
                {
                    RepositorioDoProduto.Instancia.Delete((Produto)bsDataGrid.Current);
                    OnShown(e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não é Possível excluir um produto inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}

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
    public partial class frmAterrissagemProduto : frmBaseAterrissagem
    {
        public frmAterrissagemProduto()
        {
            InitializeComponent();
        }

        private void frmAterrissagemProduto_Load(object sender, EventArgs e)
        {
            Produto produto01 = new Produto();
            produto01.PrecoUnitario = 15.50m;
            produto01.QuantidadeMinimaEstoque = 10;
            produto01.Descricao = "PÃO";


            Produto produto02 = new Produto();
            produto02.PrecoUnitario = 30.20m;
            produto02.QuantidadeMinimaEstoque = 20;
            produto02.Descricao = "BATATA";


            RepositorioDoProduto.Instancia.Add(produto01);
            RepositorioDoProduto.Instancia.Add(produto02);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizeTelaDeAterrissagem();
        }

        protected override void MonteColunasELinhasDoDataGrid()
        {
            dgvProdutos.CrieColuna("Id", nameof(Produto.Id), 50);
            dgvProdutos.CrieColuna("Descrição", nameof(Produto.Descricao));
        }

        protected override void AtualizeTelaDeAterrissagem()
        {
            bsDgv.DataSource = RepositorioDoProduto.Instancia.GetAll();
            bsDgv.ResetBindings(true);
        }


        protected override Form CrieFormulario(object objeto)
        {
            var frmComProduto = new frmCadastrarOuEditarProduto();
            frmComProduto.Produto = (Produto)objeto;
            return frmComProduto;
        }


        protected override void excluaProduto()
        {
            RepositorioDoProduto.Instancia.Delete((Produto)ObtenhaProdutoSelecionado());
            AtualizeTelaDeAterrissagem();
        }

        protected override object ConsulteComFiltro(TextBox textBox)
        {
            return RepositorioDoProduto.Instancia.GetAll().Where(p => p.Descricao.Contains(textBox.Text.ToUpper()) || p.Id.ToString().ToUpper() == textBox.Text);
        }
    }
}

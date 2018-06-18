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
    public partial class frmAterrissagemFornecedor : frmBaseAterrissagem
    {
        public frmAterrissagemFornecedor()
        {
            InitializeComponent();
        }

        private void frmAterrissagemProduto_Load(object sender, EventArgs e)
        {
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizeTelaDeAterrissagem();
        }

        protected override void MonteColunasELinhasDoDataGrid()
        {
            dgvProdutos.CrieColuna("Id", nameof(Fornecedor.Id), 50);
            dgvProdutos.CrieColuna("Nome", nameof(Fornecedor.Nome));
        }

        protected override void AtualizeTelaDeAterrissagem()
        {
            bsDgv.DataSource = RepositorioDeFornecedor.Instancia.GetAll();
            bsDgv.ResetBindings(true);
        }


        protected override Form CrieFormulario(object objeto)
        {
            var frmComFornecedor = new frmCadastrarOuEditarFornecedor();
            frmComFornecedor.Fornecedor = (Fornecedor)objeto;
            return frmComFornecedor;
        }


        protected override void excluaProduto()
        {
            RepositorioDeFornecedor.Instancia.Delete((Fornecedor)ObtenhaProdutoSelecionado());
            AtualizeTelaDeAterrissagem();
        }

        protected override object ConsulteComFiltro(TextBox textBox)
        {
            return RepositorioDeFornecedor.Instancia.GetAll().Where(p => p.Nome.Contains(textBox.Text.ToUpper()) || p.Id.ToString().ToUpper() == textBox.Text);
        }
    }
}

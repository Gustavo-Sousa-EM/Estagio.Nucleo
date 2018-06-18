using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estagio.Nucleo.Repositorios;
using Estagio.WinForms;
using Estagio.Nucleo;

namespace Estagio.WinForms
{
    public partial class frmAterrissagemCliente : frmBaseAterrissagem
    {
        public frmAterrissagemCliente()
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
            dgvProdutos.CrieColuna("Id", nameof(Cliente.Id), 50);
            dgvProdutos.CrieColuna("Nome", nameof(Cliente.Nome));
        }

        protected override void AtualizeTelaDeAterrissagem()
        {
            bsDgv.DataSource = RepositorioDeCliente.Instancia.GetAll();
            bsDgv.ResetBindings(true);
        }


        protected override Form CrieFormulario(object objeto)
        {
            var frmComCliente = new frmCadastrarOuEditarCliente();
            frmComCliente.Cliente = (Nucleo.Cliente)objeto;
            return frmComCliente;
        }


        protected override void excluaProduto()
        {
            RepositorioDeCliente.Instancia.Delete((Nucleo.Cliente)ObtenhaProdutoSelecionado());
            AtualizeTelaDeAterrissagem();
        }

        protected override object ConsulteComFiltro(TextBox textBox)
        {
            return RepositorioDeCliente.Instancia.GetAll().Where(p => p.Nome.Contains(textBox.Text.ToUpper()) || p.Id.ToString().ToUpper() == textBox.Text);
        }
    }
}

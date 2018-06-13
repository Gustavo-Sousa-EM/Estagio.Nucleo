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

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bsDgvProdutos.DataSource = RepositorioDoProduto.Instancia.GetAll();
            bsDgvProdutos.ResetBindings(true);
        }


        protected override object AdquiraNomeDaPrimeiraColuna()
        {
            return nameof(Produto.Id);
        }

        protected override object AdquiraNomeDaSegundaColuna()
        {
            return nameof(Produto.Descricao);
        }


        protected override Form InicializeFrmComObjeto(Object objeto)
        {
            var frmComProduto = new frmCadastrarOuEditarProduto();
            if (objeto == null)
            {
                frmComProduto.novoProduto = new Produto();
            }
            else
            {
                frmComProduto.novoProduto = (Produto)selecioneProduto();
            }
            return frmComProduto;
        }


        protected override void excluaProduto()
        {
            RepositorioDoProduto.Instancia.Delete((Produto)selecioneProduto());
        }



    }
}

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
    public partial class frmCadastrarOuEditarProduto : FrmBaseCadastrarOuEditar
    {
        public Produto Produto { get; set; }


        public frmCadastrarOuEditarProduto()
        {
            InitializeComponent();
            txtPrecoUnitario.FormatoMonetario();
            txtDescricao.MaxLength = 100;
            txtQuantidadeMinima.FormatoInteiro();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Produto != null)
            {
                txtDescricao.Text = Produto.Descricao;
                txtPrecoUnitario.Text = Produto.PrecoUnitario.ToString();
                txtQuantidadeMinima.Text = Produto.QuantidadeMinimaEstoque.ToString();
            }
        }
        
        protected override void Grave()
        {
            AjustePropriedades();

            if (EhNovoProduto())
            {
                RepositorioDoProduto.Instancia.Add(Produto);
            }
            else
            {
                RepositorioDoProduto.Instancia.Update(Produto);
            }
        }

        private void AjustePropriedades()
        {
            Produto = Produto ?? new Produto();
            Produto.Descricao = txtDescricao.Text;
            Produto.PrecoUnitario = Convert.ToDecimal(txtPrecoUnitario.Text);
            Produto.QuantidadeMinimaEstoque = int.Parse(txtQuantidadeMinima.Text);
        }

        private bool EhNovoProduto()
        {
            return Produto == null || Produto.Id == 0;
        }

        protected override bool PodeConfirmar()
        {
            if (!FoiInformadoOCampo(txtDescricao, "Informe a descrição")) return false;
            if (!FoiInformadoOCampo(txtQuantidadeMinima, "Informe a quantidade unitária")) return false;
            if (!FoiInformadoOCampo(txtPrecoUnitario, "Informe preço unitário")) return false;
            return true;
        }

    }
}

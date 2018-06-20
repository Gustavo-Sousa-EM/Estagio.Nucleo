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
using Estagio.Nucleo.Repositorio;

namespace Estagio.WinForm
{
    public partial class frmMovimentacaoEntrada : frmBase
    {
        private MovimentacaoDeEntrada movimentacaoDeEntrada = new MovimentacaoDeEntrada();


        public frmMovimentacaoEntrada()
        {


            InitializeComponent();
            movimentacaoDeEntrada.Itens = new List<ItemMovimentacao>();
            MonteColunas();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizeDataGrid();
        }

        private void MonteColunas()
        {
            dgvGeral.CrieColunaFill("Descrição", nameof(Produto.Descricao));
            dgvGeral.CrieColuna("Preço Unit.", nameof(Produto.PrecoUnitario), 100);
            dgvGeral.CrieColuna("Qtd. Mínima de Estoque", nameof(Produto.QuantidadeMinimaEstoque), 160);

        }

        private void AtualizeDataGrid()
        {
            bsGeral.DataSource = RepositorioDeProduto.Instancia.GetAll();
            bsGeral.ResetBindings(false);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (FoiInformadoOsCampos())
            {
                movimentacaoDeEntrada.Fornecedor = ucPesquisaFornecedor.Fornecedor;
                movimentacaoDeEntrada.Data = dtpEntrada.Value.Date;
                RepositorioDeMovimentacao.Instancia.Add(movimentacaoDeEntrada);
            }
            
        }

     

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            movimentacaoDeEntrada.Itens.Add(AdicioneUmNovoItemDeMovimentacao());
            MessageBox.Show("Adicionado!");
            
        }

        private ItemMovimentacao AdicioneUmNovoItemDeMovimentacao()
        {
            ItemMovimentacao novoItemMovimentacao = new ItemMovimentacao();
            novoItemMovimentacao.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            novoItemMovimentacao.ValorUnitario = Convert.ToDecimal(txtValor.Text);
            novoItemMovimentacao.insiraProduto((Produto)bsGeral.Current);
            return novoItemMovimentacao;
        }

        private bool FoiInformadoOsCampos()
        {
            if (!FoiInformadoOCampo(txtQuantidade, "Informe a Quantidade")) return false;
            if (!FoiInformadoOCampo(txtValor, "Informe o valor")) return false;

            return true;
        }
    }

}

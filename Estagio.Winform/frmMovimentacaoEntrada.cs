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
        //private MovimentacaoDeEntrada movimentacaoDeEntrada = new MovimentacaoDeEntrada();
        private List<ItemMovimentacao> _itensDeMovimentacao  = new List<ItemMovimentacao>();

        public frmMovimentacaoEntrada()
        {
            InitializeComponent();

            dgvProdutosSelecionados.AllowUserToAddRows = false;
            dgvProdutosSelecionados.AllowUserToDeleteRows = false;
            dgvProdutosSelecionados.AllowUserToOrderColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeRows = false;

            //movimentacaoDeEntrada.Itens = new List<ItemMovimentacao>();
            MonteColunas();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizeDataGridProduto();
        }

        private void MonteColunas()
        {
            dgvGeral.CrieColunaFill("Descrição", nameof(Produto.Descricao));
            dgvGeral.CrieColuna("Preço Unit.", nameof(Produto.PrecoUnitario), 100);
            dgvGeral.CrieColuna("Qtd. Mínima de Estoque", nameof(Produto.QuantidadeMinimaEstoque), 160);


            dgvProdutosSelecionados.CrieColunaFill("Descrição", nameof(ItemMovimentacao.Produto));
            dgvProdutosSelecionados.CrieColuna("Preço Unitario", nameof(ItemMovimentacao.ValorUnitario), 100);
            dgvProdutosSelecionados.CrieColuna("Quantidade", nameof(ItemMovimentacao.Quantidade), 100);
            dgvProdutosSelecionados.CrieColuna("SubTotal", nameof(ItemMovimentacao.ValorMovimentacao), 100);

            dgvProdutosSelecionados.Columns[0].ReadOnly = true;
            dgvProdutosSelecionados.Columns[3].ReadOnly = true;
        }

        private void AtualizeDataGridProduto()
        {
            bsGeral.DataSource = RepositorioDeProduto.Instancia.GetAll();
            bsGeral.ResetBindings(false);
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (FoiInformadoOsCampos())
            {
                MovimentacaoDeEntrada movimentacaoDeEntrada = new MovimentacaoDeEntrada();
                movimentacaoDeEntrada.Fornecedor = ucPesquisaFornecedor.Fornecedor;
                movimentacaoDeEntrada.Data = dtpEntrada.Value.Date;
                movimentacaoDeEntrada.Itens = _itensDeMovimentacao;
                RepositorioDeMovimentacao.Instancia.Add(movimentacaoDeEntrada);

                MessageBox.Show("Sucesso!");
                LimpeOFormulario();
            }


        }

        private void LimpeOFormulario()
        {
            _itensDeMovimentacao.Clear();
            ucPesquisaFornecedor.limpeTextBox();
            bsProdutosSelecionados.ResetBindings(false);
            atualizeValorTotal();
        }

        private bool FoiInformadoOsCampos()
        {
            if(ucPesquisaFornecedor.Fornecedor == null)
            {
                MessageBox.Show("Informe o Fornecedor", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(bsProdutosSelecionados.DataSource == null)
            {
                MessageBox.Show("Não há Produtos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvGeral_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!ContemProdutoSelecionado())
            {
                bsProdutosSelecionados.DataSource = insiraValoresNoDgvProdutosSelecionados();
            }
            else
            {
                atualizeQuantidade();
            }
            bsProdutosSelecionados.ResetBindings(false);
            atualizeValorTotal();
        }

        private void atualizeValorTotal()
        {
            var valorTotal = _itensDeMovimentacao.Sum(t => t.ValorMovimentacao);
            txtTotal.Text = valorTotal.ToString();
        }

        private bool ContemProdutoSelecionado()
        {
            var produto = (Produto)bsGeral.Current;
            var valid = false;
            if (_itensDeMovimentacao == null) return valid;
            foreach (var item in _itensDeMovimentacao)
            {
                valid = item.Produto.Id == produto.Id;
            }
            return valid;
        }

        private List<ItemMovimentacao> insiraValoresNoDgvProdutosSelecionados()
        {

            Produto produto = new Produto();
            produto = (Produto)bsGeral.Current;
            ItemMovimentacao itemMovimentacao = new ItemMovimentacao();

            itemMovimentacao.Quantidade = 1;
            itemMovimentacao.ValorUnitario = produto.PrecoUnitario;
            itemMovimentacao.insiraProduto(produto);

            _itensDeMovimentacao.Add(itemMovimentacao);

            return _itensDeMovimentacao;
        }

        private void atualizeQuantidade()
        {
            var produto = (Produto)bsGeral.Current;
            foreach (var item in _itensDeMovimentacao)
            {

                if (produto.Id == item.Produto.Id)
                {
                    var quantidade = item.Quantidade;
                    item.Quantidade++;
                    dgvGeral.Refresh();
                }
            }
        }

        private void dgvProdutosSelecionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            atualizeValorTotal();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var produtoSelecionado = (ItemMovimentacao)bsProdutosSelecionados.Current;
            _itensDeMovimentacao.Remove(produtoSelecionado);
            bsProdutosSelecionados.ResetBindings(false);
            atualizeValorTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

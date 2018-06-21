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

            dgvProdutosSelecionados.AllowUserToAddRows = false;
            dgvProdutosSelecionados.AllowUserToDeleteRows = false;
            dgvProdutosSelecionados.AllowUserToOrderColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeRows = false;

            movimentacaoDeEntrada.Itens = new List<ItemMovimentacao>();
            MonteColunas();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            AtualizeDataGrid(bsGeral);
        }

        private void MonteColunas()
        {
            dgvGeral.CrieColunaFill("Descrição", nameof(Produto.Descricao));
            dgvGeral.CrieColuna("Preço Unit.", nameof(Produto.PrecoUnitario), 100);
            dgvGeral.CrieColuna("Qtd. Mínima de Estoque", nameof(Produto.QuantidadeMinimaEstoque), 160);


            dgvProdutosSelecionados.CrieColunaFill("Descrição", nameof(movimentacaoDeEntrada.Itens.Produto));
            dgvProdutosSelecionados.CrieColuna("Preço Unitario", nameof(ItemMovimentacao.ValorUnitario), 100);
            dgvProdutosSelecionados.CrieColuna("Quantidade", nameof(ItemMovimentacao.Quantidade), 100);
            dgvProdutosSelecionados.CrieColuna("SubTotal", nameof(ItemMovimentacao.ValorMovimentacao), 100);

            dgvProdutosSelecionados.Columns[0].ReadOnly = true;
            dgvProdutosSelecionados.Columns[3].ReadOnly = true;
        }

        private void AtualizeDataGrid(BindingSource bindingSource)
        {
            bindingSource.DataSource = RepositorioDeProduto.Instancia.GetAll();
            bindingSource.ResetBindings(false);
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
            
            MessageBox.Show("Adicionado!");
            
        }

   

        private bool FoiInformadoOsCampos()
        {
            if (!FoiInformadoOCampo(txtQuantidade, "Informe a Quantidade")) return false;
            if (!FoiInformadoOCampo(txtValor, "Informe o valor")) return false;

            return true;
        }

        private void dgvGeral_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!ContemProdutoSelecionado())
            {
                bsProdutosSelecionados.Insert(bsProdutosSelecionados.Count, insiraValoresNoDgvProdutosSelecionados());
                dgvProdutosSelecionados.Refresh();
                return;
            }
            else
            {
                atualizeQuantidade();
                bsProdutosSelecionados.ResetBindings(false);
                movimentacaoDeEntrada.Itens.Add((ItemMovimentacao)bsProdutosSelecionados.DataSource);
            }
            
        }

        private bool ContemProdutoSelecionado()
        {
            return bsProdutosSelecionados.Contains(bsGeral.Current);
        }

        private ItemMovimentacao insiraValoresNoDgvProdutosSelecionados()
        {
            ItemMovimentacao novoItemMovimentacao = new ItemMovimentacao();
            Produto produto = new Produto();
            produto = (Produto)bsGeral.Current;


            novoItemMovimentacao.Quantidade = 1;
            novoItemMovimentacao.ValorUnitario = produto.PrecoUnitario;
            novoItemMovimentacao.insiraProduto(produto);
            return novoItemMovimentacao;

        }

        private void atualizeQuantidade()
        {
            foreach(var item in movimentacaoDeEntrada.Itens)
            {
                var produto = (Produto)bsGeral.Current;
               if (produto.Id == item.Produto.Id)
                {
                    var quantidade = item.Quantidade;
                    item.Quantidade = quantidade++;
                    dgvGeral.Refresh();
                }
            } 
        }
    }

}

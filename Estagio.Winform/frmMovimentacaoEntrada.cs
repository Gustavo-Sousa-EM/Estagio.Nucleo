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
        private List<ItemMovimentacaoMV> _itensDeMovimentacaoMV = new List<ItemMovimentacaoMV>();
        private List<ItemMovimentacao> _itensDeMovimentacao = new List<ItemMovimentacao>();

        public frmMovimentacaoEntrada()
        {
            InitializeComponent();

            dgvProdutosSelecionados.AllowUserToAddRows = false;
            dgvProdutosSelecionados.AllowUserToDeleteRows = false;
            dgvProdutosSelecionados.AllowUserToOrderColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeColumns = false;
            dgvProdutosSelecionados.AllowUserToResizeRows = false;

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

        private class ItemMovimentacaoMV : INotifyPropertyChanged
        {
            private ItemMovimentacao _itemMovimentacao;

            public ItemMovimentacaoMV(ItemMovimentacao itemMovimentacao)
            {
                _itemMovimentacao = itemMovimentacao;
            }

            public Produto Produto { get => _itemMovimentacao.Produto; }

            public int Quantidade
            {
                get => _itemMovimentacao.Quantidade;
                set
                {
                    if (value != _itemMovimentacao.Quantidade)
                    {
                        _itemMovimentacao.Quantidade = value;
                        RaisePropertyChanged("Quantidade");
                    }
                }
            }

            public decimal ValorUnitario
            {
                get => _itemMovimentacao.ValorUnitario;
                set
                {
                    if (value != _itemMovimentacao.ValorUnitario)
                    {
                        _itemMovimentacao.ValorUnitario = value;
                        RaisePropertyChanged("Valor unitário");
                    }
                }
            }

            public decimal ValorMovimentacao { get => _itemMovimentacao.ValorMovimentacao; }


            public event PropertyChangedEventHandler PropertyChanged;

            private void RaisePropertyChanged(string prop)
            {
                
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
                this.PropertyChanged -= this.PropertyChanged;
            }
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
            if (ucPesquisaFornecedor.Fornecedor == null)
            {
                MessageBox.Show("Informe o Fornecedor", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ucPesquisaFornecedor.Focus();
                return false;
            }
            if (bsProdutosSelecionados.DataSource == null)
            {
                MessageBox.Show("Não há Produtos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvProdutosSelecionados.Focus();
                return false;
            }
            return true;
        }

        private void dgvGeral_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!ContemProdutoSelecionado())
            {
                bsProdutosSelecionados.DataSource = AdicioneUmNovoItemDeMovimentacao();
            }
            bsProdutosSelecionados.ResetBindings(false);
            atualizeValorTotal();
        }

        private void atualizeValorTotal()
        {
            var valorTotal = _itensDeMovimentacaoMV.Sum(t => t.ValorMovimentacao);
            txtTotal.Text = valorTotal.ToString();
        }

        private bool ContemProdutoSelecionado()
        {
            if (_itensDeMovimentacaoMV == null) return false;
            foreach (var item in _itensDeMovimentacaoMV)
            {
                if (item.Produto == (Produto)bsGeral.Current)
                {
                    item.PropertyChanged += Item_PropertyChanged;
                    item.Quantidade++;
                    dgvGeral.Refresh();
                    return true;
                }
            }
            return false;
        }


        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show($"{e.PropertyName} Alterado!");
        }

        private void dgvProdutosSelecionados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var alteracao = (Produto)bsGeral.Current;
            foreach (var item in _itensDeMovimentacaoMV)
            {
                if (item.Produto == alteracao)
                {
                    if(item.Quantidade == item.Quantidade)
                    {
                        item.Quantidade = item.Quantidade;
                    }
                    else
                    {
                        item.ValorUnitario = item.ValorUnitario;
                    }
                    item.PropertyChanged += Item_PropertyChanged;
                    dgvGeral.Refresh();
                }
            }

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


        private List<ItemMovimentacaoMV> AdicioneUmNovoItemDeMovimentacao()
        {

            var produto = (Produto)bsGeral.Current;
            ItemMovimentacao itemMovimentacao = new ItemMovimentacao();

            itemMovimentacao.Quantidade = 1;
            itemMovimentacao.ValorUnitario = produto.PrecoUnitario;
            itemMovimentacao.insiraProduto(produto);
            ItemMovimentacaoMV itemMovimentacaoMV = new ItemMovimentacaoMV(itemMovimentacao);
            _itensDeMovimentacaoMV.Add(itemMovimentacaoMV);

            return _itensDeMovimentacaoMV;
        }

      
    }

}

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
    public partial class WinFormsNucleo : Form
    {
        public WinFormsNucleo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            
            preencheDataGrid();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preencheDataGrid()
        {
            var posicaoColunaId = 0;
            var posicaoColunaDescricao = 1;
            var listaProdutos = RepositorioDoProduto.Instancia.GetAll();
            var iContador = 0;
            dataGridViewProd.RowCount = listaProdutos.Count();
            foreach (var item in listaProdutos)
            {
                dataGridViewProd.Rows[iContador].Cells[posicaoColunaId].Value = item.Id;
                dataGridViewProd.Rows[iContador++].Cells[posicaoColunaDescricao].Value = item.Descricao;
                
            }
        }

    }
}

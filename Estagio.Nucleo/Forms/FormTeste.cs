using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo.Forms
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto01 = new Produto();
            produto01.Id = 1;
            produto01.PrecoUnitario = 20.0m;
            produto01.QuantidadeMinimaEstoque = 10;
            produto01.Descricao = "Caixa de Leite 20L";

            Produto produto02 = new Produto();
            produto02.Id = 2;
            produto02.PrecoUnitario = 10.0m;
            produto02.QuantidadeMinimaEstoque = 5;
            produto02.Descricao = "Pão de Forma";
        }

        private void btmVenda_Click(object sender, EventArgs e)
        {
            Movimentacao.MovimentacaoDeSaida movimentacaoDeSaida = new Movimentacao.MovimentacaoDeSaida();

        }

        private void btmAdCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente01 = new Cliente();
            cliente01.Id = 1;
            cliente01.Nome = "Josefino";
            CPFCNPJ cPFCNPJ01 = new CPFCNPJ("331.323.510-75");


            Cliente cliente02 = new Cliente();
            cliente02.Id = 2;
            cliente02.Nome = "Lurdes";
            CPFCNPJ cPFCNPJ02 = new CPFCNPJ("721.653.620-75");
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {

        }
    }
}

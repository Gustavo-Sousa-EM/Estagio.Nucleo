﻿using System;
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
    public partial class frmCadastroDeFornecedor : frmBaseAterrisagem
    {
        public frmCadastroDeFornecedor()
        {
            RepositorioDeFornecedor.Instancia.GetById(1);
            InitializeComponent();
        }

        protected override void MonteColunas(DataGridView dgvGeral)
        {
            dgvGeral.CrieColuna("Id", "Id", 90);
            dgvGeral.CrieColuna("Nome", "Nome");
        }

        protected override void RemovaItemDaLista(object itemSelecioando)
        {
            RepositorioDeFornecedor.Instancia.Delete((Fornecedor)itemSelecioando);
        }

        protected override Form CrieFormularioNovoOuEdicao(object fornecedor)
        {
            var frmComFornecedor = new frmEditarOuCadastrarForncedor();
            frmComFornecedor.Fornecedor = (Fornecedor)fornecedor;
            return frmComFornecedor;
        }


        protected override string ObtenhaMensagemDeCadastradoConcluido()
        {
            return "Cadastro de fornecedor realizado";
        }

        protected override string ObtenhaMensagemDeEdicaoConcluida()
        {
            return "Edição de fornecedor realizado";
        }

        protected override DialogResult ExibaMensagemDeNaoSelecionado()
        {
            return MessageBox.Show("Selecione Fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected override void AtualizeDataGrid()
        {
            bsGeral.DataSource = RepositorioDeFornecedor.Instancia.GetAll();
            bsGeral.ResetBindings(false);
        }

        protected override void ExibaItemPesquisado(string textoPesquisado)
        {
            bsProdutos.DataSource = RepositorioDeFornecedor.Instancia.GetAll().Where(p => p.Nome.ToUpper().Contains(textoPesquisado)).ToList();
            bsProdutos.ResetBindings(false);
        }

        protected override string ObtenhaMensagemDeExlusao()
        {
            return "Fornecedor excluído!";
        }
    }
}

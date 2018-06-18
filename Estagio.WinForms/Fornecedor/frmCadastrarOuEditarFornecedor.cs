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
    public partial class frmCadastrarOuEditarFornecedor : FrmBaseCadastrarOuEditar
    {
       
        public Fornecedor Fornecedor { get; set; }

        public frmCadastrarOuEditarFornecedor()
        {
            InitializeComponent();
            txtNome.MaxLength = 100;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Fornecedor != null)
            {
                txtNome.Text = Fornecedor.Nome;
                txtCpfCnpj.Text = Fornecedor.CPFCNPJ.Numero;
            }
        }

        protected override void Grave()
        {
            AjustePropriedades();

            if (EhNovoProduto())
            {
                RepositorioDeFornecedor.Instancia.Add(Fornecedor);
            }
            else
            {
                RepositorioDeFornecedor.Instancia.Update(Fornecedor);
            }
        }

        private void AjustePropriedades()
        {
            Fornecedor = Fornecedor ?? new Fornecedor();
            Fornecedor.Nome = txtNome.Text;
            CPFCNPJ cPFCNPJ = new CPFCNPJ(txtCpfCnpj.Text);
            Fornecedor.CPFCNPJ = cPFCNPJ;
        }

        private bool EhNovoProduto()
        {
            return Fornecedor == null || Fornecedor.Id == 0;
        }

        protected override bool PodeConfirmar()
        {
            if (!FoiInformadoOCampo(txtNome, "Informe o Nome")) return false;
            if (!FoiInformadoOCampo(txtCpfCnpj, "Informe o CPF ou CNPJ")) return false;
            return true;
        }
    }
}

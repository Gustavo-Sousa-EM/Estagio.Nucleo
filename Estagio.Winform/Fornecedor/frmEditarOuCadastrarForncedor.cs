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
    public partial class frmEditarOuCadastrarForncedor : frmBaseNovoOuEditar
    {
        public Fornecedor Fornecedor{ get; set; }

        public frmEditarOuCadastrarForncedor()
        {
            InitializeComponent();
            txtNome.FormatoTexto();
            txtCNPJ.FormatoCpfCnpj();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if(Fornecedor != null)
            {
                txtNome.Text = Fornecedor.Nome;
                txtCNPJ.Text = Fornecedor.CPFCNPJ.ToString();
            }
        }

        protected override void GraveElemento()
        {
            InsereValores();

            if (EhNovoFornecedor())
            {
                RepositorioDeFornecedor.Instancia.Add(Fornecedor);
            }
            else
            {
                RepositorioDeFornecedor.Instancia.UpDate(Fornecedor);
            }
        }


        private bool EhNovoFornecedor()
        {
            return Fornecedor == null || Fornecedor.Id == 0;
        }

        private void InsereValores()
        {
            Fornecedor = Fornecedor ?? new Fornecedor();
            Fornecedor.Nome = txtNome.Text;
            var CNPJ = new CPFCNPJ(txtCNPJ.Text);
            Fornecedor.CPFCNPJ = CNPJ;
        }

        protected override bool PodeConfirmar()
        {
            if (!EhCpfOuCnpjValido()) return false;
            if (!FoiInformadoOCampo(txtNome, "Informe nome")) return false;
            if (!FoiInformadoOCampo(txtCNPJ, "Informe CNPJ")) return false;
            return true;
        }

        private bool EhCpfOuCnpjValido()
        {
            try
            {
                var CPF = new CPFCNPJ(txtCNPJ.Text);
                return true;
            }
            catch (ApplicationException)
            {
                MessageBox.Show("CPF/CNPJ inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtCNPJ.Focus();
            return false;
        }
    }
}

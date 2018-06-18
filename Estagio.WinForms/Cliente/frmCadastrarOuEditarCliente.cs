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
    public partial class frmCadastrarOuEditarCliente : FrmBaseCadastrarOuEditar
    {
        public Cliente Cliente { get; set; }

        public frmCadastrarOuEditarCliente()
        {
            InitializeComponent();
            txtNome.MaxLength = 100;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (Cliente != null)
            {
                txtNome.Text = Cliente.Nome;
                txtCpfCnpj.Text = Cliente.CPFCNPJ.Numero;
            }
        }

        protected override void Grave()
        {
            AjustePropriedades();

            if (EhNovoProduto())
            {
                RepositorioDeCliente.Instancia.Add(Cliente);
            }
            else
            {
                RepositorioDeCliente.Instancia.Update(Cliente);
            }
        }

        private void AjustePropriedades()
        {
            Cliente = Cliente?? new Cliente();
            Cliente.Nome = txtNome.Text;
            CPFCNPJ cPFCNPJ = new CPFCNPJ(txtCpfCnpj.Text);
            Cliente.CPFCNPJ = cPFCNPJ;
        }

        private bool EhNovoProduto()
        {
            return Cliente == null || Cliente.Id == 0;
        }

        protected override bool PodeConfirmar()
        {
            if (!FoiInformadoOCampo(txtNome, "Informe o Nome")) return false;
            if (!FoiInformadoOCampo(txtCpfCnpj, "Informe o CPF ou CNPJ")) return false;
            return true;
        }
    }
}

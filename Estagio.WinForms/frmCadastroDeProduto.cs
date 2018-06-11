using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo
{
    public partial class frmCadastroDeProduto : Form
    {
        Produto novoProduto = new Produto();
        public frmCadastroDeProduto()
        {
            InitializeComponent();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void InsiraAtributosDeProduto()
        {
            
                novoProduto.Id = Convert.ToInt32(Repositorios.RepositorioDoProduto.Instancia.GetAll().Count().ToString()) + 1;
                novoProduto.Descricao = tbDescricao.Text;
                novoProduto.PrecoUnitario = Convert.ToDecimal(tbPrecoUnitario.Text);
                novoProduto.QuantidadeMinimaEstoque = int.Parse(tbQtdeMinimaDeEsqoque.Text);
            
            
                MessageBox.Show("Campos vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
                InsiraAtributosDeProduto();
                Repositorios.RepositorioDoProduto.Instancia.Add(novoProduto);
                DialogResult = DialogResult.OK;
                MessageBox.Show("Produto Cadastrado");
          
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tbPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44)
            {
                e.Handled = true;
            }

        }

        private void tbQtdeMinimaDeEsqoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbPrecoUnitario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void frmCadastroDeProduto_MouseMove_1(object sender, MouseEventArgs e)
        {
            try
            {
                tbPrecoUnitario.Text = String.Format("{0:0.00}", Convert.ToDecimal(tbPrecoUnitario.Text));
            }
            catch (Exception)
            {

            }
        }
    }
}

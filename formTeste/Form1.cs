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

namespace formTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //401.663.760-00
            //69.996.614/0001-71
            try
            {
                CPFCNPJ cPFCNPJ = new CPFCNPJ(tbCpfCnpj.Text);
                tbCpfCnpjFormatado.Text = cPFCNPJ.ObtenhaCPFCNPJFormatado();
            }
            catch (ApplicationException)
            {
                if (String.IsNullOrWhiteSpace(tbCpfCnpj.Text))
                {
                    MessageBox.Show("Campo vazio!\nPreencha com algum CPF / CNPJ válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCpfCnpjFormatado.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("CPF / CNPJ Inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCpfCnpjFormatado.Text = String.Empty;
                }
            }
            tbCpfCnpj.Focus();
        }
        


            private void tbCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }

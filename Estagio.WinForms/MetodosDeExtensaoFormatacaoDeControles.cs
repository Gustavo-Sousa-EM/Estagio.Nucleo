using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo
{
    public static class MetodosDeExtensaoFormatacaoDeControles
    {
        public static void FormatoMonetario(this TextBox textbox)
        {
            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.KeyPress += FormatoDecimal_KeyPress;
            textbox.Leave += FormatoDecimal_Leave;
        }

        public static void FormatoInteiro(this TextBox textbox)
        {
            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.KeyPress += FormatoInteiro_KeyPress;
        }

        public static void FiltrarDatagridView(this TextBox textbox)
        {
            textbox.KeyPress += FiltroDoBindingSource_KeyPress;
        }


        private const int teclaBackSpace = 8;
        private const int teclaVirgula = 44;

        private static void FiltroDoBindingSource_KeyPress(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text)) return;
        }

        private static void FormatoDecimal_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text)) return;
            textBox.Text = Convert.ToDecimal(textBox.Text).ToString("0.00");
        }

        private static void FormatoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Convert.ToDecimal(sender).ToString("0.00");
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != teclaBackSpace && e.KeyChar != teclaVirgula;
        }

        private static void FormatoInteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != teclaBackSpace;
        }
    }
}

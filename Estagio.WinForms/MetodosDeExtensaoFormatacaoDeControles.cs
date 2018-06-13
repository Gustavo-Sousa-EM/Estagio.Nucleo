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
        }

        //private static void FormatoMonetario(this TextBox textbox, object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        textbox.Leave += Convert.ToDecimal(sender).ToString("0.00");

        //    }
        //    catch (Exception)
        //    {

        //    }
           
        //}

        public static void FormatoInteiro(this TextBox textbox)
        {
            textbox.TextAlign = HorizontalAlignment.Right;
            textbox.KeyPress += FormatoInteiro_KeyPress;
        }

        private const int teclaBackSpace = 8;
        private const int teclaVirgula = 44;

        private static void FormatoDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != teclaBackSpace && e.KeyChar != teclaVirgula;
        }

        private static void FormatoInteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != teclaBackSpace;
        }
    }
}

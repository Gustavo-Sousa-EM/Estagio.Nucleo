using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.WinForms
{
    public static class DgvHelper
    {
        public static DataGridViewColumn AdicionaColuna(string headerText, string dataPropertyName, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = width,
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                Name = dataPropertyName
            };
        }
    }
}

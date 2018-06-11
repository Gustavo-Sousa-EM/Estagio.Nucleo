using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo
{
    public static class ValidacaoDeCampos
    {
        public static bool CampoEhVazioOuNulo(this string strValidada)
        {
            return String.IsNullOrWhiteSpace(strValidada);
        }

        public static string formateStringEmDecimal(this string strFormatar)
        {
            return strFormatar = String.Format("{0:0.00}", Convert.ToDecimal(strFormatar));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Movimentacao
{
    public class ItemMovimentacao
    {
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
       
        public Cliente Produto { get; set; }
        public decimal ValorMovimentacao
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }



    }
}

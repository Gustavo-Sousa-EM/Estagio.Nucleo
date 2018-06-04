using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeMinimaEstoque { get; set; }
        public decimal PrecoUnitario { get; set; }

    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Movimentacao
{
    public abstract class MovimentacaoDeEstoqueAbstrato
    {

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemMovimentacao> Itens { get; set; }
        public decimal ValorTotal
        {
            get
            {
                var Total = Itens.Sum(t => t.ValorMovimentacao);
                return Total;

            }
        }   


        
    }
}

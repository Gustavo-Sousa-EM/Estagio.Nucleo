using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Movimentacao
{
    public class MovimentacaoDeEntrada : MovimentacaoDeEstoqueAbstrato
    {
       public Fornecedor fornecedor { get; set; }
    }
}

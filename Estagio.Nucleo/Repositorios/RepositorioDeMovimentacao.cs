using Estagio.Nucleo.IRepositorio;
using Estagio.Nucleo.Movimentacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDeMovimentacao : IRepositorio<MovimentacaoDeEstoqueAbstrato>
    {
        RepositorioDeMovimentacao RespositrioMovimentacao = new RepositorioDeMovimentacao();

        public RepositorioDeMovimentacao()
        {

        }

        public void Add(MovimentacaoDeEstoqueAbstrato Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(MovimentacaoDeEstoqueAbstrato Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimentacaoDeEstoqueAbstrato> GetAll()
        {
            throw new NotImplementedException();
        }

        public MovimentacaoDeEstoqueAbstrato GetByld(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(MovimentacaoDeEstoqueAbstrato Item)
        {
            throw new NotImplementedException();
        }
    }
}

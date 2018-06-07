using Estagio.Nucleo.IRepositorio;
using Estagio.Nucleo.Movimentacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estagio.Nucleo.Repositorios
{
    public class RepositorioDeMovimentacao : IRepositorio<MovimentacaoDeEstoqueAbstrato>
    {
        public static readonly RepositorioDeMovimentacao Instancia = new RepositorioDeMovimentacao();
        private List<MovimentacaoDeEstoqueAbstrato> _movimentacaoDeEstoqueAbstratos = new List<MovimentacaoDeEstoqueAbstrato>();

        private RepositorioDeMovimentacao()
        {

        }

        public void Add(MovimentacaoDeEstoqueAbstrato item)
        {
            if (_movimentacaoDeEstoqueAbstratos.Contains(GetById(item.Id)))
            {
                throw new ApplicationException("Produto ja existe!");
            }
            else
            {
                _movimentacaoDeEstoqueAbstratos.Add(item);
            }
        }

        public void Delete(MovimentacaoDeEstoqueAbstrato item)
        {
            if (!_movimentacaoDeEstoqueAbstratos.Remove(GetById(item.Id)))
            {
                throw new ApplicationException("Produto não existe!");
            }
        }

        public IEnumerable<MovimentacaoDeEstoqueAbstrato> GetAll()
        {
            return _movimentacaoDeEstoqueAbstratos;
        }

        public MovimentacaoDeEstoqueAbstrato GetById(int Id)
        {
            return _movimentacaoDeEstoqueAbstratos.Find(x => x.Id == Id);
        }

        public void Update(MovimentacaoDeEstoqueAbstrato item)
        {
            Delete(item);
            _movimentacaoDeEstoqueAbstratos.Add(item);
        }
    }
}

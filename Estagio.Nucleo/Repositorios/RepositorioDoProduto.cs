using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagio.Nucleo.IRepositorio;

namespace Estagio.Nucleo.Repositorios
{
    public class RepositorioDoProduto : IRepositorio<Produto>
    {
        public static readonly RepositorioDoProduto Instancia = new RepositorioDoProduto();
        private List<Produto> _produtos = new List<Produto>();
        private List<Produto> _produtosDeletados = new List<Produto>();

        private RepositorioDoProduto()
        {

        }

        public void Add(Produto item)
        {

            if (_produtos.Contains(GetById(item.Id)))
            {
                throw new ApplicationException("Produto ja existe!");
            }
            else
            {
                _produtos.Add(item);
            }
        }

        public void Delete(Produto item)
        {
            if (!_produtos.Remove(GetById(item.Id)))
            {
                throw new ApplicationException("Produto não existe!");
            }
            _produtosDeletados.Add(item);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtos.Select(p => (Produto)p.CloneProduto());
        }

        public Produto GetById(int id)
        {
            return _produtos.Find(x => x.Id == id);
        }

        public void Update(Produto item)
        {
            Delete(item);
            _produtosDeletados.Remove(item);
            _produtos.Add(item);

        }

        public int GetAllId()
        {
            return _produtos.Count + _produtosDeletados.Count;
        }

    }

}

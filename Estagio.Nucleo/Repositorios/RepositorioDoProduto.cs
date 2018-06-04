using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagio.Nucleo.IRepositorio;

namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDoProduto : IRepositorio<Produto>
    {
        public static readonly RepositorioDoProduto Instancia = new RepositorioDoProduto();
        private List<Produto> _produtos = new List<Produto>();

        private RepositorioDoProduto()
        {
            RepositorioDoProduto rp = new RepositorioDoProduto();
        }
        public void Add(Produto item)
        {
            _produtos.Add(item);
        }

        public void Delete(Produto item)
        {
            _produtos.Remove(item);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _produtos;
        }

        public Produto GetById(int Id)
        {
           return _produtos.Find(x => x.Id == Id);
        }

        public void Update(Produto item)
        {
            _produtos.Remove(item);
            _produtos.Add(item);
        }
    }
}

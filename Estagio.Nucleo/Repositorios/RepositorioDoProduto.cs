using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagio.Nucleo.IRepositorio;

namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDoProduto : IRepositorio<Cliente>
    {
        public static readonly RepositorioDoProduto Instancia = new RepositorioDoProduto();
        private List<Cliente> _produtos = new List<Cliente>();

        private RepositorioDoProduto()
        {
            RepositorioDoProduto rp = new RepositorioDoProduto();
        }
        public void Add(Cliente item)
        {
            _produtos.Add(item);
        }

        public void Delete(Cliente item)
        {
            _produtos.Remove(item);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _produtos;
        }

        public Cliente GetById(int Id)
        {
           return _produtos.Find(x => x.Id == Id);
        }

        public void Update(Cliente item)
        {
            _produtos.Remove(item);
            _produtos.Add(item);
        }
    }
}

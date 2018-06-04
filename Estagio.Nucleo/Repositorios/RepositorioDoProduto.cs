using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDoProduto : IRepositorio<Produto>
    {
        public RepositorioDoProduto RepositorioProduto = new RepositorioDoProduto();

        private RepositorioDoProduto()
        {

        }
        public void Add(Produto Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produto GetByld(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Produto Item)
        {
            throw new NotImplementedException();
        }
    }
}

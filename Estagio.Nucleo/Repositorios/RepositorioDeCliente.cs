using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDeCliente : IRepositorio<Cliente>
    {
        public RepositorioDeCliente RepositoroCliente = new RepositorioDeCliente();

        private RepositorioDeCliente()
        {

        }

        public void Add(Cliente Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetByld(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente Item)
        {
            throw new NotImplementedException();
        }
    }
}

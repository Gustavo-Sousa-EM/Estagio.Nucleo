using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.Repositorios
{
    class RepositorioDeFornecedor : IRepositorio<Fornecedor>
    {
        RepositorioDeFornecedor RepositorioFornecedor = new RepositorioDeFornecedor();

        public RepositorioDeFornecedor()
        {

        }
        public void Add(Fornecedor Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fornecedor Item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Fornecedor GetByld(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Fornecedor Item)
        {
            throw new NotImplementedException();
        }
    }
}

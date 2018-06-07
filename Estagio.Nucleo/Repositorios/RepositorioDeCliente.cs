using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estagio.Nucleo.IRepositorio;

namespace Estagio.Nucleo.Repositorios
{
    public class RepositorioDeCliente : IRepositorio<Cliente>
    {
        public static readonly RepositorioDeCliente Instancia = new RepositorioDeCliente();
        private List<Cliente> _clientes = new List<Cliente>();

        private RepositorioDeCliente()
        {

        }

        public void Add(Cliente item)
        {
            if (_clientes.Contains(GetById(item.Id)))
            {
                throw new ApplicationException("Produto ja existe!");
            }
            else
            {
                _clientes.Add(item);
            }
        }

        public void Delete(Cliente item)
        {
            if (_clientes.Remove(GetById(item.Id)))
            {
                throw new ApplicationException("Produto não existe!");
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clientes;
        }

        public Cliente GetById(int Id)
        {
            return _clientes.Find(x => x.Id == Id);
        }

        public void Update(Cliente item)
        {
            Delete(item);
            _clientes.Add(item);
        }
    }
}

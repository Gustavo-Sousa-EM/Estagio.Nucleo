using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estagio.Nucleo.IRepositorio
{
    interface IRepositorio<T>
    {
        void Add(T Item);
        void Delete(T Item);

        void Update(T Item);
        IEnumerable<T> GetAll();
        T GetByld(int Id);
    }

}

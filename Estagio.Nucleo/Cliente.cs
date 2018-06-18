using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estagio.Nucleo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public CPFCNPJ CPFCNPJ { get; set; }

        public Cliente CloneCliente()
        {
            return new Cliente
            {
                Id = this.Id,
                Nome = this.Nome,
                CPFCNPJ = this.CPFCNPJ
            };
        }

    }
}

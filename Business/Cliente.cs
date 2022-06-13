using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Cliente
    {
        public string Nome { get; set; }
        public List<Cliente> Clientes(string cliente)
        {
            // new Databse.Cliente().Clientes();s
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente() { Nome = "Danilo" });
            return clientes;
        }
    }
}
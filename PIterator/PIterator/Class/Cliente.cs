using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIterator.Class
{    
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}

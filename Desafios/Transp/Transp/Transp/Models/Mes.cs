using System;
using System.Collections.Generic;
using System.Text;

namespace Transp.Models
{
    public class Mes
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public Mes(int id, String nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}

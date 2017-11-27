using System;
using System.Collections.Generic;
using System.Text;

namespace Transp.Models
{
    public class ListaMeses
    {
        public List<Mes> Meses { get; }

        public ListaMeses()
        {
            this.Meses = new List<Mes>
            {
                new Mes(1, "Janeiro"),
                new Mes(2, "Fevereiro"),
                new Mes(3, "Março"),
                new Mes(4, "Abril"),
                new Mes(5, "Maio"),
                new Mes(6, "Junho"),
                new Mes(7, "Julho"),
                new Mes(8, "Agosto"),
                new Mes(9, "Setembro"),
                new Mes(10, "Outubro"),
                new Mes(11, "Novembro"),
                new Mes(12, "Dezembro")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Item
    {
        public string descricao;
        public object valMax;
        public object valMin;

        /// <summary>
        /// Construtor da classe Item
        /// </summary>
        /// <param name="descricao">Nome do tipo de variável</param>
        /// <param name="valMax">Valor máximo do tipo de variável</param>
        /// <param name="valMin">Valor mínimo do tipo de variável</param>
        public Item(string descricao, object valMax, object valMin)
        {
            this.descricao = descricao;
            this.valMax = valMax;
            this.valMin = valMin;
        }

        public override string ToString()
        {
            return descricao;
        }
    }
}

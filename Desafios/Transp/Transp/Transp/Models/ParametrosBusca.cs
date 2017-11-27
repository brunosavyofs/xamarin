using System;
using System.Collections.Generic;
using System.Text;

namespace Transp.Models
{
    public class ParametrosBusca
    {
        public String Secretaria { set; get; }
        public int Ano { set; get; }
        public Mes Mes { get; set; }

        /// <summary>
        /// Valida se os parâmetros de pesquisa foram informados corretamente
        /// </summary>
        /// <returns>booleano que representa se os dados estão corretos ou não</returns>
        public bool ValidarParametros()
        {
            if (this.Secretaria == null || this.Ano == 0 || this.Mes == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

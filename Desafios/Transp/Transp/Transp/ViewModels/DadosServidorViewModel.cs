using System;
using System.Collections.Generic;
using System.Text;

namespace Transp.ViewModels
{
    public class DadosServidorViewModel
    {
        public ServidorObj ServidorSelecionado { get; set; }

        public DadosServidorViewModel(ServidorObj servidor)
        {
            this.ServidorSelecionado = servidor;
        }
    }
}

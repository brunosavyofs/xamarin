using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DadosServidorTabbedPage : TabbedPage
    {
        //public ServidorObj ServidorSelecionado { get; set; }

        public DadosServidorTabbedPage (ServidorObj servidor)
        {
            InitializeComponent();

            //this.ServidorSelecionado = servidor;

            this.BindingContext = new DadosServidorViewModel(servidor);
        }
    }
}
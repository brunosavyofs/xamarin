using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transp.Models;
using Transp.ViewModels;
using Xamarin.Forms;

namespace Transp.Views
{
    public partial class ListagemServidoresView : ContentPage
    {
        public ListagemViewModel ViewModel { get; set; }

        public ListagemServidoresView(ParametrosBusca parametrosBusca)
        {
            InitializeComponent();

            this.ViewModel = new ListagemViewModel(parametrosBusca);
            this.BindingContext = this.ViewModel;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // Inscreve o código abaixo para tratar a mensagem/ação "ServidorSelecionado"
            MessagingCenter.Subscribe<ServidorObj>(this, "ServidorSelecionado", (msg) =>
            {
                Navigation.PushAsync(new DadosServidorTabbedPage(msg));
            });

            await this.ViewModel.GetServidores();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Cancela a inscrição
            MessagingCenter.Unsubscribe<ServidorObj>(this, "ServidorSelecionado");
        }
    }
}

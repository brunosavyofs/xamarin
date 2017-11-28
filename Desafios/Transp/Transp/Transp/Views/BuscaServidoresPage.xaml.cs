using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transp.Models;
using Transp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Transp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuscaServidoresPage : ContentPage
    {
        public BuscaServidoresViewModel ViewModel { get; set; }

        public BuscaServidoresPage()
        {
            InitializeComponent();

            this.ViewModel = new BuscaServidoresViewModel();
            this.BindingContext = this.ViewModel;
        }

        #region Eventos
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<ParametrosBusca>(this, "BuscaServidores", (parametros) =>
            {
                // Inscreve o código abaixo para tratar a mensagem/ação "BuscaServidores"
                Navigation.PushAsync(new ListagemServidoresView(parametros));
            });

            await this.ViewModel.GetSecretarias();
            await this.ViewModel.GetAnos();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            // Cancela subscrição
            MessagingCenter.Unsubscribe<ParametrosBusca>(this, "BuscaServidores");
        }

        public void OnAboutToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        #endregion
    }
}
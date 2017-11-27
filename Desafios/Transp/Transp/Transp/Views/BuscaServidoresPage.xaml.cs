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

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<ParametrosBusca>(this, "BuscaServidores", (parametros) =>
            {
                Navigation.PushAsync(new ListagemServidoresView(parametros));
            });

            await this.ViewModel.GetSecretarias();
            await this.ViewModel.GetAnos();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<ParametrosBusca>(this, "BuscaServidores");
        }

        public void OnAboutToolbarItem_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sobre", "Este trabalho foi desenvolvido por Bruno Savyo de Freitas Silva " + 
                "para a disciplina de Xamarim do curso de especialização em Desenvolvimento de Aplicativos para Dispositivos Móveis " + 
                "da Faculdade Católica do Tocantins.", "OK");
        }
    }
}
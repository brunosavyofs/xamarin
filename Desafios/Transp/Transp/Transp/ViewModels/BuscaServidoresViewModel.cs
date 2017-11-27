using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Transp.Models;
using Xamarin.Forms;

namespace Transp.ViewModels
{
    public class BuscaServidoresViewModel : BaseViewModel
    {
        #region Definição de propriedades
        private APIService apiService;

        public ObservableCollection<String> Secretarias { get; set; }
        public List<Mes> Meses { get; set; }
        public ObservableCollection<int> Anos { get; set; }

        public ParametrosBusca ParametrosBusca { get; set; }

        public String Secretaria
        {
            get
            {
                return ParametrosBusca.Secretaria;
            }
            set
            {
                ParametrosBusca.Secretaria = value;

                // Notifica alteração na propriedade
                OnPropertyChanged();
                ((Command)BuscaServidores).ChangeCanExecute();
            }
        }

        public int Ano
        {
            get
            {
                return ParametrosBusca.Ano;
            }
            set
            {
                ParametrosBusca.Ano = value;

                // Notifica alteração na propriedade
                OnPropertyChanged();
                ((Command)BuscaServidores).ChangeCanExecute();
            }
        }

        public Mes Mes
        {
            get
            {
                return ParametrosBusca.Mes;
            }
            set
            {
                ParametrosBusca.Mes = value;

                // Notifica alteração na propriedade
                OnPropertyChanged();
                ((Command)BuscaServidores).ChangeCanExecute();
            }
        }
        #endregion

        public BuscaServidoresViewModel()
        {
            this.apiService = new APIService();

            // Inicializa listas a serem usadas no formulários
            this.Secretarias = new ObservableCollection<String>();
            this.Anos = new ObservableCollection<int>();
            this.Meses = new ListaMeses().Meses;

            this.ParametrosBusca = new ParametrosBusca();

            // Atribui código a ser executado pelo comando de buscar servidores
            BuscaServidores = new Command(() =>
            {
                MessagingCenter.Send<ParametrosBusca>(ParametrosBusca, "BuscaServidores");
            }, () =>
            {
                // Função anônima cujo resultado define se o botão será ou não habilitado
                return ParametrosBusca.ValidarParametros();
            });
        }

        public ICommand BuscaServidores { get; set; }

        #region Métodos para popular listas de dados
        /// <summary>
        /// Busca as secretarias e preenche a lista com o resultado da requisição.
        /// </summary>
        /// <returns>lista de secretarias</returns>
        public async Task GetSecretarias()
        {
            foreach (String secretaria in new ObservableCollection<String>(await this.apiService.BuscaSecretarias()))
            {
                this.Secretarias.Add(secretaria);
            }
        }

        /// <summary>
        /// Busca os anos disponíveis e preenche a lista com o resultado da requisição.
        /// </summary>
        /// <returns>lista de anos</returns>
        public async Task GetAnos()
        {
            foreach (int ano in new ObservableCollection<int>(await this.apiService.BuscaAnos()))
            {
                this.Anos.Add(ano);
            }
        }
        #endregion
    }
}

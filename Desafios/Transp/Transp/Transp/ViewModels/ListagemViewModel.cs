using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Transp.Models;
using Xamarin.Forms;

namespace Transp.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {
        #region Definição de propriedades
        private APIService apiService;

        public ParametrosBusca ParametrosBusca;
        public ObservableCollection<ServidorObj> Servidores { get; set; }

        private ServidorObj _servidorSelecionado;
        public ServidorObj ServidorSelecionado
        {
            get
            {
                return this._servidorSelecionado;
            }
            set
            {
                this._servidorSelecionado = value;

                if (this._servidorSelecionado != null)
                    MessagingCenter.Send<ServidorObj>(this._servidorSelecionado, "ServidorSelecionado");
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        // Propriedade responsável por controlar a exibição do indicador de atividade
        private bool _carregando;

        public bool Carregando
        {
            get
            {
                return _carregando;
            }
            set
            {
                _carregando = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public ListagemViewModel(ParametrosBusca parametros)
        {
            this.apiService = new APIService();
            this.Servidores = new ObservableCollection<ServidorObj>();

            this.ParametrosBusca = parametros;
        }

        //public void OnPropertyChanged([CallerMemberName]string name = "")
        //{
        //    // Notifica a view da alteração na propriedade
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        /// <summary>
        /// Busca os anos disponíveis e preenche a lista com o resultado da requisição.
        /// </summary>
        /// <returns>lista de anos</returns>
        public async Task GetServidores()
        {
            if (this.Servidores.Count == 0)
            {
                // Exibe indicativo de atividade
                Carregando = true;

                foreach (ServidorObj servidor in new ObservableCollection<ServidorObj>(await this.apiService.BuscaServidores(this.ParametrosBusca)))
                {
                    this.Servidores.Add(servidor);
                }

                //Esconde indicativo de atividade
                Carregando = false;
            }
        }
    }
}

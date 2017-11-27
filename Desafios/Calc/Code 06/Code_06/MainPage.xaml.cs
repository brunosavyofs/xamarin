using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_06
{
    public partial class MainPage : ContentPage
    {
        #region Constantes referentes aos operadores
        private const string OperadorSoma = "+";
        private const string OperadorSubtracao = "-";
        private const string OperadorMultiplicacao = "*";
        private const string OperadorDivisao = "/";
        #endregion

        #region Demais propriedades auxiliares
        string operador = OperadorSoma;

        Double ultimoNumero = 0;

        // Flag que informa que é para capturar novo número
        bool capturaNovoNumero = true;

        // Propriedades que controlam o modo de operação da calculadora
        bool modoCapturaOperador;
        bool mostrandoResultado;
        #endregion


        public MainPage()
        {
            InitializeComponent();

            capturaNovoNumero = true;
            modoCapturaOperador = false;
            mostrandoResultado = true;
        }

        #region Métodos de manipulação de eventos
        /// <summary>
        /// Trata evento disparado quando o botão 'C' é pressionado.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonClearClicked(object sender, EventArgs e)
        {
            lblNumero.Text = "0";
            DescoloreBotoesOperacoes();

            capturaNovoNumero = true;
            modoCapturaOperador = false;
            mostrandoResultado = true;

            ultimoNumero = 0;
        }

        /// <summary>
        /// Manipula evento de clique sobre o botão de '+/-'
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonMaisOuMenosClicked(object sender, EventArgs e)
        {
            //Zero não tem positivo nem negativo
            if (lblNumero.Text == "0")
                return;
            //Se for negativo
            if (lblNumero.Text.StartsWith(OperadorSubtracao))
                lblNumero.Text = lblNumero.Text.Replace(OperadorSubtracao, ""); //Transforma em positivo
            else //Se for positivo
                lblNumero.Text = OperadorSubtracao + lblNumero.Text; //Transforma em negativo
        }

        /// <summary>
        /// Método responsável por tratar o evento do clique de um botão referente a um número.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonNumberClicked(object sender, EventArgs e)
        {
            DescoloreBotoesOperacoes();

            var button = (sender as Button);

            //É para iniciar novo número no visor
            if (capturaNovoNumero)
            {
                lblNumero.Text = button.Text;
            }
            else
            {
                // Se estiver com visor "limpo"
                if (lblNumero.Text == "0")
                    lblNumero.Text = button.Text;
                else
                    // Completa com novos dígitos
                    lblNumero.Text = lblNumero.Text + button.Text;
            }
            capturaNovoNumero = false;
            mostrandoResultado = false;
        }

        /// <summary>
        /// Método responsável por tratar o evento disparado quando os botões referentes às operações são pressionados.
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonOperacaoClicked(object sender, EventArgs e)
        {
            capturaNovoNumero = true;

            var button = (sender as Button);
            var classId = button.ClassId;

            // Atribui o número da tela a variável que guarda o último número informado
            ultimoNumero = float.Parse(lblNumero.Text, CultureInfo.InvariantCulture);

            // Colore botão e define operador
            switch (classId)
            {
                case "btnMultiplicacao":
                    ColoreBotaoPressionado(btnMultiplicacao);
                    operador = OperadorMultiplicacao;
                    break;
                case "btnSubtracao":
                    ColoreBotaoPressionado(btnSubtracao);
                    operador = OperadorSubtracao;
                    break;
                case "btnSoma":
                    ColoreBotaoPressionado(btnSoma);
                    operador = OperadorSoma;
                    break;
                case "btnDivisao":
                    ColoreBotaoPressionado(btnDivisao);
                    operador = OperadorDivisao;
                    break;
            }

            modoCapturaOperador = true;
            mostrandoResultado = false;
        }

        /// <summary>
        /// Manipula evento responsável por clique no botão de resultado '='
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonResultadoClicked(object sender, EventArgs e)
        {
            capturaNovoNumero = true;

            Double resultado = 0;

            // Atribui o número do visor à variável que guarda o número digitado
            Double numeroAtual = Convert.ToDouble(lblNumero.Text, CultureInfo.InvariantCulture);

            // Realiza a operação com base no operador selecionado
            switch (operador)
            {
                case OperadorSoma:
                    resultado = ultimoNumero + numeroAtual;
                    break;
                case OperadorSubtracao:
                    resultado = ultimoNumero - numeroAtual;
                    break;
                case OperadorMultiplicacao:
                    resultado = ultimoNumero * numeroAtual;
                    break;
                case OperadorDivisao:
                    resultado = ultimoNumero / numeroAtual;
                    break;
            }
            
            // Caso esteja em modo operador, é necessário atualizar o último número digitado com o número atual,
            // antes de atribuir o resultado ao visor
            if (modoCapturaOperador)
                ultimoNumero = numeroAtual;

            lblNumero.Text = Convert.ToString(resultado, CultureInfo.InvariantCulture);

            modoCapturaOperador = false;
            mostrandoResultado = true;

            DescoloreBotoesOperacoes();
        }

        /// <summary>
        /// Manipula evento disparado ao clique do botão da vírgula
        /// </summary>
        /// <param name="sender">Objeto que disparou o evendo</param>
        /// <param name="e">Atributos do evento</param>
        void OnButtonVirgulaClicked(object sender, EventArgs e)
        {
            if (capturaNovoNumero)
            {
                lblNumero.Text = "0.";
            }
            else
            {
                if (!lblNumero.Text.Contains("."))
                {
                    lblNumero.Text = lblNumero.Text + ".";
                }
            }
            capturaNovoNumero = false;
        }
        #endregion

        #region Métodos auxiliares
        /// <summary>
        /// Colore o botão pressionado
        /// </summary>
        /// <param name="buttonPressionado">botão a ser colorido</param>
        void ColoreBotaoPressionado(Button buttonPressionado)
        {
            //Muda a cor dos não pressionados para cor padrão
            DescoloreBotoesOperacoes();
            //Muda a cor do botão pressionado
            buttonPressionado.BackgroundColor = Color.DarkGray;
        }

        /// <summary>
        /// Descolore todos os botões referentes às operações.
        /// </summary>
        private void DescoloreBotoesOperacoes()
        {
            btnMultiplicacao.BackgroundColor = Color.FromHex("E8AD00");
            btnSoma.BackgroundColor = Color.FromHex("E8AD00");
            btnDivisao.BackgroundColor = Color.FromHex("E8AD00");
            btnSubtracao.BackgroundColor = Color.FromHex("E8AD00");
        }
        #endregion
    }
}

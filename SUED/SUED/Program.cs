using System;
using System.Threading;

namespace SUED
{
    class Program
    {
        #region Declaração de constantes e variáveis
        private const int SEGUNDOS_PENSANDO = 3;

        private const string fraseSaudacao = "Espelho, espelho meu, me responda ";
        private const string fraseSolicitacaoPergunta = "Faça qualquer pergunta (Pressione <<END>> para encerrar): ";
        private const string fraseRespostaNaoInformada = " estou cansado agora, não posso te responder.";

        private const char caracterInicioCapturaResposta = ';';
        private const ConsoleKey teclaEncerraCapturaResposta = ConsoleKey.Enter;
        private const ConsoleKey teclaEncerraPerguntas = ConsoleKey.End;

        private static string resposta = "";
        #endregion

        static void Main(string[] args)
        {
            do
            {
                Perguntar();
                Pensar();
                Responder();
            } while (true);
        }

        /// <summary>
        /// Escreve a frase solicitando a pergunta e verifica que ação tomar conforme primeira tecla pressionada.
        /// </summary>
        private static void Perguntar()
        {
            Console.WriteLine(fraseSolicitacaoPergunta);

            // Captura a tecla pressionada
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.KeyChar == caracterInicioCapturaResposta)
            {
                // Caso inicie com ';', captura a resposta
                CapturarResposta();
            } else if (key.Key == teclaEncerraPerguntas)
            {
                // Caso a tecla END tenha sido pressionada, encerra o programa
                Environment.Exit(1);
            }

            // Permite que o usuário termine a frase
            Console.ReadLine();
        }

        /// <summary>
        /// Escreve a resposta na tela e reseta a variável contendo a resposta digitada
        /// </summary>
        private static void Responder()
        {
            if (resposta == "")
            {
                Console.WriteLine("{0}", fraseRespostaNaoInformada);
            } else
            {
                Console.WriteLine(" => {0} <=", resposta);
            }
            Console.WriteLine();
            resposta = "";
        }

        /// <summary>
        /// Captura a resposta da pergunta enquanto exibe a saudação na tela.
        /// Ao ser pressionada a tecla ';', a captura será iniciada.
        /// Ao ser pressionada a tecla ENTER, a captura será encerrada.
        /// Ao término da frase de saudação/elogio, o cursor exibirá exatamente o que for digitado.
        /// </summary>
        private static void CapturarResposta()
        {
            for (var i = 0; i < fraseSaudacao.Length; i++)
            {
                // Captura a tecla pressionada
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == teclaEncerraCapturaResposta)
                {
                    // Caso o ENTER tenha sido pressionado, encerra captura da resposta
                    break;
                }
                else
                {
                    // Se não for a tecla ENTER, continua capturando a resposta
                    resposta += key.KeyChar;
                }

                Console.Write(fraseSaudacao[i]);
            }
        }

        /// <summary>
        /// Exibe ao usuário a mensagem para aguardar a resposta.
        /// </summary>
        private static void Pensar()
        {
            // Pula uma linha antes de iniciar o "processamento"
            Console.WriteLine();

            Console.Write("Pensando");
            int x = 0;
            do
            {
                Console.Write(".");
                Thread.Sleep(1000);
                x++;
            } while (x < SEGUNDOS_PENSANDO);
        }
    }
}

using System;
using System.Threading;

namespace SUED
{
    class Program
    {
        #region Declaração de atributos
        private const int SegundosPensando = 3;

        private const string FraseSaudacao = "Espelho, espelho meu, me responda ";
        private const string FraseSolicitacaoPergunta = "Faça qualquer pergunta (Pressione <<END>> para encerrar): ";
        private const string FraseRespostaNaoInformada = " estou cansado agora, não posso te responder.";

        private const char CaracterInicioCapturaResposta = ';';
        private const ConsoleKey TeclaEncerraCapturaResposta = ConsoleKey.Enter;
        private const ConsoleKey TeclaEncerraPerguntas = ConsoleKey.End;

        private static string Resposta = "";
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
            Console.WriteLine(FraseSolicitacaoPergunta);

            // Captura a tecla pressionada
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.KeyChar == CaracterInicioCapturaResposta)
            {
                // Caso inicie com ';', captura a resposta
                CapturarResposta();
            } else if (key.Key == TeclaEncerraPerguntas)
            {
                // Caso a tecla END tenha sido pressionada, encerra o programa
                Environment.Exit(1);
            }

            // Permite que o usuário termine a frase
            Console.ReadLine();
        }

        /// <summary>
        /// Captura a resposta da pergunta enquanto exibe a saudação na tela.
        /// Ao ser pressionada a tecla ';', a captura será iniciada.
        /// Ao ser pressionada a tecla ENTER, a captura será encerrada.
        /// Ao término da frase de saudação/elogio, o cursor exibirá exatamente o que for digitado.
        /// </summary>
        private static void CapturarResposta()
        {
            for (var i = 0; i < FraseSaudacao.Length; i++)
            {
                // Captura a tecla pressionada
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == TeclaEncerraCapturaResposta)
                {
                    // Caso o ENTER tenha sido pressionado, encerra captura da resposta
                    break;
                }
                else
                {
                    // Se não for a tecla ENTER, continua capturando a resposta
                    Resposta += key.KeyChar;
                }

                Console.Write(FraseSaudacao[i]);
            }
        }

        /// <summary>
        /// Escreve a resposta na tela e reseta a variável contendo a resposta digitada
        /// </summary>
        private static void Responder()
        {
            if (Resposta == "")
            {
                Console.WriteLine("{0}", FraseRespostaNaoInformada);
            } else
            {
                Console.WriteLine(" => {0} <=", Resposta);
            }
            Console.WriteLine();
            Resposta = "";
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
            } while (x < SegundosPensando);
        }
    }
}

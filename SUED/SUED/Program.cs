using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUED
{
    class Program
    {
        #region Declaração de constantes e variáveis
        private const int SEGUNDOS_PENSANDO = 3;
        private const string saudacao = "Espelho, espelho meu, me responda ";
        private const string pergunta = "Faça qualquer pergunta:";

        private static string resposta;
        private static Boolean capturarResposta = false;
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

        private static void Perguntar()
        {
            Console.WriteLine(pergunta);
            CapturarResposta();
            Console.ReadLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Escreve a resposta na tela e reseta a variável contendo a resposta digitada
        /// </summary>
        private static void Responder()
        {
            Console.WriteLine(" => {0} <=", resposta);
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
            for (var i = 0; i < saudacao.Length; i++)
            {
                // Captura a tecla pressionada
                ConsoleKeyInfo key = Console.ReadKey(true);
                char ch = key.KeyChar;

                if (capturarResposta)
                {
                    // Caso a captura da resposta já tenha sido iniciada

                    if (key.Key == ConsoleKey.Enter)
                    {
                        // Caso o ENTER tenha sido pressionada, encerra captura da resposta
                        capturarResposta = false;
                    }
                    else
                    {
                        // Se não for a tecla ENTER, continua capturando a resposta
                        resposta += ch;
                    }
                }
                else if (ch == ';')
                {
                    // Se ainda não tiver sido iniciada a captura da resposta e for pressionada tecla ';', inicia captura da resposta
                    capturarResposta = true;
                }

                Console.Write(saudacao[i]);
            }
        }

        /// <summary>
        /// Exibe ao usuário a mensagem para aguardar a resposta.
        /// </summary>
        private static void Pensar()
        {
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

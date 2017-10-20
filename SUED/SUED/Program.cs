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
        private const string pergunta = "Faça qualquer pergunta (Use a tecla End para encerrar):";

        private static string resposta;
        private static Boolean encerrar = false;
        private static Boolean capturarResposta = false;
        #endregion

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(pergunta);
                if (CapturarResposta())
                {
                    Perguntar();
                    Pensar();
                    Responder();
                } else
                {
                    break;
                }
            } while (true);
        }

        private static void Perguntar()
        {
            Console.ReadLine();
            Console.WriteLine();
        }

        private static void Responder()
        {
            Console.WriteLine(" => {0} <=", resposta);
            Console.WriteLine();
            resposta = "";
        }

        /// <summary>
        /// Captura a resposta da pergunta.
        /// </summary>
        /// <returns>False caso a resposta não seja </returns>
        private static Boolean CapturarResposta()
        {
            for (var i = 0; i < saudacao.Length; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                char ch = key.KeyChar;

                if (capturarResposta)
                {
                    if (key.Key == ConsoleKey.Enter)
                    {
                        capturarResposta = false;
                    }
                    else
                    {
                        resposta += ch;
                    }
                }
                else if (ch == ';')
                {
                    capturarResposta = true;
                }

                // Encerra a execução se a tecla End for pressionada
                if (key.Key == ConsoleKey.End)
                {
                    return false;
                }
                Console.Write(saudacao[i]);
            }

            return true;
        }

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
            //Console.WriteLine();
        }
    }
}

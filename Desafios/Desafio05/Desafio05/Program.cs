using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    class Program
    {
        #region Constantes
        private const string TagPiada = "article class=\"item-index\"";
        private const int qtdPiadas = 15;
        #endregion

        static void Main(string[] args)
        {            
            WebClient webClient = new WebClient();

            // Adiciona evento de tratamento do conteúdo html para quando o download se completar
            webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;

            Uri uri = new Uri(Piada.UrlGeral);

            // Realiza o download do conteúdo da URI como string assincronamente
            webClient.DownloadStringAsync(uri);

            Console.Read();
        }

        #region Métodos gerais
        /// <summary>
        /// Extrai as piadas de um texto html
        /// </summary>
        /// <param name="conteudoHtml">conteúdo html de onde se quer atrair as piadas</param>
        /// <returns>lista de piadas a partir do conteúdo do html</returns>
        private static List<Piada> ExtrairPiadas(string conteudoHtml)
        {
            List<Piada> piadas = new List<Piada>();

            // Extrai as 15 primeiras piadas
            int posicaoInicioConteudoProximaPiada = 0;
            for (int x = 0; x < qtdPiadas; x++)
            {
                String htmlPiada = HtmlParser.ObtemConteudoElementoHtml(conteudoHtml, TagPiada, posicaoInicioConteudoProximaPiada);
                posicaoInicioConteudoProximaPiada = HtmlParser.ObtemPosicaoInicioElementoHtml(conteudoHtml, TagPiada, posicaoInicioConteudoProximaPiada) + 1;
                piadas.Add(new Piada(htmlPiada));
            }

            return piadas;
        }

        /// <summary>
        /// Escreve as piadas de maneira formatada
        /// </summary>
        /// <param name="piadas">lista de piadas</param>
        private static void EscreverPiadasFormatadas(List<Piada> piadas)
        {
            foreach (var piada in piadas)
            {
                Console.WriteLine(piada);
                Console.WriteLine("-------------");
                Console.WriteLine();
            }
        }
        #endregion

        #region Eventos
        private static void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            List<Piada> piadas = ExtrairPiadas(e.Result);

            EscreverPiadasFormatadas(piadas);
        }
        #endregion
    }
}

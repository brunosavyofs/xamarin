using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.osvigaristas.com.br/piadas";
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;

            string conteudo = webClient.DownloadString(url);

            Uri uri = new Uri(url);
            webClient.DownloadStringAsync(uri);
            Console.Read();
        }

        private static void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string conteudo = e.Result;
        }
    }
}

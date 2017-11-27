using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Transp.Models;

namespace Transp
{
    #region Objetos para parseamento do JSON
    class RootObjectSecretarias
    {
        public int Tamanho { get; set; }
        public List<String> Secretarias { get; set; }
    }

    class RootObjectPeriodos
    {
        public List<int> Meses { get; set; }
        public List<int> Anos { get; set; }
    }

    class RootObjectServidores
    {
        public int Count { get; set; }
        public List<ServidorObj> Results { set; get; }
    }
    #endregion

    class APIService
    {
        // Urls dos recursos da API a serem consumidos
        private const String UrlBuscaSecretarias = "http://portaldatransparencia.palmas.to.gov.br/folha-de-pagamento/secretaria/";
        private const String UrlBuscaPeriodos = "http://portaldatransparencia.palmas.to.gov.br/folha-de-pagamento/ano/";
        private const String UrlBuscaServidores = "http://integracao.palmas.to.gov.br/apirest/folha-pagamento/?format=json&secretaria={0}&ano_referencia={1}&mes_referencia={2}";

        private HttpClient client;

        public APIService()
        {
            this.client = new HttpClient();
        }

        /// <summary>
        /// Consulta as secretarias disponíveis através de requisição a API
        /// </summary>
        /// <returns>as secretarias no formato de lista de string</returns>
        public async Task<List<String>> BuscaSecretarias()
        {
            var uri = new Uri(UrlBuscaSecretarias);
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                RootObjectSecretarias result = JsonConvert.DeserializeObject<RootObjectSecretarias>(content);
                return result.Secretarias;
            }
            else
            {
                return new List<String>();
            }
        }

        /// <summary>
        /// Consulta os anos disponíveis através de requisição a API
        /// </summary>
        /// <returns>os anos no formato de lista de inteiros</returns>
        public async Task<List<int>> BuscaAnos()
        {
            var uri = new Uri(UrlBuscaPeriodos);
            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                RootObjectPeriodos result = JsonConvert.DeserializeObject<RootObjectPeriodos>(content);
                return result.Anos;
            }
            else
            {
                return new List<int>();
            }
        }

        /// <summary>
        /// Consulta os servidores de acordo com os parâmetros de busca
        /// </summary>
        /// <returns>os servidores que correspondem aos parâmetros de busca</returns>
        public async Task<List<ServidorObj>> BuscaServidores(ParametrosBusca parametros)
        {
            var uri = new Uri(String.Format(UrlBuscaServidores, parametros.Secretaria, parametros.Ano, 
                parametros.Mes.Id));

            // Faz requisição à API
            HttpResponseMessage response = await client.GetAsync(uri);

            // Caso a requsição seja processada corretamente, deserializa a resposta para o 
            // objeto auxiliar de parseamento e retorna a lista de resultados no formato adequado
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Altera estratégio de conversão dos nomes das propriedas porque a API utiliza o padrão snake_case
                var serializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver()
                    {
                        NamingStrategy = new SnakeCaseNamingStrategy()
                    }
                };
                RootObjectServidores result = JsonConvert.DeserializeObject<RootObjectServidores>(content, serializerSettings);
                return result.Results;
            }
            else
            {
                return new List<ServidorObj>();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVC
{
    /*
    * #Documentação
    * Criação de classe global App para conexão e utilização da API backend
    */
    public static class App
    {
        /*
         * #Documentação
         * Utilização de biblioteca para conexão HTTP e atribuição de objeto da classe
         */
        public static HttpClient WebAPIClient = new HttpClient();

        static App()
        {
            /*
             * #Documentação
             * Definição da rota base da API, reset de configurações padrões da classe e configuração de comunicação em formato padrão JSON
             */
            WebAPIClient.BaseAddress = new Uri("https://localhost:44366/api/");
            WebAPIClient.DefaultRequestHeaders.Clear();
            WebAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
using ClienteREST.Modelo;
using ClienteREST.Util;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;

namespace ClienteREST.Controle
{
    class CtrlEndereco
    {
        public static Endereco encheEndereco(string cep)
        {
            Uri uriBase = new Uri(UrlServico.viaCep, cep + "/");

            var client = new WebClient();
            client.Encoding = Encoding.UTF8;

            string json = client.DownloadString(new Uri(uriBase, "json"));

            Endereco objendereco = JsonConvert.DeserializeObject<Endereco>(json);

            return objendereco;
        }
    }
}

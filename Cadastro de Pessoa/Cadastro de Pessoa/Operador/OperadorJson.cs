using System;
using ClienteREST.Modelo;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Generic;

namespace ClienteREST.Operador
{
    public class OperadorJson : IntOperadorREST
    {
        public T cadastrar<T>(Objeto objeto, Uri uriBase)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                new Uri(uriBase, "json"));
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            string resposta = Requisicao.realizarComConteudo(
                JsonConvert.SerializeObject(objeto), httpWebRequest);

            return JsonConvert.DeserializeObject<T>(resposta);
        }
        public List<T> listar<T>(Uri uriBase)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                new Uri(uriBase, "json"));
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            string resposta = Requisicao.realizarSemConteudo(httpWebRequest);

            return JsonConvert.DeserializeObject<List<T>>(resposta);
        }
    }
}

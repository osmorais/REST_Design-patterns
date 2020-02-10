using System;
using ClienteREST.Modelo;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;

namespace ClienteREST.Operador
{
    public class OperadorXml : IntOperadorREST
    {
        public T cadastrar<T>(Objeto objeto, Uri uriBase)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                new Uri(uriBase, "xml"));
            httpWebRequest.ContentType = "application/xml";
            httpWebRequest.Method = "POST";

            XmlSerializer serializador = new XmlSerializer(typeof(T));

            StringWriter escritorString = new StringWriter();
            XmlTextWriter escritorXml = new XmlTextWriter(escritorString);
            serializador.Serialize(escritorXml, objeto);

            escritorString.Close();
            escritorXml?.Close();

            string resposta = Requisicao.realizarComConteudo(
                escritorString.ToString(), httpWebRequest);

            StringReader leitorString = new StringReader(resposta);
            XmlTextReader leitorXml = new XmlTextReader(leitorString);

            return (T)serializador.Deserialize(leitorXml);
        }
        public List<T> listar<T>(Uri uriBase)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                new Uri(uriBase, "xml"));
            httpWebRequest.ContentType = "application/xml";
            httpWebRequest.Method = "GET";

            string resposta = Requisicao.realizarSemConteudo(httpWebRequest);

            XmlSerializer serializador = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("list"));
            StringReader leitorString = new StringReader(resposta);
            XmlTextReader leitorXml = new XmlTextReader(leitorString);

            return serializador.Deserialize(leitorXml) as List<T>;
        }
    }
}

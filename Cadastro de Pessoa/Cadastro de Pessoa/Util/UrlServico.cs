using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteREST.Util
{
    public struct UrlServico
    {
        public static readonly Uri viaCep = new Uri("https://viacep.com.br/ws/");
        public static readonly Uri localhost = new Uri("http://localhost:8080/servico_basico/servico/");
        public static readonly Uri external3320 = new Uri("http://10.8.220.10:8080/servico_basico/servico/");
    }
}

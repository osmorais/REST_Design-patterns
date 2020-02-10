using System;
using System.Collections.Generic;
using ClienteREST.Modelo;
using ClienteREST.Util;
using ClienteREST.Operador;

namespace ClienteREST.Controle
{
    class CtrlSexo : IntControle
    {
        Uri uriBase = new Uri(UrlServico.localhost, "sexo/");
        public T cadastrar<T>(Objeto objeto, IntOperadorREST operador)
        {
            return operador.cadastrar<T>(objeto, uriBase);
        }
        public List<T> listar<T>(IntOperadorREST operador)
        {
            return operador.listar<T>(uriBase);
        }
    }
}

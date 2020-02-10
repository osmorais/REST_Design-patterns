using ClienteREST.Modelo;
using ClienteREST.Util;
using System;
using ClienteREST.Operador;
using System.Collections.Generic;

namespace ClienteREST.Controle
{
    class CtrlFuncionario : IntControle
    {
        Uri uriBase = new Uri(UrlServico.localhost, "funcionario/");
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

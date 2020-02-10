using ClienteREST.Modelo;
using System;
using ClienteREST.Util;
using ClienteREST.Operador;
using System.Collections.Generic;

namespace ClienteREST.Controle
{
    class CtrlCliente : IntControle
    {
        Uri uriBase = new Uri(UrlServico.localhost, "cliente/");
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
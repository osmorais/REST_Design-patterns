using ClienteREST.Modelo;
using System;
using System.Collections.Generic;
using ClienteREST.Util;
using ClienteREST.Operador;

namespace ClienteREST.Controle
{
    class CtrlDepartamento : IntControle
    {
        Uri uriBase = new Uri(UrlServico.localhost, "departamento/");
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

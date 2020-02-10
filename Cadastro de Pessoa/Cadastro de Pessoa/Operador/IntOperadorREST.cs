using ClienteREST.Modelo;
using System;
using System.Collections.Generic;

namespace ClienteREST.Operador
{
    public interface IntOperadorREST
    {
        T cadastrar<T>(Objeto objeto, Uri uriBase);
        List<T> listar<T>(Uri uriBase);
    }
}

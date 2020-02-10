using System.Collections.Generic;
using ClienteREST.Modelo;
using ClienteREST.Operador;

namespace ClienteREST.Controle
{
    interface IntControle
    {
        T cadastrar<T>(Objeto objeto, IntOperadorREST operador);
        List<T> listar<T>(IntOperadorREST operador);
    }
}
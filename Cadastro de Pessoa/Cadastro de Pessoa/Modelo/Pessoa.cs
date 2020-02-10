using System.Collections.Generic;

namespace ClienteREST.Modelo
{
    public abstract class Pessoa:Objeto
    {
        public string nome { get; set; }
        public Sexo sexo { get; set; }
        public List<Endereco> enderecos { get; set; }
    }
}

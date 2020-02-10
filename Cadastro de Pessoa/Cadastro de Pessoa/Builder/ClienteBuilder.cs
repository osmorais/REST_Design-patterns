using ClienteREST.Modelo;
using System.Collections.Generic;

namespace ClienteREST.Builder
{
    class ClienteBuilder
    {
        Cliente cliente = new Cliente();
        Sexo sexo = new Sexo();
		List<Endereco> enderecos = new List<Endereco>();

		public static ClienteBuilder iniciar()
        {
            return new ClienteBuilder();
        }
        public Cliente construir()
        {
            cliente.sexo = sexo;
            cliente.enderecos = enderecos;
            return cliente;
        }
        public ClienteBuilder comNome(string nome)
        {
            cliente.nome = nome;
            return this;
        }
        public ClienteBuilder comCodigoCliente(string codigoCliente)
        {
            cliente.codigoCliente = codigoCliente;
            return this;
        }
        public ClienteBuilder comSexo(int id)
        {
            sexo.id = id;
            return this;
        }
        public ClienteBuilder comEnderecos(List<Endereco> enderecos)
        {
            this.enderecos = enderecos;
            return this;
        }
    }
}

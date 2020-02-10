using ClienteREST.Modelo;
using System.Collections.Generic;

namespace ClienteREST.Builder
{
    class FuncionarioBuilder
    {
        Funcionario funcionario = new Funcionario();
        Sexo sexo = new Sexo();
        List<Endereco> enderecos = new List<Endereco>();
        Departamento departamento = new Departamento();

        public static FuncionarioBuilder iniciar()
        {
            return new FuncionarioBuilder();
        }
        public Funcionario construir()
        {
            funcionario.sexo = sexo;
            funcionario.enderecos = enderecos;
            funcionario.departamento = departamento;
            return funcionario;
        }
        public FuncionarioBuilder comNome(string nome)
        {
            funcionario.nome = nome;
            return this;
        }
        public FuncionarioBuilder comSexo(int id)
        {
            sexo.id = id;
            return this;
        }
        public FuncionarioBuilder comEnderecos(List<Endereco> enderecos)
        {
            this.enderecos = enderecos;
            return this;
        }
        public FuncionarioBuilder comDepartamento(int id)
        {
            departamento.id = id;
            return this;
        }
    }
}

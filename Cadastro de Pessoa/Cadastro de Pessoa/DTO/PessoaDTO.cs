using System.Collections.Generic;

namespace ClienteREST.DTO
{
    public abstract class PessoaDTO : ObjetoDTO
    {
        public string nome { get; set; }
        public SexoDTO sexo { get; set; }
        public List<EnderecoDTO> enderecos { get; set; }
    }
}

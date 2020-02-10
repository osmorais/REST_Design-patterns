using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteREST.DTO
{
    public class DepartamentoDTO : ObjetoDTO
    {
        public string descricao { get; set; }
        public DepartamentoDTO() { }
        public DepartamentoDTO(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}

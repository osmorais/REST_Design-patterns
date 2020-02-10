namespace ClienteREST.DTO
{
    public class SexoDTO : ObjetoDTO
    {
        public string descricao { get; set; }

        public SexoDTO() { }

        public SexoDTO(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}

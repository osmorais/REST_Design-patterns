namespace ClienteREST.Modelo
{
    public class Departamento:Objeto
    {
        public string descricao { get; set; }
        public Departamento() { }
        public Departamento(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}

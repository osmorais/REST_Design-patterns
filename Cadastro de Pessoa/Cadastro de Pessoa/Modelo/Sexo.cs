namespace ClienteREST.Modelo
{
    public class Sexo:Objeto
    {
        public string descricao { get; set; }

        public Sexo() { }

        public Sexo(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
    }
}

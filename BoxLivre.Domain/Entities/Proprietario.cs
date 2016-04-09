namespace BoxLivre.Domain.Entities
{
    public class Proprietario : EntityBase
    {
        public string Apto { get; set; }
        public string Nome { get; set; }

        public Proprietario(string apto, string nome)
        {
            Apto = apto;
            Nome = nome;
        }
    }
}

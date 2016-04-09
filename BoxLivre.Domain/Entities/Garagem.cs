using System.Collections.Generic;

namespace BoxLivre.Domain.Entities
{
    public class Garagem : EntityBase
    {
        public int GaragemId { get; set; }
        public string Descricao { get; set; }
        public List<Box> Boxes { get; set; }
    }
}

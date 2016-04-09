using System.Collections.Generic;

namespace BoxLivre.Domain.Entities
{
    public class Condominio : EntityBase
    {
        public int CondominioId { get; set; }
        public int Responsavel { get; set; }
        public List<Proprietario> Proprietarios{ get; set; }

    }

}
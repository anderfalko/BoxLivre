using System;

namespace BoxLivre.Domain.Entities
{
    public class EntityBase
    {
        public int UsuarioCriacao { get; set; }
        public DateTime DataHoraCriacao { get; set; }
        public int UsuarioEdicao { get; set; }
        public DateTime DataHoraEdicao { get; set; }
    }
}

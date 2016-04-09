using System;
using BoxLivre.Domain.Enums;

namespace BoxLivre.Domain.Entities
{
    public class Box : EntityBase
    {
        public int Numero { get; set; }
        public Proprietario Proprietario { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
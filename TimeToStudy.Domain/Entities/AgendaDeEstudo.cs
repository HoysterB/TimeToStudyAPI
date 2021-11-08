using System;

namespace TimeToStudy.Domain.Entities
{
    public class AgendaDeEstudo : Base
    {
        public DateTime Data { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int SessaoDeEstudoId { get; set; }
        public SessaoDeEstudo SessaoDeEstudo{ get; set; }
    }
}
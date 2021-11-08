using System.Collections.Generic;

namespace TimeToStudy.Domain.Entities
{
    public class Materia : Base
    {
        public string Nome { get; set; }
        public List<Conteudo> Conteudos { get; set; }
        public int SessaoDeEstudoId { get; set; }
        public SessaoDeEstudo SessaoDeEstudo { get; set; }
    }
}
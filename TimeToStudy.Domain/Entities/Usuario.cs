using System.Collections.Generic;

namespace TimeToStudy.Domain.Entities
{
    public class Usuario : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public virtual List<SessaoDeEstudo> SessoesDeEstudos { get; set; }
    }
}
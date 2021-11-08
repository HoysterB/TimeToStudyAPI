using System;

namespace TimeToStudy.Domain.Entities
{
    public class SessaoDeEstudo : Base
    {
        public int AtividadesRealizadas { get; set; }
        public int AtividadesCorretas { get; set; }
        public string TempoDuracao { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
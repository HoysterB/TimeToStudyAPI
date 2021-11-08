namespace TimeToStudy.Domain.Entities
{
    public class Conteudo : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
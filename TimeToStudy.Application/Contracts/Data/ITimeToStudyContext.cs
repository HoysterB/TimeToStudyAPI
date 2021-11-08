using Microsoft.EntityFrameworkCore;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Application.Contracts.Data
{
    public interface ITimeToStudyContext
    {
        public DbSet<AgendaDeEstudo> AgendasDeEstudos { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Revisao> Revisoes { get; set; }
        public DbSet<SessaoDeEstudo> SessoesDeEstudos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
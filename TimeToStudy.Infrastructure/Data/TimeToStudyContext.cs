using Microsoft.EntityFrameworkCore;
using TimeToStudy.Application.Contracts.Data;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Infrastructure.Data
{
    public class TimeToStudyContext : DbContext, ITimeToStudyContext
    {
        public TimeToStudyContext(DbContextOptions<TimeToStudyContext> options) : base(options) { }
        
        public DbSet<AgendaDeEstudo> AgendasDeEstudos { get; set; }
        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Revisao> Revisoes { get; set; }
        public DbSet<SessaoDeEstudo> SessoesDeEstudos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeToStudy.Domain.Entities;

namespace TimeToStudy.Infrastructure.Maps
{
    public class BaseMap<TDomain> : IEntityTypeConfiguration<TDomain> where TDomain : Base
    {
        private readonly string _tableName;

        public BaseMap(string tableName = "") => _tableName = tableName;

        public void Configure(EntityTypeBuilder<TDomain> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(b => b.CriadoEm).HasColumnName("CriadoEm").IsRequired();
        }
    }
}
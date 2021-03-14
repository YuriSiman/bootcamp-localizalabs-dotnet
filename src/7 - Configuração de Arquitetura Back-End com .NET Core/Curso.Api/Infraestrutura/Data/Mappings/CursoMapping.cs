using Curso.Api.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Infraestrutura.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Cursos>
    {
        public void Configure(EntityTypeBuilder<Cursos> builder)
        {
            builder.HasKey(u => u.Codigo);

            builder.Property(u => u.Codigo).ValueGeneratedOnAdd();
            builder.Property(u => u.Nome);
            builder.Property(u => u.Descricao);
            builder.HasOne(u => u.Usuario)
                .WithMany().HasForeignKey(fk => fk.CodigoUsuario);

            builder.ToTable("TB_CURSOS");
        }
    }
}

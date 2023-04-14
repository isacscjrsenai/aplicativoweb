using aplicativoweb.Models; // camada Model
using Microsoft.EntityFrameworkCore; // EF Framework
using Microsoft.EntityFrameworkCore.Metadata.Builders; //Fluent API

namespace aplicativoweb.EntityConfigs; // Novo namaspace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");

        builder.Property(c => c.TituloInterno)
               .HasColumnType("nvarchar(80)")
               .IsRequired();
        
        builder.Property(c => c.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired();

        builder.Property(c => c.Descricao)
                .HasColumnType("text")
                .IsRequired();
    }
}
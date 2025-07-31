using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Modelo.Domain;

namespace Modelo.Infra.Mapeamento;
public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Aluno");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Nome).HasColumnType("varchar(50)");
        builder.Property(t => t.Idade).HasColumnType("int");
        builder.Property(t => t.CEP).HasColumnType("varchar(14)");


    }
}

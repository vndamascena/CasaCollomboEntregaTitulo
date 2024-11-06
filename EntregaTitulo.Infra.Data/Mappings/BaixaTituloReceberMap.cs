﻿using EntregaTitulo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaTitulo.Infra.Data.Mappings
{
    public class BaixaTituloReceberMap : IEntityTypeConfiguration<BaixaTitulo>
    {
        public void Configure(EntityTypeBuilder<BaixaTitulo> builder)
        {
            builder.ToTable("BAIXAETITULORECEBER");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.UsuarioId).HasColumnName("USUARIOID");
            builder.Property(e => e.IdTitulo).HasColumnName("ENTREGAID");
            builder.Property(e => e.NumeroNota).HasColumnName("NUMERONOTA");
            builder.Property(e => e.NomeCliente).HasColumnName("NOMECLIENTE");
            builder.Property(e => e.Valor).HasColumnName("VALORNOTA");
            builder.Property(e => e.ImagemUrl).HasColumnName("URLIMAGEM");
            builder.Property(e => e.Observacao).HasColumnName("OBSERVACAO");
            builder.Property(o => o.Telefone).HasColumnName("TELEFONE");
            builder.Property(v => v.DataTime).HasColumnName("DATA");
            builder.Property(e => e.DataVenda).HasColumnName("DATAVENDA");
            builder.Property(v => v.Loja).HasColumnName("LOJA");
            builder.Property(e => e.Vendedor).HasColumnName("VENDEDOR");


            builder.HasOne(e => e.TituloReceber)
                .WithMany()
                .HasForeignKey(e => e.IdTitulo)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
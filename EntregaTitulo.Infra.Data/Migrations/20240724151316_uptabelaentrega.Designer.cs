﻿// <auto-generated />
using System;
using EntregaTitulo.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntregaTitulo.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240724151316_uptabelaentrega")]
    partial class uptabelaentrega
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaEntrega", b =>
                {
                    b.Property<int>("IdBaixaEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDBAIXAENTREGA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBaixaEntrega"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DiaSemana")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANA");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("EntregaId1")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URLIMAGEM");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALORNOTA");

                    b.HasKey("IdBaixaEntrega");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("BAIXAENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Entrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ATIVO");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataEntrega")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataEntrega");

                    b.Property<string>("DiaSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGEMURL");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PERIODO");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALOR");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.ToTable("ENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.PendenciaEntrega", b =>
                {
                    b.Property<int>("IdPendencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPENDENCIA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPendencia"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DiaSemana")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANA");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("EntregaId1")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URLIMAGEM");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("ObservacaoPendencia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAOPENDENCIA");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALORNOTA");

                    b.HasKey("IdPendencia");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("PENDENCIAENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaEntrega", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", "Entrega")
                        .WithMany()
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", null)
                        .WithMany("BaixaEntregas")
                        .HasForeignKey("EntregaId1");

                    b.Navigation("Entrega");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.PendenciaEntrega", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", "Entrega")
                        .WithMany()
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", null)
                        .WithMany("PendenciaEntregas")
                        .HasForeignKey("EntregaId1");

                    b.Navigation("Entrega");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Entrega", b =>
                {
                    b.Navigation("BaixaEntregas");

                    b.Navigation("PendenciaEntregas");
                });
#pragma warning restore 612, 618
        }
    }
}

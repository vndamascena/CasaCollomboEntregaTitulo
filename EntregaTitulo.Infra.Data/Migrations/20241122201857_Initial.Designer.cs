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
    [Migration("20241122201857_Initial")]
    partial class Initial
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

                    b.Property<string>("DataEntregaBaixa")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataEntrega");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataVenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("DiaSemanaBaixa")
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

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("Motorista")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTA");

                    b.Property<string>("MotoristaAtual")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTAATUAL");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
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
                        .HasColumnName("VALORNOTA");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("IdBaixaEntrega");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("BAIXAENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaTitulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DataPrevistaPagamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAPREVPG");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataVenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URLIMAGEM");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TELEFONE");

                    b.Property<int>("TituloId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("TituloReceberId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALORNOTA");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.HasIndex("TituloId");

                    b.HasIndex("TituloReceberId");

                    b.ToTable("BAIXAETITULORECEBER", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaTituloFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DataPrevistaPagamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAPREVPG");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataVenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URLIMAGEM");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<int>("TituloId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("TituloReceberFuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALORNOTA");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.HasIndex("TituloId");

                    b.HasIndex("TituloReceberFuncionarioId");

                    b.ToTable("BAIXAETITULORECEBERFUNCIONARIO", (string)null);
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

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAATUALIZACAO");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataEntrega")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataEntrega");

                    b.Property<string>("DataVenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("DiaSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGEMURL");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("Motorista")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTA");

                    b.Property<string>("MotoristaAtual")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTAATUAL");

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

                    b.Property<string>("UsuarioIdAtualizador")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOIDATUALIZADOR");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALOR");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.ToTable("ENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Impressao", b =>
                {
                    b.Property<int>("IdImpressao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDIMPRESSAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdImpressao"));

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("EntregaId1")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.HasKey("IdImpressao");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("IMPRESSAO", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDPAGAMENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPagamento"));

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("EntregaId1")
                        .HasColumnType("int");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int?>("NumeroNota")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("StatusDePagamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUSDEPAGAMENTO");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.HasKey("IdPagamento");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("PAGAMENTO", (string)null);
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

                    b.Property<string>("DataEntrega")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DataEntrega");

                    b.Property<string>("DataEntregaProximaEntrega")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANAPENDENCIA");

                    b.Property<DateTime>("DataTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<string>("DataVenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("DiaSemana")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIASEMANA");

                    b.Property<string>("DiaSemanaPendencia")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PROXIMAENTREGA");

                    b.Property<int>("EntregaId")
                        .HasColumnType("int")
                        .HasColumnName("ENTREGAID");

                    b.Property<int?>("EntregaId1")
                        .HasColumnType("int");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("URLIMAGEM");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("Motorista")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTA");

                    b.Property<string>("MotoristaAtual")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("MOTORISTAATUAL");

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

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PERIODO");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALORNOTA");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("IdPendencia");

                    b.HasIndex("EntregaId");

                    b.HasIndex("EntregaId1");

                    b.ToTable("PENDENCIAENTREGA", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.TituloReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ATIVO");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAALTERACAO");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACADASTRO");

                    b.Property<string>("DataPrevistaPagamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAPREVPG");

                    b.Property<string>("DataVenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGEMURL");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TELEFONE");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("UsuarioIdAtualizador")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOIDATUALIZADOR");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALOR");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.ToTable("TITULORECEBER", (string)null);
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.TituloReceberFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ATIVO");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATAALTERACAO");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATACADASTRO");

                    b.Property<string>("DataPrevistaPagamento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAPREVPG");

                    b.Property<string>("DataVenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DATAVENDA");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMAGEMURL");

                    b.Property<string>("Loja")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOJA");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NOMECLIENTE");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int")
                        .HasColumnName("NUMERONOTA");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OBSERVACAO");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOID");

                    b.Property<string>("UsuarioIdAtualizador")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USUARIOIDATUALIZADOR");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VALOR");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VENDEDOR");

                    b.HasKey("Id");

                    b.ToTable("TITULORECEBERFUNCIONARIO", (string)null);
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

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaTitulo", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.TituloReceber", "TituloReceber")
                        .WithMany()
                        .HasForeignKey("TituloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.TituloReceber", null)
                        .WithMany("baixaTitulos")
                        .HasForeignKey("TituloReceberId");

                    b.Navigation("TituloReceber");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.BaixaTituloFuncionario", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.TituloReceberFuncionario", "TituloReceberFuncionario")
                        .WithMany()
                        .HasForeignKey("TituloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.TituloReceberFuncionario", null)
                        .WithMany("baixaTitulosFuncionario")
                        .HasForeignKey("TituloReceberFuncionarioId");

                    b.Navigation("TituloReceberFuncionario");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Impressao", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", "Entrega")
                        .WithMany()
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", null)
                        .WithMany("Impressao")
                        .HasForeignKey("EntregaId1");

                    b.Navigation("Entrega");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.Pagamento", b =>
                {
                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", "Entrega")
                        .WithMany()
                        .HasForeignKey("EntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntregaTitulo.Domain.Entities.Entrega", null)
                        .WithMany("Pagamento")
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

                    b.Navigation("Impressao");

                    b.Navigation("Pagamento");

                    b.Navigation("PendenciaEntregas");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.TituloReceber", b =>
                {
                    b.Navigation("baixaTitulos");
                });

            modelBuilder.Entity("EntregaTitulo.Domain.Entities.TituloReceberFuncionario", b =>
                {
                    b.Navigation("baixaTitulosFuncionario");
                });
#pragma warning restore 612, 618
        }
    }
}

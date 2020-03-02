﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Pivot.Infra.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190328203917_AdicionaMarca")]
    partial class AdicionaMarca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Marca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Abrangencia");

                    b.Property<long>("AtividadeId");

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao");

                    b.Property<int>("FaixaEtaria");

                    b.Property<string>("Logo");

                    b.Property<long>("MarcaAgrupadaId");

                    b.Property<int>("ModeloOperacional");

                    b.Property<int>("PricePoint");

                    b.Property<long>("RepresentanteId");

                    b.Property<string>("Url");

                    b.Property<int>("UsuarioAlteracaoId");

                    b.Property<int>("UsuarioAlteracaoLogin");

                    b.Property<int>("UsuarioCriacaoId");

                    b.Property<string>("UsuarioCriacaoLogin");

                    b.HasKey("Id");

                    b.HasIndex("MarcaAgrupadaId")
                        .IsUnique();

                    b.HasIndex("RepresentanteId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Domain.Marca", b =>
                {
                    b.HasOne("Domain.Marca", "MarcaAgrupada")
                        .WithOne()
                        .HasForeignKey("Domain.Marca", "MarcaAgrupadaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Marca", "Representante")
                        .WithMany()
                        .HasForeignKey("RepresentanteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

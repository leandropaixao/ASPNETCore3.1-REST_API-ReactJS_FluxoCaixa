﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finaCOM.Api.Data;

namespace finaCOM.Api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201102010553_Alterado campos required da tabela de lancamentos")]
    partial class Alteradocamposrequireddatabeladelancamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("finaCOM.Api.Models.Conta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("SaldoAtual")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("SaldoInicial")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("finaCOM.Api.Models.Lancamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataPagamento")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("IdConta")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValorOriginal")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal?>("ValorPago")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Lancamentos");
                });
#pragma warning restore 612, 618
        }
    }
}

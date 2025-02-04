﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.data;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210220181132_migracao")]
    partial class migracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("backend.models.Etapa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Etapa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataHoraFim = new DateTime(2021, 3, 22, 19, 11, 31, 779, DateTimeKind.Local).AddTicks(9562),
                            DataHoraInicio = new DateTime(2021, 3, 22, 15, 11, 31, 778, DateTimeKind.Local).AddTicks(8317)
                        },
                        new
                        {
                            Id = 2,
                            DataHoraFim = new DateTime(2021, 3, 23, 19, 11, 31, 780, DateTimeKind.Local).AddTicks(1743),
                            DataHoraInicio = new DateTime(2021, 3, 23, 15, 11, 31, 780, DateTimeKind.Local).AddTicks(1737)
                        });
                });

            modelBuilder.Entity("backend.models.HorarioCafe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraFim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataHoraInicio")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("HorarioCafe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataHoraFim = new DateTime(2021, 3, 22, 15, 26, 31, 780, DateTimeKind.Local).AddTicks(2547),
                            DataHoraInicio = new DateTime(2021, 3, 22, 17, 11, 31, 780, DateTimeKind.Local).AddTicks(2541)
                        },
                        new
                        {
                            Id = 2,
                            DataHoraFim = new DateTime(2021, 3, 22, 15, 26, 31, 780, DateTimeKind.Local).AddTicks(4212),
                            DataHoraInicio = new DateTime(2021, 3, 23, 17, 11, 31, 780, DateTimeKind.Local).AddTicks(4205)
                        });
                });

            modelBuilder.Entity("backend.models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Darlan",
                            Sobrenome = "Poffo"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Vanessa",
                            Sobrenome = "Tanaka"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Nicolas",
                            Sobrenome = "Poffo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Gabriel",
                            Sobrenome = "Poffo"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Gengis",
                            Sobrenome = "khan"
                        });
                });

            modelBuilder.Entity("backend.models.PessoaSalaCafe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("HorarioCafeId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaCafeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HorarioCafeId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("SalaCafeId");

                    b.ToTable("PessoaSalaCafe");
                });

            modelBuilder.Entity("backend.models.PessoaSalaTreinamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EtapaId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioCafeId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaCafeId")
                        .HasColumnType("int");

                    b.Property<int>("SalaTreinamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EtapaId");

                    b.HasIndex("HorarioCafeId");

                    b.HasIndex("PessoaId");

                    b.HasIndex("SalaCafeId");

                    b.HasIndex("SalaTreinamentoId");

                    b.ToTable("PessoaSalaTreinamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EtapaId = 1,
                            HorarioCafeId = 1,
                            PessoaId = 1,
                            SalaCafeId = 2,
                            SalaTreinamentoId = 1
                        },
                        new
                        {
                            Id = 2,
                            EtapaId = 1,
                            HorarioCafeId = 1,
                            PessoaId = 2,
                            SalaCafeId = 2,
                            SalaTreinamentoId = 2
                        },
                        new
                        {
                            Id = 3,
                            EtapaId = 1,
                            HorarioCafeId = 1,
                            PessoaId = 3,
                            SalaCafeId = 2,
                            SalaTreinamentoId = 3
                        },
                        new
                        {
                            Id = 4,
                            EtapaId = 1,
                            HorarioCafeId = 1,
                            PessoaId = 4,
                            SalaCafeId = 2,
                            SalaTreinamentoId = 4
                        },
                        new
                        {
                            Id = 5,
                            EtapaId = 1,
                            HorarioCafeId = 1,
                            PessoaId = 5,
                            SalaCafeId = 2,
                            SalaTreinamentoId = 1
                        },
                        new
                        {
                            Id = 6,
                            EtapaId = 2,
                            HorarioCafeId = 2,
                            PessoaId = 1,
                            SalaCafeId = 1,
                            SalaTreinamentoId = 2
                        },
                        new
                        {
                            Id = 7,
                            EtapaId = 2,
                            HorarioCafeId = 2,
                            PessoaId = 2,
                            SalaCafeId = 1,
                            SalaTreinamentoId = 3
                        },
                        new
                        {
                            Id = 8,
                            EtapaId = 2,
                            HorarioCafeId = 2,
                            PessoaId = 3,
                            SalaCafeId = 1,
                            SalaTreinamentoId = 4
                        },
                        new
                        {
                            Id = 9,
                            EtapaId = 2,
                            HorarioCafeId = 2,
                            PessoaId = 4,
                            SalaCafeId = 1,
                            SalaTreinamentoId = 1
                        });
                });

            modelBuilder.Entity("backend.models.SalaCafe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("SalaCafe");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Café 1"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Café 2"
                        });
                });

            modelBuilder.Entity("backend.models.SalaTreinamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Lotacao")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int?>("SalaTreinamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("SalaTreinamentoId");

                    b.ToTable("SalaTreinamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lotacao = 10,
                            Nome = "Sala 1"
                        },
                        new
                        {
                            Id = 2,
                            Lotacao = 12,
                            Nome = "Sala 2"
                        },
                        new
                        {
                            Id = 3,
                            Lotacao = 9,
                            Nome = "Sala 3"
                        },
                        new
                        {
                            Id = 4,
                            Lotacao = 11,
                            Nome = "Sala 4"
                        });
                });

            modelBuilder.Entity("backend.models.PessoaSalaCafe", b =>
                {
                    b.HasOne("backend.models.HorarioCafe", "HorarioCafe")
                        .WithMany("PessoasSalaCafe")
                        .HasForeignKey("HorarioCafeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.Pessoa", "Pessoa")
                        .WithMany("PessoasSalaCafe")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.SalaCafe", "SalaCafe")
                        .WithMany("PessoasSalaCafe")
                        .HasForeignKey("SalaCafeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HorarioCafe");

                    b.Navigation("Pessoa");

                    b.Navigation("SalaCafe");
                });

            modelBuilder.Entity("backend.models.PessoaSalaTreinamento", b =>
                {
                    b.HasOne("backend.models.Etapa", "Etapa")
                        .WithMany("PessoasSalaTreinamento")
                        .HasForeignKey("EtapaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.HorarioCafe", "HorarioCafe")
                        .WithMany()
                        .HasForeignKey("HorarioCafeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.SalaCafe", "SalaCafe")
                        .WithMany()
                        .HasForeignKey("SalaCafeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.models.SalaTreinamento", "SalaTreinamento")
                        .WithMany()
                        .HasForeignKey("SalaTreinamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etapa");

                    b.Navigation("HorarioCafe");

                    b.Navigation("Pessoa");

                    b.Navigation("SalaCafe");

                    b.Navigation("SalaTreinamento");
                });

            modelBuilder.Entity("backend.models.SalaTreinamento", b =>
                {
                    b.HasOne("backend.models.Pessoa", null)
                        .WithMany("SalasTreinamento")
                        .HasForeignKey("PessoaId");

                    b.HasOne("backend.models.SalaTreinamento", null)
                        .WithMany("SalaTreinamentos")
                        .HasForeignKey("SalaTreinamentoId");
                });

            modelBuilder.Entity("backend.models.Etapa", b =>
                {
                    b.Navigation("PessoasSalaTreinamento");
                });

            modelBuilder.Entity("backend.models.HorarioCafe", b =>
                {
                    b.Navigation("PessoasSalaCafe");
                });

            modelBuilder.Entity("backend.models.Pessoa", b =>
                {
                    b.Navigation("PessoasSalaCafe");

                    b.Navigation("SalasTreinamento");
                });

            modelBuilder.Entity("backend.models.SalaCafe", b =>
                {
                    b.Navigation("PessoasSalaCafe");
                });

            modelBuilder.Entity("backend.models.SalaTreinamento", b =>
                {
                    b.Navigation("SalaTreinamentos");
                });
#pragma warning restore 612, 618
        }
    }
}

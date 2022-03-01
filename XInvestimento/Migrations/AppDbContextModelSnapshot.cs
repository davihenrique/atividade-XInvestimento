﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using XInvestimento.Data;

#nullable disable

namespace XInvestimento.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XInvestimento.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNacimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("XInvestimento.Models.ClientesPlano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdPlanoVip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdPlanoVip");

                    b.ToTable("ClientesPlano", (string)null);
                });

            modelBuilder.Entity("XInvestimento.Models.DadosFinaceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Agencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<double>("RendaMensal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("FinancieroCliente", (string)null);
                });

            modelBuilder.Entity("XInvestimento.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .IsUnicode(false)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("EnderecoCliente", (string)null);
                });

            modelBuilder.Entity("XInvestimento.Models.PlanoVip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("PlanoVip", (string)null);
                });

            modelBuilder.Entity("XInvestimento.Models.ClientesPlano", b =>
                {
                    b.HasOne("XInvestimento.Models.Cliente", "Cliente")
                        .WithMany("ClientesPlano")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_Cliente");

                    b.HasOne("XInvestimento.Models.PlanoVip", "PlanoVip")
                        .WithMany("ClientesPlano")
                        .HasForeignKey("IdPlanoVip")
                        .IsRequired()
                        .HasConstraintName("FK_PlanoVip");

                    b.Navigation("Cliente");

                    b.Navigation("PlanoVip");
                });

            modelBuilder.Entity("XInvestimento.Models.DadosFinaceiro", b =>
                {
                    b.HasOne("XInvestimento.Models.Cliente", "Cliente")
                        .WithMany("DadosFinaceiro")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FinanceiroCliente_Cliente");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("XInvestimento.Models.Endereco", b =>
                {
                    b.HasOne("XInvestimento.Models.Cliente", "Cliente")
                        .WithMany("Endereco")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_Endereco");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("XInvestimento.Models.Cliente", b =>
                {
                    b.Navigation("ClientesPlano");

                    b.Navigation("DadosFinaceiro");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("XInvestimento.Models.PlanoVip", b =>
                {
                    b.Navigation("ClientesPlano");
                });
#pragma warning restore 612, 618
        }
    }
}

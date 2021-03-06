// <auto-generated />
using FlixPrime.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlixPrime.Data.Migrations
{
    [DbContext(typeof(CadastroContext))]
    [Migration("20220114211149_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("FlixPrime.Model.Cadastro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ano")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("genero")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tipo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Cadastros");
                });
#pragma warning restore 612, 618
        }
    }
}

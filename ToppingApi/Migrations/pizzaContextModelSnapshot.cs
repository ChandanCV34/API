// <auto-generated />
using System;
using Apipizza.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Apipizza.Migrations
{
    [DbContext(typeof(pizzaContext))]
    partial class pizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Apipizza.Models.Topping", b =>
                {
                    b.Property<int>("ToppingNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ToppingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToppingPrice")
                        .HasColumnType("int");

                    b.HasKey("ToppingNumber");

                    b.ToTable("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}

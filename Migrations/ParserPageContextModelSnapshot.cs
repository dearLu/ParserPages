// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParserPages.Models;

namespace ParserPages.Migrations
{
    [DbContext(typeof(ParserPageContext))]
    partial class ParserPageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParserPages.Models.StaticItem", b =>
                {
                    b.Property<int>("StaticItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("PageAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Word")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaticItemId");

                    b.ToTable("StaticItems");
                });
#pragma warning restore 612, 618
        }
    }
}

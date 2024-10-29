﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netflix.Genre.Context;

#nullable disable

namespace Netflix.Genre.Migrations
{
    [DbContext(typeof(NetflixGenreContext))]
    partial class NetflixGenreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Netflix.Genre.Entitites.GenreMappings", b =>
                {
                    b.Property<int>("GenreMappingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreMappingsId"));

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("GenreMappingsId");

                    b.HasIndex("GenresId");

                    b.ToTable("GenreMappings");
                });

            modelBuilder.Entity("Netflix.Genre.Entitites.Genres", b =>
                {
                    b.Property<int>("GenresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenresId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenresId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Netflix.Genre.Entitites.GenreMappings", b =>
                {
                    b.HasOne("Netflix.Genre.Entitites.Genres", "Genre")
                        .WithMany("GenreMappings")
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Netflix.Genre.Entitites.Genres", b =>
                {
                    b.Navigation("GenreMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Netflix.Genre.Context;

#nullable disable

namespace Netflix.Genre.Migrations
{
    [DbContext(typeof(NetflixGenreContext))]
    [Migration("20241026202246_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Netflix.Genre.Entitites.GenreMapping", b =>
                {
                    b.Property<int>("GenreMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreMappingId"));

                    b.Property<int>("ContentId")
                        .HasColumnType("int");

                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.HasKey("GenreMappingId");

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

            modelBuilder.Entity("Netflix.Genre.Entitites.GenreMapping", b =>
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

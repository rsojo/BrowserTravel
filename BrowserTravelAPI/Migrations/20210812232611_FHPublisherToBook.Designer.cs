﻿// <auto-generated />
using System;
using BrowserTravelAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrowserTravelAPI.Migrations
{
    [DbContext(typeof(BrowserTravelDbcontext))]
    [Migration("20210812232611_FHPublisherToBook")]
    partial class FHPublisherToBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Author_Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Author_id")
                        .HasColumnType("int");

                    b.Property<int>("Book_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Author_id");

                    b.HasIndex("Book_id");

                    b.ToTable("Author_Books");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageCount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Publisher_id")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Publisher_id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Author_Book", b =>
                {
                    b.HasOne("BrowserTravelAPI.Data.Entities.Author", "Author")
                        .WithMany("Author_Books")
                        .HasForeignKey("Author_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrowserTravelAPI.Data.Entities.Book", "Book")
                        .WithMany("Author_Books")
                        .HasForeignKey("Book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Book", b =>
                {
                    b.HasOne("BrowserTravelAPI.Data.Entities.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_id");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Author", b =>
                {
                    b.Navigation("Author_Books");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Book", b =>
                {
                    b.Navigation("Author_Books");
                });

            modelBuilder.Entity("BrowserTravelAPI.Data.Entities.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}

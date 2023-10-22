﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pizza_web.Data;

#nullable disable

namespace pizaaweb.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231022061712_addedpizzaorder")]
    partial class addedpizzaorder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pizza_web.Model.pizzaorder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("pizaaname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("pizzaprice")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("pizzaorders");
                });
#pragma warning restore 612, 618
        }
    }
}
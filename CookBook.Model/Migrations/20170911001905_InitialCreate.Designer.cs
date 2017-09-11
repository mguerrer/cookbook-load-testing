﻿// <auto-generated />
using CookBook.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CookBook.Model.Migrations
{
    [DbContext(typeof(CookbookContext))]
    [Migration("20170911001905_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CookBook.Model.Entities.Cookbook", b =>
                {
                    b.Property<int>("CookbookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CookbookId");

                    b.ToTable("Cookbooks");
                });

            modelBuilder.Entity("CookBook.Model.Entities.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CookbookId");

                    b.Property<string>("Title");

                    b.HasKey("RecipeId");

                    b.HasIndex("CookbookId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("CookBook.Model.Entities.Recipe", b =>
                {
                    b.HasOne("CookBook.Model.Entities.Cookbook", "Cookbook")
                        .WithMany("Recipes")
                        .HasForeignKey("CookbookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

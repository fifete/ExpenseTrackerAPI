﻿// <auto-generated />
using System;
using ExpenseTrackerAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpenseTrackerAPI.Migrations
{
    [DbContext(typeof(ExpenseTrackerContext))]
    [Migration("20230127172352_Add_postgresql_db")]
    partial class Add_postgresql_db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpenseTrackerAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("color");

                    b.Property<string>("Emoji")
                        .IsRequired()
                        .HasColumnType("varchar")
                        .HasColumnName("emoji");

                    b.Property<decimal>("MaxBudget")
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("max_budget");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("name");

                    b.Property<decimal>("SpendingAmount")
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("spending_amount");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("UserIdTemp")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("userId_temp");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.CategoryExpenseDto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<decimal>("SpendingAmount")
                        .HasColumnType("numeric(8,2)");

                    b.ToTable("categories_expenses", (string)null);
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric(8,2)")
                        .HasColumnName("amount");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("description");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("time");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("expenses", (string)null);
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.Category", b =>
                {
                    b.HasOne("ExpenseTrackerAPI.Models.User", "User")
                        .WithMany("Categories")
                        .HasForeignKey("UserId")
                        .HasConstraintName("user_id_fkey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.Expense", b =>
                {
                    b.HasOne("ExpenseTrackerAPI.Models.Category", "Category")
                        .WithMany("Expenses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("category_id_fkey");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.Category", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("ExpenseTrackerAPI.Models.User", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web1c_backend.Models;

#nullable disable

namespace web1cbackend.Migrations
{
    [DbContext(typeof(Web1cDBContext))]
    partial class Web1cDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("web1c_backend.Models.Entities.Session", b =>
                {
                    b.Property<long>("En_session_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("En_session_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("En_session_id"));

                    b.Property<long?>("En_session_date")
                        .HasColumnType("bigint")
                        .HasColumnName("En_session_date");

                    b.Property<long?>("En_session_time")
                        .HasColumnType("bigint")
                        .HasColumnName("En_session_time");

                    b.Property<long?>("En_user_id")
                        .HasColumnType("bigint")
                        .HasColumnName("En_user_id");

                    b.HasKey("En_session_id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("web1c_backend.Models.Entities.User", b =>
                {
                    b.Property<long>("En_user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("En_user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("En_user_id"));

                    b.Property<string>("En_user_login")
                        .IsRequired()
                        .HasColumnType("varchar(50")
                        .HasColumnName("En_user_login");

                    b.Property<byte[]>("En_user_password")
                        .IsRequired()
                        .HasColumnType("varbinary(100")
                        .HasColumnName("En_user_password");

                    b.HasKey("En_user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
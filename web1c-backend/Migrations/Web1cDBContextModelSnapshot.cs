﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using web1c_backend.Models.Contexts;

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

            modelBuilder.Entity("web1c_backend.Models.Entities.En_debtor_agreement", b =>
                {
                    b.Property<int>("debtor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("debtor_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("debtor_id"));

                    b.Property<string>("Market_view")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Market_view");

                    b.Property<int>("base_id")
                        .HasColumnType("int")
                        .HasColumnName("base_id");

                    b.Property<int>("budget_id")
                        .HasColumnType("int")
                        .HasColumnName("budget_id");

                    b.Property<int>("business_id")
                        .HasColumnType("int")
                        .HasColumnName("business_id");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("comment");

                    b.Property<int>("counter_id")
                        .HasColumnType("int")
                        .HasColumnName("counter_id");

                    b.Property<int>("currency_id")
                        .HasColumnType("int")
                        .HasColumnName("currency_id");

                    b.Property<DateTime>("date_agreement")
                        .HasColumnType("DATETIME")
                        .HasColumnName("date_agreement");

                    b.Property<string>("debtor_name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("debtor_name");

                    b.Property<bool>("disabled_status")
                        .HasColumnType("bit")
                        .HasColumnName("disabled_status");

                    b.Property<string>("number_agreement")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("number_agreement");

                    b.Property<int>("payment_id")
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    b.Property<bool>("public_status")
                        .HasColumnType("bit")
                        .HasColumnName("public_status");

                    b.Property<string>("responsible")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("responsible");

                    b.Property<int>("society_id")
                        .HasColumnType("int")
                        .HasColumnName("society_id");

                    b.Property<string>("status_agreement")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("status_agreement");

                    b.Property<int>("turnover_id")
                        .HasColumnType("int")
                        .HasColumnName("turnover_id");

                    b.Property<bool>("typical_status")
                        .HasColumnType("bit")
                        .HasColumnName("typical_status");

                    b.HasKey("debtor_id");

                    b.ToTable("Debtor_Agreement");
                });

            modelBuilder.Entity("web1c_backend.Models.Entities.En_debtor_card", b =>
                {
                    b.Property<int>("debtor_card_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("debtor_card_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("debtor_card_id"));

                    b.Property<DateTime>("creation_date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_date");

                    b.Property<string>("debtor_card_name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("debtor_card_name");

                    b.Property<int>("debtor_id")
                        .HasColumnType("INT")
                        .HasColumnName("debtor_id");

                    b.Property<int>("emergency_message_id")
                        .HasColumnType("INT")
                        .HasColumnName("emergency_message_id");

                    b.Property<string>("inn")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)")
                        .HasColumnName("inn");

                    b.Property<bool>("is_bankrupt")
                        .HasColumnType("BIT")
                        .HasColumnName("is_bankrupt");

                    b.Property<bool>("is_in_creditors_list")
                        .HasColumnType("BIT")
                        .HasColumnName("is_in_creditors_list");

                    b.Property<bool>("is_smp")
                        .HasColumnType("BIT")
                        .HasColumnName("is_smp");

                    b.Property<string>("kpp")
                        .IsRequired()
                        .HasColumnType("VARCHAR(9)")
                        .HasColumnName("kpp");

                    b.Property<string>("sanctions")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("sanctions");

                    b.HasKey("debtor_card_id");

                    b.ToTable("Debtor_cards");
                });

            modelBuilder.Entity("web1c_backend.Models.Entities.En_event_record", b =>
                {
                    b.Property<int>("event_record_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("event_record_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("event_record_id"));

                    b.Property<int>("base_document_id")
                        .HasColumnType("INT")
                        .HasColumnName("base_document_id");

                    b.Property<int>("business_id")
                        .HasColumnType("INT")
                        .HasColumnName("business_id");

                    b.Property<int>("company_id")
                        .HasColumnType("INT")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("creation_date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("creation_date");

                    b.Property<int>("debtor_card_id")
                        .HasColumnType("INT")
                        .HasColumnName("debtor_card_id");

                    b.Property<string>("event_comment")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("event_comment");

                    b.Property<string>("event_description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(1000)")
                        .HasColumnName("event_description");

                    b.Property<DateTime>("executon_date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("execution_date");

                    b.Property<DateTime>("exp_execution_date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("exp_execution_date");

                    b.Property<string>("responsible_user")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("responsible_user");

                    b.Property<DateTime>("send_date")
                        .HasColumnType("DATETIME")
                        .HasColumnName("send_date");

                    b.Property<int>("work_type_id")
                        .HasColumnType("INT")
                        .HasColumnName("work_type_id");

                    b.HasKey("event_record_id");

                    b.ToTable("Event_records");
                });

            modelBuilder.Entity("web1c_backend.Models.Entities.En_session", b =>
                {
                    b.Property<long>("En_session_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("En_session_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("En_session_id"));

                    b.Property<long?>("En_user_id")
                        .HasColumnType("bigint")
                        .HasColumnName("En_user_id");

                    b.HasKey("En_session_id");

                    b.ToTable("En_session");
                });

            modelBuilder.Entity("web1c_backend.Models.Entities.En_user", b =>
                {
                    b.Property<long>("En_user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("En_user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("En_user_id"));

                    b.Property<string>("En_user_login")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("En_user_login");

                    b.Property<byte[]>("En_user_password")
                        .IsRequired()
                        .HasColumnType("varbinary(100)")
                        .HasColumnName("En_user_password");

                    b.HasKey("En_user_id");

                    b.ToTable("En_user");
                });
#pragma warning restore 612, 618
        }
    }
}

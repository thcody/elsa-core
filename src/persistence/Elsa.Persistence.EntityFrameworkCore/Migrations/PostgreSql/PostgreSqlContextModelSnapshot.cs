﻿// <auto-generated />
using System;
using Elsa.Persistence.EntityFrameworkCore.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Elsa.Persistence.EntityFrameworkCore.Migrations.PostgreSql
{
    [DbContext(typeof(PostgreSqlContext))]
    partial class PostgreSqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<int>("Left")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<int>("Top")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ActivityDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("text");

                    b.Property<string>("Output")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("ActivityInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ActivityId")
                        .HasColumnType("text");

                    b.Property<string>("ActivityType")
                        .HasColumnType("text");

                    b.Property<int?>("WorkflowInstanceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowInstanceId");

                    b.ToTable("BlockingActivities");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DestinationActivityId")
                        .HasColumnType("text");

                    b.Property<string>("Outcome")
                        .HasColumnType("text");

                    b.Property<string>("SourceActivityId")
                        .HasColumnType("text");

                    b.Property<int?>("WorkflowDefinitionVersionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorkflowDefinitionVersionId");

                    b.ToTable("ConnectionDefinitions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DefinitionId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSingleton")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Variables")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.Property<string>("VersionId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("WorkflowDefinitionVersions");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("AbortedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("DefinitionId")
                        .HasColumnType("text");

                    b.Property<string>("ExecutionLog")
                        .HasColumnType("text");

                    b.Property<string>("Fault")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FaultedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Input")
                        .HasColumnType("text");

                    b.Property<string>("InstanceId")
                        .HasColumnType("text");

                    b.Property<string>("Scope")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("WorkflowInstances");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowDefinitionVersionId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ActivityInstanceEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("Activities")
                        .HasForeignKey("WorkflowInstanceId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.BlockingActivityEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowInstanceEntity", "WorkflowInstance")
                        .WithMany("BlockingActivities")
                        .HasForeignKey("WorkflowInstanceId");
                });

            modelBuilder.Entity("Elsa.Persistence.EntityFrameworkCore.Entities.ConnectionDefinitionEntity", b =>
                {
                    b.HasOne("Elsa.Persistence.EntityFrameworkCore.Entities.WorkflowDefinitionVersionEntity", "WorkflowDefinitionVersion")
                        .WithMany("Connections")
                        .HasForeignKey("WorkflowDefinitionVersionId");
                });
#pragma warning restore 612, 618
        }
    }
}

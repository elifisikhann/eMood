﻿// <auto-generated />
using System;
using Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace e_Mood.Migrations
{
    [DbContext(typeof(eMoodContext))]
    [Migration("20200229173113_InitialMigr")]
    partial class InitialMigr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Entity.ActivityAttribute", b =>
                {
                    b.Property<int>("ActivityAttributeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActivityForeignKey")
                        .HasColumnType("int");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<string>("AttributeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmotionForeignKey")
                        .HasColumnType("int");

                    b.Property<int?>("EmotionId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InInside")
                        .HasColumnType("bit");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("ActivityAttributeID");

                    b.HasIndex("ActivityForeignKey");

                    b.HasIndex("ActivityId");

                    b.HasIndex("EmotionForeignKey");

                    b.HasIndex("EmotionId");

                    b.ToTable("ActivityAttributes");
                });

            modelBuilder.Entity("Entity.ActivityEmotion", b =>
                {
                    b.Property<int>("ActivityID")
                        .HasColumnType("int");

                    b.Property<int>("EmotionID")
                        .HasColumnType("int");

                    b.HasKey("ActivityID", "EmotionID");

                    b.HasIndex("EmotionID");

                    b.ToTable("ActivityEmotions");
                });

            modelBuilder.Entity("Entity.Emotion", b =>
                {
                    b.Property<int>("EmotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmotionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmotionId");

                    b.ToTable("Emotions");
                });

            modelBuilder.Entity("Entity.ActivityAttribute", b =>
                {
                    b.HasOne("Entity.Activity", null)
                        .WithMany()
                        .HasForeignKey("ActivityForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Activity", "Activity")
                        .WithMany("ActivityAttributes")
                        .HasForeignKey("ActivityId");

                    b.HasOne("Entity.Emotion", null)
                        .WithMany()
                        .HasForeignKey("EmotionForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Emotion", "Emotion")
                        .WithMany("ActivityAttributes")
                        .HasForeignKey("EmotionId");
                });

            modelBuilder.Entity("Entity.ActivityEmotion", b =>
                {
                    b.HasOne("Entity.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Emotion", "Emotion")
                        .WithMany()
                        .HasForeignKey("EmotionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

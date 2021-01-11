﻿// <auto-generated />
using System;
using GarbageCan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GarbageCan.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210111164247_ConsistentTableNames")]
    partial class ConsistentTableNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GarbageCan.Data.Entities.Boosters.EntityActiveBooster", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime");

                    b.Property<float>("multipler")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("xpActiveBoosters");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Boosters.EntityAvailableSlot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("channelId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("xpAvailableSlots");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Boosters.EntityQueuedBooster", b =>
                {
                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.Property<long>("durationInSeconds")
                        .HasColumnType("bigint");

                    b.Property<float>("multiplier")
                        .HasColumnType("float");

                    b.HasKey("position");

                    b.ToTable("xpQueuedBoosters");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Boosters.EntityUserBooster", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("durationInSeconds")
                        .HasColumnType("bigint");

                    b.Property<float>("multiplier")
                        .HasColumnType("float");

                    b.Property<ulong>("userId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("xpUserBoosters");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Moderation.EntityActionLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("comments")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("issuedDate")
                        .HasColumnType("datetime");

                    b.Property<ulong>("mId")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("punishmentLevel")
                        .HasColumnType("int");

                    b.Property<ulong>("uId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("moderationActionLogs");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Moderation.EntityActiveChannelRestrict", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("channelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime");

                    b.Property<ulong>("uId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("moderationActiveChannelRestricts");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Moderation.EntityActiveMute", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("datetime");

                    b.Property<ulong>("uId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("moderationActiveMutes");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Roles.EntityLevelRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("lvl")
                        .HasColumnType("int");

                    b.Property<bool>("remain")
                        .HasColumnType("tinyint(1)");

                    b.Property<ulong>("roleId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("xpLevelRoles");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Roles.EntityReactionRole", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("channelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("emoteId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("messageId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("roleId")
                        .HasColumnType("bigint unsigned");

                    b.HasKey("id");

                    b.ToTable("reactionRoles");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.XP.EntityExcludedChannel", b =>
                {
                    b.Property<ulong>("channelId")
                        .HasColumnType("bigint unsigned");

                    b.ToTable("xpExcludedChannels");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.XP.EntityUser", b =>
                {
                    b.Property<ulong>("id")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("lvl")
                        .HasColumnType("int");

                    b.Property<double>("xp")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("xpUsers");
                });

            modelBuilder.Entity("GarbageCan.Data.Entities.Boosters.EntityActiveBooster", b =>
                {
                    b.HasOne("GarbageCan.Data.Entities.Boosters.EntityAvailableSlot", "slot")
                        .WithMany()
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("slot");
                });
#pragma warning restore 612, 618
        }
    }
}

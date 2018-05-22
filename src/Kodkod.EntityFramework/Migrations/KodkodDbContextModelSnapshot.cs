﻿// <auto-generated />
using System;
using Kodkod.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kodkod.EntityFramework.Migrations
{
    [DbContext(typeof(KodkodDbContext))]
    partial class KodkodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role");

                    b.HasData(
                        new { Id = new Guid("faa507c8-12fe-4363-a6e8-1fa5cd8e7c21"), ConcurrencyStamp = "65cc7fdb-bb5d-4b10-b469-b968694507ee", Name = "Admin", NormalizedName = "ADMIN" }
                    );
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User");

                    b.HasData(
                        new { Id = new Guid("81055e15-6a0c-45ca-bd80-3005ee7aaccf"), AccessFailedCount = 5, ConcurrencyStamp = "8ef735e4-f398-4ea3-838c-30b3ce5f0174", Email = "admin@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "ADMIN@MAIL.COM", NormalizedUserName = "ADMIN", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = new Guid("3d74697b-d4ee-4e99-a610-cfce27dfd733"), AccessFailedCount = 5, ConcurrencyStamp = "e43536a3-245e-4f98-be3b-6c1ef7410616", Email = "testuser@mail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "TESTUSER@MAIL.COM", NormalizedUserName = "TESTUSER", PasswordHash = "AM4OLBpptxBYmM79lGOX9egzZk3vIQU3d/gFCJzaBjAPXzYIK3tQ2N7X4fcrHtElTw==", PhoneNumberConfirmed = false, TwoFactorEnabled = false, UserName = "testuser" }
                    );
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<Guid>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new { UserId = new Guid("81055e15-6a0c-45ca-bd80-3005ee7aaccf"), RoleId = new Guid("faa507c8-12fe-4363-a6e8-1fa5cd8e7c21") }
                    );
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Kodkod.Core.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new { Id = new Guid("37cd881c-0ba4-49a3-899c-9cc3282d0833"), DisplayName = "Api user", Name = "ApiUser" }
                    );
                });

            modelBuilder.Entity("Kodkod.Core.Entities.RolePermission", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("PermissionId");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new { RoleId = new Guid("faa507c8-12fe-4363-a6e8-1fa5cd8e7c21"), PermissionId = new Guid("37cd881c-0ba4-49a3-899c-9cc3282d0833") }
                    );
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationRoleClaim", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserClaim", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserLogin", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserRole", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kodkod.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodkod.Core.Entities.ApplicationUserToken", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodkod.Core.Entities.RolePermission", b =>
                {
                    b.HasOne("Kodkod.Core.Entities.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kodkod.Core.Entities.ApplicationRole", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

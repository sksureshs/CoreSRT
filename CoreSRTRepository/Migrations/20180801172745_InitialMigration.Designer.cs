﻿// <auto-generated />
using System;
using CoreSRTRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreSRTRepository.Migrations
{
    [DbContext(typeof(BillingContext))]
    [Migration("20180801172745_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoreSRTModels.AccountDetails", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BankName")
                        .IsRequired();

                    b.Property<string>("Branch")
                        .IsRequired();

                    b.Property<string>("IFSCCode")
                        .IsRequired();

                    b.HasKey("AccountNo");

                    b.ToTable("AccountDetails");
                });

            modelBuilder.Entity("CoreSRTModels.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<double>("OutStandingAmount");

                    b.Property<int>("ShopIdCustomerId");

                    b.Property<double>("TotalPrice");

                    b.Property<int>("TotalQuantity");

                    b.HasKey("BillId");

                    b.HasIndex("ShopIdCustomerId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CoreSRTModels.BillingItem", b =>
                {
                    b.Property<int>("BillingItmeId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CGST");

                    b.Property<int>("ItemId");

                    b.Property<double>("OriginalPrice");

                    b.Property<int>("Quantity");

                    b.Property<double>("SGCT");

                    b.Property<double>("SellingPrice");

                    b.Property<double>("TotalPrice");

                    b.HasKey("BillingItmeId");

                    b.HasIndex("ItemId");

                    b.ToTable("BillingItems");
                });

            modelBuilder.Entity("CoreSRTModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("EmailId");

                    b.Property<string>("GSTNo")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Type");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CoreSRTModels.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CGST");

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<double>("Rate");

                    b.Property<double>("SGST");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CoreSRTModels.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Details");

                    b.Property<int>("PayemntType");

                    b.HasKey("PaymentId");

                    b.HasIndex("BillId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("CoreSRTModels.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountDetailsAccountNo");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("ContactNo")
                        .IsRequired();

                    b.Property<string>("EmailId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ProducerId");

                    b.HasIndex("AccountDetailsAccountNo");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("CoreSRTModels.Bill", b =>
                {
                    b.HasOne("CoreSRTModels.Customer", "ShopId")
                        .WithMany()
                        .HasForeignKey("ShopIdCustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreSRTModels.BillingItem", b =>
                {
                    b.HasOne("CoreSRTModels.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreSRTModels.Payment", b =>
                {
                    b.HasOne("CoreSRTModels.Bill")
                        .WithMany("Payments")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreSRTModels.Producer", b =>
                {
                    b.HasOne("CoreSRTModels.AccountDetails", "AccountDetails")
                        .WithMany()
                        .HasForeignKey("AccountDetailsAccountNo")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
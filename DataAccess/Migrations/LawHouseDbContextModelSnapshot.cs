﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(LawHouseDbContext))]
    partial class LawHouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityModels.Case", b =>
                {
                    b.Property<int>("CaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseID"));

                    b.Property<int>("CaseTypeID")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("EstimatedHours")
                        .HasColumnType("real");

                    b.Property<int>("LawyerID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("CaseID");

                    b.HasIndex("CaseTypeID");

                    b.HasIndex("ClientID");

                    b.HasIndex("LawyerID");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("EntityModels.CaseService", b =>
                {
                    b.Property<int>("CaseServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseServiceID"));

                    b.Property<int>("CaseID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("HoursWorked")
                        .HasColumnType("real");

                    b.Property<int>("LawyerID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("Units")
                        .HasColumnType("real");

                    b.HasKey("CaseServiceID");

                    b.HasIndex("CaseID");

                    b.HasIndex("LawyerID");

                    b.HasIndex("ServiceID");

                    b.ToTable("CaseServices", t =>
                        {
                            t.HasTrigger("Trigger");
                        });

                    b.HasAnnotation("SqlServer:UseSqlOutputClause", false);
                });

            modelBuilder.Entity("EntityModels.CaseType", b =>
                {
                    b.Property<int>("CaseTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseTypeID"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaseTypeID");

                    b.ToTable("CaseTypes");
                });

            modelBuilder.Entity("EntityModels.ClientFormDocument", b =>
                {
                    b.Property<int>("ClientFormDocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientFormDocumentID"));

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("FormDocumentID")
                        .HasColumnType("int");

                    b.HasKey("ClientFormDocumentID");

                    b.HasIndex("ClientID");

                    b.HasIndex("FormDocumentID");

                    b.ToTable("ClientFormDocuments");
                });

            modelBuilder.Entity("EntityModels.ClientSubscription", b =>
                {
                    b.Property<int>("ClientSubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientSubscriptionID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("PaidPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubscriptionID")
                        .HasColumnType("int");

                    b.HasKey("ClientSubscriptionID");

                    b.HasIndex("ClientID");

                    b.HasIndex("SubscriptionID");

                    b.ToTable("ClientSubscriptions");
                });

            modelBuilder.Entity("EntityModels.FormDocument", b =>
                {
                    b.Property<int>("FormDocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormDocumentID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("FormDocumentID");

                    b.ToTable("FormDocuments");
                });

            modelBuilder.Entity("EntityModels.LawyerSpeciality", b =>
                {
                    b.Property<int>("LawyerID")
                        .HasColumnType("int");

                    b.Property<int>("SpecialityID")
                        .HasColumnType("int");

                    b.HasKey("LawyerID", "SpecialityID");

                    b.HasIndex("SpecialityID");

                    b.ToTable("LawyerSpecialities");
                });

            modelBuilder.Entity("EntityModels.LawyerTitle", b =>
                {
                    b.Property<int>("LawyerTitleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LawyerTitleID"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LawyerTitleID");

                    b.ToTable("LawyerTitles");
                });

            modelBuilder.Entity("EntityModels.LoginDetails", b =>
                {
                    b.Property<int>("LoginDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginDetailsID"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginDetailsID");

                    b.ToTable("LoginDetails");
                });

            modelBuilder.Entity("EntityModels.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"));

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoginDetailsID")
                        .HasColumnType("int");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.HasKey("PersonID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LoginDetailsID")
                        .IsUnique();

                    b.ToTable("Persons");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EntityModels.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhoneID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("PhoneID");

                    b.HasIndex("ClientID");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("EntityModels.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ServicePriceTypeID")
                        .HasColumnType("int");

                    b.HasKey("ServiceID");

                    b.HasIndex("ServicePriceTypeID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EntityModels.ServiceEntry", b =>
                {
                    b.Property<int>("ServiceEntryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceEntryID"));

                    b.Property<int>("CaseServiceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("HoursWorked")
                        .HasColumnType("real");

                    b.HasKey("ServiceEntryID");

                    b.HasIndex("CaseServiceID");

                    b.ToTable("ServiceEntries");
                });

            modelBuilder.Entity("EntityModels.ServicePriceType", b =>
                {
                    b.Property<int>("ServicePriceTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicePriceTypeID"));

                    b.Property<string>("PriceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicePriceTypeID");

                    b.ToTable("ServicePriceTypes");
                });

            modelBuilder.Entity("EntityModels.Speciality", b =>
                {
                    b.Property<int>("SpecialityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialityID"));

                    b.Property<string>("SpecialityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialityID");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("EntityModels.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionID"));

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubscriptionID");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("EntityModels.Client", b =>
                {
                    b.HasBaseType("EntityModels.Person");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("EntityModels.Employee", b =>
                {
                    b.HasBaseType("EntityModels.Person");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LawyerTitleID")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasIndex("LawyerTitleID");

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EntityModels.Lawyer", b =>
                {
                    b.HasBaseType("EntityModels.Employee");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.ToTable("Lawyers");
                });

            modelBuilder.Entity("EntityModels.Secretary", b =>
                {
                    b.HasBaseType("EntityModels.Employee");

                    b.ToTable("Secretaries");
                });

            modelBuilder.Entity("EntityModels.Case", b =>
                {
                    b.HasOne("EntityModels.CaseType", "CaseType")
                        .WithMany("Cases")
                        .HasForeignKey("CaseTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Client", "Client")
                        .WithMany("Cases")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EntityModels.Lawyer", "Lawyer")
                        .WithMany("Cases")
                        .HasForeignKey("LawyerID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CaseType");

                    b.Navigation("Client");

                    b.Navigation("Lawyer");
                });

            modelBuilder.Entity("EntityModels.CaseService", b =>
                {
                    b.HasOne("EntityModels.Case", "Case")
                        .WithMany("CaseServices")
                        .HasForeignKey("CaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Lawyer", "Lawyer")
                        .WithMany("CaseServices")
                        .HasForeignKey("LawyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Service", "Service")
                        .WithMany("CaseServices")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Lawyer");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("EntityModels.ClientFormDocument", b =>
                {
                    b.HasOne("EntityModels.Client", "Client")
                        .WithMany("ClientForms")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.FormDocument", "FormDocument")
                        .WithMany("ClientFormDocuments")
                        .HasForeignKey("FormDocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("FormDocument");
                });

            modelBuilder.Entity("EntityModels.ClientSubscription", b =>
                {
                    b.HasOne("EntityModels.Client", "Client")
                        .WithMany("ClientSubscriptions")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Subscription", "Subscription")
                        .WithMany("ClientSubscriptions")
                        .HasForeignKey("SubscriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("EntityModels.LawyerSpeciality", b =>
                {
                    b.HasOne("EntityModels.Lawyer", "Lawyer")
                        .WithMany("LawyerSpecialities")
                        .HasForeignKey("LawyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Speciality", "Speciality")
                        .WithMany("LawyerSpecialities")
                        .HasForeignKey("SpecialityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lawyer");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("EntityModels.Person", b =>
                {
                    b.HasOne("EntityModels.LoginDetails", "LoginDetails")
                        .WithOne("Person")
                        .HasForeignKey("EntityModels.Person", "LoginDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoginDetails");
                });

            modelBuilder.Entity("EntityModels.Phone", b =>
                {
                    b.HasOne("EntityModels.Client", "Client")
                        .WithMany("Phones")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("EntityModels.Service", b =>
                {
                    b.HasOne("EntityModels.ServicePriceType", "ServicePriceType")
                        .WithMany("Services")
                        .HasForeignKey("ServicePriceTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServicePriceType");
                });

            modelBuilder.Entity("EntityModels.ServiceEntry", b =>
                {
                    b.HasOne("EntityModels.CaseService", "CaseService")
                        .WithMany("ServiceEntries")
                        .HasForeignKey("CaseServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaseService");
                });

            modelBuilder.Entity("EntityModels.Client", b =>
                {
                    b.HasOne("EntityModels.Person", null)
                        .WithOne()
                        .HasForeignKey("EntityModels.Client", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityModels.Employee", b =>
                {
                    b.HasOne("EntityModels.LawyerTitle", "LawyerTitle")
                        .WithMany("Employees")
                        .HasForeignKey("LawyerTitleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityModels.Person", null)
                        .WithOne()
                        .HasForeignKey("EntityModels.Employee", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LawyerTitle");
                });

            modelBuilder.Entity("EntityModels.Lawyer", b =>
                {
                    b.HasOne("EntityModels.Employee", null)
                        .WithOne()
                        .HasForeignKey("EntityModels.Lawyer", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityModels.Secretary", b =>
                {
                    b.HasOne("EntityModels.Employee", null)
                        .WithOne()
                        .HasForeignKey("EntityModels.Secretary", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityModels.Case", b =>
                {
                    b.Navigation("CaseServices");
                });

            modelBuilder.Entity("EntityModels.CaseService", b =>
                {
                    b.Navigation("ServiceEntries");
                });

            modelBuilder.Entity("EntityModels.CaseType", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("EntityModels.FormDocument", b =>
                {
                    b.Navigation("ClientFormDocuments");
                });

            modelBuilder.Entity("EntityModels.LawyerTitle", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EntityModels.LoginDetails", b =>
                {
                    b.Navigation("Person")
                        .IsRequired();
                });

            modelBuilder.Entity("EntityModels.Service", b =>
                {
                    b.Navigation("CaseServices");
                });

            modelBuilder.Entity("EntityModels.ServicePriceType", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("EntityModels.Speciality", b =>
                {
                    b.Navigation("LawyerSpecialities");
                });

            modelBuilder.Entity("EntityModels.Subscription", b =>
                {
                    b.Navigation("ClientSubscriptions");
                });

            modelBuilder.Entity("EntityModels.Client", b =>
                {
                    b.Navigation("Cases");

                    b.Navigation("ClientForms");

                    b.Navigation("ClientSubscriptions");

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("EntityModels.Lawyer", b =>
                {
                    b.Navigation("CaseServices");

                    b.Navigation("Cases");

                    b.Navigation("LawyerSpecialities");
                });
#pragma warning restore 612, 618
        }
    }
}

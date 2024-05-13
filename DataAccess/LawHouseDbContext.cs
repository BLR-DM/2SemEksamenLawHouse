using EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Security.Cryptography;
using System.Configuration;

namespace DataAccess
{
    public class LawHouseDbContext : DbContext
    {
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseService> CaseServices { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientFormDocument> ClientFormDocuments { get; set; }
        public DbSet<ClientSubscription> ClientSubscriptions { get; set; }
        public DbSet<FormDocument> FormDocuments { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<LawyerSpeciality> LawyerSpecialities { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LoginDetails> LoginDetails { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<CaseType> CaseTypes { get; set; }
        public DbSet<LawyerTitle> LawyerTitles { get; set; }
        public DbSet<ServicePriceType> ServicePriceTypes { get; set; }
        public DbSet<ServiceEntry> ServiceEntries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connstring fra App.Config
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Simply"].ToString()).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>()
                        .HasIndex(p => p.Email)
                        .IsUnique();
            modelBuilder.Entity<Employee>()
                        .HasIndex(e => e.PhoneNumber)
                        .IsUnique();
            modelBuilder.Entity<Phone>()
                        .HasIndex(p => p.PhoneNumber)
                        .IsUnique();

            // Configure DeleteBehavior
            modelBuilder.Entity<Case>()
                .HasOne(c => c.Lawyer)
                .WithMany(l => l.Cases)
                .HasForeignKey(c => c.LawyerID)
                .OnDelete(DeleteBehavior.Restrict); // Ændrer kaskadesletning til NO ACTION for Lawyers

            // Configure DeleteBehavior
            modelBuilder.Entity<Case>()
                .HasOne(c => c.Client)
                .WithMany(cl => cl.Cases)
                .HasForeignKey(c => c.ClientID)
                .OnDelete(DeleteBehavior.Restrict); // Ændrer kaskadesletning til NO ACTION for Clients


            modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.Entity<Employee>().UseTptMappingStrategy();

            ////discriminator til usertype paa user tabel
            //modelBuilder.Entity<User>()
            //    .HasDiscriminator<String>("UserType")
            //    .HasValue<Client>("Client")
            //    .HasValue<Lawyer>("Lawyer")
            //    .HasValue<Secretary>("Secretary");

            /////////

            modelBuilder.Entity<LawyerSpeciality>()
                .HasKey(c => new { c.LawyerID, c.SpecialityID });

            modelBuilder.Entity<LawyerSpeciality>()
                .HasOne(ls => ls.Lawyer)
                .WithMany(l => l.LawyerSpecialities)
                .HasForeignKey(ls => ls.LawyerID);

            modelBuilder.Entity<LawyerSpeciality>()
                .HasOne(ls => ls.Speciality)
                .WithMany(s => s.LawyerSpecialities)
                .HasForeignKey(ls => ls.SpecialityID);


            modelBuilder.Entity<CaseService>().ToTable(cs => cs.HasTrigger("Trigger"));
            //////////
            
            //modelBuilder.Entity<ClientFormular>()
            //    .HasOne(ls => ls.Client)
            //    .WithMany(l => l.ClientFormulars)
            //    .HasForeignKey(ls => ls.ClientID);

            //modelBuilder.Entity<ClientFormular>()
            //    .HasOne(ls => ls.Formular)
            //    .WithMany(s => s.ClientFormulars)
            //    .HasForeignKey(ls => ls.FormularID);

            ///////////

            //modelBuilder.Entity<CaseService>()
            //    .HasOne(ls => ls.Case)
            //    .WithMany(l => l.CaseServices)
            //    .HasForeignKey(ls => ls.CaseID);

            //modelBuilder.Entity<CaseService>()
            //    .HasOne(ls => ls.Service)
            //    .WithMany(s => s.CaseServices)
            //    .HasForeignKey(ls => ls.ServiceID);

        }
    }
}

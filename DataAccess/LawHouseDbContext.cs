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
            modelBuilder.Entity<Case>()
                .Property(c => c.CaseID)
                .UseIdentityColumn(10000, 1);
            modelBuilder.Entity<Person>()
                .Property(p => p.PersonID)
                .UseIdentityColumn(100, 1);

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

        }
    }
}

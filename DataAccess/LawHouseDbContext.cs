using EntityModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class LawHouseDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Formular> Formulars { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<PersonInfo> PersonInfos { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<LawyerSpeciality> LawyerSpeciality { get; set; }
        public DbSet<ClientFormular> ClientFormulars { get; set; }
        public DbSet<CaseService> CaseServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BILAL-KINALI;Database=LawHouseTest;Trusted_Connection=True;Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure foreign key relationship for Cases -> Lawyers
            modelBuilder.Entity<Case>()
                .HasOne(c => c.Lawyer)
                .WithMany(l => l.Cases)
                .HasForeignKey(c => c.LawyerID)
                .OnDelete(DeleteBehavior.Restrict); // Ændrer kaskadesletning til NO ACTION for Lawyers

            // Configure foreign key relationship for Cases -> Clients
            modelBuilder.Entity<Case>()
                .HasOne(c => c.Client)
                .WithMany(cl => cl.Cases)
                .HasForeignKey(c => c.ClientID)
                .OnDelete(DeleteBehavior.Restrict); // Ændrer kaskadesletning til NO ACTION for Clients

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

            /////////

            modelBuilder.Entity<ClientFormular>()
                .HasKey(c => new { c.ClientID, c.FormularID });

            modelBuilder.Entity<ClientFormular>()
                .HasOne(ls => ls.Client)
                .WithMany(l => l.ClientFormulars)
                .HasForeignKey(ls => ls.ClientID);

            modelBuilder.Entity<ClientFormular>()
                .HasOne(ls => ls.Formular)
                .WithMany(s => s.ClientFormulars)
                .HasForeignKey(ls => ls.FormularID);

            /////////

            modelBuilder.Entity<CaseService>()
                .HasKey(c => new { c.CaseID, c.ServiceID });

            modelBuilder.Entity<CaseService>()
                .HasOne(ls => ls.Case)
                .WithMany(l => l.CaseServices)
                .HasForeignKey(ls => ls.CaseID);

            modelBuilder.Entity<CaseService>()
                .HasOne(ls => ls.Service)
                .WithMany(s => s.CaseServices)
                .HasForeignKey(ls => ls.ServiceID);
        }
    }
}

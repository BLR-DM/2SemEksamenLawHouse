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
            optionsBuilder.UseSqlServer("Server=SKOV-PC;Database=LawHouseTest;Trusted_Connection=True;Encrypt=False;");
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



            modelBuilder.Entity<LawyerSpeciality>()
                .HasKey(c => new { c.LawyerID, c.SpecialityID });

            modelBuilder.Entity<Lawyer>()
                .HasMany(l => l.Specialities)
                .WithMany(s => s.Lawyers)
                .UsingEntity<LawyerSpeciality>(
                    j => j
                        .HasOne(ls => ls.Speciality)
                        .WithMany(),
                    j => j
                        .HasOne(ls => ls.Lawyer)
                        .WithMany()
                 );

            modelBuilder.Entity<ClientFormular>()
                .HasKey(c => new { c.ClientID, c.FormularID });

            modelBuilder.Entity<Client>()
                .HasMany(l => l.Formulars)
                .WithMany(s => s.Clients)
                .UsingEntity<ClientFormular>(
                    j => j
                        .HasOne(ls => ls.Formular)
                        .WithMany(),
                    j => j
                        .HasOne(ls => ls.Client)
                        .WithMany()
                 );

            modelBuilder.Entity<CaseService>()
                .HasKey(c => new { c.CaseID, c.ServiceID });

            modelBuilder.Entity<Case>()
                .HasMany(l => l.Services)
                .WithMany(s => s.Cases)
                .UsingEntity<CaseService>(
                    j => j
                        .HasOne(ls => ls.Service)
                        .WithMany(),
                    j => j
                        .HasOne(ls => ls.Case)
                        .WithMany()
                 );
        }
    }
}

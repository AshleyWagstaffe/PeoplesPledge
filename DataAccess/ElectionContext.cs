using Microsoft.EntityFrameworkCore;
using DatabaseModels;

namespace DataAccess
{
    public class ElectionContext : DbContext
    {
        public ElectionContext(DbContextOptions<ElectionContext> options) : base(options)
        {

        }

        public DbSet<Party> Parties { get; set; }

        public DbSet<Constituency> Constituencies { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Constituency>()
                .ToTable("Constituencies")
                .HasMany(c => c.Candidates)
                .WithOne(c => c.Constituency)
                .HasForeignKey(c => c.ConstituencyId);

            modelBuilder.Entity<Candidate>()
                .ToTable("Candidates");

            modelBuilder.Entity<Party>()
                .ToTable("Parties")
                .HasMany(p => p.Candidates)
                .WithOne(c => c.Party)
                .HasForeignKey(c => c.PartyId);
        }
    }
}

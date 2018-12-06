namespace cs_Final_part2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MissionContext : DbContext
    {
        public MissionContext()
            : base("name=FinalDB")
        {
        }

        public virtual DbSet<Astronaut> Astronauts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Crew> Crews { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Astronaut>()
                .HasMany(e => e.Crews)
                .WithRequired(e => e.Astronaut1)
                .HasForeignKey(e => e.Astronaut);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Astronauts)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.Nationality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mission>()
                .HasMany(e => e.Crews)
                .WithRequired(e => e.Mission1)
                .HasForeignKey(e => e.Mission);
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Periodic_Table_Elements.Models
{
    public partial class PeriodicTableDBContext : DbContext
    {
        public PeriodicTableDBContext()
            : base("name=PeriodicTableDBContext")
        {
        }

        public virtual DbSet<element> elements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<element>()
                .Property(e => e.atomic_mass)
                .HasPrecision(11, 8);
        }
    }
}

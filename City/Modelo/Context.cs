using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Modelo
{
    public class Context : DbContext
    {
        public Context() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Country>()
                .HasKey(_ => _.IdCountry);

            modelBuilder.Entity<State>()
                .HasKey(_ => _.IdState)
                .HasRequired(_ => _.Country);

            modelBuilder.Entity<City>()
                .HasKey(_ => _.IdCity)
                .HasRequired(_ => _.State).WithMany(_ => _.Cities)
                .HasForeignKey(_ => _.IdState);

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}

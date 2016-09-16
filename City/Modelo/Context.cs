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

            //Database.SetInitializer(new ContextInitializer());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

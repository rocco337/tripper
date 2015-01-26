using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tripper.Services.Entities.Entities;

namespace Tripper.Services.Core
{
    [DbConfigurationType("DataContext")]
    public class DataContext : DbContext
    {
        public DataContext() : base("TripperDataContext")
        {

        }

        public DbSet<TripEntity> Trips { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

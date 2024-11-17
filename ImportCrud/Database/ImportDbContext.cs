using ImportCrud.Models.Imports;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ImportCrud.Database
{
    public class ImportDbContext : DbContext
    {
        public ImportDbContext() : base("DbConnection")
        {
        }

        public DbSet<Import> Import { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
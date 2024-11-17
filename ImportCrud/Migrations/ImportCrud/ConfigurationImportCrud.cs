namespace ImportCrud.Migrations.ImportCrud
{
    using global::ImportCrud.Database;
    using global::ImportCrud.Database.Seed;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationImportCrud : DbMigrationsConfiguration<ImportDbContext>
    {
        public ConfigurationImportCrud()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ImportCrud";
        }

        protected override void Seed(ImportDbContext context)
        {
            new ImportInitializer().Seed(context);
        }
    }
}

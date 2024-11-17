using ImportCrud.Models;
using ImportCrud.Models.Imports;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace ImportCrud.Database.Seed
{
    public class ImportInitializer
    {
        public void Seed(ImportDbContext context)
        {
            var imports = new List<Import>
            {
                new Import
                {
                    ID = 1,
                    Code = "IMP2024A001",
                    Cnpj = "12.345.678/0001-90",
                    Origin = "Shanghai, China",
                    Destination = "New York, USA",
                    TotalValue = 50000.75m,
                    Active = true,
                    ProcessDate = new DateTime(2024, 11, 15),
                    EstimatedTimeDeparture = new DateTime(2024, 11, 18, 14, 30, 0),
                    EstimatedTimeArrival = new DateTime(2024, 11, 25, 9, 0, 0)
                },
                new Import
                {
                    ID = 2,
                    Code = "IMP2024A002",
                    Cnpj = "98.765.432/0001-09",
                    Origin = "Hamburg, Germany",
                    Destination = "Rio de Janeiro, Brazil",
                    TotalValue = 125000.00m,
                    Active = false,
                    ProcessDate = new DateTime(2024, 11, 10),
                    EstimatedTimeDeparture = new DateTime(2024, 11, 12, 10, 0, 0),
                    EstimatedTimeArrival = new DateTime(2024, 11, 22, 16, 0, 0)
                }
            };

            imports.ForEach(x => context.Import.AddOrUpdate(x));
            context.SaveChanges();
        }
    }
}
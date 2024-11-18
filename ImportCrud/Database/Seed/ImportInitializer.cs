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
                    Id = 1,
                    Code = "IMP2024A001",
                    Company = "Shanghai Export Co., Ltd.",
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
                    Id = 2,
                    Code = "IMP2024A002",
                    Company = "Hamburg Logistics GmbH",
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
namespace ImportCrud.Migrations.ImportCrud
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Import",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Cnpj = c.String(),
                        Origin = c.String(),
                        Destination = c.String(),
                        TotalValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        ProcessDate = c.DateTime(nullable: false),
                        EstimatedTimeDeparture = c.DateTime(nullable: false),
                        EstimatedTimeArrival = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Import");
        }
    }
}

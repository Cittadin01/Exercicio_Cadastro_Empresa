namespace ImportCrud.Migrations.ImportCrud
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Cnpj_Company : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Import", "Company", c => c.String());
            DropColumn("dbo.Import", "Cnpj");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Import", "Cnpj", c => c.String());
            DropColumn("dbo.Import", "Company");
        }
    }
}

namespace CompaniesRelations.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreatedTableCompanies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                {
                    CompanyId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Earnings = c.Int(nullable: false),
                    Company_CompanyId = c.Int(),
                })
                .PrimaryKey(t => t.CompanyId)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId)
                .Index(t => t.Company_CompanyId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Company_CompanyId", "dbo.Companies");
            DropIndex("dbo.Companies", new[] { "Company_CompanyId" });
            DropTable("dbo.Companies");
        }
    }
}

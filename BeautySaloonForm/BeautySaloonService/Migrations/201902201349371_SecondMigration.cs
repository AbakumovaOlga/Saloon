namespace BeautySaloonService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeProcedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameType = c.String(nullable: false),
                        ProcedureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Procedures", t => t.ProcedureId, cascadeDelete: true)
                .Index(t => t.ProcedureId);
            
            AddColumn("dbo.Procedures", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Procedures", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Procedures", "Type", c => c.String(nullable: false));
            DropForeignKey("dbo.TypeProcedures", "ProcedureId", "dbo.Procedures");
            DropIndex("dbo.TypeProcedures", new[] { "ProcedureId" });
            DropColumn("dbo.Procedures", "Name");
            DropTable("dbo.TypeProcedures");
        }
    }
}

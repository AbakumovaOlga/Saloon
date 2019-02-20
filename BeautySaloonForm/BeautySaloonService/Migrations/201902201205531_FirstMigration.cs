namespace BeautySaloonService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false),
                        PassportNumber = c.String(nullable: false),
                        ContractId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Summa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpensesSumma = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceType = c.String(nullable: false),
                        ContractId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Masters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false),
                        ContractId = c.Int(nullable: false),
                        CommissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Commissions", t => t.CommissionId, cascadeDelete: true)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId)
                .Index(t => t.CommissionId);
            
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Procedures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        ContractId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserRole = c.String(nullable: false),
                        ContractId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .Index(t => t.ContractId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Procedures", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Masters", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Masters", "CommissionId", "dbo.Commissions");
            DropForeignKey("dbo.Directories", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Clients", "ContractId", "dbo.Contracts");
            DropIndex("dbo.Users", new[] { "ContractId" });
            DropIndex("dbo.Procedures", new[] { "ContractId" });
            DropIndex("dbo.Masters", new[] { "CommissionId" });
            DropIndex("dbo.Masters", new[] { "ContractId" });
            DropIndex("dbo.Directories", new[] { "ContractId" });
            DropIndex("dbo.Clients", new[] { "ContractId" });
            DropTable("dbo.Users");
            DropTable("dbo.Procedures");
            DropTable("dbo.Commissions");
            DropTable("dbo.Masters");
            DropTable("dbo.Directories");
            DropTable("dbo.Contracts");
            DropTable("dbo.Clients");
        }
    }
}

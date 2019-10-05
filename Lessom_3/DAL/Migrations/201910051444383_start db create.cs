namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startdbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imgs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imgs");
        }
    }
}

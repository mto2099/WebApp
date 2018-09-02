namespace Web_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appcontext10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libraries",
                c => new
                    {
                        LibID = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Description = c.String(),
                        Rating = c.String(),
                        Status = c.String(),
                        ISBN = c.String(),
                        reviews = c.String(),
                    })
                .PrimaryKey(t => t.LibID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libraries");
        }
    }
}

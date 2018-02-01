namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Genreid = c.Byte(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        Genres_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genres_id, cascadeDelete: true)
                .Index(t => t.Genres_id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}

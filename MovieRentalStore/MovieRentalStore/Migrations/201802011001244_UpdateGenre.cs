namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genres_id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_id" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Movies", "Genres_id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Genres", "id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "id");
            CreateIndex("dbo.Movies", "Genres_id");
            AddForeignKey("dbo.Movies", "Genres_id", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_id" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "Genres_id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "id");
            CreateIndex("dbo.Movies", "Genres_id");
            AddForeignKey("dbo.Movies", "Genres_id", "dbo.Genres", "id", cascadeDelete: true);
        }
    }
}

namespace MovieRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonth = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "MembershipTypeid", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeid");
            AddForeignKey("dbo.Customers", "MembershipTypeid", "dbo.MembershipTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeid", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeid" });
            DropColumn("dbo.Customers", "MembershipTypeid");
            DropTable("dbo.MembershipTypes");
        }
    }
}

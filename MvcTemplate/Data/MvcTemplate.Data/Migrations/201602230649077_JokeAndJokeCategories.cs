namespace MvcTemplate.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class JokeAndJokeCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JokeCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.IsDeleted);
            
            CreateTable(
                "dbo.Jokes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        CategoryId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JokeCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jokes", "CategoryId", "dbo.JokeCategories");
            DropIndex("dbo.Jokes", new[] { "IsDeleted" });
            DropIndex("dbo.Jokes", new[] { "CategoryId" });
            DropIndex("dbo.JokeCategories", new[] { "IsDeleted" });
            DropTable("dbo.Jokes");
            DropTable("dbo.JokeCategories");
        }
    }
}
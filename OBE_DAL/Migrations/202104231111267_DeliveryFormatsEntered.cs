namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class DeliveryFormatsEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[DeliveryFormats] ([Name]) VALUES ('Theory')
INSERT INTO [dbo].[DeliveryFormats] ([Name]) VALUES ('Theory + Lab')
");
        }
        
        public override void Down()
        {
        }
    }
}

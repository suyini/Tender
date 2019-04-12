namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eleve : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Scheme", "年级", c => c.Int(nullable: false));
            AlterColumn("dbo.Student", "年级", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "年级", c => c.String());
            AlterColumn("dbo.Scheme", "年级", c => c.String());
        }
    }
}

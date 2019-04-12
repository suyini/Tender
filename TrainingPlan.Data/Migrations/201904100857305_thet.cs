namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "类别", c => c.String());
            AlterColumn("dbo.Course", "必选", c => c.String());
            AlterColumn("dbo.GCourse", "类别", c => c.String());
            AlterColumn("dbo.PEandEn", "类别", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PEandEn", "类别", c => c.Int(nullable: false));
            AlterColumn("dbo.GCourse", "类别", c => c.Int(nullable: false));
            AlterColumn("dbo.Course", "必选", c => c.Int(nullable: false));
            AlterColumn("dbo.Course", "类别", c => c.Int(nullable: false));
        }
    }
}

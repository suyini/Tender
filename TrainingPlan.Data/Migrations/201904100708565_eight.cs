namespace TrainingPlan.Data
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eight : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GCourse", "课程名称", c => c.String());
            AlterColumn("dbo.PEandEn", "课程名称", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PEandEn", "课程名称", c => c.Int(nullable: false));
            AlterColumn("dbo.GCourse", "课程名称", c => c.Int(nullable: false));
        }
    }
}

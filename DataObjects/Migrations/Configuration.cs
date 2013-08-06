namespace DataObjects.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DataObjects.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentManagerEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentManagerEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Students.AddOrUpdate(
              p => p.StudentName,
              new EntityStudent { StudentName = "Jhon" },
              new EntityStudent { StudentName = "Pop" },
              new EntityStudent { StudentName = "Lee" }
            );
            
        }
    }
}

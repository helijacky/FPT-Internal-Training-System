namespace test9.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using test9.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<test9.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "test9.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
          
        }

       

    }
}

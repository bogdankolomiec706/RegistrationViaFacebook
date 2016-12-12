namespace RadaCode.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RadaCode.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "RadaCode.Models.ApplicationDbContext";
        }

        protected override void Seed(RadaCode.Models.ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (context.Users.Count() == 0)
            {
                var mainAdmin = new ApplicationUser { Name = "Main admin", Email = "mainAdmin@gmail.com" };// bogdankolomiec@gmail.com
                mainAdmin.UserName = mainAdmin.Email;
                string password = "mainAdmin";
                var result = userManager.Create(mainAdmin, password);
            }
            base.Seed(context);
        }
    }
}

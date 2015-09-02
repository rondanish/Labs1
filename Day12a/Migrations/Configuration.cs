namespace Day12a.Migrations
{
    using Day12a.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<Day12a.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Day12a.Models.ApplicationDbContext";
        }

        //protected override void Seed(ApplicationDbContext context)
        //{
        //    var userStore = new UserStore<ApplicationUser>(context);
        //    var userManager = new ApplicationUserManager(userStore);
        //    var roleStore = new RoleStore<IdentityRole>(context);
        //    var roleManager = new ApplicationRoleManager(roleStore);

        //    // Ensure Admin role
        //    if (!roleManager.RoleExists("Admin"))
        //    {
        //        roleManager.Create(new IdentityRole("Admin"));
        //    }


        //    // Ensure Stephen
        //    var user = userManager.FindByName("rondanish@charter.net");
        //    if (user == null)
        //    {
        //        user = new ApplicationUser
        //        {
        //            UserName = "rondanish@charter.net",
        //            Email = "rondanish@charter.net"
        //        };
        //        userManager.Create(user, "Secret123!");
        //    }

        //    // Make Stephen Admin
        //    var rolesForUser = userManager.GetRoles(user.Id);
        //    if (!rolesForUser.Contains("Admin"))
        //    {
        //        userManager.AddToRole(user.Id, "Admin");
        //    }

        //}
        protected override void Seed(ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);

            // Ensure Stephen
            var user = userManager.FindByName("xondanish@charter.net");
            if (user == null)
            {
                // create user
                user = new ApplicationUser
                {
                    UserName = "rondanish@charter.net",
                    Email = "rondanish@charter.net"
                };
                userManager.Create(user, "Secret123!");

                // add claims
                userManager.AddClaim(user.Id, new Claim("CanEditProducts", "true"));
                userManager.AddClaim(user.Id, new Claim(ClaimTypes.DateOfBirth, "12/25/1966"));
            }
        }


    }
}

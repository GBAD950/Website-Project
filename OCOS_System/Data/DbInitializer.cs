using OCOS_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OCOS_System.Data
{
    public class DbInitializer
    {
        private static void SeedUsers(ApplicationDbContext dbcontext)
        {
            var Users = dbcontext.Set<ApplicationUser>();

            if (Users.Any())
            {

                return;
            }

            for (int i = 0; i < 50; i++)
            {

                Users.Add(new ApplicationUser
                {
                    Email = $"User{1}@email.com",
                    // Role = "User",
                    Password =$"Password{i}!",

                });


            }
            Users.Add(new ApplicationUser
            {
                Email = $"Dev@email.com",
                // Role = "Developer",
                Password = $"Password1!",

            });
            dbcontext.SaveChanges();
        }

    }
}


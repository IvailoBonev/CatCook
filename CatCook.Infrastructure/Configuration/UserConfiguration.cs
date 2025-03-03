using CatCook.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                FirstName = "Guest",
                LastName = "User",
                City = "Sofia",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ProfileName = "Guest"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "guest1000");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                UserName = "ivan.georgiev@example.com",
                NormalizedUserName = "ivan.georgiev@example.com",
                Email = "ivan.georgiev@example.com",
                NormalizedEmail = "ivan.georgiev@example.com",
                FirstName = "Ivan",
                LastName = "Georgiev",
                City = "Burgas",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ProfileName = "Ivan_G"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "ivan1000");

            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "bb7a3df5-42fc-4458-be02-ebc18a9ca65c",
                UserName = "admin@example.com",
                NormalizedUserName = "admin@example.com",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                FirstName = "The",
                LastName = "Admin",
                City = "Unknown",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                ProfileName = "Admin"
            };

            user.PasswordHash =
                hasher.HashPassword(user, "admin1000");

            users.Add(user);

            return users;
        }
    }
}

using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Infrastructure.Configuration
{
    public class ForumConfiguration : IEntityTypeConfiguration<Forum>
    {
        public void Configure(EntityTypeBuilder<Forum> builder)
        {
            builder.HasData(CreateForums());
        }

        private List<Forum> CreateForums()
        {
            var forums = new List<Forum>()
            {
                new Forum()
                {
                    Id = 1,
                    Title = "Need Help Perfecting My Caesar Salad Dressing!",
                    Text = "Hi everyone! I'm trying to make a classic Caesar salad at home, but I’m struggling with the dressing. My main issue is getting the right balance of flavors—it’s either too tangy or too mild. I’m using anchovies, garlic, Dijon mustard, olive oil, lemon juice, and Parmesan, but something feels off. Should I adjust the ratios, or am I missing a key ingredient? Also, any tips for getting the texture just right? Thanks in advance!",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    DateAdded = DateTime.Now,
                    IsDeleted = false
                },
                new Forum()
                {
                    Id = 2,
                    Title = "Help Needed with Cheesecake Recipe!",
                    Text = "Hey yall! I’m trying to make a classic cheesecake, but I’m running into a few issues. My main problem is getting the texture right—it’s either too dense or ends up cracking on top. I’m using cream cheese, eggs, sugar, and a graham cracker crust. Should I adjust baking time or temperature? Also, do I need to use a water bath, or is there another trick to keep it smooth? Any advice would be greatly appreciated. Thanks!",
                    UserId = "36998a40-6007-4cea-ac6e-c191880fa9e8",
                    DateAdded = DateTime.Now,
                    IsDeleted = false
                }
            };

            return forums;
        }
    }
}

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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(CreateComments());
        }

        private List<Comment> CreateComments()
        {
            var comments = new List<Comment>()
            {
                new Comment()
                {
                    Id = 1,
                    ForumId = 1,
                    UserId = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                    Title = "Try Adding Worcestershire Sauce",
                    Text = "You might want to add a dash of Worcestershire sauce—it enhances the umami without overpowering. For balance, try adjusting the lemon juice and Parmesan quantities. Also, emulsifying the dressing with a blender can help achieve a smooth, creamy texture. Let us know how it turns out!",
                    DateAdded = DateTime.Now
                },
                new Comment()
                {
                    Id = 2,
                    ForumId = 2,
                    UserId = "0464d803-7820-4ec4-bb42-d75b5a1fcb7c",
                    Title = "Might have a solution",
                    Text = "Using a water bath can really help with preventing cracks and keeping the texture smooth. Wrap your springform pan in foil to avoid leaks, and bake it in a roasting pan with hot water. Also, don’t overmix the batter, as that can introduce air bubbles. Good luck with your cheesecake!",
                    DateAdded = DateTime.Now
                },
            };

            return comments;
        }
    }
}

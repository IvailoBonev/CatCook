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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Предястия"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Салати"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Торти"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Риба"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Сладкиши"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Основно"
                },
            };

            return categories;
        }
    }
}

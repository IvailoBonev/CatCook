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
    public class DifficultyConfiguration : IEntityTypeConfiguration<Difficulty>
    {
        public void Configure(EntityTypeBuilder<Difficulty> builder)
        {
            builder.HasData(CreateDifficulties());
        }

        private List<Difficulty> CreateDifficulties()
        {
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = 1,
                    Name = "Лесно"
                },
                new Difficulty()
                {
                    Id = 2,
                    Name = "Средно"
                },
                new Difficulty()
                {
                    Id = 3,
                    Name = "Трудно"
                },
                new Difficulty()
                {
                    Id = 4,
                    Name = "Много трудно"
                },
            };

            return difficulties;
        }
    }
}

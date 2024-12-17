using CatCook.Core.Contracts;
using CatCook.Core.Models.Recipe;
using CatCook.Core.Services;
using CatCook.Extensions;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace CatCook.Tests
{
    [TestClass]
    public sealed class RecipeServiceTests
    {
        private IRepository repo;
        private IRecipeService recipeService;
        private ApplicationDbContext applicationDbContext;
        private string userId = Guid.NewGuid().ToString();

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("CatCookDb")
                .Options;

            applicationDbContext = new ApplicationDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestLast4RecipesNumberAndOrder()
        {
            var repoMock = new Mock<IRepository>();
            string differentUser = Guid.NewGuid().ToString();

            IEnumerable<Recipe> recipes = new List<Recipe>()
            {
                new Recipe() { Id = 1, UserId = userId, IsPrivate = false, DateAdded = DateTime.Now.AddMinutes(2) },
                new Recipe() { Id = 3, UserId = userId, IsPrivate = false, DateAdded = DateTime.Now.AddMinutes(2) },
                new Recipe() { Id = 5, UserId = userId, IsPrivate = false, DateAdded = DateTime.Now.AddMinutes(2) },
                new Recipe() { Id = 2, UserId = differentUser, IsPrivate = true, DateAdded = DateTime.Now.AddMinutes(2)},
                new Recipe() { Id = 4, UserId = differentUser, IsPrivate = true, DateAdded = DateTime.Now}
            }.AsEnumerable();

            repo = repoMock.Object;
            recipeService = new RecipeService(repo);

            var recipeCollectionMainUser = await recipeService.LastFourRecipes(userId, false);
            var recipeCollectionNewUser = await recipeService.LastFourRecipes(differentUser, false);
            var recipeCollectionAdmin = await recipeService.LastFourRecipes(Guid.NewGuid().ToString(), true);

            Assert.That(3, Is.EqualTo(recipeCollectionMainUser.Count()));
            Assert.That(4, Is.EqualTo(recipeCollectionMainUser.Count()));
            Assert.That(4, Is.EqualTo(recipeCollectionAdmin.Count()));
            Assert.That(recipeCollectionAdmin.Any(h => h.Id == 4), Is.False);
        }

        [Test]
        public async Task TestRecipeEdit()
        {
            var repoMock = new Mock<Repository>(applicationDbContext);
            repo = repoMock.Object;
            recipeService = new RecipeService(repo);

            await repo.AddAsync(new Recipe()
            {
                Id = 1,
                Descipriton = " ",
                DateAdded = DateTime.Now,
                DifficultyId = 1,
                CategoryId = 1,
                IsDeleted = false,
                IsPrivate = false,
                PortionsCount = 1,
                TimeForPreparation = 20,
                TimeForCooking = 30,
                Rating = new List<double>() { 0.0 },
                Name = " ",
            });

            await repo.SaveChangesAsync();

            await recipeService.Edit(1, new RecipeModel()
            {
                Description = "This is crazy!",
                DateAdded = DateTime.Now,
                DifficultyId = 1,
                CategoryId = 1,
                IsPrivate = false,
                PortionsCount = 1,
                TimeForPreparation = 20,
                TimeForCooking = 30,
                Name = "This is crazy!",
            });

            var dbRecipe = await repo.GetByIdAsync<Recipe>(1);

            Assert.That(dbRecipe.Descipriton, Is.EqualTo("This is crazy!"));
            Assert.That(dbRecipe.Name, Is.EqualTo("This is crazy!"));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}

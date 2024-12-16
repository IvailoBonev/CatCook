using CatCook.Core.Contracts;
using CatCook.Core.Services;
using CatCook.Infrastructure.Common;

namespace CatCook.Extensions
{
    public static class CatCookServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<ITipService, TipService>();
            services.AddScoped<IForumService, ForumService>();
            services.AddScoped<ICommentService, CommentService>();


            return services;
        }
    }
}

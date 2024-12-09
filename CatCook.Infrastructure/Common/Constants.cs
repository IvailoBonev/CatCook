using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Infrastructure.Common
{
    public static class Constants
    {
        //Cooker(ApplicationUser)
        public const int UserFirstNameMaxLength = 35;
        public const int UserLastNameMaxLength = 40;
        public const int UserCityNameMaxLength = 80;
        public const int UserUrlImageMaxLength = 200;
        public const int UserStatusMaxLength = 100;
        public const int UserProfileNameMaxLength = 18;
        //Category
        public const int CategoryNameMaxLength = 40;
        //Comment
        public const int CommentTitleMaxLength = 40;
        public const int CommentTextMaxLength = 900;
        //Forum
        public const int ForumTitleMaxLength = 100;
        public const int ForumTextMaxLength = 1200;
        //Image
        public const int ImageUrlMaxLength = 200;
        //Recipe
        public const int RecipeNameMinLength = 4;
        public const int RecipeNameMaxLength = 90;
        public const string RecipeNameErrorMessage = "Recipe name must be between {2} and {1} symbols!";
        public const int RecipePortionsCountMin = 1;
        public const int RecipePortionsCountMax = 20;
        public const string RecipePortionsErrorMessage = "Recipe portions must be between {1} and {2}!";
        public const int RecipeCookingTimeMin = 3;
        public const int RecipeCookingTimeMax = 720;
        public const string RecipeCookingErrorMessage = "Recipe cooking time must be between {1} and {2} minutes!";
        public const int RecipePreparationTimeMin = 2;
        public const int RecipePreparationTimeMax = 60;
        public const string RecipePreparationErrorMessage = "Recipe preparation time must be between {1} and {2} minutes!";
        //Difficulty
        public const int DifficultyNameMaxLength = 30;
        //Tip
        public const int TipTitleMinLength = 10;
        public const int TipTitleMaxLength = 100;
        public const string TipTitleErrorMessage = "Tip title must be between {2} and {1} symbols!";
    }
}

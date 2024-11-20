﻿using System;
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
        public const int UserUrlImageMaxLength = 120;
        public const int UserStatusMaxLength = 100;
        //Category
        public const int CategoryNameMaxLength = 40;
        //Comment
        public const int CommentTitleMaxLength = 40;
        public const int CommentTextMaxLength = 450;
        //Forum
        public const int ForumTitleMaxLength = 60;
        public const int ForumTextMaxLength = 600;
        //Image
        public const int ImageUrlMaxLength = 120;
        //Recipe
        public const int RecipeNameMaxLength = 80;
        public const int RecipeDescriptionMaxLength = 450;
        //Difficulty
        public const int DifficultyNameMaxLength = 30;
        //Tip
        public const int TipImageUrlMaxLength = 120;
        public const int TipTitleMaxLength = 60;
        public const int TipDescriptionMaxLength = 300;
    }
}
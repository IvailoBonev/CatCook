// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CatCook.Infrastructure.Common;
using CatCook.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static CatCook.Infrastructure.Common.Constants;

namespace CatCook.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRepository repo;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IRepository _repo)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            repo = _repo;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [EmailAddress]
            [Display(Name = "Имейл")]
            public string Email { get; set; }

            [Required]
            [StringLength(UserFirstNameMaxLength,
                MinimumLength = UserFirstNameMinLength, ErrorMessage = UserFirstNameErrorMessage)]
            public string FirstName { get; set; } = string.Empty;

            [Required]
            [StringLength(UserLastNameMaxLength,
                MinimumLength = UserLastNameMinLength, ErrorMessage = UserLastNameErrorMessage)]
            public string LastName { get; set; } = string.Empty;

            [Required]
            [StringLength(UserProfileNameMaxLength,
                MinimumLength = UserProfileNameMinLength, ErrorMessage = UserProfileNameЕrrorMessage)]
            public string ProfileName { get; set; } = string.Empty;

            [StringLength(UserCityNameMaxLength,
               MinimumLength = UserCityNameMinLength, ErrorMessage = UserCityNameErrorMessage)]
            public string? City { get; set; }

            [StringLength(UserStatusMaxLength,
               MinimumLength = UserStatusMinLength, ErrorMessage = UserStatusErrorMessage)]
            public string? Status { get; set; }

            [MaxLength(UserUrlImageMaxLength)]
            public string? AvatarImageUrl { get; set; }

            public bool IsWhiteMode { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            var firstName = user.FirstName;
            var lastName = user.LastName;
            var profileName = user.ProfileName;
            var city = user.City;
            var avatarImgUrl = user.AvatarImageUrl;
            var email = user.Email;
            var status = user.Status;
            var whiteMode = user.IsWhiteMode;

            Username = userName;

            Input = new InputModel
            {
                FirstName = firstName,
                LastName = lastName,
                ProfileName = profileName,
                AvatarImageUrl = avatarImgUrl,
                City = city,
                Email = email,
                Status = status,
                IsWhiteMode = whiteMode
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            user.FirstName = Input.FirstName;
            user.LastName = Input.LastName;
            user.City = Input.City;
            user.AvatarImageUrl = Input.AvatarImageUrl;
            user.ProfileName = Input.ProfileName;
            user.Status = Input.Status;
            user.IsWhiteMode = Input.IsWhiteMode;

            await _signInManager.RefreshSignInAsync(user);
            await repo.SaveChangesAsync();

            StatusMessage = "Профила ви беше обновен.";
            return RedirectToPage();
        }
    }
}

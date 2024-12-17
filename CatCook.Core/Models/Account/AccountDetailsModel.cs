using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCook.Core.Models.Account
{
    public class AccountDetailsModel
    {
        public int Id { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string AvatarImgUrl { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int UserPoints { get; set; }
    }
}

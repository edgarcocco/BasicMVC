using Microsoft.AspNetCore.Identity;

namespace BasicMVC.Models.IdentityModels
{
    public class MVCUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";
    }
}

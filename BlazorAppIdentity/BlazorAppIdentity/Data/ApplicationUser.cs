using Microsoft.AspNetCore.Identity;

namespace BlazorAppIdentity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public byte[]? ProfilePicture { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace MangoMe.Services.AuthAPI.Models;

public class ApplicationUser : IdentityUser
{
    public string Name {  get; set; }

}

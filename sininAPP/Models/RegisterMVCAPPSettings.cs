using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RegisterMVCAPP.Models
{
    public class RegisterMVCAPPSettings : IdentityUser
    {
       public string lastName {  get; set; }    
    }
}

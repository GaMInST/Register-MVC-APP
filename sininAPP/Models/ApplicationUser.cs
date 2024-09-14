
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
namespace RegisterMVCAPP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }

    }
}
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application.Models
{
    public class VkUserModel : PageModel
    {
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PageUrl { get; set; }


        public VkUserModel()
        {
            OnGet();
        }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                FirstName = User.FindFirst(c => c.Type == ClaimTypes.Name)?.Value;
                LastName = User.FindFirst(c => c.Type == ClaimTypes.Surname)?.Value;
                Avatar = User.FindFirst(c => c.Type == "urn:vk:photo")?.Value;
                PageUrl = "vk.com/" + User.FindFirst(c => c.Type == "urn:vk:login")?.Value;
            }
        }
    }
}
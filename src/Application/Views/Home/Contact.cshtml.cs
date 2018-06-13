using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Application.Models
{
    public class ContactModel : PageModel
    {
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PageUrl { get; set; }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                FirstName = User.FindFirst(c => c.Type == ClaimTypes.GivenName)?.Value;
                LastName = User.FindFirst(c => c.Type == ClaimTypes.Surname)?.Value;
                Avatar = User.FindFirst(c => c.Type == "urn:vk:photo")?.Value;
                //PageUrl = "vk.com/" + User.FindFirst(c => c.Type == "urn:vk:login")?.Value;
            }
        }
    }
}
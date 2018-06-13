using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace Application.VkAuth
{
    public class VkAuthOptions : OAuthOptions
    {
        public VkAuthOptions()
        {
            CallbackPath = new PathString(VkAuthDefaults.CallbackPath);
            ClaimsIssuer = VkAuthDefaults.ClaimsIssuer;
            AuthorizationEndpoint = VkAuthDefaults.AuthorizationEndpoint;
            TokenEndpoint = VkAuthDefaults.TokenEndpoint;
            UserInformationEndpoint = VkAuthDefaults.UserInformationEndpoint;
            
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
            ClaimActions.MapJsonKey(ClaimTypes.GivenName, "first_name");
            ClaimActions.MapJsonKey(ClaimTypes.Surname, "last_name");
            ClaimActions.MapJsonKey("urn:vk:photo", "photo_200");
            ClaimActions.MapJsonKey("urn:vk:photo_rec", "photo_rec");

        }

        public string Fields => "photo_rec,photo_200";
        
        public string ApiVersion { get; set; } = VkAuthDefaults.ApiVersion;
    }
}
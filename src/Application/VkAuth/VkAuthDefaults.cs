namespace Application.VkAuth
{
    public static class VkAuthDefaults
    {
        public const string ClaimsIssuer = "Vk";
        
        public const string AuthenticationScheme = "Vk";

        public const string DisplayName = "VK";
        
        public const string AuthorizationEndpoint = "https://oauth.vk.com/authorize";

        public const string TokenEndpoint = "https://oauth.vk.com/access_token";

        public const string UserInformationEndpoint = "https://api.vk.com/method/users.get";

        public const string CallbackPath = "/signin-vk";
        
        public const string ApiVersion = "5.78";
    }
}
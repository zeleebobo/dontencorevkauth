using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json.Linq;

namespace Application.VkAuth
{
    public static class VkAuthExtensions
    {
        public static AuthenticationBuilder AddVk(this AuthenticationBuilder builder)
            => builder.AddVk(_ => { });

        public static AuthenticationBuilder AddVk(this AuthenticationBuilder builder, Action<VkAuthOptions> options)
            => builder.AddVk(VkAuthDefaults.AuthenticationScheme, options);

        public static AuthenticationBuilder AddVk(this AuthenticationBuilder builder, string schemeName,
            Action<VkAuthOptions> options)
            => builder.AddVk(schemeName, VkAuthDefaults.DisplayName, options);

        public static AuthenticationBuilder AddVk(this AuthenticationBuilder builder, string schemeName,
            string displayName, Action<VkAuthOptions> options)
            => builder.AddOAuth<VkAuthOptions, VkAuthHandler>(schemeName, displayName, options);

    }
}
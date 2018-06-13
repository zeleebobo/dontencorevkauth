using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace Application.VkAuth
{
    public class VkAuthHandler : OAuthHandler<VkAuthOptions>
    {
        public VkAuthHandler(IOptionsMonitor<VkAuthOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
            
        }

        protected override async Task<AuthenticationTicket> CreateTicketAsync(ClaimsIdentity identity, AuthenticationProperties properties, OAuthTokenResponse tokens)
        {
            var queryParams = new Dictionary<string, string>()
            {
                {"v", Options.ApiVersion},
                {"access_token", tokens.AccessToken},
                {"fields", Options.Fields}
            };
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, QueryHelpers.AddQueryString(VkAuthDefaults.UserInformationEndpoint, queryParams));
            requestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await Backchannel.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead,
                Context.RequestAborted);
            response.EnsureSuccessStatusCode();
            
            /*var response = await Backchannel.GetAsync(QueryHelpers.AddQueryString(VkAuthDefaults.AuthorizationEndpoint, queryParams), Context.RequestAborted);
            
            Console.WriteLine(requestMessage);
            if (!response.IsSuccessStatusCode)
            {
                Logger.LogError($"An error occurred while retrieving the user profile: the remote server " +
                                $"returned a {response.StatusCode} " +
                                $"response with the following payload: {response.Headers} " +
                                $"{await response.Content.ReadAsStringAsync()}.");
                throw new HttpRequestException("An error occurred while retrieving the user profile.");
            }

            Console.WriteLine(response);*/
            var user = JObject.Parse(await response.Content.ReadAsStringAsync())["response"].First as JObject;
            Console.WriteLine(user);

            if (tokens.Response["email"] != null)
            {
                user.Add("email", tokens.Response["email"]);
            }

            var principal = new ClaimsPrincipal(identity);
            var context = new OAuthCreatingTicketContext(principal, properties, Context, Scheme, Options, Backchannel, tokens, user);
            context.RunClaimActions(user);

            await Options.Events.CreatingTicket(context);
            return new AuthenticationTicket(context.Principal, context.Properties, Scheme.Name);
        }
    }
}
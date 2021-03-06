#pragma checksum "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c31d48984999406c0167dd18f1ad2568dda53035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Authentication_SignIn), @"mvc.1.0.view", @"/Pages/Authentication/SignIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Authentication/SignIn.cshtml", typeof(AspNetCore.Pages_Authentication_SignIn))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c31d48984999406c0167dd18f1ad2568dda53035", @"/Pages/Authentication/SignIn.cshtml")]
    public class Pages_Authentication_SignIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthenticationScheme[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 139, true);
            WriteLiteral("\n<div class=\"jumbotron\">\n    <h1>Authentication</h1>\n    <p class=\"lead text-left\">Sign in using one of these external providers:</p>\n    \n");
            EndContext();
#line 8 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
     foreach (var scheme in Model)
    {

#line default
#line hidden
            BeginContext(253, 94, true);
            WriteLiteral("        <form action=\"/signin\" method=\"post\">\n            <input type=\"hidden\" name=\"Provider\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 347, "\"", 367, 1);
#line 11 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
WriteAttributeValue("", 355, scheme.Name, 355, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(368, 53, true);
            WriteLiteral(" />\n            <input type=\"hidden\" name=\"ReturnUrl\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 421, "\"", 447, 1);
#line 12 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
WriteAttributeValue("", 429, ViewBag.ReturnUrl, 429, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 84, true);
            WriteLiteral(" />\n\n            <button class=\"btn btn-lg btn-success\" type=\"submit\">Connect using ");
            EndContext();
            BeginContext(533, 18, false);
#line 14 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
                                                                          Write(scheme.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(551, 26, true);
            WriteLiteral("</button>\n        </form>\n");
            EndContext();
#line 16 "/Users/zeleebobo/Projects/sharp/OpenIdApplication/src/Application/Pages/Authentication/SignIn.cshtml"
    }

#line default
#line hidden
            BeginContext(583, 6, true);
            WriteLiteral("</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthenticationScheme[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498d5837590a75a86dab6096cff033b0b15f1ac6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
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
#line 1 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\_ViewImports.cshtml"
using App.Admin;

#line default
#line hidden
#line 2 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models;

#line default
#line hidden
#line 3 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"498d5837590a75a86dab6096cff033b0b15f1ac6", @"/Views/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0df6c0c259843b3e9a8a7b548d3ee29c0d7696", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
            WriteLiteral("\r\n<h2>");
#line 5 "D:\NET.WEB\CQRSAPP\App\App.Admin\Views\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            WriteLiteral("</h2>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

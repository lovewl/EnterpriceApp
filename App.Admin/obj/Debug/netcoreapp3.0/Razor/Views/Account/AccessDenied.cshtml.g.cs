#pragma checksum "D:\NET.WEB\EnterpriceApp\App.Admin\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835056e6c354d3c872a626af029e7f1ecaea90db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
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
#line 1 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\_ViewImports.cshtml"
using App.Admin;

#line default
#line hidden
#line 2 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models;

#line default
#line hidden
#line 3 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\_ViewImports.cshtml"
using App.Infrastructure.CrossCutting.Identity.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835056e6c354d3c872a626af029e7f1ecaea90db", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d0df6c0c259843b3e9a8a7b548d3ee29c0d7696", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
            WriteLiteral("<br/>\r\n<header>\r\n    <div class=\"alert alert-danger\">\r\n        <h2 class=\"text-danger\">");
#line 7 "D:\NET.WEB\EnterpriceApp\App.Admin\Views\Account\AccessDenied.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
            WriteLiteral("</h2>\r\n    </div>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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

#pragma checksum "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6844fc934576a8e3c77e0b6b105721b36f0c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6844fc934576a8e3c77e0b6b105721b36f0c7f", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33404293f951c9e4bee0fe62cf42734d386355db", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDCWebApplication.ViewModels.CustomerDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Customer\Details.cshtml"
Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 4 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Customer\Details.cshtml"
Write(Model.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 5 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Customer\Details.cshtml"
Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDCWebApplication.ViewModels.CustomerDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

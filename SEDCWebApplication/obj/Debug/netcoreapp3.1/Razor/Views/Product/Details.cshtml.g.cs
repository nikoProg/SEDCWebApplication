#pragma checksum "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31e32e0303944ec22047d0e784f3997f061dbf48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e32e0303944ec22047d0e784f3997f061dbf48", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33404293f951c9e4bee0fe62cf42734d386355db", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<img class=\"figure-img align-content-lg-center col-7\"");
            BeginWriteAttribute("src", "  src=", 87, "", 109, 1);
#nullable restore
#line 3 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml"
WriteAttributeValue("", 93, Model.ImagePath, 93, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\" style=\"width:100%\">\r\n<h1>");
#nullable restore
#line 4 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 5 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml"
Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 7 "C:\Users\name\Downloads\SEDC - Web Applications using ASP.NET Core MVC-20210817T224102Z-001\SEDC - Web Applications using ASP.NET Core MVC\Class 5\SEDCWebApplication\SEDCWebApplication\Views\Product\Details.cshtml"
Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" RSD</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

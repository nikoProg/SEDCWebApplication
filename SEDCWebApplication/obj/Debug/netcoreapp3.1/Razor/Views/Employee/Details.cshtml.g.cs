#pragma checksum "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140986b089f320a978e783e6b014730bb8dc011b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication.BLL.Logic.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\_ViewImports.cshtml"
using SEDCWebApplication.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140986b089f320a978e783e6b014730bb8dc011b", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"985bef76733613b1f28c0948a74fd30bfe6588d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<img class=\"figure-img align-content-lg-center col-7\"");
            BeginWriteAttribute("src", " src=\"", 88, "\"", 110, 1);
#nullable restore
#line 3 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\Employee\Details.cshtml"
WriteAttributeValue("", 94, Model.ImagePath, 94, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\" style=\"width:100%\">\r\n<h1>");
#nullable restore
#line 4 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\Employee\Details.cshtml"
Write(Model.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s details</h1>\r\n<h2>");
#nullable restore
#line 5 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\Employee\Details.cshtml"
Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 6 "C:\Users\name\source\repos\SEDCWebApplication\SEDCWebApplication\Views\Employee\Details.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Some example text some example text. John Doe is an architect and engineer</h3>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "G:\CORE PROJECT\Book\Views\Fine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2a63c9411b9ec2c7f06d2afd2267029103b141"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fine_Index), @"mvc.1.0.view", @"/Views/Fine/Index.cshtml")]
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
#line 1 "G:\CORE PROJECT\Book\Views\_ViewImports.cshtml"
using Book;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\CORE PROJECT\Book\Views\_ViewImports.cshtml"
using Book.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2a63c9411b9ec2c7f06d2afd2267029103b141", @"/Views/Fine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b252a8f427cf8f6a5987d720e148396be09107fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Fine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book.Models.Fine>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\CORE PROJECT\Book\Views\Fine\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 9 "G:\CORE PROJECT\Book\Views\Fine\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 78 "G:\CORE PROJECT\Book\Views\Fine\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book.Models.Fine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
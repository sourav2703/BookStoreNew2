#pragma checksum "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de99ede26be4747307f760aa770e958e9a330a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Exp), @"mvc.1.0.view", @"/Views/Home/Exp.cshtml")]
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
#line 6 "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de99ede26be4747307f760aa770e958e9a330a0", @"/Views/Home/Exp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f605c4e6116b880074f9df786db7dde731e5ecb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Exp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml"
  
    ViewData["Title"] = "Exp";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Exp</h1>\r\n\r\n");
#nullable restore
#line 10 "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml"
Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "E:\DOTNET_FILES_LocalDisk_E\first\BookStore\BookStore\Views\Home\Exp.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd3dfbd3de0738ce93b76785230a66be0269c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\_ViewImports.cshtml"
using MyPlace;

#line default
#line hidden
#line 2 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\_ViewImports.cshtml"
using MyPlace.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd3dfbd3de0738ce93b76785230a66be0269c84", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e30bb40e8cd6881c51f3fbecd2ddce7fcdf429", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestMVC.Models.Model1>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(95, 6, true);
            WriteLiteral("\r\n<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 101, "\"", 122, 1);
#line 7 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
WriteAttributeValue("", 107, Model.ImageURL, 107, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(123, 9, true);
            WriteLiteral(" />\r\n<h1>");
            EndContext();
            BeginContext(133, 15, false);
#line 8 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(148, 40, true);
            WriteLiteral("</h1>\r\n\r\n\r\n<h2> Ingridiants</h2>\r\n<ul>\r\n");
            EndContext();
#line 13 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
     foreach (var Image in @Model.Images)
    {

#line default
#line hidden
            BeginContext(238, 17, true);
            WriteLiteral("        <li> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 255, "\"", 267, 1);
#line 15 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
WriteAttributeValue("", 261, Image, 261, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(268, 58, true);
            WriteLiteral(" alt=\"Girl in a jacket\" width=\"600\" height=\"500\">  </li>\r\n");
            EndContext();
#line 16 "C:\Users\CAUS\Desktop\TEST MCV\MyPlace\MyPlace\Views\Home\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(333, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestMVC.Models.Model1> Html { get; private set; }
    }
}
#pragma warning restore 1591
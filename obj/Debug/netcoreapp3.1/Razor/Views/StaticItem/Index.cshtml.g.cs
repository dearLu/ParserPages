#pragma checksum "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c83c5fb3bd69660613404174fe772b4601fb0dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StaticItem_Index), @"mvc.1.0.view", @"/Views/StaticItem/Index.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\ParserPages\Views\_ViewImports.cshtml"
using ParserPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\ParserPages\Views\_ViewImports.cshtml"
using ParserPages.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c83c5fb3bd69660613404174fe772b4601fb0dd", @"/Views/StaticItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13583a1c32a3399a73eaa3f8c02a59e495c27be", @"/Views/_ViewImports.cshtml")]
    public class Views_StaticItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ParserPages.Models.StaticItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n    <h2 class=\"text-primary\">Statics</h2>\r\n    <br /><br />\r\n");
#nullable restore
#line 10 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Site</th>
                    <th>Word</th>
                    <th>Frequency</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\">");
#nullable restore
#line 24 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
                                   Write(item.PageAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"30%\">");
#nullable restore
#line 25 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
                                   Write(item.Word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td width=\"20%\">");
#nullable restore
#line 26 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
                                   Write(item.Frequency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 31 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No data</p>\r\n");
#nullable restore
#line 35 "C:\Users\admin\source\repos\ParserPages\Views\StaticItem\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ParserPages.Models.StaticItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "945100261e9fa3795a5a8a1dfa0770f91c98011f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/_ViewImports.cshtml"
using CoreSRT;

#line default
#line hidden
#line 2 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/_ViewImports.cshtml"
using CoreSRT.Models;

#line default
#line hidden
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945100261e9fa3795a5a8a1dfa0770f91c98011f", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(194, 106, true);
            WriteLiteral("\r\n<div>\r\n    <p align =\"center\"> <b>Items</b> </p>\r\n    </div>\r\n<div>\r\n    <button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 300, "\"", 363, 3);
            WriteAttributeValue("", 310, "window.location.href=\'", 310, 22, true);
#line 14 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
WriteAttributeValue("", 332, Url.Action("Create", "Items"), 332, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 362, "\'", 362, 1, true);
            EndWriteAttribute();
            BeginContext(364, 327, true);
            WriteLiteral(@"> Add New </button>
<table class=""table table-hover"">
    <thead>
        <tr>
            <td>Description</td>
            <td>Rate</td>
            <td>CGST</td>
            <td>SGST</td>
            <td>Date From </td>
            <td>Date To </td>
            <td> Actions </td>
        </tr>
        </thead>
");
            EndContext();
#line 27 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(732, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(781, 16, false);
#line 31 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(853, 9, false);
#line 34 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.Rate);

#line default
#line hidden
            EndContext();
            BeginContext(862, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(918, 9, false);
#line 37 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.CGST);

#line default
#line hidden
            EndContext();
            BeginContext(927, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(983, 9, false);
#line 40 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.SGST);

#line default
#line hidden
            EndContext();
            BeginContext(992, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1048, 13, false);
#line 43 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.DateFrom);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1117, 11, false);
#line 46 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(item.DateTo);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1184, 95, false);
#line 49 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(Html.ActionLink("", "Edit", new { Id = @item.Id }, new { @class = "glyphicon glyphicon-edit" }));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1300, 193, false);
#line 50 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"
           Write(Html.ActionLink("", "Delete", new { Id = @item.Id },
new { onclick = "return confirm('Do you really want to delete this Item?')", @class = "glyphicon glyphicon-remove", @style = "color:red" }));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 54 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1538, 21, true);
            WriteLiteral("\r\n</table>\r\n </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
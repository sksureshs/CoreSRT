#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b7cda134e15935e9456f5b2d4a78ad669e154a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Edit), @"mvc.1.0.view", @"/Views/Customer/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Edit.cshtml", typeof(AspNetCore.Views_Customer_Edit))]
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
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b7cda134e15935e9456f5b2d4a78ad669e154a0", @"/Views/Customer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 72, true);
            WriteLiteral("\r\n\r\n    <p align=\"center\"> <b>Edit New Item</b> </p>\r\n\r\n<div>\r\n    <p>\r\n");
            EndContext();
#line 14 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
         using (Html.BeginForm("Edit", "Customer", FormMethod.Post))
        {
            

#line default
#line hidden
            BeginContext(357, 141, true);
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <td>\r\n                    <div class=\"table-cell\">\r\n                        ");
            EndContext();
            BeginContext(499, 18, false);
#line 21 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
                   Write(Html.Label("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(517, 95, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(613, 35, false);
#line 25 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(648, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(753, 19, false);
#line 30 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.Label("GSTNo"));

#line default
#line hidden
            EndContext();
            BeginContext(772, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(840, 36, false);
#line 33 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.EditorFor(model => model.GSTNo));

#line default
#line hidden
            EndContext();
            BeginContext(876, 106, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(983, 27, false);
#line 39 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.Label("ContactNumber"));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1078, 44, false);
#line 42 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.EditorFor(model => model.ContactNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 105, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            <tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1228, 21, false);
#line 48 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.Label("Address"));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1317, 30, false);
#line 51 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.EditorFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1347, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1452, 21, false);
#line 56 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.Label("EmailId"));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1541, 30, false);
#line 59 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.EditorFor(m => m.EmailId));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 104, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1676, 18, false);
#line 64 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.Label("Type"));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1762, 155, false);
#line 67 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
               Write(Html.DropDownListFor(m => m.TypeId, new SelectList(Model.Types, "TypeId", "Type"),
                 Model.Types.First(t => t.TypeId == Model.TypeId).Type));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 97, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr></tr>\r\n        </table>\r\n            ");
            EndContext();
            BeginContext(2014, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93d5b2f0145b4e0491c346c7dd04d8e4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 73 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 73 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
                                  WriteLiteral(Model.CustomerId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2080, 76, true);
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 75 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(2167, 22, true);
            WriteLiteral("        <br>\r\n        ");
            EndContext();
            BeginContext(2190, 40, false);
#line 77 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Customer/Edit.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 20, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

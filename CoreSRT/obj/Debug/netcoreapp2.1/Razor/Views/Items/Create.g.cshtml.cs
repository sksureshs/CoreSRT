#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62b57b438fe75beafc6203f86e33560fc855d4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Create), @"mvc.1.0.view", @"/Views/Items/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Create.cshtml", typeof(AspNetCore.Views_Items_Create))]
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
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62b57b438fe75beafc6203f86e33560fc855d4f", @"/Views/Items/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(164, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 716, true);
            WriteLiteral(@"<div>
    <script>
        function changeRate()
        {
            var gstAmt = $('#Rate').val() * ($('#hiCGST').val()/100);
            $('#cgstAmt').val( gstAmt );
            $('#sgstAmt').val( gstAmt);
            $('#totalAmt').val('0');
            if ($('#Rate').val() != '')
                $('#totalAmt').val( parseFloat($('#Rate').val()) + (gstAmt * 2));
        }
        function radioClick(val)
        {
            $('#CGST').val(val/2);
            $('#SGST').val(val/2);
            $('#hiCGST').val(val/2);
            $('#hiSGST').val(val/2);
            changeRate();
        }
    </script>
<p align=""center""> <b>Create New Item</b> </p>
    </div>


<div>
    <p>
");
            EndContext();
#line 35 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
         using (Html.BeginForm("Create", "Items", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(984, 165, true);
            WriteLiteral("            <table class=\"table\">\r\n\r\n                <tr>\r\n\r\n                    <td>\r\n                        <div class=\"table-cell\">\r\n                            ");
            EndContext();
            BeginContext(1150, 25, false);
#line 43 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
                       Write(Html.Label("Description"));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 111, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1287, 43, false);
#line 47 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
                   Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 124, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1455, 18, false);
#line 52 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
                   Write(Html.Label("Rate"));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1553, 71, false);
#line 55 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
                   Write(Html.TextBoxFor(model => model.Rate, new  { onChange = "changeRate()"}));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 865, true);
            WriteLiteral(@"
                    </td>
                <tr>
                    <td>
                        <p>Choose GST Slab </p>

                        <input type=""radio"" name=""radioGst"" value=""0"" onclick=""radioClick(0)"" /> 0
                        <input type=""radio"" name=""radioGst"" value=""5"" onclick=""radioClick(5)"" />  5
                        <input type=""radio"" name=""radioGst"" value=""10"" onclick=""radioClick(10)"" />  10
                        <input type=""radio"" name=""radioGst"" value=""12"" onclick=""radioClick(12)"" />  12
                        <input type=""radio"" name=""radioGst"" value=""18"" onclick=""radioClick(18)"" />  18
                        <input type=""radio"" name=""radioGst"" value=""28"" onclick=""radioClick(28)"" />  28

                    </td>
                </tr>
            <tr>
                    <td>
                        ");
            EndContext();
            BeginContext(2490, 18, false);
#line 72 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
                   Write(Html.Label("CGST"));

#line default
#line hidden
            EndContext();
            BeginContext(2508, 29, true);
            WriteLiteral(" - \r\n                        ");
            EndContext();
            BeginContext(2537, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69e20f3c159c4a12a537e834f2591884", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 73 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CGST);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2589, 310, true);
            WriteLiteral(@"
                        <input type=""text"" id=""hiCGST"" readonly=""readonly"" />
                    </td>
                    <td>
                        <input type=""text"" id=""cgstAmt"" readonly=""readonly""/>
                    </td>
            </tr>
           <tr>
            <td>
                ");
            EndContext();
            BeginContext(2900, 18, false);
#line 82 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
           Write(Html.Label("SGCT"));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 20, true);
            WriteLiteral(" -\r\n                ");
            EndContext();
            BeginContext(2938, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "806aabd45e0944a88e72db6077e18672", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 83 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SGST);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2990, 268, true);
            WriteLiteral(@"
                <input type=""text"" id=""hiSGST"" readonly=""readonly"" />
            </td>
            <td>
                <input type=""text"" id=""sgstAmt"" readonly=""readonly""/>
            </td>
        </tr>
           <tr>
               <td>
               ");
            EndContext();
            BeginContext(3259, 26, false);
#line 92 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
          Write(Html.Label("Total Amount"));

#line default
#line hidden
            EndContext();
            BeginContext(3285, 204, true);
            WriteLiteral("\r\n                   </td>\r\n               <td>\r\n                   <input type=\"text\" readonly=\"readonly\" id=\"totalAmt\">\r\n                   </td>\r\n           </tr>\r\n        <tr></tr>\r\n        </table>\r\n");
            EndContext();
            BeginContext(3491, 70, true);
            WriteLiteral("        <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n");
            EndContext();
#line 102 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"

    }

#line default
#line hidden
            BeginContext(3570, 22, true);
            WriteLiteral("        <br>\r\n        ");
            EndContext();
            BeginContext(3593, 40, false);
#line 105 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Items/Create.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3633, 27, true);
            WriteLiteral("\r\n        </>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

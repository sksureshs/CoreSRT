#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b4858ca650d6e60ca02543eeb0be5ed598c0eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Print), @"mvc.1.0.view", @"/Views/Bills/Print.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/Print.cshtml", typeof(AspNetCore.Views_Bills_Print))]
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
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b4858ca650d6e60ca02543eeb0be5ed598c0eb", @"/Views/Bills/Print.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_Print : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillPrintViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(164, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65fde5d34b4644689e929798bcc01fba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(237, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "be8cb91e2c8e4068aaf96d5287341255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(337, 308, true);
            WriteLiteral(@"
<script>
function PrintDoc() {
    var printContents = document.getElementById('billPrintArea').innerHTML;
    var originalContents = document.body.innerHTML;

     document.body.innerHTML = printContents;

     window.print();

     document.body.innerHTML = originalContents;
    }
</script>
");
            EndContext();
            BeginContext(672, 324, true);
            WriteLiteral(@"<br>
<br>
<div id=""billPrintArea"" class=""container responsive "">
    <div class=""panel-group"">
        <div class=""panel panel-default"">
            <div class=""panel-body"">
                <div class=""row"">
                    <div class=""col-sm-7"">
                        <span style=""text-transform: uppercase;"">");
            EndContext();
            BeginContext(997, 17, false);
#line 30 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                            Write(Model.Seller.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 44, true);
            WriteLiteral("</span><br>\r\n                        <small>");
            EndContext();
            BeginContext(1059, 20, false);
#line 31 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                          Write(Model.Seller.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1079, 89, true);
            WriteLiteral("<br></small>\r\n                        <span class=\"glyphicon glyphicon-envelope\"></span> ");
            EndContext();
            BeginContext(1169, 20, false);
#line 32 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                                      Write(Model.Seller.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 78, true);
            WriteLiteral("<br>\r\n                        <span class=\"glyphicon glyphicon-phone\"></span> ");
            EndContext();
            BeginContext(1268, 26, false);
#line 33 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                                   Write(Model.Seller.ContactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 48, true);
            WriteLiteral("<br>\r\n                        <small> GSTIN: <b>");
            EndContext();
            BeginContext(1343, 18, false);
#line 34 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                     Write(Model.Seller.GSTNo);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 267, true);
            WriteLiteral(@"</b></small>

                    </div>
                    <div class=""col-sm-1""><p class=""text-right"">To:</p></div>
                    <div class=""col-sm-4 table-bordered"">
                        <p class=""text-left"">
                            <small><b>");
            EndContext();
            BeginContext(1629, 16, false);
#line 40 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                 Write(Model.Buyer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 56, true);
            WriteLiteral("</b></small> <br>\r\n                            <small>  ");
            EndContext();
            BeginContext(1702, 19, false);
#line 41 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                Write(Model.Buyer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1721, 51, true);
            WriteLiteral("<br></small>\r\n                            <small>  ");
            EndContext();
            BeginContext(1773, 25, false);
#line 42 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                Write(Model.Buyer.ContactNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1798, 51, true);
            WriteLiteral("</small><br>\r\n                            <small>  ");
            EndContext();
            BeginContext(1850, 19, false);
#line 43 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                Write(Model.Buyer.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(1869, 57, true);
            WriteLiteral("</small><br>\r\n                            <small> GSTIN: ");
            EndContext();
            BeginContext(1927, 17, false);
#line 44 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                      Write(Model.Buyer.GSTNo);

#line default
#line hidden
            EndContext();
            BeginContext(1944, 483, true);
            WriteLiteral(@"</small>
                        </p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-sm-3""></div>
                    <div class=""col-sm-5"">
                        <p class=""text-center""><ins><b>TAX INVOICE</b></ins></p>
                    </div>
                
                <div class=""col-sm-2"">
                    <p class=""text-left"">
                        <small>Invoice Number : <b>");
            EndContext();
            BeginContext(2428, 12, false);
#line 56 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                              Write(Model.BillNo);

#line default
#line hidden
            EndContext();
            BeginContext(2440, 69, true);
            WriteLiteral("</b><br></small>\r\n                        <small>Invoice Date   : <b>");
            EndContext();
            BeginContext(2510, 34, false);
#line 57 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                              Write(Model.BillDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2544, 1703, true);
            WriteLiteral(@"</b><br></small>
                    </p>
                </div>
            </div>
        </div>
            <div class=""panel panel-default"" >
                <div class=""panel panel-heading"" >
                    <div class=""row"">
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>ItemNo</b></p>
                        </div>
                        <div class=""col-sm-3"">
                            <p class=""text-center""><b>Name</b></p>
                        </div>
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>Price</b></p>
                        </div>
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>CGST%</b></p>
                        </div>
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>SGST%</b></p>
                        </div>
                        <div class=""");
            WriteLiteral(@"col-sm-1"">
                            <p class=""text-center""><b>CGST</b></p>
                        </div>
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>SGST</b></p>
                        </div>
                        <div class=""col-sm-1"">
                            <p class=""text-center""><b>Quantity</b></p>
                        </div>
                        <div class=""col-sm-2"">
                            <p class=""text-center""><b>Total</b></p>
                        </div>
                        </div>
                    </div>
                        <div class=""panel panel-body"">

");
            EndContext();
#line 96 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                             for (int i = 0; i < Model.Items.Count; i++)
                    {

#line default
#line hidden
            BeginContext(4344, 158, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small> ");
            EndContext();
            BeginContext(4504, 5, false);
#line 100 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                           Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4510, 165, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-3\">\r\n                               <p class=\"text-center\"> <small> ");
            EndContext();
            BeginContext(4676, 26, false);
#line 103 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                          Write(Model.Items[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(4702, 164, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>");
            EndContext();
            BeginContext(4867, 20, false);
#line 106 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                         Write(Model.Items[i].Price);

#line default
#line hidden
            EndContext();
            BeginContext(4887, 164, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>");
            EndContext();
            BeginContext(5052, 19, false);
#line 109 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                         Write(Model.Items[i].CGST);

#line default
#line hidden
            EndContext();
            BeginContext(5071, 198, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>\r\n                                ");
            EndContext();
            BeginContext(5270, 19, false);
#line 113 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                           Write(Model.Items[i].SGST);

#line default
#line hidden
            EndContext();
            BeginContext(5289, 232, true);
            WriteLiteral("\r\n                                </small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>\r\n                                ");
            EndContext();
            BeginContext(5522, 25, false);
#line 118 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                           Write(Model.Items[i].CGSTAmount);

#line default
#line hidden
            EndContext();
            BeginContext(5547, 232, true);
            WriteLiteral("\r\n                                </small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>\r\n                                ");
            EndContext();
            BeginContext(5780, 25, false);
#line 123 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                           Write(Model.Items[i].SGSTAmount);

#line default
#line hidden
            EndContext();
            BeginContext(5805, 236, true);
            WriteLiteral("\r\n                                    </small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-1\">\r\n                                <p class=\"text-center\"><small>\r\n                                ");
            EndContext();
            BeginContext(6042, 23, false);
#line 128 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                           Write(Model.Items[i].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(6065, 198, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                            <div class=\"col-sm-2\">\r\n                                <p class=\"text-center\"><small>\r\n                                ");
            EndContext();
            BeginContext(6264, 25, false);
#line 132 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                           Write(Model.Items[i].TotalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(6289, 82, true);
            WriteLiteral("</small></p>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 135 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                        }

#line default
#line hidden
            BeginContext(6398, 371, true);
            WriteLiteral(@"                        </div>
                        
                        <div class=""panel-footer"">
                            <div class=""row"">
                                <div class=""col-sm-7"">
                                </div>
                                <div class=""col-sm-2"">
                                    <small><b>Total Quanity : ");
            EndContext();
            BeginContext(6770, 19, false);
#line 143 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                         Write(Model.TotalQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(6789, 269, true);
            WriteLiteral(@"</b></small>
                                </div>
                                <div class=""col-sm-1"">

                                </div>
                                <div class=""col-sm-2"">
                                    <small><b>Total Amount : ");
            EndContext();
            BeginContext(7059, 17, false);
#line 149 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                        Write(Model.TotalAmount);

#line default
#line hidden
            EndContext();
            BeginContext(7076, 343, true);
            WriteLiteral(@"</b></small>
                                </div>

                            </div>
                        </div>
                    </div>


                        <div class=""panel-body"">
                            <br>
                            <br>
                                    <p class=""text-right""><small>For ");
            EndContext();
            BeginContext(7420, 17, false);
#line 160 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Print.cshtml"
                                                                Write(Model.Seller.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7437, 339, true);
            WriteLiteral(@"</small></p>
                        </div>
            </div>
        </div>
    </div>
<p class=""text-center"">
                  <button class=""btn btn-print center"" id=""btnPrint"" onclick=""PrintDoc()"">
                        <span class=""glyphicon glyphicon-print text-center""> Print</span>
                    </button></p>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillPrintViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

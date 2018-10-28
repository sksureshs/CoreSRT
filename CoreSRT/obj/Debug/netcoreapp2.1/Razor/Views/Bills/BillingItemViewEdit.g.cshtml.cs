#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20680e1dfe09f6348d9dc58a35d28e3894372bd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_BillingItemViewEdit), @"mvc.1.0.view", @"/Views/Bills/BillingItemViewEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/BillingItemViewEdit.cshtml", typeof(AspNetCore.Views_Bills_BillingItemViewEdit))]
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
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20680e1dfe09f6348d9dc58a35d28e3894372bd4", @"/Views/Bills/BillingItemViewEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_BillingItemViewEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillingItemViewModel>
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
            BeginContext(195, 51, true);
            WriteLiteral("\r\n\r\n<tr>\r\n    \r\n    <td class=\"col-xs-2\">\r\n        ");
            EndContext();
            BeginContext(247, 181, false);
#line 14 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
   Write(Html.DropDownListFor(m => m.ItemId, new SelectList(Model.Items,
                          "Id", "Description"), "Select Item", new { onchange = "ChangeItem(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(428, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(439, 40, false);
#line 16 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
   Write(Html.ValidationMessageFor(m => m.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(479, 104, true);
            WriteLiteral("\r\n\r\n        <input id=\"m.Index\" hidden=\"hidden\">\r\n    </td>\r\n        <td class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(584, 83, false);
#line 21 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.CGST, new { @readonly = "readonly", @style = "width:10px"  }));

#line default
#line hidden
            EndContext();
            BeginContext(667, 78, true);
            WriteLiteral("\r\n\r\n\r\n        </td>\r\n        <td class=\"col-md-2\" width=\"10ppx\">\r\n            ");
            EndContext();
            BeginContext(746, 82, false);
#line 26 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.SGST, new { @readonly = "readonly", @style = "width:10px" }));

#line default
#line hidden
            EndContext();
            BeginContext(828, 62, true);
            WriteLiteral("\r\n\r\n        </td>\r\n        <td class=\"col-md-2\">\r\n            ");
            EndContext();
            BeginContext(891, 91, false);
#line 30 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.OriginalPrice, new { @readonly = "readonly", @style = "width:10px" }));

#line default
#line hidden
            EndContext();
            BeginContext(982, 45, true);
            WriteLiteral("\r\n\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1028, 118, false);
#line 34 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.SellingPrice, new { @style = "width:10px", onchange = "ChangeTotalPrice(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 45, true);
            WriteLiteral("\r\n\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1192, 114, false);
#line 38 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.Quantity, new { @style = "width:10px", onchange = "ChangeTotalPrice(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1350, 88, false);
#line 41 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.TotalPrice, new { @readonly = "readonly", @style = "width:10px" }));

#line default
#line hidden
            EndContext();
            BeginContext(1438, 45, true);
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1484, 140, false);
#line 45 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.CGSTAmount, new { @readonly = "readonly", @style = "width:10px", onchange = "ChangeTotalPrice(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1668, 140, false);
#line 48 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.SGSTAmount, new { @readonly = "readonly", @style = "width:40px", onchange = "ChangeTotalPrice(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1852, 142, false);
#line 51 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
       Write(Html.EditorFor(m => m.PerItemPrice, new { @readonly = "readonly", @style = "width:40px", onchange = "ChangeTotalPrice(" + Model.Index + ")" }));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 117, true);
            WriteLiteral("\r\n        </td>\r\n</tr>\r\n\r\n<script type=\"text/javascript\">\r\n    function ChangeItem(index)\r\n    {\r\n       var items = ");
            EndContext();
            BeginContext(2114, 37, false);
#line 58 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/BillingItemViewEdit.cshtml"
                Write(Html.Raw(Json.Serialize(Model.Items)));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 2062, true);
            WriteLiteral(@";
       var e = $('[id*=""BillingItemId""]').val();
       if(index >0)
       {
          var tempId= index+'__BillingItemId';
          e = $('[id*='+ tempId +']').val();
       }
       for(i=0; i<items.length; i++)
       {
          var cgstId = (index == 0) ?'CGST' : index+'__CGST';
          var sgstId = (index == 0) ?'SGST' : index+'__SGST';
          var ogPriceId = (index == 0) ?'OriginalPrice' : index+'__OriginalPrice';

          if(items[i].id == e)
          {
            $('[id*='+cgstId+']').first().val( items[i].cgst);
            $('[id*='+sgstId+']').first().val( items[i].sgst);
            $('[id*='+ogPriceId+']').first().val( items[i].rate);
            break;
          }
        }
    };

    function ChangeTotalPrice(index)
    {
        console.log(index);
        var tpPriceId = (index == 0) ?'TotalPrice' : index+'__TotalPrice';
        var selPriceId = (index == 0) ?'SellingPrice' : index+'__SellingPrice';
        var cgstPerId = (index ==0) ? ""CGST"" : inde");
            WriteLiteral(@"x+'__CGST';
        var sgstPerId = (index ==0) ? ""SGST"" : index+'__SGST';

        var cgstPerAmt = (index ==0) ? ""CGSTAmount"" : index+'__CGSTAmount';
        var sgstPerAmt = (index ==0) ? ""SGSTAmount"" : index+'__SGSTAmount';
        $('[id*='+cgstPerAmt+']').first().val($('[id*='+selPriceId+']').first().val() * $('[id*='+cgstPerId+']').first().val()/100)
        $('[id*='+sgstPerAmt+']').first().val($('[id*='+selPriceId+']').first().val() * $('[id*='+sgstPerId+']').first().val()/100)

        var perItemPrice = (index == 0)?""PerItemPrice"" : index+'__PerItemPrice';

        $('[id*='+perItemPrice+']').first().val(parseInt($('[id*='+selPriceId+']').first().val()) + parseFloat($('[id*='+cgstPerAmt+']').first().val())
                            + parseFloat($('[id*='+sgstPerAmt+']').first().val()));

        var quanId = (index == 0) ?'Quantity' : index+'__Quantity';
        $('[id*='+tpPriceId+']').first().val($('[id*='+perItemPrice+']').first().val() * $('[id*='+quanId+']').first().val());
  ");
            WriteLiteral("  }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillingItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
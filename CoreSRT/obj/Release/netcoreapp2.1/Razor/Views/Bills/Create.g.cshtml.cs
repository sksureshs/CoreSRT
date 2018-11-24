#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86291b886ca2dc11ff6deca11f8bbbae16092166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Create), @"mvc.1.0.view", @"/Views/Bills/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/Create.cshtml", typeof(AspNetCore.Views_Bills_Create))]
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
#line 7 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86291b886ca2dc11ff6deca11f8bbbae16092166", @"/Views/Bills/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 490, true);
            WriteLiteral(@"

<!-- Bootstrap Date-Picker Plugin -->
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/js/bootstrap-datepicker.min.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.4.1/css/bootstrap-datepicker3.css"" />

<div>
    <p align=""center""> <b>Generate Bill</b> </p>
</div>




<table class=""table"">
    <tr>
        <td> Select Customer : </td>
        <td>
            ");
            EndContext();
            BeginContext(681, 113, false);
#line 27 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
       Write(Html.DropDownListFor(m => m.CustomerId, new SelectList(Model.Customers, "CustomerId", "Name"), "Select Customer"));

#line default
#line hidden
            EndContext();
            BeginContext(794, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(809, 109, false);
#line 28 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
       Write(Html.ValidationMessageFor(m => m.CustomerId, "Please select a customer!", new { @class = "text-danger" }, ""));

#line default
#line hidden
            EndContext();
            BeginContext(918, 680, true);
            WriteLiteral(@"
        </td>
            <td>
            Date
            </td>
            <td>
                <div class=""input-group date"" data-provide=""datepicker"">
                    <input type=""text"" class=""form-control"" id=""billDate"">
                    <div class=""input-group-addon"">
                        <span class=""glyphicon glyphicon-th""></span>
                    </div>
                </div>
            </td>
     </tr>
</table>

<table name=""BillingItems"" class=""table"" id=""billingItemsTable"">
    <thead>
        <tr>

            <th class=""col-md-2"">
                Item
            </th>
            <th class=""col-md-2"">
                ");
            EndContext();
            BeginContext(1599, 61, false);
#line 52 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().CGST));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 56, true);
            WriteLiteral("%\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1717, 61, false);
#line 55 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SGST));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 56, true);
            WriteLiteral("%\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1835, 70, false);
#line 58 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().OriginalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1905, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1961, 69, false);
#line 61 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SellingPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2086, 65, false);
#line 64 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2207, 67, false);
#line 67 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2330, 67, false);
#line 70 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().CGSTAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2453, 67, false);
#line 73 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SGSTAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2576, 69, false);
#line 76 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().PerItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 87, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"itemCollections\">\r\n");
            EndContext();
#line 81 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
         for (int i = 0; i < Model.BillingItems.Count; i++)
        {

            

#line default
#line hidden
            BeginContext(2819, 59, false);
#line 84 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
       Write(Html.Partial("BillingItemViewModel", Model.BillingItems[i]));

#line default
#line hidden
            EndContext();
#line 84 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Create.cshtml"
                                                                        ;
        }

#line default
#line hidden
            BeginContext(2892, 3629, true);
            WriteLiteral(@"
    </tbody>
    <tfoot>
        <tr>
            <td>
                <button id=""btnAdd"" class=""btnAdd btn btn-info btn-sm"" type=""button"" value=""Add"">
                    <span class=""glyphicon glyphicon-plus""></span>
                </button>
            </td>

            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </tfoot>
</table>


<p class=""text-center"">
    <button id=""btnSubmit"" class=""btn btn-primary btn-sm"" onclick=""TestFunction()"">
        <span class=""glyphicon glyphicon-ok""></span> Generate Bill
    </button>
</p>



<script type=""text/javascript"">
        $(function(){
                $('.datepicker').datepicker({
            format: 'dd/mm/yyyy',
            autoclose: true,
            todayHighlight: true,
            startDate: '-3d'
        })});

    $(document).on(""click"", "".btnAdd"", function(){
    var index = $(""table#billingItemsTable tbody tr"").length");
            WriteLiteral(@" + 1;

       $.ajax({
            url: 'AddItem',
    data:{index:index},
            success: function (data) {
                $('#billingItemsTable > tbody').append(data);
            },
            error: function (a, b, c) {
                console.log(a, b, c);
            }

        });
    });
 function TestFunction(){
        var table = $('table#billingItemsTable');

        var o = [];
        table.find('tr').each(function() {
        var $this = $(this);
        var $elements = $this.find('input, textarea, select')
        if ($elements.size() > 0) {
            var serialized = $elements.serialize();
            var item = $.toDictionary( serialized );
            o.push(item);
        }
        });

        //o.splice(-1,1);

        var modelJson = new Object();
        modelJson.CustomerId = parseInt($('[id*=""CustomerId""]').val());
        modelJson.BillDate = new Date($('#billDate').val());
        modelJson.Items = o;

        var dataJson = JSON.stringif");
            WriteLiteral(@"y(modelJson);
        var tempp = JSON.stringify({""modelJson"": dataJson});

        $.ajax({
             url:'Create',
             type:'POST',
             dataType: ""json"",
             contentType: 'application/json; charset=utf-8',
             data:  dataJson,
             success: function(data1){
                     var url = data1['RedirectURL'];
                     var print = confirm('Do you want to Print this Bill?');
                     if(print == true)
                     {
                        window.location.replace(decodeURIComponent(url));
                     }
                     else{
                         window.location.replace('/bills/index');
                     }
             },
             error: function (a, b, c) {
                alert('An error Occured! please try again..')
                console.log(a, b, c);
                window.location.replace('/bills/create');
            }
        });
    }
        (function($) {
    $.extend({");
            WriteLiteral(@"
        toDictionary: function(query) {
            var parms = {};
            var items = query.split(""&""); // split
            for (var i = 0; i < items.length; i++) {
                var values = items[i].split(""="");
                var keys = values.shift().split(""."");
                var key = decodeURIComponent(keys[keys.length -1]);
                var value = values.join(""="")
                parms[key] = parseFloat(decodeURIComponent(value));
            }
            return (parms);
        }
    })
})(jQuery);


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

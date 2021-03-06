#pragma checksum "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cacc366c42b65575459a93ea87cc077aa90701"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bills_Edit), @"mvc.1.0.view", @"/Views/Bills/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bills/Edit.cshtml", typeof(AspNetCore.Views_Bills_Edit))]
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
#line 6 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
using CoreSRT.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81cacc366c42b65575459a93ea87cc077aa90701", @"/Views/Bills/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d3c613dcf7826469de347edd45536d095786a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bills_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(186, 480, true);
            WriteLiteral(@"<!-- Bootstrap Date-Picker Plugin -->
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
            BeginContext(667, 113, false);
#line 20 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
       Write(Html.DropDownListFor(m => m.CustomerId, new SelectList(Model.Customers, "CustomerId", "Name"), "Select Customer"));

#line default
#line hidden
            EndContext();
            BeginContext(780, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(795, 109, false);
#line 21 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.CustomerId, "Please select a customer!", new { @class = "text-danger" }, ""));

#line default
#line hidden
            EndContext();
            BeginContext(904, 635, true);
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
            BeginContext(1540, 61, false);
#line 43 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().CGST));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 56, true);
            WriteLiteral("%\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1658, 61, false);
#line 46 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SGST));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 56, true);
            WriteLiteral("%\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1776, 70, false);
#line 49 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().OriginalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1846, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1902, 69, false);
#line 52 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SellingPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2027, 65, false);
#line 55 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2148, 67, false);
#line 58 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2215, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2271, 67, false);
#line 61 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().CGSTAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2394, 67, false);
#line 64 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().SGSTAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2461, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2517, 69, false);
#line 67 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
           Write(Html.DisplayNameFor(model => model.BillingItems.First().PerItemPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 87, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody class=\"itemCollections\">\r\n");
            EndContext();
#line 72 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
         foreach(var model in Model.BillingItems)
        {

            

#line default
#line hidden
            BeginContext(2750, 43, false);
#line 75 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
       Write(Html.Partial("BillingItemViewModel", model));

#line default
#line hidden
            EndContext();
#line 75 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
                                                        ;
         }

#line default
#line hidden
            BeginContext(2808, 918, true);
            WriteLiteral(@"    </tbody>
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

                $('#billDate').datepicker({
            format: 'dd/mm/yyyy',
            autoclose: true,
            todayHighlight: true,
            startDate: '-3d'
        });
        $('#billDate').val('");
            EndContext();
            BeginContext(3727, 34, false);
#line 110 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
                       Write(Model.BillDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3761, 1286, true);
            WriteLiteral(@"');
        });

    $(document).on(""click"", "".btnAdd"", function(){
    var index = $(""table#billingItemsTable tbody tr"").length + 1;

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
        modelJson.CustomerId = parseInt($('[id*=""CustomerId""]').val());");
            WriteLiteral(@"
        modelJson.BillDate = new Date($('#billDate').val());
        modelJson.Items = o;

        var dataJson = JSON.stringify(modelJson);
        var tempp = JSON.stringify({""modelJson"": dataJson});

        $.ajax({
             url:'edit?billNo='+ ");
            EndContext();
            BeginContext(5048, 12, false);
#line 153 "/Volumes/Suresh/VS Code/CoreSRT/CoreSRT/Views/Bills/Edit.cshtml"
                            Write(Model.BillNo);

#line default
#line hidden
            EndContext();
            BeginContext(5060, 1453, true);
            WriteLiteral(@",
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
    $.extend({
        toDictionary: function(query) {
            var parms = {};
            var items = query.split(""&""); // split");
            WriteLiteral(@"
            for (var i = 0; i < items.length; i++) {
                var values = items[i].split(""="");
                var keys = values.shift().split(""."");
                var key = decodeURIComponent(keys[keys.length -1]);
                var value = values.join(""="")
                parms[key] = parseInt(decodeURIComponent(value));
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

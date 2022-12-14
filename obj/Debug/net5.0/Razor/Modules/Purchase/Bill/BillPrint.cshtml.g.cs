#pragma checksum "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c855c6b065d3a25326d3a5141bbfad7a9b0c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Purchase_Bill_BillPrint), @"mvc.1.0.view", @"/Modules/Purchase/Bill/BillPrint.cshtml")]
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
#line 1 "D:\akmal\InvoiceKu\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\akmal\InvoiceKu\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\akmal\InvoiceKu\Modules\_ViewImports.cshtml"
using InvoiceKu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\akmal\InvoiceKu\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\akmal\InvoiceKu\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c855c6b065d3a25326d3a5141bbfad7a9b0c38", @"/Modules/Purchase/Bill/BillPrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239e15e7a4b0f1de762cbb51d9e3ccf8ba4ae064", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Purchase_Bill_BillPrint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvoiceKu.Purchase.BillPrintData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
    Layout = "_LayoutNoNavigation";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"invoice\">\n    <div class=\"row\">\n        <div class=\"col-xs-12\">\n            <h2 class=\"page-header\">\n                VENDOR BILL\n                <small class=\"pull-right\">Print at: ");
#nullable restore
#line 13 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                                               Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </h2>\n        </div>\n    </div>\n    <!-- info row -->\n    <div class=\"row invoice-info\">\n        <div class=\"col-sm-4 invoice-col\">\n            From\n            <address>\n                <strong>");
#nullable restore
#line 22 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                   Write(Model.Vendor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\n                ");
#nullable restore
#line 23 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
           Write(Model.Vendor.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                ");
#nullable restore
#line 24 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
           Write(Model.Vendor.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                              Write(Model.Vendor.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                                                  Write(Model.Vendor.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                Phone: ");
#nullable restore
#line 25 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                  Write(Model.Vendor.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                Email: ");
#nullable restore
#line 26 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                  Write(Model.Vendor.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </address>\n        </div>\n        <!-- /.col -->\n        <div class=\"col-sm-4 invoice-col\">\n            To\n            <address>\n                <strong>");
#nullable restore
#line 33 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                   Write(Model.Company.TenantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\n                ");
#nullable restore
#line 34 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
           Write(Model.Company.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                ");
#nullable restore
#line 35 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
           Write(Model.Company.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                               Write(Model.Company.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                                                    Write(Model.Company.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                Phone: ");
#nullable restore
#line 36 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                  Write(Model.Company.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n                Email: ");
#nullable restore
#line 37 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                  Write(Model.Company.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </address>\n        </div>\n        <!-- /.col -->\n        <div class=\"col-sm-4 invoice-col\">\n            Bill Number:<br>\n            ");
#nullable restore
#line 43 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
       Write(Model.Header.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n            Bill Date:<br>\n            ");
#nullable restore
#line 45 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
       Write(Model.Header.BillDate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n            Amount Bill:<br>\n            ");
#nullable restore
#line 47 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
       Write(Model.Company.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                               Write(Model.Header.Total.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n            Order Number:<br>\n            ");
#nullable restore
#line 49 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
       Write(Model.Header.PurchaseOrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
        <div class=""col-xs-12 table-responsive"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Item</th>
                        <th>Price</th>
                        <th>Qty</th>
                        <th>SubTotal</th>
                        <th>Discount</th>
                        <th>BeforeTax</th>
                        <th>TaxAmt</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 71 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                     foreach (var d in Model.Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 74 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                           Write(d.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 75 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.Price.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 76 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.Qty.ToStringDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 77 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.SubTotal.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 78 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.Discount.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 79 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.BeforeTax.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 80 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.TaxAmount.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 81 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                            Write(d.Total.ToStringDefault("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 83 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /.col -->
    </div>

    <div class=""row"">
        <div class=""col-xs-6"">

        </div>
        <!-- /.col -->
        <div class=""col-xs-6"">
            <p class=""lead"">Summary, in currency ");
#nullable restore
#line 96 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                                            Write(Model.Company.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <div class=\"table-responsive\">\n                <table class=\"table\">\n                    <tr>\n                        <th style=\"width:50%\">Subtotal:</th>\n                        <td>");
#nullable restore
#line 101 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.SubTotal.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Discount:</th>\n                        <td>");
#nullable restore
#line 105 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.Discount.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>BeforeTax:</th>\n                        <td>");
#nullable restore
#line 109 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.BeforeTax.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>TaxAmount:</th>\n                        <td>");
#nullable restore
#line 113 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.TaxAmount.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>OtherCharges:</th>\n                        <td>");
#nullable restore
#line 117 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.OtherCharge.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr>\n                        <th>Total:</th>\n                        <td>");
#nullable restore
#line 121 "D:\akmal\InvoiceKu\Modules\Purchase\Bill\BillPrint.cshtml"
                       Write(Model.Header.Total.Value.ToString("#,##0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                </table>\n            </div>\n        </div>\n    </div>\n</section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvoiceKu.Purchase.BillPrintData> Html { get; private set; }
    }
}
#pragma warning restore 1591

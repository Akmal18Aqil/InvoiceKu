#pragma checksum "D:\akmal\InvoiceKu\Modules\Purchase\VendorContact\VendorContactIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cce4a8391f4e1c33b132282a6aeb773098642fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Purchase_VendorContact_VendorContactIndex), @"mvc.1.0.view", @"/Modules/Purchase/VendorContact/VendorContactIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cce4a8391f4e1c33b132282a6aeb773098642fb", @"/Modules/Purchase/VendorContact/VendorContactIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"239e15e7a4b0f1de762cbb51d9e3ccf8ba4ae064", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Purchase_VendorContact_VendorContactIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\akmal\InvoiceKu\Modules\Purchase\VendorContact\VendorContactIndex.cshtml"
  
    ViewData["Title"] = Localizer.Get("Db.Purchase.VendorContact.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"GridDiv\"></div>\n\n<script type=\"text/javascript\">\n    jQuery(function () {\n        new InvoiceKu.Purchase.VendorContactGrid($(\'#GridDiv\'), {}).init();\n\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\n    });\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

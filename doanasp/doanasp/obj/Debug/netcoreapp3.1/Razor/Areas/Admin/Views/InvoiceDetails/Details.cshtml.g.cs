#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6feed28d8d278fa0d7332b57c98a0453acfaffe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_InvoiceDetails_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/InvoiceDetails/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6feed28d8d278fa0d7332b57c98a0453acfaffe4", @"/Areas/Admin/Views/InvoiceDetails/Details.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_InvoiceDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doanasp.Models.InvoiceDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>InvoiceDetail</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Invoice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Invoice.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 44 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Createddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Createddate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1277, "\"", 1301, 1);
#nullable restore
#line 52 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Details.cshtml"
WriteAttributeValue("", 1292, Model.Id, 1292, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<doanasp.Models.InvoiceDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ac884aa164f8084ae4ac9cc8017009baa17426"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_InvoiceDetails_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/InvoiceDetails/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ac884aa164f8084ae4ac9cc8017009baa17426", @"/Areas/Admin/Views/InvoiceDetails/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_InvoiceDetails_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doanasp.Models.InvoiceDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\InvoiceDetails\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Edit</h2>

<h4>InvoiceDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""InvoiceId"" class=""control-label""></label>
                <select asp-for=""InvoiceId"" class=""form-control"" asp-items=""ViewBag.InvoiceId""></select>
                <span asp-validation-for=""InvoiceId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductId"" class=""control-label""></label>
                <select asp-for=""ProductId"" class=""form-control"" asp-items=""ViewBag.ProductId""></select>
                <span asp-validation-for=""ProductId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
        ");
            WriteLiteral(@"        <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UnitPrice"" class=""control-label""></label>
                <input asp-for=""UnitPrice"" class=""form-control"" />
                <span asp-validation-for=""UnitPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Discount"" class=""control-label""></label>
                <input asp-for=""Discount"" class=""form-control"" />
                <span asp-validation-for=""Discount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Createddate"" class=""control-label""></label>
                <input asp-for=""Createddate"" class=""form-control"" />
                <span asp-validation-for=""Createddate"" class=""text-danger""></span>
            </div>
            ");
            WriteLiteral("<div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
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

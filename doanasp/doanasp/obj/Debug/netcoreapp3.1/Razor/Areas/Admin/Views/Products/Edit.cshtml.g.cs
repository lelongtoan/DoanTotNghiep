#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16cd7c028345115329da1f3d7025d005c70a298d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16cd7c028345115329da1f3d7025d005c70a298d", @"/Areas/Admin/Views/Products/Edit.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doanasp.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Products\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""SKU"" class=""control-label""></label>
                <input asp-for=""SKU"" class=""form-control"" />
                <span asp-validation-for=""SKU"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Descript");
            WriteLiteral(@"ion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Stock"" class=""control-label""></label>
                <input asp-for=""Stock"" class=""form-control"" />
                <span asp-validation-for=""Stock"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProducerId"" class=""control-label""></label>
                <select asp-for=""ProducerId"" class=""form-control"" asp-items=""ViewBag.ProducerId""></select>
                <span asp-validation-for=""ProducerId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductTypeId"" class=""control-lab");
            WriteLiteral(@"el""></label>
                <select asp-for=""ProductTypeId"" class=""form-control"" asp-items=""ViewBag.ProductTypeId""></select>
                <span asp-validation-for=""ProductTypeId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Discount"" class=""control-label""></label>
                <input asp-for=""Discount"" class=""form-control"" />
                <span asp-validation-for=""Discount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label""></label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Createddate"" class=""control-label""></label>
                <input asp-for=""Createddate"" class=""form-control"" />
                <span asp-validation-for=""Createddate""");
            WriteLiteral(" class=\"text-danger\"></span>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"checkbox\">\r\n                    <label>\r\n                        <input asp-for=\"Status\" /> ");
#nullable restore
#line 69 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Products\Edit.cshtml"
                                              Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </label>
                </div>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<doanasp.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5763f6af0bf9628aebf2a71ba7dc19d8631dbf6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductDetails_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductDetails/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5763f6af0bf9628aebf2a71ba7dc19d8631dbf6c", @"/Areas/Admin/Views/ProductDetails/Create.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ProductDetails_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doanasp.Models.ProductDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Create</h2>

<h4>ProductDetail</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Importprice"" class=""control-label""></label>
                <input asp-for=""Importprice"" class=""form-control"" />
                <span asp-validation-for=""Importprice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Importquantity"" class=""control-label""></label>
                <input asp-for=""Importquantity"" class=""form-control"" />
                <span asp-validation-for=""Importquantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Totalprice"" class=""control-label""></label>
                <input asp-for=""Totalprice"" class=""form-control"" />
                <span asp-validation-f");
            WriteLiteral(@"or=""Totalprice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<doanasp.Models.ProductDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

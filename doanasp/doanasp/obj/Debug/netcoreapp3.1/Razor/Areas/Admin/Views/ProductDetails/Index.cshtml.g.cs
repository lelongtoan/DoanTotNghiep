#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d95b1667efe499f363f38b283de7751b82f7b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductDetails_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductDetails/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d95b1667efe499f363f38b283de7751b82f7b7d", @"/Areas/Admin/Views/ProductDetails/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ProductDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<doanasp.Models.ProductDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Importprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Importquantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Importprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Importquantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1001, "\"", 1031, 1);
#nullable restore
#line 40 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 1016, item.ProductId, 1016, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1084, "\"", 1114, 1);
#nullable restore
#line 41 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 1099, item.ProductId, 1099, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1169, "\"", 1199, 1);
#nullable restore
#line 42 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
WriteAttributeValue("", 1184, item.ProductId, 1184, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<doanasp.Models.ProductDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

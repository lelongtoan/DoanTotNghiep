#pragma checksum "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd13a1b36ad201e39dae8b9a12b8970d4e36cfa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Producers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Producers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd13a1b36ad201e39dae8b9a12b8970d4e36cfa3", @"/Areas/Admin/Views/Producers/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<doanasp.Models.Producer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 763, "\"", 786, 1);
#nullable restore
#line 34 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
WriteAttributeValue("", 778, item.Id, 778, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 839, "\"", 862, 1);
#nullable restore
#line 35 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
WriteAttributeValue("", 854, item.Id, 854, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 917, "\"", 940, 1);
#nullable restore
#line 36 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
WriteAttributeValue("", 932, item.Id, 932, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\locph\OneDrive\Documents\DoanTotNghiep\doanasp\doanasp\Areas\Admin\Views\Producers\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<doanasp.Models.Producer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

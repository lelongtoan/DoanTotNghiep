#pragma checksum "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62c73dea2eb318a6a4276814686bc39c8b0260e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Carts_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Carts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62c73dea2eb318a6a4276814686bc39c8b0260e", @"/Areas/Admin/Views/Carts/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Carts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<doanasp.Models.Cart>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 982, "\"", 1005, 1);
#nullable restore
#line 40 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
WriteAttributeValue("", 997, item.Id, 997, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1058, "\"", 1081, 1);
#nullable restore
#line 41 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
WriteAttributeValue("", 1073, item.Id, 1073, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1136, "\"", 1159, 1);
#nullable restore
#line 42 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
WriteAttributeValue("", 1151, item.Id, 1151, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\Carts\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<doanasp.Models.Cart>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

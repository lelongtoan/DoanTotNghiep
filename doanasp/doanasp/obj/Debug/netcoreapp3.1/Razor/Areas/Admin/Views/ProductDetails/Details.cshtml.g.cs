#pragma checksum "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b92169c101478abbc260e9e72198a57375f142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductDetails_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductDetails/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b92169c101478abbc260e9e72198a57375f142", @"/Areas/Admin/Views/ProductDetails/Details.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ProductDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<doanasp.Models.ProductDetail>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>ProductDetail</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Importprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Importprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Importquantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Importquantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 771, "\"", 802, 1);
#nullable restore
#line 34 "C:\Users\ninhx\OneDrive\Documents\GitHub\ASP\doanasp\doanasp\Areas\Admin\Views\ProductDetails\Details.cshtml"
WriteAttributeValue("", 786, Model.ProductId, 786, 16, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<doanasp.Models.ProductDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
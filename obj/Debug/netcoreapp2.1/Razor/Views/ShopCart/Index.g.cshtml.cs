#pragma checksum "E:\web\kursovoi\Kursovoi\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5200c6d75518e8052ee4f982a598683c5f353c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 1 "E:\web\kursovoi\Kursovoi\Views\_ViewImports.cshtml"
using Shop.ViewModels;

#line default
#line hidden
#line 2 "E:\web\kursovoi\Kursovoi\Views\_ViewImports.cshtml"
using Shop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5200c6d75518e8052ee4f982a598683c5f353c9c", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f04dce114dc5162cca525c7f7d4445d1a583e67", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
#line 4 "E:\web\kursovoi\Kursovoi\Views\ShopCart\Index.cshtml"
     foreach (var el in Model.shopCart.listShopItems)
    {

#line default
#line hidden
            BeginContext(115, 78, true);
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Автомобиль:</b>");
            EndContext();
            BeginContext(194, 11, false);
#line 7 "E:\web\kursovoi\Kursovoi\Views\ShopCart\Index.cshtml"
                         Write(el.car.name);

#line default
#line hidden
            EndContext();
            BeginContext(205, 32, true);
            WriteLiteral("<br />\r\n            <b>Цена:</b>");
            EndContext();
            BeginContext(238, 26, false);
#line 8 "E:\web\kursovoi\Kursovoi\Views\ShopCart\Index.cshtml"
                   Write(el.car.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 10 "E:\web\kursovoi\Kursovoi\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(289, 133, true);
            WriteLiteral("    <hr />\r\n    <a class=\"btn btn-danger\" href=\"Order/Checkout\" @*asp-controller=\"Order\" asp-action=\"Checkout\"*@>Оплатить</a>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

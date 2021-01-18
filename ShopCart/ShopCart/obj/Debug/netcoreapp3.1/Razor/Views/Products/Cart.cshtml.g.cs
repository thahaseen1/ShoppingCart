#pragma checksum "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdbe9ee3959d966b6ee45b75a30a043533ea1e3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Cart), @"mvc.1.0.view", @"/Views/Products/Cart.cshtml")]
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
#line 1 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\_ViewImports.cshtml"
using ShopCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\_ViewImports.cshtml"
using ShopCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdbe9ee3959d966b6ee45b75a30a043533ea1e3f", @"/Views/Products/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d27adb5ee7bba6e47abc7ff9c5a5b145ee89e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShopCart.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    decimal totalAmount = 0;
    decimal thisAmount = 0;
    decimal discountAmount = 0;
    decimal amount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cart (");
#nullable restore
#line 11 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n<a><h4 class=\"badge badge-pill badge-danger\">20% off</h4></a>\r\n");
#nullable restore
#line 13 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger text-center\" style=\"font-size:50px;\">Cart Empty</div>\r\n    <p class=\"text-center\">\r\n        <br />\r\n        <a href=\"/Products/Shop\">Continue Shopping!</a>\r\n    </p>\r\n");
#nullable restore
#line 20 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
}
else
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Product Name</th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Amount</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
             foreach (var item in Model)
            {
                thisAmount = (item.Qty * item.Price);
                totalAmount = totalAmount + thisAmount;
                discountAmount = ((totalAmount * 20) / 100);
                amount = (totalAmount - discountAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdbe9ee3959d966b6ee45b75a30a043533ea1e3f7166", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1361, "~/Images/", 1361, 9, true);
#nullable restore
#line 47 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
AddHtmlAttributeValue("", 1370, item.ImageName, 1370, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
AddHtmlAttributeValue("", 1392, item.ProductName, 1392, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
                   Write(thisAmount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbe9ee3959d966b6ee45b75a30a043533ea1e3f10351", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Net Amount</td>\r\n                <td>");
#nullable restore
#line 65 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
               Write(totalAmount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Discount</td>\r\n                <td>");
#nullable restore
#line 69 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
               Write(discountAmount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total Amount</td>\r\n                <td>");
#nullable restore
#line 73 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
               Write(amount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <div class=\"text-center\">\r\n        <a href=\"/Products/Checkout\" class=\"btn btn-success\">Checkout</a>\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\tshaik\source\repos\ShopCart\ShopCart\Views\Products\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Products/Shop\" class=\"alert-info\">Continue Shopping!</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShopCart.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591

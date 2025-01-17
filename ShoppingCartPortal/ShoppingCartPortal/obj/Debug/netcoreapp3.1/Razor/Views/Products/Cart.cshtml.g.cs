#pragma checksum "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be6f690847f75239ff8614ecaaab24fc6bf41a6"
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
#line 1 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\_ViewImports.cshtml"
using ShoppingCartPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\_ViewImports.cshtml"
using ShoppingCartPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be6f690847f75239ff8614ecaaab24fc6bf41a6", @"/Views/Products/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deaad339f0e51b0ab8910a9db6531235f0e75675", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShoppingCartPortal.Models.Cart>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
  
    ViewData["Title"] = "Cart";
    decimal totalAmount = 0;
    decimal thisAmount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cart (");
#nullable restore
#line 9 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
     Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h1>\r\n");
#nullable restore
#line 10 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-danger text-center\" style=\"font-size:50px;\">Baba ji, No items into the Cart!</div>\r\n    <p class=\"text-center\">\r\n        <br />\r\n        <a href=\"/Products/Shop\">Continue Shopping!</a>\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Products/Shop\">Continue Shopping!</a>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Product Name</th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Amount</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
             foreach (var item in Model)
            {
                thisAmount = (item.Quantity * item.Price);
                totalAmount = totalAmount + thisAmount;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4be6f690847f75239ff8614ecaaab24fc6bf41a66359", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1215, "~/Images/", 1215, 9, true);
#nullable restore
#line 43 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
AddHtmlAttributeValue("", 1224, item.ImageName, 1224, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
AddHtmlAttributeValue("", 1246, item.ProductName, 1246, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
                   Write(thisAmount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total</td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
               Write(totalAmount.ToString("00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
            WriteLiteral("    <div class=\"text-center\">\r\n        <a href=\"/Products/Checkout\" class=\"btn btn-success\">Checkout</a>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShoppingCartPortal.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591

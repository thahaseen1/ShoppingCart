#pragma checksum "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d298e9ee98780033d34b000f3a17384ccaa802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_OrderDetails), @"mvc.1.0.view", @"/Views/Products/OrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d298e9ee98780033d34b000f3a17384ccaa802", @"/Views/Products/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deaad339f0e51b0ab8910a9db6531235f0e75675", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartPortal.Models.Order>
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
#line 3 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";

    var orderDetails = (IEnumerable<OrderDetail>)ViewBag.OrderDetails;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order Details</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayFor(model => model.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayFor(model => model.OrderAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
       Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h4>Order Details</h4>\r\n    <table class=\"table table-striped\">\r\n        <tr>\r\n            <td>Id</td><td>Product</td><td>Quantity</td><td>Price</td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
         foreach(var item in orderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
               Write(item.OrderDetailId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
               Write(item.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67d298e9ee98780033d34b000f3a17384ccaa8027810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1495, "~/Images/", 1495, 9, true);
#nullable restore
#line 53 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
AddHtmlAttributeValue("", 1504, item.Product.ImageName, 1504, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
AddHtmlAttributeValue("", 1534, item.Product.ProductName, 1534, 25, false);

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
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 58 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "C:\Users\thahaseen\OneDrive\Desktop\ShoppingCart\ShoppingCartPortal\ShoppingCartPortal\Views\Products\OrderDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartPortal.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7f8390ac3a390b65fe432e1fb2c4d2ac45dfad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
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
#line 1 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7f8390ac3a390b65fe432e1fb2c4d2ac45dfad5", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e02d88a0cbcd052fa09b7068ff937865e00573", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Orders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
  
    var pageName = "Details";
    ViewData["Title"] = pageName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
Write(pageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressLine2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressLine2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 39 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 45 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 51 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 54 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 57 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 63 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 69 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderPlaced));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 72 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderPlaced));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 75 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 78 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n        <dt>\r\n            <br />----- Order\r\n        </dt>\r\n        <dd>\r\n            <br /><b>Details -----</b>\r\n        </dd>\r\n");
#nullable restore
#line 87 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
          decimal subtotal = 0M;

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
         foreach (OrderDetail orderDetail in ViewBag.OrderDetailsList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt>\r\n                ");
#nullable restore
#line 91 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(Html.DisplayNameFor(model => orderDetail.PizzaCust));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 94 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(model => orderDetail.PizzaCust.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 97 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(Html.DisplayNameFor(model => orderDetail.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
#nullable restore
#line 100 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(model => orderDetail.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
#nullable restore
#line 103 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(Html.DisplayNameFor(model => orderDetail.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                    ");
#nullable restore
#line 106 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
               Write(orderDetail.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                Sub Total\r\n            </dt>\r\n            <dd>\r\n");
#nullable restore
#line 112 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
                  subtotal = orderDetail.Price * orderDetail.Amount;

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 113 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
           Write(subtotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                <br />\r\n            </dt>\r\n            <dd>\r\n                <br />\r\n            </dd>\r\n");
#nullable restore
#line 121 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>\r\n            Total Price\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 126 "C:\Users\ssais\OneDrive\Desktop\workshop_2021\FinalProject\benro\Views\Orders\Details.cshtml"
       Write(Model.OrderTotal.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7f8390ac3a390b65fe432e1fb2c4d2ac45dfad515008", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Orders> Html { get; private set; }
    }
}
#pragma warning restore 1591

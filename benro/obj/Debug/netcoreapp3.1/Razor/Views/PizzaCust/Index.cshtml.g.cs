#pragma checksum "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\PizzaCust\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a512125876288a47bafea87b07f40775bb2ba7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PizzaCust_Index), @"mvc.1.0.view", @"/Views/PizzaCust/Index.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a512125876288a47bafea87b07f40775bb2ba7e", @"/Views/PizzaCust/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e02d88a0cbcd052fa09b7068ff937865e00573", @"/Views/_ViewImports.cshtml")]
    public class Views_PizzaCust_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaKnight.Models.PizzaCust>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\PizzaCust\Index.cshtml"
  
    ViewData["Title"] = "Pizza Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h2>Pizza Menu</h2>\r\n<br />\r\n\r\n<h4>All Pizzas</h4>\r\n\r\n<div class=\"PizzaSummaryId\">\r\n");
#nullable restore
#line 15 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\PizzaCust\Index.cshtml"
     foreach (var pizza in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\PizzaCust\Index.cshtml"
   Write(Html.Partial("PizzaSummary", pizza));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\PizzaCust\Index.cshtml"
                                            

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n</div>\r\n<br />\r\n<style>\r\n    .PizzaSummaryId {\r\n        display: grid;\r\n        grid-template-columns: auto auto auto;\r\n        height: 500px;\r\n        padding: 10px;\r\n        margin-bottom: 100px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaKnight.Models.PizzaCust>> Html { get; private set; }
    }
}
#pragma warning restore 1591

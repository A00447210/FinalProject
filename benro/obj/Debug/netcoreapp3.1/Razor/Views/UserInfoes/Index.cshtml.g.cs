#pragma checksum "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89f9723d511b7407a54a2dc1c2150f62ba79325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfoes_Index), @"mvc.1.0.view", @"/Views/UserInfoes/Index.cshtml")]
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
#line 1 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\_ViewImports.cshtml"
using PizzaKnight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89f9723d511b7407a54a2dc1c2150f62ba79325", @"/Views/UserInfoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f731c40b9e07f0dadb974453cba0edeb6483b90", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaKnight.Models.UserInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e89f9723d511b7407a54a2dc1c2150f62ba793253761", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <\r\n        ");
#nullable restore
#line 30 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
         foreach (var item in Model)
        {
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
             if (item.Password == "123")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 39 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1048, "\"", 1077, 1);
#nullable restore
#line 45 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
WriteAttributeValue("", 1063, item.UserName, 1063, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                        <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1138, "\"", 1167, 1);
#nullable restore
#line 46 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
WriteAttributeValue("", 1153, item.UserName, 1153, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                        <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1230, "\"", 1259, 1);
#nullable restore
#line 47 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
WriteAttributeValue("", 1245, item.UserName, 1245, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "\\Mac\Home\Downloads\onelasttime\secondtime_nikita\FinalProject\benro\Views\UserInfoes\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaKnight.Models.UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591

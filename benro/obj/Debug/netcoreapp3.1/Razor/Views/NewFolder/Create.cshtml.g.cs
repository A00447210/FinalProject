#pragma checksum "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\NewFolder\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "623513c282ba0ecc284e60c75b1471144068267b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewFolder_Create), @"mvc.1.0.view", @"/Views/NewFolder/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623513c282ba0ecc284e60c75b1471144068267b", @"/Views/NewFolder/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79e02d88a0cbcd052fa09b7068ff937865e00573", @"/Views/_ViewImports.cshtml")]
    public class Views_NewFolder_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DELL\Desktop\MCDA5510_PROJECT\FinalProject\benro\Views\NewFolder\Create.cshtml"
  
    ViewData["Title"] = "Timer";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <center>
        <div id=""countdown-container"">
            <div id=""countdown"">
                <span id=""days"">0d</span> : <span id=""hours"">0h</span> :
            <span id=""minutes"">0m</span> : <span id=""seconds"">0s</span>
            </div>
        </div>
    </center>

<script>
#countdown - container {
                display: inline - block; /*displays divs on a line*/
                width: 300px; /*gives the div element a width of 300px*/
                margin: 20px 0; /*gives 20px space at the top and bottom of the div element*/
                border - radius: 5px; /*curves the edges of the div element by 5px;*/
                background: #1d81af; /*gives the div element a background color*/
            }
#countdown {
                font - family: ""Fira Sans"", sans - serif; /*changes the text font in the divelement */
                display: inline - block; /*displays divs on a line*/
                padding: 30px; /*creates 30px space between the content of the div ele");
            WriteLiteral(@"ment and the walls of the div element*/
                background: #1d81af;
                color: white; /*changes the text color in the div element*/
            }

            countdown span {
                font - weight: bold; /*boldens text in the span element*/
                font - size: 30px; /*changes the text size in the span element*/
            }
 </script>

<script>
    let days = 0; //starting number of days
    let hours = 0; // starting number of hours
    let minutes = 30; // starting number of minutes
    let seconds = 0; // starting number of seconds

    // converts all to seconds
    let totalSeconds =
        days * 60 * 60 * 24 + hours * 60 * 60 + minutes * 60 + seconds;

    //temporary seconds holder
    let tempSeconds = totalSeconds;

    // calculates number of days, hours, minutes and seconds from a given number of seconds
    const convert = (value, inSeconds) => {
        if (value > inSeconds) {
            let x = value % inSeconds;
           ");
            WriteLiteral(@" tempSeconds = x;
            return (value - x) / inSeconds;
        } else {
            return 0;
        }
    };

    //sets seconds
    const setSeconds = (s) => {
        document.querySelector(""#seconds"").textContent = s + ""s"";
    };

    //sets minutes
    const setMinutes = (m) => {
        document.querySelector(""#minutes"").textContent = m + ""m"";
    };

    //sets hours
    const setHours = (h) => {
        document.querySelector(""#hours"").textContent = h + ""h"";
    };

    //sets Days
    const setDays = (d) => {
        document.querySelector(""#days"").textContent = d + ""d"";
    };

    // Update the count down every 1 second
    var x = setInterval(() => {
        //clears countdown when all seconds are counted
        if (totalSeconds <= 0) {
            clearInterval(x);
        }
        setDays(convert(tempSeconds, 24 * 60 * 60));
        setHours(convert(tempSeconds, 60 * 60));
        setMinutes(convert(tempSeconds, 60));
        setSeconds(tempSeconds ");
            WriteLiteral("== 60 ? 59 : tempSeconds);\r\n        totalSeconds--;\r\n        tempSeconds = totalSeconds;\r\n    }, 1000);\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

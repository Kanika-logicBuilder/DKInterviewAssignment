#pragma checksum "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a1ba0b6e46fe64aebcefc52de54f3dd5ac6525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DK_GetActiveCampaign), @"mvc.1.0.view", @"/Views/DK/GetActiveCampaign.cshtml")]
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
#line 1 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\_ViewImports.cshtml"
using DKInterviewAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\_ViewImports.cshtml"
using DKInterviewAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a1ba0b6e46fe64aebcefc52de54f3dd5ac6525", @"/Views/DK/GetActiveCampaign.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed51bf71af22d12f7da240905ab51254fb90fe41", @"/Views/_ViewImports.cshtml")]
    public class Views_DK_GetActiveCampaign : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< DKInterviewAssignment.Models.CampaingDetalis>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"

    ViewData["Title"] = "ActiveCampaingDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""page-wrapper-inside"">
    <div class=""groups"">
        <div class=""group-wrapper"">
            <h1 class=""group-title""> Active Campaign Details </h1>
            <div class=""group"">
                <div class=""blocks-wrapper row"">
                    
                    <table class=""table full-width"">
                        <thead>
                            <tr>
                                <th>Title</th>
                                <th>Total Amount</th>
                                <th>Backers count </th>
                                <th>End Date </th>
                                <th>Created Date</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 25 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 28 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                                   Write(Html.DisplayFor(modelItem =>item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 29 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.totalAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 30 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.backersCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td> ");
#nullable restore
#line 31 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.endDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 32 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                                   Write(Html.DisplayFor(modelItem =>item.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                   \r\n\r\n                                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\kkala\source\repos\DKInterviewAssignment\DKInterviewAssignment\Views\DK\GetActiveCampaign.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< DKInterviewAssignment.Models.CampaingDetalis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
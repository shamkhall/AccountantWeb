#pragma checksum "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72a603fa8d74c86dbf30b7f744bfcb99b57ab47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Worker_Account), @"mvc.1.0.view", @"/Views/Worker/Account.cshtml")]
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
#line 1 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72a603fa8d74c86dbf30b7f744bfcb99b57ab47", @"/Views/Worker/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60f5e31f32e5dfe6764f5bb1f1e68533606a2df", @"/Views/_ViewImports.cshtml")]
    public class Views_Worker_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 style=\"text-align: center;color: black\">");
#nullable restore
#line 1 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                       Write(localizer["Own"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>


<div class=""card-body"">
    <div class=""row"">

        <div class=""col-lg"">

            <div class=""table-responsive border-bottom"" data-toggle=""lists"" data-lists-values=""[&quot;js-lists-values-employee-name&quot;]"">


                <table class=""table mb-0"">
                    <thead>
                    <tr>

                        <th style=""width: 100px;"">");
#nullable restore
#line 16 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                             Write(localizer["Income"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        <th style=\"width: 100px;\">");
#nullable restore
#line 18 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                             Write(localizer["Expenses"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th style=\"width: 100px;\">");
#nullable restore
#line 19 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                             Write(localizer["Profit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th style=\"width: 100px;\">");
#nullable restore
#line 20 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                             Write(localizer["ReceiptAmount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>

                    </tr>
                    </thead>
                    <tbody class=""list"" id=""search"">

                    <tr>

                        <td>

                            <span class=""js-lists-values-employee-name"">
                                ");
#nullable restore
#line 31 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                           Write(ViewBag.ProfitResult);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Manat\r\n\r\n                            </span>\r\n\r\n                        </td>\r\n\r\n                        <td>\r\n                            <span class=\"js-lists-values-employee-name\">");
#nullable restore
#line 38 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                                                   Write(ViewBag.ExpencesResult);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Manat</span>\r\n\r\n");
            WriteLiteral("                        </td>\r\n\r\n                        <td>\r\n");
#nullable restore
#line 44 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                              
                                string color = "green";
                                if (ViewBag.GainResult < 0)
                                {
                                    color = "red";
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"js-lists-values-employee-name\"");
            BeginWriteAttribute("style", " style=\"", 1764, "\"", 1785, 2);
            WriteAttributeValue("", 1772, "color:", 1772, 6, true);
#nullable restore
#line 51 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
WriteAttributeValue(" ", 1778, color, 1779, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                                                                         Write(ViewBag.GainResult);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Manat</span>\r\n\r\n                        </td>\r\n\r\n                        <td>\r\n                            <span class=\"js-lists-values-employee-name\">");
#nullable restore
#line 56 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Worker\Account.cshtml"
                                                                   Write(ViewBag.ReceiptCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                        </td>\r\n\r\n\r\n");
            WriteLiteral("\r\n                    </tr>\r\n\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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

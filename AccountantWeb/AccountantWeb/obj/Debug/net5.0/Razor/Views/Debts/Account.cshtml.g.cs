#pragma checksum "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Debts\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2de55045eb67749071f58823a13ca07ec5ca78e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Debts_Account), @"mvc.1.0.view", @"/Views/Debts/Account.cshtml")]
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
#line 1 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\_ViewImports.cshtml"
using AccountantWeb.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Debts\Account.cshtml"
using Microsoft.EntityFrameworkCore.Metadata.Internal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2de55045eb67749071f58823a13ca07ec5ca78e", @"/Views/Debts/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60f5e31f32e5dfe6764f5bb1f1e68533606a2df", @"/Views/_ViewImports.cshtml")]
    public class Views_Debts_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccountantWeb.Models.DebtsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"



<div class=""card-body"">
    <div class=""row"">

        <div class=""col-lg"">

            <div class=""table-responsive border-bottom"" data-toggle=""lists"" data-lists-values=""[&quot;js-lists-values-employee-name&quot;]"">


                <table class=""table mb-0"">
                    <thead>
                    <tr>

                        <th style=""width:auto;"">Borc Məbləği</th>

                        <th style=""width: auto;"">Ödənilmiş Məbləğ</th>
                       
                        <th style=""width: auto;"">Qəbz Sayı</th>
                        
                    </tr>
                    </thead>
                    <tbody class=""list"" id=""search"">

                    <tr>

                        <td>

                            <span class=""js-lists-values-employee-name"">
                                
                                

                            </span>

                        </td>

                        <td>
           ");
            WriteLiteral("                 <span class=\"js-lists-values-employee-name\"> </span>\r\n\r\n");
            WriteLiteral("                        </td>\r\n\r\n                        <td>\r\n                            \r\n                            <span class=\"js-lists-values-employee-name\" > ");
#nullable restore
#line 49 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Debts\Account.cshtml"
                                                                     Write(ViewBag.ReceiptCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                        </td>

                        <td>
                            <span class=""js-lists-values-employee-name""></span>

                        </td>
                        <td>
                            <span class=""js-lists-values-employee-name""></span>

                        </td>
                        

                    </tr>


                    </tbody>
                </table>
            </div>

        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccountantWeb.Models.DebtsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
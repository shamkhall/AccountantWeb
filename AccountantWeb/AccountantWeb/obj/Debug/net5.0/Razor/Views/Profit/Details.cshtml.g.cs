#pragma checksum "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84306c3202dc0059701ae3da3616b19b89d5e253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profit_Details), @"mvc.1.0.view", @"/Views/Profit/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84306c3202dc0059701ae3da3616b19b89d5e253", @"/Views/Profit/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60f5e31f32e5dfe6764f5bb1f1e68533606a2df", @"/Views/_ViewImports.cshtml")]
    public class Views_Profit_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Profit>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-Danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Bax</h1>\r\n\r\n<div class=\"card card-body\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral("        <div class=\"col-lg-8 d-flex align-items-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84306c3202dc0059701ae3da3616b19b89d5e2536185", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>Ad:</h3>\r\n                    <h5>");
#nullable restore
#line 17 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>Müəllif:</h3>\r\n                    <h5>");
#nullable restore
#line 23 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <h3>Tarix:</h3>\r\n                    <h5>");
#nullable restore
#line 28 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>Məbləğ:</h3>\r\n                    <h5>");
#nullable restore
#line 33 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <h3>Valyuta:</h3>\r\n                    <h5>");
#nullable restore
#line 40 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Currency);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <h3>Status:</h3>\r\n                    <h5>");
#nullable restore
#line 48 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>Rəy:</h3>\r\n                    <h5>");
#nullable restore
#line 55 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Comment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>Şəxsi:</h3>\r\n                    <h5>");
#nullable restore
#line 63 "F:\Desktop\Accountant\Accountant\AccountantWeb\AccountantWeb\Views\Profit\Details.cshtml"
                   Write(Model.Own);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <br/>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84306c3202dc0059701ae3da3616b19b89d5e2539685", async() => {
                    WriteLiteral("Ana Səhifə");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Profit> Html { get; private set; }
    }
}
#pragma warning restore 1591

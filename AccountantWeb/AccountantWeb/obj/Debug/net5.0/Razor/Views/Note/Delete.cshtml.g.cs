#pragma checksum "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7b2777879a498b5b7287dfa157f7579fdfe196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Delete), @"mvc.1.0.view", @"/Views/Note/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7b2777879a498b5b7287dfa157f7579fdfe196", @"/Views/Note/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60f5e31f32e5dfe6764f5bb1f1e68533606a2df", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccountantWeb.Models.NoteModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "note", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
Write(localizer["CreateReceipt"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"card card-body\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral("        <div class=\"col-lg-8 d-flex align-items-center\">\r\n            <div class=\"flex\" asp-controller=\"home\" asp-action=\"index\" method=\"post\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a7b2777879a498b5b7287dfa157f7579fdfe1966252", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>");
#nullable restore
#line 20 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(localizer["Author"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n                    <h5>");
#nullable restore
#line 21 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    <h3>");
#nullable restore
#line 26 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(localizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n                    <h5>");
#nullable restore
#line 27 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <h3>");
#nullable restore
#line 31 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(localizer["Date"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n                    <h5>");
#nullable restore
#line 32 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n\r\n\r\n                    <h3>");
#nullable restore
#line 38 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(localizer["Note"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</h3>\r\n                    <h5>");
#nullable restore
#line 39 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                   Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n                </div>\r\n\r\n                <br/>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7b2777879a498b5b7287dfa157f7579fdfe19610470", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a7b2777879a498b5b7287dfa157f7579fdfe19610749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1624, "\"", 1659, 1);
#nullable restore
#line 47 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
WriteAttributeValue("", 1632, localizer["CreateReceipt"], 1632, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\"/>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a7b2777879a498b5b7287dfa157f7579fdfe19612947", async() => {
#nullable restore
#line 48 "C:\repos\Prestij724\AccountantWeb\AccountantWeb\AccountantWeb\Views\Note\Delete.cshtml"
                                                                                  Write(localizer["Back"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountantWeb.Models.NoteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

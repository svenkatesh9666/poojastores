#pragma checksum "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eac1341b0f0da25cbec3079ea05e8af7a4a43d10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authenticate_ResetPassword), @"mvc.1.0.view", @"/Views/Authenticate/ResetPassword.cshtml")]
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
#line 1 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\PoojaStores13042023\trunk\PoojaStores\Views\_ViewImports.cshtml"
using PoojaStores.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eac1341b0f0da25cbec3079ea05e8af7a4a43d10", @"/Views/Authenticate/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16fd5e81157aaadf292c89301cd5c1be8ee9a165", @"/Views/_ViewImports.cshtml")]
    public class Views_Authenticate_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PoojaStores.Models.ModelClasses.PasswordChangeRequest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Authenticate/ResetPassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main class=""main"">
    <div class=""container login-container mt-4"">
        <div class=""row"">
            <div class=""col-lg-10 mx-auto"">
                <div class=""row"">
                    <div class=""col-md-3""></div>
                    <div class=""col-md-6"">
                        <div class=""heading mb-1"">
                            <h4 class=""title"">Reset Your Password</h4>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eac1341b0f0da25cbec3079ea05e8af7a4a43d104591", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 732, "\"", 753, 1);
#nullable restore
#line 15 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
WriteAttributeValue("", 740, Model.UserId, 740, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <label for=""login-email"">
                                Otp Sent to mobile
                                <span class=""required"">*</span>
                            </label>
                            <input type=""text"" name=""key"" placeholder=""OTP""");
                BeginWriteAttribute("required", " required=\"", 1044, "\"", 1055, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1056, "\"", 1074, 1);
#nullable restore
#line 20 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
WriteAttributeValue("", 1064, Model.key, 1064, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-input form-wide\">\r\n                            ");
#nullable restore
#line 21 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
                       Write(Html.ValidationMessageFor(a => a.key, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <label for=""login-email"">
                                Enter New Password
                                <span class=""required"">*</span>
                            </label>
                            <input type=""password"" name=""password"" placeholder=""**********""");
                BeginWriteAttribute("required", " required=\"", 1514, "\"", 1525, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1526, "\"", 1549, 1);
#nullable restore
#line 26 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
WriteAttributeValue("", 1534, Model.password, 1534, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-input form-wide\">\r\n                            ");
#nullable restore
#line 27 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
                       Write(Html.ValidationMessageFor(a => a.password, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <label for=""login-email"">
                                Re-Enter Password
                                <span class=""required"">*</span>
                            </label>
                            <input type=""password"" name=""confirmPassword"" placeholder=""**********""");
                BeginWriteAttribute("required", " required=\"", 2000, "\"", 2011, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2012, "\"", 2042, 1);
#nullable restore
#line 32 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
WriteAttributeValue("", 2020, Model.confirmPassword, 2020, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-input form-wide\">\r\n                            ");
#nullable restore
#line 33 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
                       Write(Html.ValidationMessageFor(a => a.confirmPassword, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("                            <div>\r\n                                <span class=\"text-danger\">\r\n                                    ");
#nullable restore
#line 44 "J:\PoojaStores13042023\trunk\PoojaStores\Views\Authenticate\ResetPassword.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                            <div class=\"form-footer\">\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <button type=""submit"" class=""btn btn-dark btn-md w-100"">
                                        Reset
                                    </button>
                                </div>
");
                WriteLiteral("                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-3\"></div>\r\n");
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PoojaStores.Models.ModelClasses.PasswordChangeRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
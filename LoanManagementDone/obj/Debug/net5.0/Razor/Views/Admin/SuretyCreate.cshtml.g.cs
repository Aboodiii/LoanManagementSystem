#pragma checksum "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecd55ad80805cf9df09bff602d86e7f8df86a26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SuretyCreate), @"mvc.1.0.view", @"/Views/Admin/SuretyCreate.cshtml")]
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
#line 1 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\_ViewImports.cshtml"
using LoanManagementDone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecd55ad80805cf9df09bff602d86e7f8df86a26d", @"/Views/Admin/SuretyCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_SuretyCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementDone.Models.Surety>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/customer/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Create</h2>\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 16 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Surety</h4>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd55ad80805cf9df09bff602d86e7f8df86a26d4911", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control", id = "firstname" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.MiddleName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.MiddleName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.MiddleName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 42 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 50 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.DateOfBirth, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.DateOfBirth, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 53 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.DateOfBirth, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    Male:   ");
#nullable restore
#line 60 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
                       Write(Html.RadioButton("Gender", "Male"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    Female: ");
#nullable restore
#line 61 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
                       Write(Html.RadioButton("Gender", "Female"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 67 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.PhoneNumberOne, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 69 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.PhoneNumberOne, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 70 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.PhoneNumberOne, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 75 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.PhoneNumberTwo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 77 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.PhoneNumberTwo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 78 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.PhoneNumberTwo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 83 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 85 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 86 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 91 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.Occupation, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.Occupation, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 94 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.Occupation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 99 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.IdType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 101 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.IdType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 102 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.IdType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 107 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.IdNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 109 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.IdNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 110 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.IdNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 115 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.IdIssuedDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 117 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.IdIssuedDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 118 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.IdIssuedDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 123 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.ExpiryDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 125 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.ExpiryDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 126 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.ExpiryDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 131 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.Income, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 133 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.Income, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 134 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.Income, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 138 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
           Write(Html.LabelFor(model => model.SuretyId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 140 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.EditorFor(model => model.SuretyId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 141 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
               Write(Html.ValidationMessageFor(model => model.SuretyId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n        ");
            }
            );
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
            WriteLiteral(@"

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" /> | <a href=""/Admin/Create"" class=""btn btn-info btn-rounded""><i class=""bi bi-eye""></i>Back to list</a>
            </div>
        </div>
    </div>
");
#nullable restore
#line 155 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\SuretyCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementDone.Models.Surety> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

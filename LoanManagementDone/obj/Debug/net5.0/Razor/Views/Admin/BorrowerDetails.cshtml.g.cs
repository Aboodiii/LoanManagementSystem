#pragma checksum "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4861d5b431d369161dbc215c9890527528e3731d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_BorrowerDetails), @"mvc.1.0.view", @"/Views/Admin/BorrowerDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4861d5b431d369161dbc215c9890527528e3731d", @"/Views/Admin/BorrowerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b5dd3ec496b1a6ca3ba26a22fe51978d75a289", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_BorrowerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanManagementDone.Models.MultipleAdminView>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
  
    ViewBag.Title = "HandleLoanApplications";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
  
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<h3>Borrower Details</h3>\r\n<table class=\"table table-hover\">\r\n\r\n\r\n\r\n\r\n    <tr>\r\n        <th>Customer ID</th>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.CustomerAdminview.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Customer Name</th>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
        Write(Model.CustomerAdminview.FirstName + " " + Model.CustomerAdminview.MiddleName + " " + Model.CustomerAdminview.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Customer Phone Number 1</th>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.CustomerAdminview.PhoneNumberOne);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Customer Phone Number 2</th>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.CustomerAdminview.PhoneNumberTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Total To Be Paid</th>\r\n        <td>");
#nullable restore
#line 41 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.LoanApplicationAdminView.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Loan Type</th>\r\n        <td>");
#nullable restore
#line 45 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.LoanTypesAdminView.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <th>Loan Approval Date</th>\r\n        <td>");
#nullable restore
#line 50 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.LoanApplicationAdminView.LoanApplicationApprovedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Payment Date</th>\r\n        <td>");
#nullable restore
#line 54 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.LoanApplicationAdminView.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <th>Payment Status</th>\r\n        <td>");
#nullable restore
#line 60 "C:\Users\Abdellah\Documents\LoanManagementDone\LoanManagementDone\Views\Admin\BorrowerDetails.cshtml"
       Write(Model.LoanApplicationAdminView.PaymentStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n\r\n<a href=\"/Admin/BorrowerList\" class=\"btn btn-info\">Back to home Page</a>\r\n\r\n\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanManagementDone.Models.MultipleAdminView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

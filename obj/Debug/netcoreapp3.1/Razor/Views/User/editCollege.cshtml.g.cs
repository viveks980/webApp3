#pragma checksum "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66596c3509a584b99e0a499d4e2f5d7c164fb00d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_editCollege), @"mvc.1.0.view", @"/Views/User/editCollege.cshtml")]
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
#line 1 "C:\Users\vivek\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vivek\source\repos\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66596c3509a584b99e0a499d4e2f5d7c164fb00d", @"/Views/User/editCollege.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_User_editCollege : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.getCollege>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:15%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("roleForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:15px;padding:5%;background:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:antiquewhite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
  
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66596c3509a584b99e0a499d4e2f5d7c164fb00d5691", async() => {
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <script src=""https://code.jquery.com/jquery-3.6.4.min.js""></script>


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66596c3509a584b99e0a499d4e2f5d7c164fb00d7179", async() => {
                WriteLiteral("\r\n\r\n    <nav style=\"padding: 0px; background-color: #0c4da2\" class=\"navbar navbar-expand-lg bg-body-tertiary\">\r\n        <div class=\"container-fluid\">\r\n            <a class=\"navbar-brand\" href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66596c3509a584b99e0a499d4e2f5d7c164fb00d7647", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link"" style=""color:white""");
                BeginWriteAttribute("href", " href=\"", 1466, "\"", 1506, 1);
#nullable restore
#line 27 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 1473, Url.Action("GetRoleList","User"), 1473, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&nbsp;Role &nbsp; Master</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 1682, "\"", 1721, 1);
#nullable restore
#line 31 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 1689, Url.Action("GetDepList","User"), 1689, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Department Master</a>\r\n                    </li>\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 1888, "\"", 1931, 1);
#nullable restore
#line 34 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 1895, Url.Action("GetStudentList","User"), 1895, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Student Master</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n\r\n                        <a class=\"nav-link\" style=\"margin-left: 720px; color: white\"");
                BeginWriteAttribute("href", " href=\"", 2109, "\"", 2148, 1);
#nullable restore
#line 38 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 2116, Url.Action("display","Project"), 2116, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Logout</a>\r\n\r\n                    </li>\r\n\r\n                </ul>\r\n\r\n            </div>\r\n        </div>\r\n    </nav>\r\n\r\n\r\n    <div style=\"padding:3%\" class=\"container mt-5 w-50\">\r\n\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66596c3509a584b99e0a499d4e2f5d7c164fb00d11750", async() => {
                    WriteLiteral("\r\n            <div class=\"d-none\"><input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 2468, "\"", 2489, 1);
#nullable restore
#line 53 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 2476, Model.clg_id, 2476, 13, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"form-control\" id=\"clg_id\" name=\"clg_id\" required></div>\r\n            <h2 class=\"mb-4\">College Master Form</h2>\r\n            <div class=\"form-group\">\r\n                <label for=\"roleName\">College Name:</label>\r\n                <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 2743, "\"", 2769, 1);
#nullable restore
#line 57 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 2751, Model.CollegeName, 2751, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control"" id=""cglName"" name=""CollegeName"" required>
            </div>

            <div class=""form-group"">
                <label for=""roleDesignation"">College Fees:</label>
                <input type=""text"" class=""form-control"" id=""fees""");
                    BeginWriteAttribute("value", " value=\"", 3028, "\"", 3047, 1);
#nullable restore
#line 62 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 3036, Model.fees, 3036, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"fees\" required>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"roleDesignation\">Admission Date :</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"AddmissionDate\"");
                    BeginWriteAttribute("value", " value=\"", 3276, "\"", 3328, 1);
#nullable restore
#line 66 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
WriteAttributeValue("", 3284, Model.AddmissionDate.ToString("dd/MM/yyyy"), 3284, 44, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"AddmissionDate\" readonly>\r\n            </div><br />\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"Student Name\" class=\"form-label\">\r\n\r\n                    Student Name\r\n\r\n                </label>\r\n\r\n                ");
#nullable restore
#line 76 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
           Write(Html.DropDownList("stu_Name", ViewBag.stuname as SelectList, Model.firstName, new { @class = "formcheck", id = "studentId" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"Brnach Name\" class=\"form-label\">\r\n\r\n                    Branch Name\r\n\r\n                </label>\r\n\r\n                ");
#nullable restore
#line 87 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
           Write(Html.DropDownList("branch", ViewBag.DepBranch as SelectList, Model.branchName, new { @class = "formcheck", id = "branchId" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"Role Designation\" class=\"form-label\">\r\n\r\n                    Role Designation\r\n\r\n                </label>\r\n\r\n                ");
#nullable restore
#line 98 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
           Write(Html.DropDownList("desination", ViewBag.roleDes as SelectList, Model.Role_designation, new { @class = "formcheck", id = "Role_id" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"form-check\">\r\n                    <input type=\"checkbox\" class=\"form-check-input\" id=\"Payment\" name=\"Is_Payment\" ");
#nullable restore
#line 103 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
                                                                                               Write(Model.Is_Payment ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@">
                    <label class=""form-check-label"" for=""isActive"">Is Payment</label>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""form-check"">
                    <input type=""checkbox"" class=""form-check-input"" id=""isActive"" name=""Is_active"" ");
#nullable restore
#line 109 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editCollege.cshtml"
                                                                                               Write(Model.Is_active ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(@">

                    <label class=""form-check-label"" for=""isActive"">Is Active</label>
                </div>
            </div> <br />
            <br />

            <button id=""update"" type=""submit"" style=""background-color: #0c4da2"" class=""btn btn-primary"">Update</button>
            <button id=""cancel"" class=""btn btn-secondary"">Cancel</button>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>
<script>
    $(document).ready(function () {
        $('#update').click(function (e) {
            e.preventDefault(); // Prevent the default form submission




            let clg_id = $('#clg_id').val();
            debugger;
            let CollegeName = $('#cglName').val();
            let fees = $('#fees').val();
            let AddmissionDate = $('#AddmissionDate').val();
            let StudentName = $('#studentId').val();
            let branchName = $('#branchId').val();
            let RoleDesignation = $('#Role_id').val();
            let Is_active = $('#isActive').prop('checked');
            let Is_Payment = $('#Payment').prop('checked');


            
            let obj = {
                clg_id: clg_id,
                CollegeName: CollegeName,
                fees: fees,
                AddmissionDate: AddmissionDate,
                StudentName: StudentName,
                branchName: branchName,
                RoleDesignation: RoleDesignation,
  ");
            WriteLiteral(@"              Is_active: Is_active,
                Is_Payment: Is_Payment
            };

            $.ajax({
                url: ""/User/updateCollege"",
                type: ""POST"",
                data: obj,
                success: function (data) {
                    alert(""Data updated successfully...!!"");
                    location.reload();
                    window.location.href = ""GetAddmissionList""
                },
                error: function (err) {
                    console.error(err.message);
                    return;
                },
            });
        });
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.getCollege> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_editStudent), @"mvc.1.0.view", @"/Views/User/editStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e3", @"/Views/User/editStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_User_editStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication3.Models.StudentModel>
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
#line 2 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e35710", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>editStudent</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e37080", async() => {
                WriteLiteral("\r\n\r\n    <nav style=\"padding: 0px; background-color: #0c4da2\" class=\"navbar navbar-expand-lg bg-body-tertiary\">\r\n        <div class=\"container-fluid\">\r\n            <a class=\"navbar-brand\" href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e37548", async() => {
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
                BeginWriteAttribute("href", " href=\"", 1367, "\"", 1401, 1);
#nullable restore
#line 27 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 1374, Url.Action("Index","User"), 1374, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&nbsp;Role &nbsp; Master</a>\r\n\r\n                    </li>\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 1577, "\"", 1623, 1);
#nullable restore
#line 31 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 1584, Url.Action("Department_master","User"), 1584, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Department Master</a>\r\n                    </li>\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 1790, "\"", 1833, 1);
#nullable restore
#line 34 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 1797, Url.Action("Student_master","User"), 1797, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Student Master</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n\r\n                        <a class=\"nav-link\" style=\"margin-left: 720px; color: white\"");
                BeginWriteAttribute("href", " href=\"", 2011, "\"", 2046, 1);
#nullable restore
#line 38 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 2018, Url.Action("Login","Login"), 2018, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Logout</a>

                    </li>

                </ul>

            </div>
        </div>
    </nav>

    <div style=""padding:3%"" class=""container mt-5 w-50"">

        <h2 style=""color: #19234F;margin-left:25%;""><b>Student Master</b></h2>
        <div class=""d-none""><input type=""text""");
                BeginWriteAttribute("value", " value=\"", 2352, "\"", 2376, 1);
#nullable restore
#line 51 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 2360, Model.studentId, 2360, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" id=\"studentId\" name=\"branchName\" required></div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf9c6a7032b8b0432d9d08f10a6f63e415e5e7e312208", async() => {
                    WriteLiteral("\r\n\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"firstName\" class=\"form-label\"><b>First Name</b></label>\r\n\r\n                <input type=\"text\" class=\"form-control\" id=\"firstName\" name=\"firstName\"");
                    BeginWriteAttribute("value", " value=\"", 2747, "\"", 2771, 1);
#nullable restore
#line 59 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 2755, Model.firstName, 2755, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required>\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"session\" class=\"form-label\"><b>Session</b></label>\r\n\r\n                <input type=\"text\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 2983, "\"", 3005, 1);
#nullable restore
#line 69 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 2991, Model.session, 2991, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"session\" name=\"session\" required>\r\n\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"email\" class=\"form-label\"><b>Email</b></label>\r\n\r\n                <input type=\"email\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3238, "\"", 3258, 1);
#nullable restore
#line 77 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 3246, Model.email, 3246, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"email\" name=\"email\" required>\r\n\r\n            </div>\r\n\r\n            <div class=\"mb-3\">\r\n\r\n                <label for=\"phoneNo\" class=\"form-label\"><b>Phone Number</b></label>\r\n\r\n                <input type=\"tel\" class=\"form-control\"");
                    BeginWriteAttribute("value", " value=\"", 3494, "\"", 3516, 1);
#nullable restore
#line 85 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 3502, Model.phoneNo, 3502, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" id=\"phoneNo\" name=\"phoneNo\" required>\r\n\r\n            </div>\r\n\r\n            <div class=\"mb-3 form-check\" style=\"display:flex;\">\r\n\r\n                <input type=\"checkbox\" class=\"form-check-input\" id=\"isActive\" name=\"isActive\" ");
#nullable restore
#line 91 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
                                                                                          Write(Model.isActive ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(">&nbsp;&nbsp;\r\n\r\n                <label class=\"form-check-label\"");
                    BeginWriteAttribute("value", " value=\"", 3840, "\"", 3863, 1);
#nullable restore
#line 93 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 3848, Model.isActive, 3848, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" for=\"isActive\"><b>Is Active</b></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n\r\n                <input type=\"checkbox\" class=\"form-check-input\" id=\"isDeleted\" name=\"isDeleted\" ");
#nullable restore
#line 95 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
                                                                                            Write(Model.isDeleted ? "checked" : "");

#line default
#line hidden
#nullable disable
                    WriteLiteral(">&nbsp;&nbsp;\r\n               \r\n                <label class=\"form-check-label\"");
                    BeginWriteAttribute("value", " value=\"", 4178, "\"", 4202, 1);
#nullable restore
#line 97 "C:\Users\vivek\source\repos\WebApplication3\Views\User\editStudent.cshtml"
WriteAttributeValue("", 4186, Model.isDeleted, 4186, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" for=""isDeleted""><b>Is Deleted</b></label>

            </div>

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
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
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




            let studentId = $('#studentId').val();
            debugger;
            let firstName = $('#firstName').val();
            let session = $('#session').val();
            let email = $('#email').val();
            let phoneNo = $('#phoneNo').val();
            let isActive = $('#isActive').prop('checked');
            let isDeleted = $('#isDeleted').prop('checked');



            let obj = {
                studentId: studentId,
                firstName: firstName,
                session: session,
                email: email,
                phoneNo: phoneNo,
                isActive: isActive,
                isDeleted: isDeleted
            };

            $.ajax({
                url: ""/User/updateStudent"",
                type: ""POST"",
                data: obj,
                success: ");
            WriteLiteral(@"function (data) {
                    alert(""Data updated successfully...!!"");
                    location.reload();
                    window.location.href =""GetStudentList""
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication3.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c5fafd598a8fbc389acccb396489bd9a729a17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetRoleList), @"mvc.1.0.view", @"/Views/User/GetRoleList.cshtml")]
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
#line 2 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c5fafd598a8fbc389acccb396489bd9a729a17", @"/Views/User/GetRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:15%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
   ViewBag.Title = "roleList"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c5fafd598a8fbc389acccb396489bd9a729a174521", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Signup Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.17.3/xlsx.full.min.js""></script>
    <script src=""https://code.jquery.com/jquery-3.6.4.min.js""></script>
    
    <script src=""https://cdn.rawgit.com/rainabba/jquery-table2excel/1.1.0/dist/jquery.table2excel.min.js""></script>

    <style>

        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            align-items: center;
            justify-content: center;
        }

        nav {
            background-color: #0c4da2;
        }

        .nav-link {
            color: white;
        }

            .nav-link:hover {
         ");
                WriteLiteral(@"       color: darkorange;
            }

        form {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 50%;
            margin-top: 4%;
        }

        label {
            display: block;
            margin-bottom: 8px;
        }

        input {
            width: 100%;
            padding: 8px;
            margin-bottom: 12px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        button {
            background-color: #0c4da2;
            color: #fff;
            padding: 10px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

            button:hover {
                background-color: darkorange;
            }

        span {
            color: red;
        }

        .navbarCenter {
            display: flex;
            align-items: center;
            justify-content");
                WriteLiteral(": space-between;\n            margin-left: 90px;\n        }\n    </style>\n\n");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9c5fafd598a8fbc389acccb396489bd9a729a177700", async() => {
                WriteLiteral("\n    <nav style=\"padding: 0px; background-color: #0c4da2\" class=\"navbar navbar-expand-lg bg-body-tertiary\">\n        <div class=\"container-fluid\">\n            <a class=\"navbar-brand\" href=\"#\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9c5fafd598a8fbc389acccb396489bd9a729a178158", async() => {
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
                BeginWriteAttribute("href", " href=\"", 3063, "\"", 3103, 1);
#nullable restore
#line 101 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
WriteAttributeValue("", 3070, Url.Action("GetRoleList","User"), 3070, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&nbsp;Role &nbsp; Master</a>\n\n                    </li>\n                    <li class=\"nav-item dropdown\">\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 3275, "\"", 3314, 1);
#nullable restore
#line 105 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
WriteAttributeValue("", 3282, Url.Action("GetDepList","User"), 3282, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Department Master</a>\n                    </li>\n                    <li class=\"nav-item dropdown\">\n                        <a class=\"nav-link\" style=\"color:white\"");
                BeginWriteAttribute("href", " href=\"", 3478, "\"", 3521, 1);
#nullable restore
#line 108 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
WriteAttributeValue("", 3485, Url.Action("GetStudentList","User"), 3485, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Student Master</a>\n                    </li>\n                    <li class=\"nav-item\">\n\n                        <a class=\"nav-link\" style=\"margin-left: 720px; color: white\"");
                BeginWriteAttribute("href", " href=\"", 3695, "\"", 3734, 1);
#nullable restore
#line 112 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
WriteAttributeValue("", 3702, Url.Action("display","Project"), 3702, 32, false);

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

    <div class=""container mt-5"">

        <h2>Role  Table</h2>
        <button class=""btn btn-success"" onclick=""exportfn()"">Export to Excel</button>


        <table id=""tbl"" class=""table table-striped table-hover"">

            <thead>

                <tr>

                    <th scope=""col"">Role ID</th>
                    <th scope=""col"">Role Name</th>
                    <th scope=""col"">Role Designation</th>
                    <th scope=""col"">Created Date</th>
                    <th scope=""col"">Is Active</th>
                    <th>
                        <a class=""fs-3  p-2 text-white bg-secondary  text-decoration-none"" href=""/User/Role_master"">+ </a>
                    </th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 146 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
                 foreach (var item in Model as List<RoleModel>)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 149 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
       Write(item.Role_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td>");
#nullable restore
#line 150 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
       Write(item.Role_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td>");
#nullable restore
#line 151 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
       Write(item.Role_designation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td>");
#nullable restore
#line 152 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
       Write(item.created_date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td>");
#nullable restore
#line 153 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
       Write(item.Is_active);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td> ");
#nullable restore
#line 154 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
        Write(Html.ActionLink("Edit", "editRole", new { Role_id = item.Role_id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        <td><button class=\"btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5088, "\"", 5121, 3);
                WriteAttributeValue("", 5098, "deletefn(", 5098, 9, true);
#nullable restore
#line 155 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
WriteAttributeValue("", 5107, item.Role_id, 5107, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5120, ")", 5120, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button></td>\n    </tr>\n");
#nullable restore
#line 157 "C:\Users\vivek\source\repos\WebApplication3\Views\User\GetRoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </tbody>\n\n        </table>\n\n    </div>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
    function deletefn(Role_id) {


        console.log(Role_id)
        console.log(""btnClick"")

        var a = confirm(""Sure You Want to Delete The data..!!"")
        if (a == true) {


            $.ajax({

                url: ""/User/deleteRole?Role_id="" + Role_id,

                type: ""POST"",

                // debugger;

                success: function (data) {

                    alert(""Data Deleted success Fully...!!!"");

                    location.reload();

                },

                error: function (err) {

                    console.error(err.message);
                    return;


                },

            });

        }


    }
</script>
<script>
    function exportfn() {
        
        var tableData = [];
        $('table tbody tr').each(function (rowIndex, row) {
            var rowData = [];
            $(row).find('td').each(function (colIndex, col) {
                rowData.push($(col).text());
            });
            tableData.p");
            WriteLiteral(@"ush(rowData);
        });

        
        var wb = XLSX.utils.book_new();
        var ws = XLSX.utils.aoa_to_sheet([['Role ID', 'Role Name', 'Role Designation', 'Created Date', 'Is Active']].concat(tableData));
        XLSX.utils.book_append_sheet(wb, ws, 'Roles');

        
        XLSX.writeFile(wb, 'RoleData.xlsx');
    }
</script>
<script>
    $(document).ready(function () {

        $(""#btnExport"").click(function () {

            $(""#tbl"").table2excel({

                filename: ""ArnMasterTable.xls""

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

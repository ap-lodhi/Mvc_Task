#pragma checksum "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cdf4a37806ddeb42c53f770db38c013c4924674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_GetRoleList), @"mvc.1.0.view", @"/Views/Dashboard/GetRoleList.cshtml")]
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
#line 1 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\_ViewImports.cshtml"
using Task_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
using Task_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cdf4a37806ddeb42c53f770db38c013c4924674", @"/Views/Dashboard/GetRoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f6cb265ae10b635a3a5b5440ef7bc5af4061b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_GetRoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
   ViewBag.Title = "RoleList"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdf4a37806ddeb42c53f770db38c013c49246744270", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Signup Page</title>
    <link href=""
https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""
https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.17.3/xlsx.full.min.js""></script>

    <script src=""
https://code.jquery.com/jquery-3.6.4.min.js""></script>

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
                color: darkorange;
            }

        form {
            back");
                WriteLiteral(@"ground-color: #fff;
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
            justify-content: space-between;
            ");
                WriteLiteral("margin-left: 90px;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cdf4a37806ddeb42c53f770db38c013c49246747421", async() => {
                WriteLiteral("\r\n\r\n    <nav class=\"navbar navbar-expand-lg \">\r\n        <div class=\"container-fluid\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cdf4a37806ddeb42c53f770db38c013c49246747786", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse navbarCenter"">
                <ul class=""navbar-nav "">
                    <li class=""nav-item"">
                        <a class=""nav-link active fs-4"" aria-current=""page"" href=""#"">Role Master</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""/Dashboard/GetDepList"">Department Master</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""#"">Student Master</a>
                    </li>
                </ul>
            </div>
            <div>

            </div>
            <ul class=""navbar-nav "">
  ");
                WriteLiteral("              <li class=\"nav-item\">\r\n                    <p class=\"fs-3 text-white\">");
#nullable restore
#line 132 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                                          Write(ViewBag.sess);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </li>
            </ul>

        </div>
    </nav>
    <button onclick=""exportfn()"">Export to Excel</button>
    <div class=""container mt-5"">
        <h2>Role Table</h2>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Role ID</th>
                    <th scope=""col"">Role Name</th>
                    <th scope=""col"">Role Designation</th>
                    <th scope=""col"">Created Date</th>
                    <th scope=""col"">Is Active</th>
                    <th>

                        <a class=""fs-3  p-2 text-white bg-secondary  text-decoration-none"" href=""/Dashboard/roleMaster"">+ </a>
                    </th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 157 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                 foreach (var item in Model as List<RoleModel>)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 160 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(item.Role_id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 161 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(item.Role_name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 162 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(item.Role_designation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 163 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(item.created_date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 164 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(item.Is_active);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>\r\n                            <button");
                BeginWriteAttribute("onclick", " onclick=\"", 5015, "\"", 5050, 3);
                WriteAttributeValue("", 5025, "projectDel(", 5025, 11, true);
#nullable restore
#line 166 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
WriteAttributeValue("", 5036, item.Role_id, 5036, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5049, ")", 5049, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn-danger ml-3\">Delete</button>\r\n                            ");
#nullable restore
#line 167 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                       Write(Html.ActionLink("Edit", "editRole", new { id = item.Role_id }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 170 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\GetRoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </tbody>
        </table>
    </div>


    <script>

        function projectDel(id) {
            console.log(id)
            console.log(""btn click"")
            //  let obj = {}
            var a = confirm(""Are you sure want to delete this project"");
            if (a == true) {
                // obj.id = id;

                $.ajax({
                    url: ""/Dashboard/DeleteRole?id="" + id,
                    type: ""DELETE"",

                    // debugger;
                    success: function (data) {
                        alert(""Deleted sucessfuly"");
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
            $('table tbody tr').each(function (");
                WriteLiteral(@"rowIndex, row) {
                var rowData = [];
                $(row).find('td').each(function (colIndex, col) {
                    rowData.push($(col).text());
                });
                tableData.push(rowData);
            });




            var wb = XLSX.utils.book_new();
            var ws = XLSX.utils.aoa_to_sheet([['Role ID', 'Role Name', 'Role Designation', 'Created Date', 'Is Active']].concat(tableData));
            XLSX.utils.book_append_sheet(wb, ws, 'Roles');




            XLSX.writeFile(wb, 'RoleData.xlsx');
        }
    </script>
");
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
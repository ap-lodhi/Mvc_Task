#pragma checksum "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "990a8bb8ac9f42a361a544675bcad270a678fb5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Student), @"mvc.1.0.view", @"/Views/Dashboard/Student.cshtml")]
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
#line 2 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\_ViewImports.cshtml"
using Task_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990a8bb8ac9f42a361a544675bcad270a678fb5f", @"/Views/Dashboard/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f6cb265ae10b635a3a5b5440ef7bc5af4061b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:25%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\Student.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990a8bb8ac9f42a361a544675bcad270a678fb5f4604", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Signup Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.6.4.min.js""></script>
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

        .form {
            margin-top: 150px;
        }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990a8bb8ac9f42a361a544675bcad270a678fb5f6531", async() => {
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-lg \">\r\n        <div class=\"container-fluid\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "990a8bb8ac9f42a361a544675bcad270a678fb5f6892", async() => {
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
                        <a class=""nav-link active fs-4"" aria-current=""page"" href=""/Dashboard/GetRoleList"">Role Master</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""/Dashboard/GetDepList"">Department Master</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link fs-4"" href=""/Dashboard/GetStuList"">Student Master</a>
                    </li>
                </ul>
            </div>
            <div>

            </div>");
                WriteLiteral("\n            <ul class=\"navbar-nav \">\r\n                <li class=\"nav-item\">\r\n                    <p class=\"fs-3 text-white\">");
#nullable restore
#line 70 "C:\Users\mrapl\source\repos\Task_1\Task_1\Views\Dashboard\Student.cshtml"
                                          Write(ViewBag.sess);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </li>
            </ul>

        </div>
    </nav>

    <div class=""w-50 m-auto shadow bg-white p-5 mt-5"">
        <div class=""container mt-5"">

            <h2 style=""color: #19234F;margin-left:25%;""><b>Student Master</b></h2>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "990a8bb8ac9f42a361a544675bcad270a678fb5f9744", async() => {
                    WriteLiteral(@"

                <div class=""mb-3"">

                    <label for=""firstName"" class=""form-label""><b>First Name</b></label>

                    <input type=""text"" class=""form-control"" id=""firstName"" name=""firstName"" required>

                </div>

                <div class=""mb-3"">

                    <label for=""lastName"" class=""form-label""><b>Last Name</b></label>

                    <input type=""text"" class=""form-control"" id=""lastName"" name=""lastName"" required>

                </div>

                <div class=""mb-3"">

                    <label for=""session"" class=""form-label""><b>Session</b></label>

                    <input type=""text"" class=""form-control"" id=""session"" name=""session"" required>

                </div>

                <div class=""mb-3"">

                    <label for=""email"" class=""form-label""><b>Email</b></label>

                    <input type=""email"" class=""form-control"" id=""email"" name=""email"" required>

                </div>

         ");
                    WriteLiteral(@"       <div class=""mb-3"">

                    <label for=""phoneNo"" class=""form-label""><b>Phone Number</b></label>

                    <input type=""tel"" class=""form-control"" id=""phoneNo"" name=""phoneNo"" required>

                </div>

                <div class=""mb-3 form-check"" style=""display:flex;"">

                    <input type=""checkbox"" class=""form-check-input"" id=""isActive"" name=""isActive"">&nbsp;&nbsp;

                    <label class=""form-check-label"" for=""isActive""><b>Is Active</b></label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                    <input type=""checkbox"" class=""form-check-input"" id=""isDeleted"" name=""isDeleted"">&nbsp;&nbsp;

                    <label class=""form-check-label"" for=""isDeleted""><b>Is Deleted</b></label>

                </div>

                <button type=""submit"" id=""submit"">Submit</button>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        </div>
        </div>


        <script>
            $(document).ready(function () {
                $('#submit').click(function () {
                 //   debugger;
                    let obj = {
                        Student_fisrt_Name: $('#firstName').val(),

                        Student_Last_Name: $('#lastName').val(),
                        Student_Email: $('#email').val(),
                        Student_Phone: $('#phoneNo').val(),
                        Student_Session: $('#session').val(),
                        Is_active: $('#isActive').is(':checked'),
                        Is_Deleted: $('#isDeleted').is(':checked')

                    };

                    $.ajax({
                        url: ""/Dashboard/addStudent"",
                        type: ""POST"",
                        data: obj,
                        success: function (data) {
                            alert(JSON.stringify(data.message));
                            location.reload()");
                WriteLiteral(@";
                        },
                        error: function (err) {
                            console.error(err.message);
                        },
                    })
                });

                // Clear the form on cancel button
                $('#cancel').click(function () {
                    $('#roleForm')[0].reset();
                });
            });
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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

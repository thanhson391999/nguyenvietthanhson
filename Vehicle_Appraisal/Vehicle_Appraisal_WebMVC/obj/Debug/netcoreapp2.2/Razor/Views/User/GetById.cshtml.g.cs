#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5327abb281195b2d556966bed260766039741d3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetById), @"mvc.1.0.view", @"/Views/User/GetById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetById.cshtml", typeof(AspNetCore.Views_User_GetById))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC;

#line default
#line hidden
#line 2 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5327abb281195b2d556966bed260766039741d3f", @"/Views/User/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUserModelMVC>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(53, 958, true);
            WriteLiteral(@"
<div class=""content-wrapper"">


    <!-- Content Wrapper. Contains page content -->
    <div class=""content"">
        <!-- Content Header (Page header) -->
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1><a href=""/user/getall"">USERS</a></h1>
                    </div>
                    <div class=""col-sm-6"">
                        <ol class=""breadcrumb float-sm-right"">
                            <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                            <li class=""breadcrumb-item""><a href=""/user/GetAll"">Users</a></li>
                            <li class=""breadcrumb-item active"">GetById</li>
                        </ol>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>
        ");
            EndContext();
            BeginContext(1011, 518, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5327abb281195b2d556966bed260766039741d3f5170", async() => {
                BeginContext(1051, 471, true);
                WriteLiteral(@"
            <div class=""input-group mb-3"" style=""width:300px; margin-left:1.2rem"">
                <input type=""text"" name=""Id"" class=""form-control"" placeholder=""Input ID"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"" required>
                <div class=""input-group-append"">
                    <button type=""submit"" class=""input-group-text btn-primary"" id=""basic-addon2"">Get Users</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1529, 1086, true);
            WriteLiteral(@"
        <!-- Main content -->
        <section class=""content"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                <table class=""table table-bordered table-hover"">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Date</th>
                                            <th>UserName</th>
                                            <th>Email</th>
                                            <th>ConfirmEmail</th>
                                            <th>FullName</th>
                                            <th>Role</th>
                                            <th>Options</th>
                                        </tr>
                             ");
            WriteLiteral("       </thead>\r\n                                    <tbody>\r\n");
            EndContext();
#line 57 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                         if (Model != null && Model.appUserVM.AppUserRolesId == 2)
                                        {

#line default
#line hidden
            BeginContext(2758, 156, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(2915, 18, false);
#line 61 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2933, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3097, 47, false);
#line 64 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3144, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3308, 24, false);
#line 67 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3332, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3496, 21, false);
#line 70 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3517, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3681, 28, false);
#line 73 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.ConfirmEmail);

#line default
#line hidden
            EndContext();
            BeginContext(3709, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3873, 24, false);
#line 76 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserVM.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3897, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(4061, 24, false);
#line 79 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Model.appUserRoleVM.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4085, 163, true);
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(4249, 609, false);
#line 82 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Html.ActionLink("Edit", "updateUsers", "user", new
                                               {
                                                   Model.appUserVM.Id,
                                                   Model.appUserVM.CreateAt,
                                                   Model.appUserVM.UserName,
                                                   Model.appUserVM.Email,
                                                   Model.appUserVM.FullName,
                                                   Model.appUserRoleVM.Name
                                               }));

#line default
#line hidden
            EndContext();
            BeginContext(4858, 56, true);
            WriteLiteral(" |\r\n                                                    ");
            EndContext();
            BeginContext(4915, 46, false);
#line 91 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                               Write(Html.ActionLink("Details", "Details", new { }));

#line default
#line hidden
            EndContext();
            BeginContext(4961, 58, true);
            WriteLiteral(" |\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5019, "\"", 5089, 1);
#line 92 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
WriteAttributeValue("", 5026, Url.Action("DeleteAction", "user", new { Model.appUserVM.Id }), 5026, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5090, 33, true);
            WriteLiteral(" type=\"text\" class=\"text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5123, "\"", 5210, 12);
            WriteAttributeValue("", 5133, "return", 5133, 6, true);
            WriteAttributeValue(" ", 5139, "confirm(\'Are", 5140, 13, true);
            WriteAttributeValue(" ", 5152, "you", 5153, 4, true);
            WriteAttributeValue(" ", 5156, "sure", 5157, 5, true);
            WriteAttributeValue(" ", 5161, "want", 5162, 5, true);
            WriteAttributeValue(" ", 5166, "delete", 5167, 7, true);
            WriteAttributeValue(" ", 5173, "User", 5174, 5, true);
            WriteAttributeValue(" ", 5178, "with", 5179, 5, true);
            WriteAttributeValue(" ", 5183, "ID", 5184, 3, true);
            WriteAttributeValue(" ", 5186, "=", 5187, 2, true);
#line 92 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
WriteAttributeValue(" ", 5188, Model.appUserVM.Id, 5189, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 5208, "\')", 5208, 2, true);
            EndWriteAttribute();
            BeginContext(5211, 231, true);
            WriteLiteral(">\r\n                                                        Delete\r\n                                                    </a>\r\n                                                </td>\r\n                                            </tr>\r\n");
            EndContext();
#line 97 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetById.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5485, 529, true);
            WriteLiteral(@"                                    </tbody>

                                </table>
                            </div>
                            <!-- /.card-body -->
                        </div>
                        <!-- /.card -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.container-fluid -->
        </section>
        <!-- /.content -->
    </div>
    <!-- /.content-wrapper -->
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUserModelMVC> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e77740f1a4327ca7ff589c74d4d99a50041eb40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetAll), @"mvc.1.0.view", @"/Views/User/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/GetAll.cshtml", typeof(AspNetCore.Views_User_GetAll))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e77740f1a4327ca7ff589c74d4d99a50041eb40", @"/Views/User/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageResultVM<AppUserModelMVC>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(111, 788, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1><a href=""/user/GetAll"">USERS</a></h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                        <li class=""breadcrumb-item active"">Users</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <div class=""row"">
        <div class=""col-md-auto"" style=""margin-left:1rem"">
");
            EndContext();
#line 26 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
            BeginContext(960, 98, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1059, 18, false);
#line 29 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 31 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1118, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 32 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
             if (ViewBag.ErrorMsg != null)
            {

#line default
#line hidden
            BeginContext(1177, 97, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-danger\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1275, 16, false);
#line 35 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
               Write(ViewBag.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 37 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1332, 32, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1364, 365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e77740f1a4327ca7ff589c74d4d99a50041eb407269", async() => {
                BeginContext(1370, 352, true);
                WriteLiteral(@"
        <div class=""form-group"" style=""width:300px; margin-left:1rem"">
            <div class=""input-group"">
                <span class=""input-group-addon""><i class=""glyphicon glyphicon-search""></i></span>
                <input type=""text"" id=""Search"" placeholder=""Search for..."" class=""form-control"" />
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1729, 1119, true);
            WriteLiteral(@"
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered table-hover"">
                                    <thead>
                                        <tr>
                                            <th>No.</th>
                                            <th>Date</th>
                                            <th>UserName</th>
                                            <th>Email</th>
                                            <th>ConfirmEmail</th>
                                            <th>FullName</th>
                                            <th>Role</th>
                                            <th>Options</th>
                                        </t");
            WriteLiteral("r>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
            EndContext();
#line 70 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                         if (Model.Items != null)
                                        {
                                            var i = 0;
                                            foreach (var item in Model.Items.Where(x => x.appUserVM.AppUserRolesId == 2))
                                            {

#line default
#line hidden
            BeginContext(3184, 127, true);
            WriteLiteral("                                                <tr class=\"Search\">\r\n                                                    <td>\r\n");
            EndContext();
#line 77 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                          
                                                            i += 1;
                                                        

#line default
#line hidden
            BeginContext(3499, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(3556, 1, false);
#line 80 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3557, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3733, 46, false);
#line 83 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(item.appUserVM.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3779, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3955, 49, false);
#line 86 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.appUserVM.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(4004, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4180, 46, false);
#line 89 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.appUserVM.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4226, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4402, 53, false);
#line 92 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.appUserVM.ConfirmEmail));

#line default
#line hidden
            EndContext();
            BeginContext(4455, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4631, 49, false);
#line 95 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.appUserVM.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(4680, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4856, 49, false);
#line 98 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.appUserRoleVM.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4905, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(5081, 645, false);
#line 101 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                                   Write(Html.ActionLink("Edit", "updateUsers", "user", new
                                                        {
                                                       item.appUserVM.Id,
                                                       item.appUserVM.CreateAt,
                                                       item.appUserVM.UserName,
                                                       item.appUserVM.Email,
                                                       item.appUserVM.FullName,
                                                       item.appUserRoleVM.Name
                                                        }));

#line default
#line hidden
            EndContext();
            BeginContext(5726, 62, true);
            WriteLiteral(" |\r\n                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5788, "\"", 5855, 1);
#line 110 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
WriteAttributeValue("", 5795, Url.Action("DeleteAction","user",new { item.appUserVM.Id }), 5795, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5856, 33, true);
            WriteLiteral(" type=\"text\" class=\"text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5889, "\"", 5972, 9);
            WriteAttributeValue("", 5899, "return", 5899, 6, true);
            WriteAttributeValue(" ", 5905, "confirm(\'Are", 5906, 13, true);
            WriteAttributeValue(" ", 5918, "you", 5919, 4, true);
            WriteAttributeValue(" ", 5922, "sure", 5923, 5, true);
            WriteAttributeValue(" ", 5927, "want", 5928, 5, true);
            WriteAttributeValue(" ", 5932, "delete", 5933, 7, true);
            WriteAttributeValue(" ", 5939, "User:", 5940, 6, true);
#line 110 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
WriteAttributeValue(" ", 5945, item.appUserVM.UserName, 5946, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 5970, "\')", 5970, 2, true);
            EndWriteAttribute();
            BeginContext(5973, 251, true);
            WriteLiteral(">\r\n                                                            Delete\r\n                                                        </a>\r\n\r\n                                                    </td>\r\n\r\n                                                </tr>\r\n");
            EndContext();
#line 117 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(6314, 152, true);
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            ");
            EndContext();
            BeginContext(6467, 43, false);
#line 122 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\User\GetAll.cshtml"
                       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
            EndContext();
            BeginContext(6510, 370, true);
            WriteLiteral(@"
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

<!-- jQuery -->
");
            EndContext();
            BeginContext(6880, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e77740f1a4327ca7ff589c74d4d99a50041eb4019717", async() => {
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
            EndContext();
            BeginContext(6943, 763, true);
            WriteLiteral(@"
<!-- /.Search function -->
<script>
    $(document).ready(function () {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
        $(""#Search"").keyup(function () {
            var searchText = $(""#Search"").val().toLowerCase();
            $("".Search"").each(function () {
                if (!Contains($(this).text().toLowerCase(), searchText)) {
                    $(this).hide();
                }
                else {
                    $(this).show();
                }
            });
        });
    });
</script>
<!-- /.Alert function -->
<script>
    setTimeout(function () {
        $(""#msgAlert"").fadeOut('slow');
    }, 5000);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageResultVM<AppUserModelMVC>> Html { get; private set; }
    }
}
#pragma warning restore 1591

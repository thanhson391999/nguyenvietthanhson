#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157825902065b25c3f8c6e759830bdf90b98cbff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Make_GetAll), @"mvc.1.0.view", @"/Views/Make/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Make/GetAll.cshtml", typeof(AspNetCore.Views_Make_GetAll))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157825902065b25c3f8c6e759830bdf90b98cbff", @"/Views/Make/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Make_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageResultVM<MakeVM>>
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
#line 3 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(102, 835, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1><a href=""/make/GetAll"">MAKE</a></h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                        <li class=""breadcrumb-item active"">Make</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <div class=""row"">
        <div class=""col-md-auto"" style=""margin-left:1rem"">
");
            EndContext();
#line 27 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
            BeginContext(998, 98, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1097, 18, false);
#line 30 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 32 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1156, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 33 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
             if (ViewBag.ErrorMsg != null)
            {

#line default
#line hidden
            BeginContext(1215, 97, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-danger\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1313, 16, false);
#line 36 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
               Write(ViewBag.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 38 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1370, 230, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"card-header\">\r\n        <a id=\"btn-create\" class=\"btn btn-primary\" href=\"/make/insert\">\r\n            <i class=\"far fa-plus-square\"></i>\r\n            Create\r\n        </a>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(1600, 365, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157825902065b25c3f8c6e759830bdf90b98cbff7528", async() => {
                BeginContext(1606, 352, true);
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
            BeginContext(1965, 866, true);
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
                                            <th>Name</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 73 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                         if (Model.Items != null)
                                        {
                                            var i = ((Model.PageIndex - 1) * Model.PageSize);
                                            foreach (var item in Model.Items)
                                            {

#line default
#line hidden
            BeginContext(3162, 127, true);
            WriteLiteral("                                                <tr class=\"Search\">\r\n                                                    <td>\r\n");
            EndContext();
#line 80 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                                          
                                                            i += 1;
                                                        

#line default
#line hidden
            BeginContext(3477, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(3534, 1, false);
#line 83 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3535, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3711, 36, false);
#line 86 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                                   Write(item.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3747, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(3923, 35, false);
#line 89 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                                   Write(Html.DisplayFor(Model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3958, 175, true);
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
            EndContext();
            BeginContext(4134, 84, false);
#line 92 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                                   Write(Html.ActionLink("Edit", "update", "make", new { item.Id, item.CreateAt, item.Name }));

#line default
#line hidden
            EndContext();
            BeginContext(4218, 62, true);
            WriteLiteral(" |\r\n                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4280, "\"", 4337, 1);
#line 93 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
WriteAttributeValue("", 4287, Url.Action("DeleteAction","make",new { item.Id }), 4287, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4338, 33, true);
            WriteLiteral(" type=\"text\" class=\"text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4371, "\"", 4440, 9);
            WriteAttributeValue("", 4381, "return", 4381, 6, true);
            WriteAttributeValue(" ", 4387, "confirm(\'Are", 4388, 13, true);
            WriteAttributeValue(" ", 4400, "you", 4401, 4, true);
            WriteAttributeValue(" ", 4404, "sure", 4405, 5, true);
            WriteAttributeValue(" ", 4409, "want", 4410, 5, true);
            WriteAttributeValue(" ", 4414, "delete", 4415, 7, true);
            WriteAttributeValue(" ", 4421, "Make:", 4422, 6, true);
#line 93 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
WriteAttributeValue(" ", 4427, item.Name, 4428, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 4438, "\')", 4438, 2, true);
            EndWriteAttribute();
            BeginContext(4441, 247, true);
            WriteLiteral(">\r\n                                                            Delete\r\n                                                        </a>\r\n                                                    </td>\r\n                                                </tr>\r\n");
            EndContext();
#line 98 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(4778, 152, true);
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            ");
            EndContext();
            BeginContext(4931, 43, false);
#line 103 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Make\GetAll.cshtml"
                       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
            EndContext();
            BeginContext(4974, 368, true);
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
            BeginContext(5342, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157825902065b25c3f8c6e759830bdf90b98cbff16639", async() => {
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
            BeginContext(5405, 769, true);
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
</script>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageResultVM<MakeVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f8becde3ba785da72847595f99f2731e2a339f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_GetAllConditionById), @"mvc.1.0.view", @"/Views/Vehicle/GetAllConditionById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/GetAllConditionById.cshtml", typeof(AspNetCore.Views_Vehicle_GetAllConditionById))]
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
#line 1 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC;

#line default
#line hidden
#line 2 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC.Models;

#line default
#line hidden
#line 1 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3f8becde3ba785da72847595f99f2731e2a339f", @"/Views/Vehicle/GetAllConditionById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_GetAllConditionById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ConditionVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/plugins/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/dist/css/adminlte.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/plugins/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/dist/js/adminlte.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/dist/js/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(97, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(126, 690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f6701", async() => {
                BeginContext(132, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(254, 17, false);
#line 13 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(271, 68, true);
                WriteLiteral(" - Vehicle_Appraisal_WebMVC</title>\r\n    <!-- Font Awesome -->\r\n    ");
                EndContext();
                BeginContext(339, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f3f8becde3ba785da72847595f99f2731e2a339f7661", async() => {
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
                EndContext();
                BeginContext(423, 165, true);
                WriteLiteral("\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\r\n    <!-- overlayScrollbars -->\r\n    ");
                EndContext();
                BeginContext(588, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3f8becde3ba785da72847595f99f2731e2a339f9164", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(655, 154, true);
                WriteLiteral("\r\n    <!-- Google Font: Source Sans Pro -->\r\n    <link href=\"https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700\" rel=\"stylesheet\">\r\n");
                EndContext();
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
            EndContext();
            BeginContext(816, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(818, 6303, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f11456", async() => {
                BeginContext(824, 845, true);
                WriteLiteral(@"
    <div class=""wrapper"">


        <!-- Content Wrapper. Contains page content -->
        <div class=""content"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <h1><a href=""#"">CONDITIONS</a></h1>
                        </div>
                        <div class=""col-sm-6"">
                            <ol class=""breadcrumb float-sm-right"">
                                <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                                <li class=""breadcrumb-item active""><a href=""/vehicle/getall"">Vehicle</a></li>
                                <li class=""breadcrumb-item active"">");
                EndContext();
                BeginContext(1670, 47, false);
#line 40 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                              Write(Model.Select(x => x.VehicleId).FirstOrDefault());

#line default
#line hidden
                EndContext();
                BeginContext(1717, 356, true);
                WriteLiteral(@"</li>
                                <li class=""breadcrumb-item active"">Condition</li>
                            </ol>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>
            <div class=""card-header"">
                <a id=""btn-create"" class=""btn btn-primary""");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2073, "\"", 2146, 2);
                WriteAttributeValue("", 2080, "/condition/insert/", 2080, 18, true);
#line 48 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
WriteAttributeValue("", 2098, Model.Select(x => x.VehicleId).FirstOrDefault(), 2098, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2147, 1092, true);
                WriteLiteral(@">
                    <i class=""far fa-plus-square""></i>
                    Create
                </a>
            </div>
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
                                                <th>Type</th>
                                                <th>Image</th>
                                                <th>Note</th>
                                                <th>Options</th>
                                            </tr>
                               ");
                WriteLiteral("         </thead>\r\n                                        <tbody>\r\n");
                EndContext();
#line 71 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                             if (Model != null)
                                            {
                                                foreach (var item in Model)
                                                {
                                                    if (item.Id != 0)
                                                    {

#line default
#line hidden
                BeginContext(3605, 207, true);
                WriteLiteral("                                                        <tr class=\"Search\">\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(3813, 33, false);
#line 79 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                           Write(Html.DisplayFor(Model => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(3846, 199, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4046, 35, false);
#line 82 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                           Write(Html.DisplayFor(Model => item.Type));

#line default
#line hidden
                EndContext();
                BeginContext(4081, 203, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4284, "\"", 4339, 2);
                WriteAttributeValue("", 4290, "/Images/", 4290, 8, true);
#line 85 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
WriteAttributeValue("", 4298, Html.DisplayFor(Model => item.ImagePath), 4298, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4340, 202, true);
                WriteLiteral(" />\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4543, 35, false);
#line 88 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                           Write(Html.DisplayFor(Model => item.Note));

#line default
#line hidden
                EndContext();
                BeginContext(4578, 199, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4778, 117, false);
#line 91 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                           Write(Html.ActionLink("Edit", "update", "condition", new { item.Id, item.Type, item.ImagePath, item.Note, item.VehicleId }));

#line default
#line hidden
                EndContext();
                BeginContext(4895, 70, true);
                WriteLiteral(" |\r\n                                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4965, "\"", 5044, 1);
#line 92 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
WriteAttributeValue("", 4972, Url.Action("DeleteAction","condition",new { item.Id , item.VehicleId }), 4972, 72, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5045, 33, true);
                WriteLiteral(" type=\"text\" class=\"text-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5078, "\"", 5159, 12);
                WriteAttributeValue("", 5088, "return", 5088, 6, true);
                WriteAttributeValue(" ", 5094, "confirm(\'Are", 5095, 13, true);
                WriteAttributeValue(" ", 5107, "you", 5108, 4, true);
                WriteAttributeValue(" ", 5111, "sure", 5112, 5, true);
                WriteAttributeValue(" ", 5116, "want", 5117, 5, true);
                WriteAttributeValue(" ", 5121, "delete", 5122, 7, true);
                WriteAttributeValue(" ", 5128, "condition", 5129, 10, true);
                WriteAttributeValue(" ", 5138, "with", 5139, 5, true);
                WriteAttributeValue(" ", 5143, "ID", 5144, 3, true);
                WriteAttributeValue(" ", 5146, "=", 5147, 2, true);
#line 92 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
WriteAttributeValue(" ", 5148, item.Id, 5149, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 5157, "\')", 5157, 2, true);
                EndWriteAttribute();
                BeginContext(5160, 300, true);
                WriteLiteral(@">
                                                                    Delete
                                                                </a>                     
                                                            </td>
                                                        </tr>
");
                EndContext();
#line 97 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllConditionById.cshtml"
                                                    }
                                                }
                                            }

#line default
#line hidden
                BeginContext(5613, 1137, true);
                WriteLiteral(@"                                        </tbody>
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
        <footer class=""main-footer"">
            <div class=""float-right d-none d-sm-block"">
                <b>Version</b> 3.0.5
            </div>
            <strong>Copyright &copy; 2014-2019 <a href=""http://adminlte.io"">AdminLTE.io</a>.</strong> All rights
            reserved.
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar c");
                WriteLiteral("ontent goes here -->\r\n        </aside>\r\n        <!-- /.control-sidebar -->\r\n    </div>\r\n    <!-- jQuery -->\r\n    ");
                EndContext();
                BeginContext(6750, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f23138", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6813, 32, true);
                WriteLiteral("\r\n    <!-- Bootstrap 4 -->\r\n    ");
                EndContext();
                BeginContext(6845, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f24423", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6924, 33, true);
                WriteLiteral("\r\n    <!-- AdminLTE App -->\r\n    ");
                EndContext();
                BeginContext(6957, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f25709", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7015, 47, true);
                WriteLiteral("\r\n    <!-- AdminLTE for demo purposes -->\r\n    ");
                EndContext();
                BeginContext(7062, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3f8becde3ba785da72847595f99f2731e2a339f27009", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7112, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(7121, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ConditionVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a51f10815eb519126e331aa1eed9810cb05f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_GetAllAppraisalValueById), @"mvc.1.0.view", @"/Views/Vehicle/GetAllAppraisalValueById.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/GetAllAppraisalValueById.cshtml", typeof(AspNetCore.Views_Vehicle_GetAllAppraisalValueById))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a51f10815eb519126e331aa1eed9810cb05f7f", @"/Views/Vehicle/GetAllAppraisalValueById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_GetAllAppraisalValueById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VehicleAppraisalVM>>
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
#line 3 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(104, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(133, 690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f6769", async() => {
                BeginContext(139, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(261, 17, false);
#line 13 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(278, 68, true);
                WriteLiteral(" - Vehicle_Appraisal_WebMVC</title>\r\n    <!-- Font Awesome -->\r\n    ");
                EndContext();
                BeginContext(346, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0a51f10815eb519126e331aa1eed9810cb05f7f7737", async() => {
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
                BeginContext(430, 165, true);
                WriteLiteral("\r\n    <!-- Ionicons -->\r\n    <link rel=\"stylesheet\" href=\"https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css\">\r\n    <!-- overlayScrollbars -->\r\n    ");
                EndContext();
                BeginContext(595, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c0a51f10815eb519126e331aa1eed9810cb05f7f9240", async() => {
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
                BeginContext(662, 154, true);
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
            BeginContext(823, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(825, 6979, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f11532", async() => {
                BeginContext(831, 849, true);
                WriteLiteral(@"
    <div class=""wrapper"">


        <!-- Content Wrapper. Contains page content -->
        <div class=""content"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <h1><a href=""#"">APPRAISALVALUE</a></h1>
                        </div>
                        <div class=""col-sm-6"">
                            <ol class=""breadcrumb float-sm-right"">
                                <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                                <li class=""breadcrumb-item active""><a href=""/vehicle/getall"">Vehicle</a></li>
                                <li class=""breadcrumb-item active"">");
                EndContext();
                BeginContext(1681, 9, false);
#line 40 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                              Write(ViewBag.i);

#line default
#line hidden
                EndContext();
                BeginContext(1690, 363, true);
                WriteLiteral(@"</li>
                                <li class=""breadcrumb-item active"">AppraisalValue</li>
                            </ol>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>
            <div class=""row"">
                <div class=""col-md-auto"" style=""margin-left:1rem"">
");
                EndContext();
#line 49 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                     if (ViewBag.SuccessMsg != null)
                    {

#line default
#line hidden
                BeginContext(2130, 114, true);
                WriteLiteral("                        <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(2245, 18, false);
#line 52 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                       Write(ViewBag.SuccessMsg);

#line default
#line hidden
                EndContext();
                BeginContext(2263, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 54 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                    }

#line default
#line hidden
                BeginContext(2320, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 55 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                     if (ViewBag.ErrorMsg != null)
                    {

#line default
#line hidden
                BeginContext(2395, 113, true);
                WriteLiteral("                        <div id=\"msgAlert\" class=\"alert alert-danger\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(2509, 16, false);
#line 58 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                       Write(ViewBag.ErrorMsg);

#line default
#line hidden
                EndContext();
                BeginContext(2525, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 60 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                    }

#line default
#line hidden
                BeginContext(2582, 44, true);
                WriteLiteral("                </div>\r\n            </div>\r\n");
                EndContext();
#line 63 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
             if (Model.Count == 0)
            {

#line default
#line hidden
                BeginContext(2677, 105, true);
                WriteLiteral("                <div class=\"card-header\">\r\n                    <a id=\"btn-create\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2782, "\"", 2825, 2);
                WriteAttributeValue("", 2789, "/vehicleappraisal/insert/", 2789, 25, true);
#line 66 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 2814, ViewBag.id, 2814, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2826, 145, true);
                WriteLiteral(">\r\n                        <i class=\"far fa-plus-square\"></i>\r\n                        Create\r\n                    </a>\r\n                </div>\r\n");
                EndContext();
#line 71 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
            }

#line default
#line hidden
                BeginContext(2986, 848, true);
                WriteLiteral(@"            <!-- Main content -->
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <table class=""table table-bordered table-hover"">
                                        <thead>
                                            <tr>
                                                <th>Date</th>
                                                <th>AppraisalValue</th>
                                                <th>Options</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
                EndContext();
#line 88 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                             if (Model != null)
                                            {
                                                foreach (var item in Model)
                                                {
                                                    if (item.Id != 0)
                                                    {

#line default
#line hidden
                BeginContext(4200, 207, true);
                WriteLiteral("                                                        <tr class=\"Search\">\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4408, 36, false);
#line 96 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                           Write(item.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(4444, 199, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4644, 45, false);
#line 99 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                           Write(Html.DisplayFor(Model => item.AppraisalValue));

#line default
#line hidden
                EndContext();
                BeginContext(4689, 199, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(4889, 122, false);
#line 102 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                           Write(Html.ActionLink("Edit", "update", "vehicleappraisal", new { item.Id, item.CreateAt, item.AppraisalValue, item.VehicleId }));

#line default
#line hidden
                EndContext();
                BeginContext(5011, 70, true);
                WriteLiteral(" |\r\n                                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5081, "\"", 5166, 1);
#line 103 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 5088, Url.Action("DeleteAction","vehicleappraisal",new { item.Id, item.VehicleId }), 5088, 78, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5167, 33, true);
                WriteLiteral(" type=\"text\" class=\"text-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5200, "\"", 5287, 13);
                WriteAttributeValue("", 5210, "return", 5210, 6, true);
                WriteAttributeValue(" ", 5216, "confirm(\'Are", 5217, 13, true);
                WriteAttributeValue(" ", 5229, "you", 5230, 4, true);
                WriteAttributeValue(" ", 5233, "sure", 5234, 5, true);
                WriteAttributeValue(" ", 5238, "want", 5239, 5, true);
                WriteAttributeValue(" ", 5243, "delete", 5244, 7, true);
                WriteAttributeValue(" ", 5250, "appraisal", 5251, 10, true);
                WriteAttributeValue(" ", 5260, "value", 5261, 6, true);
                WriteAttributeValue(" ", 5266, "with", 5267, 5, true);
                WriteAttributeValue(" ", 5271, "ID", 5272, 3, true);
                WriteAttributeValue(" ", 5274, "=", 5275, 2, true);
#line 103 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue(" ", 5276, item.Id, 5277, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 5285, "\')", 5285, 2, true);
                EndWriteAttribute();
                BeginContext(5288, 217, true);
                WriteLiteral(">\r\n                                                                    Delete\r\n                                                                </a> |\r\n                                                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5505, "\"", 5575, 1);
#line 106 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 5512, Url.Action("BuyVehicle","vehicle",new { id = item.VehicleId }), 5512, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5576, 33, true);
                WriteLiteral(" type=\"text\" class=\"text-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 5609, "\"", 5708, 14);
                WriteAttributeValue("", 5619, "return", 5619, 6, true);
                WriteAttributeValue(" ", 5625, "confirm(\'Are", 5626, 13, true);
                WriteAttributeValue(" ", 5638, "you", 5639, 4, true);
                WriteAttributeValue(" ", 5642, "sure", 5643, 5, true);
                WriteAttributeValue(" ", 5647, "want", 5648, 5, true);
                WriteAttributeValue(" ", 5652, "to", 5653, 3, true);
                WriteAttributeValue(" ", 5655, "buy", 5656, 4, true);
                WriteAttributeValue(" ", 5659, "this", 5660, 5, true);
                WriteAttributeValue(" ", 5664, "vehicle", 5665, 8, true);
                WriteAttributeValue(" ", 5672, "with", 5673, 5, true);
                WriteAttributeValue(" ", 5677, "value", 5678, 6, true);
                WriteAttributeValue(" ", 5683, "=", 5684, 2, true);
#line 106 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue(" ", 5685, item.AppraisalValue, 5686, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 5706, "\')", 5706, 2, true);
                EndWriteAttribute();
                BeginContext(5709, 276, true);
                WriteLiteral(@">
                                                                    Buy
                                                                </a>
                                                            </td>
                                                        </tr>
");
                EndContext();
#line 111 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                    }
                                                }
                                            }

#line default
#line hidden
                BeginContext(6138, 1137, true);
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
                BeginContext(7275, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f27157", async() => {
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
                BeginContext(7338, 32, true);
                WriteLiteral("\r\n    <!-- Bootstrap 4 -->\r\n    ");
                EndContext();
                BeginContext(7370, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f28442", async() => {
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
                BeginContext(7449, 33, true);
                WriteLiteral("\r\n    <!-- AdminLTE App -->\r\n    ");
                EndContext();
                BeginContext(7482, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f29728", async() => {
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
                BeginContext(7540, 47, true);
                WriteLiteral("\r\n    <!-- AdminLTE for demo purposes -->\r\n    ");
                EndContext();
                BeginContext(7587, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a51f10815eb519126e331aa1eed9810cb05f7f31028", async() => {
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
                BeginContext(7637, 160, true);
                WriteLiteral("\r\n    <!-- /.Alert function -->\r\n    <script>\r\n        setTimeout(function () {\r\n            $(\"#msgAlert\").fadeOut(\'slow\');\r\n        }, 5000);\r\n    </script>\r\n");
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
            BeginContext(7804, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VehicleAppraisalVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

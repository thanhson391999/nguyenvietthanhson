#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965477a0ce9b4eaa4fff5282838075ddb1bbb6be"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965477a0ce9b4eaa4fff5282838075ddb1bbb6be", @"/Views/Vehicle/GetAllAppraisalValueById.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be6769", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be7737", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be9240", async() => {
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
            BeginContext(825, 7942, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be11532", async() => {
                BeginContext(831, 671, true);
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
");
                EndContext();
#line 39 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                 if (ViewBag.isBought == false)
                                {

#line default
#line hidden
                BeginContext(1602, 115, true);
                WriteLiteral("                                    <li class=\"breadcrumb-item active\"><a href=\"/vehicle/getall\">Vehicle</a></li>\r\n");
                EndContext();
#line 42 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                }

#line default
#line hidden
                BeginContext(1752, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 43 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                 if (ViewBag.isBought == true)
                                {

#line default
#line hidden
                BeginContext(1851, 134, true);
                WriteLiteral("                                    <li class=\"breadcrumb-item active\"><a href=\"/vehicle/getallVehicleBought\">VehicleBought</a></li>\r\n");
                EndContext();
#line 46 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                }

#line default
#line hidden
                BeginContext(2020, 67, true);
                WriteLiteral("                                <li class=\"breadcrumb-item active\">");
                EndContext();
                BeginContext(2088, 9, false);
#line 47 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                              Write(ViewBag.i);

#line default
#line hidden
                EndContext();
                BeginContext(2097, 363, true);
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
#line 56 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                     if (ViewBag.SuccessMsg != null)
                    {

#line default
#line hidden
                BeginContext(2537, 114, true);
                WriteLiteral("                        <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(2652, 18, false);
#line 59 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                       Write(ViewBag.SuccessMsg);

#line default
#line hidden
                EndContext();
                BeginContext(2670, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 61 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                    }

#line default
#line hidden
                BeginContext(2727, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 62 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                     if (ViewBag.ErrorMsg != null)
                    {

#line default
#line hidden
                BeginContext(2802, 113, true);
                WriteLiteral("                        <div id=\"msgAlert\" class=\"alert alert-danger\" role=\"alert\">\r\n                            ");
                EndContext();
                BeginContext(2916, 16, false);
#line 65 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                       Write(ViewBag.ErrorMsg);

#line default
#line hidden
                EndContext();
                BeginContext(2932, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 67 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                    }

#line default
#line hidden
                BeginContext(2989, 44, true);
                WriteLiteral("                </div>\r\n            </div>\r\n");
                EndContext();
#line 70 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
             if (ViewBag.isBought == false)
            {
                if (Model.Count == 0)
                {

#line default
#line hidden
                BeginContext(3151, 113, true);
                WriteLiteral("                    <div class=\"card-header\">\r\n                        <a id=\"btn-create\" class=\"btn btn-primary\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3264, "\"", 3307, 2);
                WriteAttributeValue("", 3271, "/vehicleappraisal/insert/", 3271, 25, true);
#line 75 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 3296, ViewBag.id, 3296, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3308, 161, true);
                WriteLiteral(">\r\n                            <i class=\"far fa-plus-square\"></i>\r\n                            Create\r\n                        </a>\r\n                    </div>\r\n");
                EndContext();
#line 80 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(3503, 632, true);
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
");
                EndContext();
#line 94 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                 if (ViewBag.isBought == false)
                                                {

#line default
#line hidden
                BeginContext(4267, 70, true);
                WriteLiteral("                                                    <th>Options</th>\r\n");
                EndContext();
#line 97 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                }

#line default
#line hidden
                BeginContext(4388, 150, true);
                WriteLiteral("                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
                EndContext();
#line 101 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                             if (Model != null)
                                            {
                                                foreach (var item in Model)
                                                {
                                                    if (item.Id != 0)
                                                    {

#line default
#line hidden
                BeginContext(4904, 207, true);
                WriteLiteral("                                                        <tr class=\"Search\">\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(5112, 36, false);
#line 109 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                           Write(item.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(5148, 199, true);
                WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
                EndContext();
                BeginContext(5348, 45, false);
#line 112 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                           Write(Html.DisplayFor(Model => item.AppraisalValue));

#line default
#line hidden
                EndContext();
                BeginContext(5393, 69, true);
                WriteLiteral("\r\n                                                            </td>\r\n");
                EndContext();
#line 114 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                             if (ViewBag.isBought == false)
                                                            {

#line default
#line hidden
                BeginContext(5618, 138, true);
                WriteLiteral("                                                                <td>\r\n                                                                    ");
                EndContext();
                BeginContext(5757, 122, false);
#line 117 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                               Write(Html.ActionLink("Edit", "update", "vehicleappraisal", new { item.Id, item.CreateAt, item.AppraisalValue, item.VehicleId }));

#line default
#line hidden
                EndContext();
                BeginContext(5879, 74, true);
                WriteLiteral(" |\r\n                                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5953, "\"", 6040, 1);
#line 118 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 5960, Url.Action("DeleteAction", "vehicleappraisal", new { item.Id, item.VehicleId }), 5960, 80, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6041, 33, true);
                WriteLiteral(" type=\"text\" class=\"text-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6074, "\"", 6161, 13);
                WriteAttributeValue("", 6084, "return", 6084, 6, true);
                WriteAttributeValue(" ", 6090, "confirm(\'Are", 6091, 13, true);
                WriteAttributeValue(" ", 6103, "you", 6104, 4, true);
                WriteAttributeValue(" ", 6107, "sure", 6108, 5, true);
                WriteAttributeValue(" ", 6112, "want", 6113, 5, true);
                WriteAttributeValue(" ", 6117, "delete", 6118, 7, true);
                WriteAttributeValue(" ", 6124, "appraisal", 6125, 10, true);
                WriteAttributeValue(" ", 6134, "value", 6135, 6, true);
                WriteAttributeValue(" ", 6140, "with", 6141, 5, true);
                WriteAttributeValue(" ", 6145, "ID", 6146, 3, true);
                WriteAttributeValue(" ", 6148, "=", 6149, 2, true);
#line 118 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue(" ", 6150, item.Id, 6151, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 6159, "\')", 6159, 2, true);
                EndWriteAttribute();
                BeginContext(6162, 229, true);
                WriteLiteral(">\r\n                                                                        Delete\r\n                                                                    </a> |\r\n                                                                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 6391, "\"", 6463, 1);
#line 121 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue("", 6398, Url.Action("BuyVehicle", "vehicle", new { id = item.VehicleId }), 6398, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6464, 33, true);
                WriteLiteral(" type=\"text\" class=\"text-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6497, "\"", 6596, 14);
                WriteAttributeValue("", 6507, "return", 6507, 6, true);
                WriteAttributeValue(" ", 6513, "confirm(\'Are", 6514, 13, true);
                WriteAttributeValue(" ", 6526, "you", 6527, 4, true);
                WriteAttributeValue(" ", 6530, "sure", 6531, 5, true);
                WriteAttributeValue(" ", 6535, "want", 6536, 5, true);
                WriteAttributeValue(" ", 6540, "to", 6541, 3, true);
                WriteAttributeValue(" ", 6543, "buy", 6544, 4, true);
                WriteAttributeValue(" ", 6547, "this", 6548, 5, true);
                WriteAttributeValue(" ", 6552, "vehicle", 6553, 8, true);
                WriteAttributeValue(" ", 6560, "with", 6561, 5, true);
                WriteAttributeValue(" ", 6565, "value", 6566, 6, true);
                WriteAttributeValue(" ", 6571, "=", 6572, 2, true);
#line 121 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
WriteAttributeValue(" ", 6573, item.AppraisalValue, 6574, 20, false);

#line default
#line hidden
                WriteAttributeValue("", 6594, "\')", 6594, 2, true);
                EndWriteAttribute();
                BeginContext(6597, 225, true);
                WriteLiteral(">\r\n                                                                        Buy\r\n                                                                    </a>\r\n                                                                </td>\r\n");
                EndContext();
#line 125 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                            }

#line default
#line hidden
                BeginContext(6885, 63, true);
                WriteLiteral("                                                        </tr>\r\n");
                EndContext();
#line 127 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAllAppraisalValueById.cshtml"
                                                    }
                                                }
                                            }

#line default
#line hidden
                BeginContext(7101, 1137, true);
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
                BeginContext(8238, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be30381", async() => {
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
                BeginContext(8301, 32, true);
                WriteLiteral("\r\n    <!-- Bootstrap 4 -->\r\n    ");
                EndContext();
                BeginContext(8333, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be31666", async() => {
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
                BeginContext(8412, 33, true);
                WriteLiteral("\r\n    <!-- AdminLTE App -->\r\n    ");
                EndContext();
                BeginContext(8445, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be32952", async() => {
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
                BeginContext(8503, 47, true);
                WriteLiteral("\r\n    <!-- AdminLTE for demo purposes -->\r\n    ");
                EndContext();
                BeginContext(8550, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965477a0ce9b4eaa4fff5282838075ddb1bbb6be34252", async() => {
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
                BeginContext(8600, 160, true);
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
            BeginContext(8767, 11, true);
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

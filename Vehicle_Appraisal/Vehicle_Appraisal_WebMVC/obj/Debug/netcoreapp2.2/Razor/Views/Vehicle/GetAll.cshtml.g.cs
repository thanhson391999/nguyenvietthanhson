#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fae1fa2865186cb4da10285e4930bf23c816ee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_GetAll), @"mvc.1.0.view", @"/Views/Vehicle/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/GetAll.cshtml", typeof(AspNetCore.Views_Vehicle_GetAll))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae1fa2865186cb4da10285e4930bf23c816ee2", @"/Views/Vehicle/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageResultVM<VehicleModelMVC>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ThemeLTE/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(111, 795, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1><a href=""/vehicle/getall"">VEHICLE</a></h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/home/index"">Home</a></li>
                        <li class=""breadcrumb-item active"">Vehicle</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>
    <div class=""row"">
        <div class=""col-md-auto"" style=""margin-left:1rem"">
");
            EndContext();
#line 26 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
            BeginContext(967, 98, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1066, 18, false);
#line 29 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 31 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1125, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 32 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
             if (ViewBag.ErrorMsg != null)
            {

#line default
#line hidden
            BeginContext(1184, 97, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-danger\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1282, 16, false);
#line 35 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
               Write(ViewBag.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1298, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 37 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
            }

#line default
#line hidden
            BeginContext(1339, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 40 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
     if (User.Claims.Where(x => x.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() == "Admin")
    {

#line default
#line hidden
            BeginContext(1501, 233, true);
            WriteLiteral("        <div class=\"card-header\">\r\n            <a id=\"btn-create\" class=\"btn btn-primary\" href=\"/vehicle/insert\">\r\n                <i class=\"far fa-plus-square\"></i>\r\n                Create\r\n            </a>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1734, 520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fae1fa2865186cb4da10285e4930bf23c816ee28854", async() => {
                BeginContext(1774, 473, true);
                WriteLiteral(@"
            <div class=""input-group mb-3"" style=""width:300px; margin-left:1.2rem"">
                <input type=""text"" name=""Id"" class=""form-control"" placeholder=""Input ID"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"" required>
                <div class=""input-group-append"">
                    <button type=""submit"" class=""input-group-text btn-primary"" id=""basic-addon2"">Get Vehicle</button>
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
            BeginContext(2254, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2264, 2067, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fae1fa2865186cb4da10285e4930bf23c816ee211209", async() => {
                BeginContext(2309, 2015, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col"" style=""margin-left:1.2rem"">
                    <input type=""text"" name=""customer"" class=""form-control"" placeholder=""customer"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
                <div class=""col"">
                    <input type=""text"" name=""make"" class=""form-control"" placeholder=""make"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
                <div class=""col"">
                    <input type=""text"" name=""model"" class=""form-control"" placeholder=""model"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col"" style=""margin-left:1.2rem"">
                    <input type=""text"" name=""odometer"" class=""form-control"" placeholder=""odometer"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </di");
                WriteLiteral(@"v>
                <div class=""col"">
                    <input type=""text"" name=""VIN"" class=""form-control"" placeholder=""VIN"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
                <div class=""col"">
                    <input type=""text"" name=""engine"" class=""form-control"" placeholder=""engine"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
            </div>
            <div class=""row"">
                <div class=""col-4"" style=""margin-left:1.2rem"">
                    <input type=""text"" name=""appuser"" class=""form-control"" placeholder=""Users"" aria-label=""Recipient's username"" aria-describedby=""basic-addon2"">
                </div>
            </div>
            <div class=""input-group mb-3"" style=""width:300px; margin-left:1.2rem"">
                <button type=""submit"" class=""input-group-text btn-primary"" id=""basic-addon2"">Get Vehicle</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(4331, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
    }

#line default
#line hidden
            BeginContext(4340, 1228, true);
            WriteLiteral(@"    <!-- Main content -->
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
                                            <th>ID</th>
                                            <th>Date</th>
                                            <th>Customer</th>
                                            <th>Make</th>
                                            <th>Model</th>
                                            <th>VIN</th>
                                            <th>Odometer</th>
                                            <th>Engine</th>
                                            <th>Users</t");
            WriteLiteral("h>\r\n                                            <th>Options</th>\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
            EndContext();
#line 113 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                         if (Model.Items != null)
                                        {
                                            if (User.Claims.Where(c => c.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() != "Admin")
                                            {
                                                foreach (var item in Model.Items.Where(x => x.appUserVM.FullName.Equals(User.Claims.Where(c => c.Type.Equals("FullName")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim())))
                                                {

#line default
#line hidden
            BeginContext(6175, 180, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(6356, 43, false);
#line 121 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Id));

#line default
#line hidden
            EndContext();
            BeginContext(6399, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(6587, 46, false);
#line 124 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(item.vehicleVM.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6633, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(6821, 51, false);
#line 127 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.customerVM.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(6872, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(6874, 50, false);
#line 127 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                                                                            Write(Html.DisplayFor(Model => item.customerVM.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(6924, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(7112, 42, false);
#line 130 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.makeVM.Name));

#line default
#line hidden
            EndContext();
            BeginContext(7154, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(7342, 43, false);
#line 133 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.modelVM.Name));

#line default
#line hidden
            EndContext();
            BeginContext(7385, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(7573, 44, false);
#line 136 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(7617, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(7805, 49, false);
#line 139 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Odometer));

#line default
#line hidden
            EndContext();
            BeginContext(7854, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(8042, 47, false);
#line 142 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Engine));

#line default
#line hidden
            EndContext();
            BeginContext(8089, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(8277, 49, false);
#line 145 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.appUserVM.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(8326, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(8514, 78, false);
#line 148 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.ActionLink("Condition", "GetAllConditionById", new { item.vehicleVM.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(8592, 124, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
            EndContext();
#line 151 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                }
                                            }
                                            else
                                            {
                                                foreach (var item in Model.Items)
                                                {

#line default
#line hidden
            BeginContext(9045, 180, true);
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(9226, 43, false);
#line 159 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Id));

#line default
#line hidden
            EndContext();
            BeginContext(9269, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(9457, 46, false);
#line 162 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(item.vehicleVM.CreateAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(9503, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(9691, 51, false);
#line 165 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.customerVM.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(9742, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(9744, 50, false);
#line 165 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                                                                            Write(Html.DisplayFor(Model => item.customerVM.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(9794, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(9982, 42, false);
#line 168 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.makeVM.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10024, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(10212, 43, false);
#line 171 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.modelVM.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10255, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(10443, 44, false);
#line 174 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.VIN));

#line default
#line hidden
            EndContext();
            BeginContext(10487, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(10675, 49, false);
#line 177 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Odometer));

#line default
#line hidden
            EndContext();
            BeginContext(10724, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(10912, 47, false);
#line 180 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.vehicleVM.Engine));

#line default
#line hidden
            EndContext();
            BeginContext(10959, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(11147, 49, false);
#line 183 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.DisplayFor(Model => item.appUserVM.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(11196, 187, true);
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
            EndContext();
            BeginContext(11384, 1015, false);
#line 186 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.ActionLink("Edit", "update", "vehicle", new
                                                       {
                                                           item.vehicleVM.Id,
                                                           item.vehicleVM.CreateAt,
                                                           item.vehicleVM.Odometer,
                                                           item.vehicleVM.VIN,
                                                           item.vehicleVM.Engine,
                                                           MakeName = item.makeVM.Name,
                                                           item.appUserVM.FullName,
                                                           ModelName = item.modelVM.Name,
                                                           item.customerVM.FirstName,
                                                           item.customerVM.LastName,
                                                       }));

#line default
#line hidden
            EndContext();
            BeginContext(12399, 64, true);
            WriteLiteral(" |\r\n                                                            ");
            EndContext();
            BeginContext(12464, 78, false);
#line 199 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.ActionLink("Condition", "GetAllConditionById", new { item.vehicleVM.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(12542, 64, true);
            WriteLiteral(" |\r\n                                                            ");
            EndContext();
            BeginContext(12607, 88, false);
#line 200 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                       Write(Html.ActionLink("AppraisalValue", "GetAllAppraisalValueById", new { item.vehicleVM.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(12695, 66, true);
            WriteLiteral(" |\r\n                                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 12761, "\"", 12833, 1);
#line 201 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
WriteAttributeValue("", 12768, Url.Action("DeleteAction", "vehicle", new { item.vehicleVM.Id }), 12768, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(12834, 33, true);
            WriteLiteral(" type=\"text\" class=\"text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 12867, "\"", 12956, 12);
            WriteAttributeValue("", 12877, "return", 12877, 6, true);
            WriteAttributeValue(" ", 12883, "confirm(\'Are", 12884, 13, true);
            WriteAttributeValue(" ", 12896, "you", 12897, 4, true);
            WriteAttributeValue(" ", 12900, "sure", 12901, 5, true);
            WriteAttributeValue(" ", 12905, "want", 12906, 5, true);
            WriteAttributeValue(" ", 12910, "delete", 12911, 7, true);
            WriteAttributeValue(" ", 12917, "vehicle", 12918, 8, true);
            WriteAttributeValue(" ", 12925, "with", 12926, 5, true);
            WriteAttributeValue(" ", 12930, "ID", 12931, 3, true);
            WriteAttributeValue(" ", 12933, "=", 12934, 2, true);
#line 201 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
WriteAttributeValue(" ", 12935, item.vehicleVM.Id, 12936, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 12954, "\')", 12954, 2, true);
            EndWriteAttribute();
            BeginContext(12957, 263, true);
            WriteLiteral(@">
                                                                Delete
                                                            </a>
                                                        </td>
                                                    </tr>
");
            EndContext();
#line 206 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                                                }
                                            }
                                        }

#line default
#line hidden
            BeginContext(13361, 152, true);
            WriteLiteral("                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                            ");
            EndContext();
            BeginContext(13514, 43, false);
#line 212 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Vehicle\GetAll.cshtml"
                       Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
            EndContext();
            BeginContext(13557, 349, true);
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
");
            EndContext();
            BeginContext(13906, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fae1fa2865186cb4da10285e4930bf23c816ee237124", async() => {
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
            BeginContext(13969, 134, true);
            WriteLiteral("\r\n<!-- /.Alert function -->\r\n<script>\r\n    setTimeout(function () {\r\n        $(\"#msgAlert\").fadeOut(\'slow\');\r\n    }, 5000);\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageResultVM<VehicleModelMVC>> Html { get; private set; }
    }
}
#pragma warning restore 1591

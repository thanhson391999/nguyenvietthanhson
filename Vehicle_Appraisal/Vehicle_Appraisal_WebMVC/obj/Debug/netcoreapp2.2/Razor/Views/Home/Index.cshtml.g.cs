#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d9910846f989395ff732360bb6a69e06c7de895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9910846f989395ff732360bb6a69e06c7de895", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashBoardModelMVC>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 874, true);
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0 text-dark"">Dashboard</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Dashboard v1</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <div class=""row"">
        <div class=""col-md-auto"" style=""margin-left:1rem"">
");
            EndContext();
#line 26 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
             if (ViewBag.SuccessMsg != null)
            {

#line default
#line hidden
            BeginContext(1006, 98, true);
            WriteLiteral("                <div id=\"msgAlert\" class=\"alert alert-success\" role=\"alert\">\r\n                    ");
            EndContext();
            BeginContext(1105, 18, false);
#line 29 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
               Write(ViewBag.SuccessMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1123, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 31 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1164, 174, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <!-- Small boxes (Stat box) -->\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 38 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    if (User.Claims.Where(x => x.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() == "Admin")
                    {

#line default
#line hidden
            BeginContext(1559, 256, true);
            WriteLiteral(@"                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-info"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(1816, 28, false);
#line 46 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListCustomerVM.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1844, 774, true);
            WriteLiteral(@"</h3>

                                    <p>Customer</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""ion ion-person-add""></i>
                                </div>
                                <a href=""/customer/getall"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-success"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(2619, 59, false);
#line 61 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2678, 775, true);
            WriteLiteral(@"</h3>

                                    <p>Vehicle Current</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""fa fa-car-alt""></i>
                                </div>
                                <a href=""/vehicle/getall"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-warning"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(3454, 61, false);
#line 76 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListAppuserVM.Where(x => x.AppUserRolesId == 2).Count());

#line default
#line hidden
            EndContext();
            BeginContext(3515, 766, true);
            WriteLiteral(@"</h3>

                                    <p>Users</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""ion ion-person-add""></i>
                                </div>
                                <a href=""/user/getall"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-danger"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(4282, 58, false);
#line 91 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought == true).Count());

#line default
#line hidden
            EndContext();
            BeginContext(4340, 528, true);
            WriteLiteral(@"</h3>

                                    <p>Vehicle Bought</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""fa fa-car-alt""></i>
                                </div>
                                <a href=""/vehicle/getallvehiclebought"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
");
            EndContext();
#line 102 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                    }
                    if (User.Claims.Where(x => x.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() == "Users")
                    {

#line default
#line hidden
            BeginContext(5056, 299, true);
            WriteLiteral(@"                        <!-- ./col -->
                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-success"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(5356, 205, false);
#line 110 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought == false).Where(y => y.AppUserId.ToString().Equals(User.Claims.Where(c => c.Type.Equals("Id")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim())).Count());

#line default
#line hidden
            EndContext();
            BeginContext(5561, 506, true);
            WriteLiteral(@"</h3>
                                    <p>Vehicle</p>
                                </div>
                                <div class=""icon"">
                                    <i class=""fa fa-car-alt""></i>
                                </div>
                                <a href=""/vehicle/getall"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
                            </div>
                        </div>
                        <!-- ./col -->
");
            EndContext();
#line 120 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(6109, 60, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
            EndContext();
            BeginContext(6169, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d9910846f989395ff732360bb6a69e06c7de89513415", async() => {
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
            BeginContext(6232, 134, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashBoardModelMVC> Html { get; private set; }
    }
}
#pragma warning restore 1591

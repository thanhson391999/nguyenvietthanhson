#pragma checksum "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059e5d762e345b4a08383bb7fe2f3457754e5a49"
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
#line 1 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC;

#line default
#line hidden
#line 2 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\_ViewImports.cshtml"
using Vehicle_Appraisal_WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059e5d762e345b4a08383bb7fe2f3457754e5a49", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashBoardModelMVC>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(71, 937, true);
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
    <section class=""content"">
        <div class=""container-fluid"">
            <!-- Small boxes (Stat box) -->
            <div class=""row"">
");
            EndContext();
#line 28 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    if (User.Claims.Where(x => x.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() == "Admin")
                    {

#line default
#line hidden
            BeginContext(1229, 256, true);
            WriteLiteral(@"                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-info"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(1486, 28, false);
#line 36 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListCustomerVM.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1514, 774, true);
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
            BeginContext(2289, 64, false);
#line 51 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought.Equals(false)).Count());

#line default
#line hidden
            EndContext();
            BeginContext(2353, 775, true);
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
            BeginContext(3129, 61, false);
#line 66 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListAppuserVM.Where(x => x.AppUserRolesId == 2).Count());

#line default
#line hidden
            EndContext();
            BeginContext(3190, 766, true);
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
            BeginContext(3957, 63, false);
#line 81 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought.Equals(true)).Count());

#line default
#line hidden
            EndContext();
            BeginContext(4020, 528, true);
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
#line 92 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                    }
                    if (User.Claims.Where(x => x.Type.Equals("Role")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim() == "Users")
                    {

#line default
#line hidden
            BeginContext(4736, 299, true);
            WriteLiteral(@"                        <!-- ./col -->
                        <div class=""col-lg-3 col-6"">
                            <!-- small box -->
                            <div class=""small-box bg-success"">
                                <div class=""inner"">
                                    <h3>");
            EndContext();
            BeginContext(5036, 210, false);
#line 100 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                                   Write(Model.ListVehicleVM.Where(x => x.isBought.Equals(false)).Where(x => x.AppUserId.ToString().Equals(User.Claims.Where(c => c.Type.Equals("Id")).FirstOrDefault().ToString().Split(':').ElementAt(1).Trim())).Count());

#line default
#line hidden
            EndContext();
            BeginContext(5246, 506, true);
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
#line 110 "E:\Github\ss-training-son\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(5794, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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

#pragma checksum "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ad72693a0e83a8fcbd7ed5496021604ecff0830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleCrawlData_GetAllVehicleHyundaiCrawlData), @"mvc.1.0.view", @"/Views/VehicleCrawlData/GetAllVehicleHyundaiCrawlData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VehicleCrawlData/GetAllVehicleHyundaiCrawlData.cshtml", typeof(AspNetCore.Views_VehicleCrawlData_GetAllVehicleHyundaiCrawlData))]
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
#line 1 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
using Vehicle_Appraisal_WebApi.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ad72693a0e83a8fcbd7ed5496021604ecff0830", @"/Views/VehicleCrawlData/GetAllVehicleHyundaiCrawlData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8716a36880e6f8a4368c72227f8f746a2a66e75", @"/Views/_ViewImports.cshtml")]
    public class Views_VehicleCrawlData_GetAllVehicleHyundaiCrawlData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VehicleCrawlDataVM>>
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
#line 3 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
  
    Layout = Layout;

#line default
#line hidden
            BeginContext(106, 385, true);
            WriteLiteral(@"<div class=""content-wrapper"">

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row row-small align-center list-bg"" id=""row-706255199"">
");
            EndContext();
#line 16 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
                                 if (Model != null)
                                {
                                    foreach (var item in Model.Where(x => x.Name.Split(' ').ElementAt(0).Equals("Hyundai")))
                                    {

#line default
#line hidden
            BeginContext(744, 344, true);
            WriteLiteral(@"                                        <div id=""col-83102025"" class=""col item-bg medium-3 small-12 large-3"">
                                            <div class=""col-inner"">
                                                <article class=""archive-product"">
                                                    <h3 class=""name""><a href=""#"">");
            EndContext();
            BeginContext(1089, 35, false);
#line 23 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
                                                                            Write(Html.DisplayFor(Model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 230, true);
            WriteLiteral("</a></h3>\r\n                                                    <div class=\"info\">\r\n                                                        <p><a class=\"image\" href=\"#\"><img class=\"img-bangiga lazy-load-active\" style=\"width: 40rem\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1354, "\"", 1397, 1);
#line 25 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
WriteAttributeValue("", 1360, Html.DisplayFor(Model => item.Image), 1360, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1398, "\"", 1440, 1);
#line 25 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
WriteAttributeValue("", 1404, Html.DisplayFor(Model => item.Name), 1404, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1441, 298, true);
            WriteLiteral(@"></a></p>
                                                        <dl class=""versions"">
                                                            <dt>Giá bán</dt>
                                                            <dd>
                                                                ");
            EndContext();
            BeginContext(1740, 36, false);
#line 29 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
                                                           Write(Html.DisplayFor(Model => item.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 352, true);
            WriteLiteral(@"
                                                            </dd>
                                                        </dl>
                                                    </div>
                                                </article>
                                            </div>
                                        </div>
");
            EndContext();
#line 36 "E:\Github\nguyenvietthanhson\Vehicle_Appraisal\Vehicle_Appraisal_WebMVC\Views\VehicleCrawlData\GetAllVehicleHyundaiCrawlData.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2202, 402, true);
            WriteLiteral(@"                            </div>
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
            BeginContext(2604, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ad72693a0e83a8fcbd7ed5496021604ecff08309042", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VehicleCrawlDataVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f40f9029941bac7a9021f7e966fb4591f4c03e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clinic_ClinicPage), @"mvc.1.0.view", @"/Views/Clinic/ClinicPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f40f9029941bac7a9021f7e966fb4591f4c03e", @"/Views/Clinic/ClinicPage.cshtml")]
    public class Views_Clinic_ClinicPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicalCenter.Entities.Models.Clinic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/user.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<!doctype html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f40f9029941bac7a9021f7e966fb4591f4c03e4037", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n\r\n    <title>The HTML5 Herald</title>\r\n    <meta name=\"description\" content=\"The HTML5 Herald\">\r\n    <meta name=\"author\" content=\"SitePoint\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94f40f9029941bac7a9021f7e966fb4591f4c03e4494", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94f40f9029941bac7a9021f7e966fb4591f4c03e5672", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f40f9029941bac7a9021f7e966fb4591f4c03e7562", async() => {
                WriteLiteral("\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\"");
                BeginWriteAttribute("href", "  href=\"", 528, "\"", 610, 2);
                WriteAttributeValue("", 536, "https://localhost:44389/ClinicPage/", 536, 35, true);
#nullable restore
#line 21 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 571, Html.DisplayFor(modelItem => Model.Id), 571, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Profil Klinke</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 744, "\"", 832, 2);
                WriteAttributeValue("", 751, "https://localhost:44389/ClinicExamination/", 751, 42, true);
#nullable restore
#line 24 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 793, Html.DisplayFor(modelItem => Model.Id), 793, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Spisak specijalizovanih pregleda </a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 986, "\"", 1069, 2);
                WriteAttributeValue("", 993, "https://localhost:44389/MedicalStaff/", 993, 37, true);
#nullable restore
#line 27 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 1030, Html.DisplayFor(modelItem => Model.Id), 1030, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Spisak zdravstvenih radnika </a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 1218, "\"", 1317, 2);
                WriteAttributeValue("", 1225, "https://localhost:44389/MedicalExaminationOnDiscount/", 1225, 53, true);
#nullable restore
#line 30 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 1278, Html.DisplayFor(modelItem => Model.Id), 1278, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Prgledi na popustu </a>
        </li>

    </ul>
    <div class=""container"">
        <br><br>
        <div class=""container-fluid"">

            <div class=""card bg-info text-white"">
                <div class=""card-header"">
                    <h3 class=""panel-title"">Podaci Klinike ");
#nullable restore
#line 40 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
                                                      Write(Html.DisplayFor(modelItem => Model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>
                </div>

                <div class=""card-body"">
                    <div class=""row justify-content-md-center "">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""Description"">O nama: </label>
                                <textarea id=""Description"" name=""Description"" style=""height:300px""  class="" form-control"" readonly>");
#nullable restore
#line 48 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
                                                                                                                              Write(Html.DisplayFor(modelItem => Model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                            </div>
                        </div>
                    </div>

                    <div class=""row justify-content-md-center "">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""City"">Grad: </label>
                                <input id=""City"" type=""text"" name=""City""");
                BeginWriteAttribute("value", " value=\"", 2567, "\"", 2616, 1);
#nullable restore
#line 57 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 2575, Html.DisplayFor(modelItem => Model.City), 2575, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" readonly>
                            </div>
                        </div>
                    </div>
                    <div class=""row justify-content-md-center "">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""Adress"">Adresa: </label>
                                <input id=""Adress"" type=""text"" name=""Adress""");
                BeginWriteAttribute("value", " value=\"", 3060, "\"", 3111, 1);
#nullable restore
#line 65 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicPage.cshtml"
WriteAttributeValue("", 3068, Html.DisplayFor(modelItem => Model.Adress), 3068, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" readonly>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicalCenter.Entities.Models.Clinic> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d969eae8a4da4249fa73cfbb677f7526739f930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clinic_ClinicExamination), @"mvc.1.0.view", @"/Views/Clinic/ClinicExamination.cshtml")]
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
#nullable restore
#line 2 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d969eae8a4da4249fa73cfbb677f7526739f930", @"/Views/Clinic/ClinicExamination.cshtml")]
    public class Views_Clinic_ClinicExamination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicalCenter.Entities.ViewModels.ClinicExaminationViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/MedicalExaminationOnDiscount.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!doctype html>\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d969eae8a4da4249fa73cfbb677f7526739f9304346", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n\r\n    <title>The HTML5 Herald</title>\r\n    <meta name=\"description\" content=\"The HTML5 Herald\">\r\n    <meta name=\"author\" content=\"SitePoint\">\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d969eae8a4da4249fa73cfbb677f7526739f9304803", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d969eae8a4da4249fa73cfbb677f7526739f9305981", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d969eae8a4da4249fa73cfbb677f7526739f9307871", async() => {
                WriteLiteral("\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 649, "\"", 723, 2);
                WriteAttributeValue("", 656, "https://localhost:44389/ClinicPage/", 656, 35, true);
#nullable restore
#line 21 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
WriteAttributeValue("", 691, Context.Session.GetString("Id"), 691, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Profil Klinke</a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\"");
                BeginWriteAttribute("href", " href=\"", 828, "\"", 909, 2);
                WriteAttributeValue("", 835, "https://localhost:44389/ClinicExamination/", 835, 42, true);
#nullable restore
#line 24 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
WriteAttributeValue("", 877, Context.Session.GetString("Id"), 877, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Spisak specijalizovanih pregleda </a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 1063, "\"", 1139, 2);
                WriteAttributeValue("", 1070, "https://localhost:44389/MedicalStaff/", 1070, 37, true);
#nullable restore
#line 27 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
WriteAttributeValue("", 1107, Context.Session.GetString("Id"), 1107, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Spisak zdravstvenih radnika </a>\r\n        </li>\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\" style=\"background-color: lightblue\"");
                BeginWriteAttribute("href", " href=\"", 1288, "\"", 1380, 2);
                WriteAttributeValue("", 1295, "https://localhost:44389/MedicalExaminationOnDiscount/", 1295, 53, true);
#nullable restore
#line 30 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
WriteAttributeValue("", 1348, Context.Session.GetString("Id"), 1348, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Prgledi na popustu </a>
        </li>

    </ul>
    <div class=""container"">
        <br><br>
        <table style=""width:100%"">
            <thead>
                <tr>
                    <th style=""width:25%"">Naziv</th>
                    <th style=""width:50%"">Opis</th>
                    <th style=""width:15%"">Cena</th>
                    <th style=""width:10%"">Zakaži pregled</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 46 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NameOfMedicalExamination));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(", din\r\n                        </td>\r\n\r\n\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2431, "\"", 2525, 2);
                WriteAttributeValue("", 2438, "https://localhost:44389/CreateMedicalExaminition/", 2438, 49, true);
#nullable restore
#line 61 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
WriteAttributeValue("", 2487, Html.DisplayFor(modelItem => item.Id), 2487, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"submit\" value=\"Zakaži pregled\">\r\n                            </a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 67 "C:\Users\MB\Desktop\ClinicalCenter\ClinicalCenter\ClinicalCenter\Views\Clinic\ClinicExamination.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicalCenter.Entities.ViewModels.ClinicExaminationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

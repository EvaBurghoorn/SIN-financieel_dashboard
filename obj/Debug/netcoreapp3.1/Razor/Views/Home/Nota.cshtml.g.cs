#pragma checksum "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\Nota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8e2aa5e9c4a7c4133af0e366ded27b8bc2e41fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Nota), @"mvc.1.0.view", @"/Views/Home/Nota.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\_ViewImports.cshtml"
using Case_study;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\_ViewImports.cshtml"
using Case_study.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\Nota.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\Nota.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8e2aa5e9c4a7c4133af0e366ded27b8bc2e41fd", @"/Views/Home/Nota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60325b1f919c99be206dcb9ab363d4ce839ccb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Nota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OverzichtNota", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\Nota.cshtml"
  
    ViewData["Title"] = "Nieuwe onkostennota";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\Nota.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<button>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e2aa5e9c4a7c4133af0e366ded27b8bc2e41fd6089", async() => {
                WriteLiteral("Overzicht onkostennota\'s");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</button>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8e2aa5e9c4a7c4133af0e366ded27b8bc2e41fd7769", async() => {
                WriteLiteral("\r\n                <div class=\"row d-flex\">\r\n              \r\n                        <p class=\"col-12 col-md-5\">\r\n                        <label class=\"fst-italic\" for=\"voornaam\" >Voornaam</label>\r\n");
                WriteLiteral(@"                        <input aria-label=""Vul dit veld in"" name=""Voornaam"" type=""text"" class=""form-control"" id=""voornaam"" placeholder=""Voornaam"" required>

                    </p>
                        <p class=""col-12 col-md-5"">
                            <label class=""fst-italic"" for=""achternaam"">Achternaam</label>
                            <input aria-label=""Vul dit veld in"" name=""achternaam"" type=""text"" class=""form-control"" id=""naam"" placeholder=""Achternaam"" required>
                    </p>
                 
                    <p class=""col-12 col-md-5"">
                        <label for=""bankrekeningNummer"">Bankrekening nummer</label>
                        <input aria-label=""Vul dit veld in"" name=""bankrekeningNummer"" type=""text"" class=""form-control"" id=""bankrekeningNummer"" placeholder=""Geef een bankrekening nummer"" required>
                        
                    </p>

                    <p class=""col-12 col-md-2"">
                        <label for=""BIC"">BIC</label>
 ");
                WriteLiteral(@"                       <input name=""BIC"" type=""text"" class=""form-control"" id=""BIC"" placeholder=""BIC"">
                    </p>
              

                    <p class=""col-12 col-md-3"">
                        <label for=""datumsOnkosten"">Datum van onkosten</label>
                        <input aria-label=""Vul dit veld in"" name=""datumsOnkosten"" type=""date"" class=""form-control"" id=""datumsOnkosten"" placeholder=""Datum van onkosten"" required>
                    </p>

                    <p class=""col-10"">
                        <label for=""beschrijvingUitgave"">Beschrijving uitgave</label>
                        <textarea  aria-label=""Vul dit veld in"" name=""beschrijvingUitgave"" class=""form-control"" id=""beschrijvingUitgave"" placeholder=""Geef een beschrijving van de uitgave"" required></textarea>
                    </p>

                    <p class=""col-12 col-md-5"">
                        <label for=""categorie"">Categorie</label>
                        <input aria-label=""Vul dit veld in"" n");
                WriteLiteral(@"ame=""categorie"" type=""dropdown"" class=""form-control"" id=""categorie"" placeholder=""Categorie"" required>
                    </p>
                    <p class=""col-12 col-md-5"">
                        <label for=""anders"">Anders</label>
                        <input name=""anders"" type=""text"" class=""form-control"" id=""anders"" placeholder=""Anders"" >
                    </p>

                    <p class=""col-12 col-md-5"">
                        <label for=""onkostenDetails"">Onkosten Details</label>
                        <textarea aria-label=""Vul dit veld in"" name=""onkostenDetails"" class=""form-control"" id=""onkostenDetails"" placeholder=""Onkosten details"" required></textarea>
                    </p>
                    <p class=""col-12 col-md-5"">
                        <label for=""totaalBedrag"">Totaal bedrag</label>
                        <input aria-label=""Vul dit veld in"" name=""totaalBedrag"" type=""number"" class=""form-control"" id=""totaalBedrag"" placeholder=""Totaal bedrag"" required>
               ");
                WriteLiteral(@"     </p>
                    <p class=""col-12 col-md-5"">
                        <label for=""bijlage"">Bijlage</label>
                        <input aria-label=""Vul dit veld in"" name=""bijlage"" type=""file"" class=""form-control"" id=""bijlage"" placeholder=""Bijlage"" required>
                    </p>



                    <p class=""col-12 p-1 text-secondary"">
                        <input type=""submit"" class="" rounded bg-secondary text-white border-secondary"" value=""Nieuwe onkostennota"">
                    </p>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            \r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

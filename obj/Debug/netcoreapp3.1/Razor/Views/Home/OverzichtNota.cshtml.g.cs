#pragma checksum "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2399bd9734425fe9c17f847878f9cd48df4619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OverzichtNota), @"mvc.1.0.view", @"/Views/Home/OverzichtNota.cshtml")]
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
#line 2 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2399bd9734425fe9c17f847878f9cd48df4619", @"/Views/Home/OverzichtNota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d60325b1f919c99be206dcb9ab363d4ce839ccb9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_OverzichtNota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentfulCollection<onkostenNota>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
  
    ViewData["Title"] = "Overzicht onkostennota's";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<h1>Onkosten Nota</h1>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
 foreach (var onkostenNota in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <details>\r\n  <summary>Datum van onkosten: ");
#nullable restore
#line 19 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
                          Write(onkostenNota.datumVanOnkosten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</summary>\r\n  <p>Naam: ");
#nullable restore
#line 20 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
      Write(onkostenNota.naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Voornaam: ");
#nullable restore
#line 21 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
            Write(onkostenNota.voornaam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Bankrekeningnummer: ");
#nullable restore
#line 22 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
                      Write(onkostenNota.bankrekeningnummer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>BIC: ");
#nullable restore
#line 23 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
       Write(onkostenNota.bic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Datum van onkosten: ");
#nullable restore
#line 24 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
                      Write(onkostenNota.datumVanOnkosten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Categorie: ");
#nullable restore
#line 25 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
             Write(onkostenNota.categorie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Onkosten: ");
#nullable restore
#line 26 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
            Write(onkostenNota.onkosten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Totaal bedrag: ");
#nullable restore
#line 27 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
                 Write(onkostenNota.totaalBedrag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" euro</p>\r\n    <p>Bijlage:</p>\r\n    <ul>\r\n");
#nullable restore
#line 30 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
         foreach (var bijlage in onkostenNota.bijlage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 887, 1);
#nullable restore
#line 32 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
WriteAttributeValue("", 870, bijlage.File.Url, 870, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
                                       Write(bijlage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 33 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</details>\r\n");
#nullable restore
#line 36 "C:\Users\eburg\Documents\Thomas More\2APPAI01\Semester 1\Devops & security\Case study\financieel_dashboard\Views\Home\OverzichtNota.cshtml"



       
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentfulCollection<onkostenNota>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\muham\Source\Repos\Grupa1-Schpritzer\Imunizacija21\Imunizacija21\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2bbdffb0a81c6b1ef70e536c8ee611755ef00cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\muham\Source\Repos\Grupa1-Schpritzer\Imunizacija21\Imunizacija21\Views\_ViewImports.cshtml"
using Imunizacija21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muham\Source\Repos\Grupa1-Schpritzer\Imunizacija21\Imunizacija21\Views\_ViewImports.cshtml"
using Imunizacija21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2bbdffb0a81c6b1ef70e536c8ee611755ef00cd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21dda8bd18bc29f7dbb8f943bdfc4bab3680e14a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/HomeStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FAQ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\muham\Source\Repos\Grupa1-Schpritzer\Imunizacija21\Imunizacija21\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c2bbdffb0a81c6b1ef70e536c8ee611755ef00cd4813", async() => {
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<section>
    <div class=""text-center"">
        <h1 class=""display-4"">Imunizacija'21</h1>
        <p>Dobrodošli na stranicu na kojoj možete naći sve o Covid-19.</p>
");
            WriteLiteral("    </div>\r\n    <hr />\r\n    <div class=\"graf-center\">\r\n        <div id=\"piechart\" class=\"home-column\"></div>\r\n    </div>\r\n");
            WriteLiteral(@"
    <div class=""home-column text-center"">
        <h4 class=""display-6"">Broj dostavljenih vakcina po proizvođaču</h4>
        <p>Trenutno je Kantonu Sarajevo isporučeno ukupno 74755 doza vakcina protiv Covid-19. Najviše dostavljenih vakcina je od strane proizvođača Pfizer/BioNTech u iznosu od 34564 doza.</p>
    </div>
</section>
<hr />
<section>
    <div class=""text-center"" id=""Presjek"" style=""scroll-behavior: smooth;"">
        <h1 class=""display-5"">Trenutno stanje COVID-19 u Kantonu Sarajevo</h1>
        <h4 class=""display-6"">Presjek stanja za 14.6.2021.</h4>
    </div>
</section>
<section class=""ft-main"">
    <div class=""ft-main-item text-center"">
        <h1 class=""display-4"">12</h1>
        <p>Novozaraženih</p>
    </div>
    <div class=""ft-main-item text-center"">
        <h1 class=""display-4"">27</h1>
        <p>Oporavljenih</p>
    </div>
    <div class=""ft-main-item text-center"">
        <h1 class=""display-4"">2</h1>
        <p>Preminulih</p>
    </div>
</section>
<hr />
<di");
            WriteLiteral(@"v class=""text-center"">
    <h4 class=""display-6"">Pregled zaraženih za prethodnih 10 sedmica</h4>
</div>
<div id=""chartContainer"" style=""height: 300px; width: 100%;""></div>
<script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
<hr />

<div class=""text-center"">
    <h1 class=""display-5"">Najčešće postavljena pitanja</h1>
</div>
<hr />
<section class=""ft-main"">
    <div class=""ft-main-item text-center"">
        <h4 class=""display-7"">Da li su i koje vakcine sigurne za osobe iznad 65 godina?</h4>
        <p>Sve vakcine koje se koriste u našoj regiji su odobrene za upotrebu i kod osoba starijih od 65 godina. Dosadašnje iskustvo u primjeni Pfizer vakcine u Kantonu Sarajevo govori da starije osobe dobro podnose ovu vakcinu (reakcije na vakcinu kod starijih osoba su rjeđe nego kod mlađih).</p>
    </div>
    <div class=""ft-main-item text-center"">
        <h4 class=""display-7"">Koja vakcina se preporučuje onima koji su preboljeli COVID-19?</h4>
        <p>Osobe koje su preboljele CO");
            WriteLiteral(@"VID-19 mogu da prime bilo koju vakcinu protiv COVID-19.</p>
    </div>
    <div class=""ft-main-item text-center"">
        <h4 class=""display-7"">Je li sigurno za moje dijete da dobije cjepivo prvotiv Covid-19?</h4>
        <p>Da. Studije pokazuju da su cjepiva protiv COVID-19 sigurna i učinkovita. Kao i odrasli, i djeca mogu imati neke nuspojave nakon cijepljenja protiv COVID-19. Te nuspojave mogu utjecati na njihovu sposobnost obavljanja svakodnevnih aktivnosti, no trebale bi nestati za nekoliko dana.</p>
    </div>
</section>
<div class=""text-center"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2bbdffb0a81c6b1ef70e536c8ee611755ef00cd9171", async() => {
                WriteLiteral("Za pritup više često postavljenih pitanja, kliknite ovdje");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@"
</div>
<hr />


<script type=""text/javascript"">
    // Load google charts
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    // Draw the chart and set the chart values
    function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Vakcina', 'Broj Dostavljenih'],
            ['Pfizer', 34564],
            ['AstraZeneca', 21053],
            ['SputnikV', 5078],
            ['Sinopharm', 7747],
            ['Sinovac', 6313]
        ]);

        // Optional; add a title and set the width and height of the chart
        var options = { 'title': '', 'width': 550, 'height': 400 };

        // Display the chart inside the <div> element with id=""piechart""
        var chart = new google.visualization.PieChart(document.getElementById('piechart'));
        chart.draw(data, options);
    }
</script>


<script>
    window.onload = function () {

        var chart = new CanvasJS.Chart(""");
            WriteLiteral(@"chartContainer"", {
            animationEnabled: true,
            theme: ""light2"",
            title: {
                text: """"
            },
            data: [{
                type: ""line"",
                indexLabelFontSize: 16,
                dataPoints: [
                    { y: 496 },
                    { y: 707 },
                    { y: 746 },
                    { y: 658 },
                    { y: 611 },
                    { y: 497 },
                    { y: 304 },
                    { y: 333 },
                    { y: 500 },
                    { y: 281 },
                    { y: 163 },
                    { y: 195 },
                    { y: 174 },
                    { y: 282 },
                    { y: 179 },
                    { y: 186 },
                    { y: 156 },
                    { y: 99 },
                    { y: 71 },
                    { y: 98 },
                    { y: 176 },
                    { y: 137 },
                    { y: ");
            WriteLiteral(@"119 },
                    { y: 93 },
                    { y: 63 },
                    { y: 65 },
                    { y: 85 },
                    { y: 82 },
                    { y: 64 },
                    { y: 67 },
                    { y: 53 },
                    { y: 67 },
                    { y: 76 },
                    { y: 48 },
                    { y: 29 },
                    { y: 45 },
                    { y: 26 },
                    { y: 33 },
                    { y: 22 },
                    { y: 21 },
                    { y: 23 },
                    { y: 17 },
                    { y: 16 },
                    { y: 15 },
                    { y: 17 },
                    { y: 14 },
                    { y: 15 },
                    { y: 7 },
                    { y: 22 },
                    { y: 11 },
                    { y: 35 },
                    { y: 22 },
                    { y: 12 },
                    { y: 13 },
                    { y: ");
            WriteLiteral(@"6 },
                    { y: 14 },
                    { y: 16 },
                    { y: 21 },
                    { y: 8 },
                    { y: 11 },
                    { y: 2 },
                    { y: 12 },
                    { y: 10 },
                    { y: 6 },
                    { y: 9 },
                    { y: 9 },
                    { y: 8 },
                    { y: 7 },
                    { y: 6 },
                    { y: 7 },
                    { y: 7 },
                    { y: 8 },
                    { y: 13 },
                    { y: 11 },
                    { y: 3 }
                ]
            }]
        });
        chart.render();
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Projeler\MovieCave\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6444d908366f49349aba2650f739aad319a072ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Projeler\MovieCave\Views\_ViewImports.cshtml"
using MovieCave;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projeler\MovieCave\Views\_ViewImports.cshtml"
using MovieCave.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6444d908366f49349aba2650f739aad319a072ec", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3815037d9f91e9332948dbe573bd775f455f699a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieCave.Models.Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
 foreach (var item in Model) {
    if (item.Year <= 2021)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <h2 style=""text-align:center"">VIZYONDAKİ FİLMLER</h2>
        <section class=""py-5 bg-light"" id=""scroll-target"">
            <div class=""container px-5 my-5"">
                    <div class=""row gx-5 align-items-center"">
                        <div class=""col-lg-6""> 
                            <a");
            BeginWriteAttribute("href", " href=\"", 477, "\"", 540, 2);
            WriteAttributeValue("", 484, "../Movies/Details/", 484, 18, true);
#nullable restore
#line 15 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
WriteAttributeValue("", 502, Html.DisplayFor(modelItem => item.Id), 502, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"img-fluid rounded mb-5 mb-lg-0 \" width=\"600\" height=\"800\"");
            BeginWriteAttribute("src", " src=\"", 645, "\"", 702, 2);
            WriteAttributeValue("", 651, "./images/", 651, 9, true);
#nullable restore
#line 16 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
WriteAttributeValue("", 660, Html.DisplayFor(modelItem => item.Banner), 660, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."" />
                                </a>
                                </div>
                        <div class=""col-lg-6"">
                            <div class = ""embed-responsiver embed-responsive-16by9"">
                                <iframe width=""560"" height=""315""");
            BeginWriteAttribute("src", " src=\"", 994, "\"", 1043, 1);
#nullable restore
#line 21 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1000, Html.DisplayFor(modelItem => item.Trailer), 1000, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                            </div>
                            <br/>
                            <h2 class=""fw-bolder"">");
#nullable restore
#line 24 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p class=\"lead fw-normal text-muted mb-0\">");
#nullable restore
#line 25 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
                                                                 Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 30 "C:\Projeler\MovieCave\Views\Movies\Index.cshtml"
   }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieCave.Models.Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591

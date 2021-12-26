#pragma checksum "C:\Projeler\MovieCave\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90be7551365bd289af1246b282d0bda2c6fb535d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90be7551365bd289af1246b282d0bda2c6fb535d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3815037d9f91e9332948dbe573bd775f455f699a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieCave.Models.Movies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""container px-0"">
                    <div class=""row gx-5 align-items-center justify-content-center bg-dark"">
                        <div class=""col-lg-8 col-xl-7 col-xxl-6"">
                            <div class=""my-5 text-center text-xl-start"">
                                <h1 class=""display-5 fw-bolder text-white text-center mb-2""> </h1>
                                <p class=""lead fw-normal text-white-50 text-center mb-4"">Yakın zamanda gelmesi planlanan filmler.</p>
                                <div class=""d-grid gap-3 d-sm-flex justify-content-sm-center justify-content-xl-center"">
                                    <a class=""btn btn-primary btn-lg px-4 me-sm-3"" href=""#features"">Hakkında</a>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-5 col-xxl-6 d-none d-xl-block text-center""><img class=""img-fluid rounded-3 my-5"" src=""https://www.dreadcentral.com/wp-c");
            WriteLiteral(@"ontent/uploads/2019/07/Doctor-Strange-2-Movie-Multiverse-Of-Madness-banner.jpg"" alt=""..."" /></div>
                    </div>
                </div>
               <br /><br /><br />
    <div class=""row gx-5 justify-content-center"">
        <div class=""row gx-5"">
");
#nullable restore
#line 24 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 mb-5\">\r\n                            <div class=\"card h-100 shadow border-0\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1647, 2);
            WriteAttributeValue("", 1591, "../Movies/Details/", 1591, 18, true);
#nullable restore
#line 28 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
WriteAttributeValue("", 1609, Html.DisplayFor(modelItem => item.Id), 1609, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1708, "\"", 1765, 2);
            WriteAttributeValue("", 1714, "./images/", 1714, 9, true);
#nullable restore
#line 29 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
WriteAttributeValue("", 1723, Html.DisplayFor(modelItem => item.Banner), 1723, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""..."" />
                                </a>
                                <div class=""card-body p-4"">
                                    <div class=""badge bg-primary bg-gradient rounded-pill mb-2"">Filmler</div>
                                    <a class=""text-decoration-none link-dark stretched-link"" href=""#!""><h5 class=""card-title mb-3"">");
#nullable restore
#line 33 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
                                                                                                                              Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n                                    <p class=\"card-text mb-0\">");
#nullable restore
#line 34 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n            \r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Projeler\MovieCave\Views\Home\Index.cshtml"
        
    }             

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- Call to action-->
                    <aside class=""bg-primary bg-gradient rounded-3 p-4 p-sm-5 mt-5"">
                        <div class=""d-flex align-items-center justify-content-between flex-column flex-xl-row text-center text-xl-start"">
                            <div class=""mb-4 mb-xl-0"">
                                <div class=""fs-3 fw-bold text-white"">Yeni filmlerin haberi için kayıt ol.</div>
                                <div class=""text-white-50"">Sign up for our newsletter for the latest updates.</div>
                            </div>
                            <div class=""ms-xl-4"">
                                <div class=""input-group mb-2"">
                                    <input class=""form-control"" type=""text"" placeholder=""Email address..."" aria-label=""Email address..."" aria-describedby=""button-newsletter"" />
                                    <button class=""btn btn-outline-light"" id=""button-newsletter"" type=""button"">Sign up</button>
           ");
            WriteLiteral(@"                     </div>
                                <div class=""small text-white-50"">Güvenliğine önem veriyoruz.</div>
                            </div>
                        </div>
                    </aside>
                </div>
             </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieCave.Models.Movies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
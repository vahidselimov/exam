#pragma checksum "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e8d9463844137458ab7103d5b1ad4cc6ef27460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\_ViewImports.cshtml"
using Final_Project.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\_ViewImports.cshtml"
using Final_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e8d9463844137458ab7103d5b1ad4cc6ef27460", @"/Views/shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25527b97cbfa2765b40e364820b5868573ede3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer>\r\n    <section id=\"image\"></section>\r\n    <div class=\"contacts\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"con\">\r\n                    <div class=\"contact\">\r\n                        <h1>");
#nullable restore
#line 9 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                       Write(Model.Settings.FooterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                    <div class=\"title\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 13 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                       Write(Model.Settings.FooterTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                    <div class=\"icon\">\r\n                        <div class=\"content col-lg-4 col-md-12 col-sm-12\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 653, "\"", 689, 1);
#nullable restore
#line 19 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 661, Model.Settings.PhoneIconUrl, 661, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            <p>");
#nullable restore
#line 20 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                          Write(Model.Settings.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"content col-lg-4 col-md-12 col-sm-12\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 893, "\"", 929, 1);
#nullable restore
#line 23 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 901, Model.Settings.GmailIconUrl, 901, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            <p>");
#nullable restore
#line 24 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                          Write(Model.Settings.GmailText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"icon2\">\r\n                        <div class=\"content col-lg-4 col-md-12 col-sm-12\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 1206, "\"", 1240, 1);
#nullable restore
#line 29 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1214, Model.Settings.LocIconUrl, 1214, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            <p>");
#nullable restore
#line 30 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                          Write(Model.Settings.LocText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"content col-lg-4 col-md-12 col-sm-12\">\r\n                            <form");
            BeginWriteAttribute("action", " action=\"", 1449, "\"", 1458, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <input type=\"email\" placeholder=\"Subscribe your email\"><a");
            BeginWriteAttribute("href", " href=\"", 1551, "\"", 1558, 0);
            EndWriteAttribute();
            WriteLiteral(">Submit</a>\r\n                            </form>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"copy\">");
#nullable restore
#line 44 "C:\Users\examtwo\source\repos\Final Project\Final Project\Views\shared\Components\Footer\Default.cshtml"
                 Write(Model.Settings.Copyrigth);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""
            integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js""
            integrity=""sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js""></script>
    <script src=""../assets/javascript/index.js""></script>
</footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0129f1f2543a845693e94d0bca22096a7c458861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0129f1f2543a845693e94d0bca22096a7c458861", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f7b35d88b37c975eae9949a4ab8c13b1780a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("about-img-front"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("member photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
            <nav aria-label=""breadcrumb"" class=""breadcrumb-nav border-0 mb-0"">
                <div class=""container"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">About us</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->
            <div class=""container"">
        <div class=""page-header page-header-big text-center""");
            BeginWriteAttribute("style", " style=\"", 734, "\"", 811, 4);
            WriteAttributeValue("", 742, "background-image:", 742, 17, true);
            WriteAttributeValue(" ", 759, "url(\'/uploads/images/", 760, 22, true);
#nullable restore
#line 17 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
WriteAttributeValue("", 781, Model.AboutInfos?.ImagePath, 781, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 809, "\')", 809, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
           
        			<h1 class=""page-title text-white"">About us<span class=""text-white"">Who we are</span></h1>
	        	</div><!-- End .page-header -->
            </div><!-- End .container -->

            <div class=""page-content pb-0"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-6 mb-3 mb-lg-0"">
                            <h2 class=""title"">Our Vision</h2><!-- End .title -->
                    <p> ");
#nullable restore
#line 28 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                   Write(Html.Raw(Model.AboutInfos?.OurVision));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                        </div><!-- End .col-lg-6 -->\r\n                        \r\n                        <div class=\"col-lg-6\">\r\n                            <h2 class=\"title\">Our Mission</h2><!-- End .title -->\r\n                    <p> ");
#nullable restore
#line 33 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                   Write(Html.Raw(Model.AboutInfos?.OurMission));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div><!-- End .col-lg-6 -->
                    </div><!-- End .row -->

                    <div class=""mb-5""></div><!-- End .mb-4 -->
                </div><!-- End .container -->

                <div class=""bg-light-2 pt-6 pb-5 mb-6 mb-lg-8"">
            <div class=""container"">
                        <div class=""row"">
                            <div class=""col-lg-5 mb-3 mb-lg-0"">
                                <h2 class=""title"">Who We Are</h2><!-- End .title -->
                                <p class=""lead text-primary mb-3"">");
#nullable restore
#line 45 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                                             Write(Html.Raw(Model.AboutWhoWeAre?.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><!-- End .lead text-primary -->\r\n                                <p class=\"mb-2\">");
#nullable restore
#line 46 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                           Write(Html.Raw(Model.AboutWhoWeAre?.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                                <a href=""blog.html"" class=""btn btn-sm btn-minwidth btn-outline-primary-2"">
                                    <span>VIEW OUR NEWS</span>
                                    <i class=""icon-long-arrow-right""></i>
                                </a>
                            </div><!-- End .col-lg-5 -->

                            <div class=""col-lg-6 offset-lg-1"">
                                <div class=""about-images"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0129f1f2543a845693e94d0bca22096a7c4588619603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2902, "~/uploads/images/", 2902, 17, true);
#nullable restore
#line 56 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
AddHtmlAttributeValue("", 2919, Model.AboutWhoWeAre.ImagePath, 2919, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div><!-- End .about-images -->
                            </div><!-- End .col-lg-6 -->
                        </div><!-- End .row -->
                    </div><!-- End .container -->
                </div><!-- End .bg-light-2 pt-6 pb-6 -->

                <div class=""container"">
                   

                    <hr class=""mt-4 mb-6"">

                    <h2 class=""title text-center mb-4"">Meet Our Team</h2><!-- End .title text-center mb-2 -->

                    <div class=""row"">
");
#nullable restore
#line 71 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                         foreach(var item in Model.AboutTeam){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        <div class=\"member member-anim text-center\">\r\n                            <figure class=\"member-media\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0129f1f2543a845693e94d0bca22096a7c45886112281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3809, "~/uploads/images/", 3809, 17, true);
#nullable restore
#line 75 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
AddHtmlAttributeValue("", 3826, item.ImagePath, 3826, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                <figcaption class=\"member-overlay\">\r\n                                    <div class=\"member-overlay-content\">\r\n                                        <h3 class=\"member-title\">");
#nullable restore
#line 79 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 79 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                                                            Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3><!-- End .member-title -->\r\n                                        <p>");
#nullable restore
#line 80 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                      Write(Html.Raw(@item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"social-icons social-icons-simple\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4355, "\"", 4380, 1);
#nullable restore
#line 82 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
WriteAttributeValue("", 4362, item.FacebookLink, 4362, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"social-icon\" title=\"Facebook\" target=\"_blank\"><i class=\"icon-facebook-f\"></i></a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4518, "\"", 4542, 1);
#nullable restore
#line 83 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
WriteAttributeValue("", 4525, item.TwitterLink, 4525, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"social-icon\" title=\"Twitter\" target=\"_blank\"><i class=\"icon-twitter\"></i></a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 4676, "\"", 4702, 1);
#nullable restore
#line 84 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
WriteAttributeValue("", 4683, item.InstagramLink, 4683, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""social-icon"" title=""Instagram"" target=""_blank""><i class=""icon-instagram""></i></a>
                                        </div><!-- End .soial-icons -->
                                    </div><!-- End .member-overlay-content -->
                                </figcaption><!-- End .member-overlay -->
                            </figure><!-- End .member-media -->
                            <div class=""member-content"">
                                <h3 class=""member-title"">");
#nullable restore
#line 90 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 90 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                                                    Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h3><!-- End .member-title -->\r\n                            </div><!-- End .member-content -->\r\n                        </div><!-- End .member -->\r\n                    </div>\r\n");
            WriteLiteral("                    <!-- End .col-md-4 -->\r\n");
#nullable restore
#line 96 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div><!-- End .row -->
                </div><!-- End .container -->

                <div class=""mb-2""></div><!-- End .mb-2 -->

                <div class=""about-testimonials bg-light-2 pt-6 pb-6"">
                    <div class=""container"">
                        <h2 class=""title text-center mb-3"">What Customer Say About Us</h2><!-- End .title text-center -->

                        <div class=""owl-carousel owl-simple owl-testimonials-photo"" data-toggle=""owl"" 
                            data-owl-options='{
                                ""nav"": false, 
                                ""dots"": true,
                                ""margin"": 20,
                                ""loop"": false,
                                ""responsive"": {
                                    ""1200"": {
                                        ""nav"": true
                                    }
                                }
                            }'>
");
#nullable restore
#line 119 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                              foreach(var item in Model.AboutCustomers){

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <blockquote class=\"testimonial text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0129f1f2543a845693e94d0bca22096a7c45886119376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6677, "~/uploads/images/", 6677, 17, true);
#nullable restore
#line 121 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
AddHtmlAttributeValue("", 6694, item.ImagePath, 6694, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <p>“");
#nullable restore
#line 122 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                           Write(Html.Raw(@item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("”</p>\r\n                                <cite>\r\n                                    ");
#nullable restore
#line 124 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span>");
#nullable restore
#line 125 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                                     Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </cite>\r\n                            </blockquote><!-- End .testimonial -->\r\n");
#nullable restore
#line 128 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\About.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div><!-- End .testimonials-slider owl-carousel -->
                    </div><!-- End .container -->
                </div><!-- End .bg-light-2 pt-5 pb-6 -->
            </div><!-- End .page-content -->
        </main><!-- End .main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

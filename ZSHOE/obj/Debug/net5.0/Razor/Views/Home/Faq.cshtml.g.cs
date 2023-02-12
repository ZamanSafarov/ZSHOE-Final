#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddea5f5f2c89ce597eb072ae2cc9cad9111fa03a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Faq), @"mvc.1.0.view", @"/Views/Home/Faq.cshtml")]
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
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddea5f5f2c89ce597eb072ae2cc9cad9111fa03a", @"/Views/Home/Faq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"475fba674f1a07948c5d1292978b86116bfa4b90", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Faq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Faq>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml"
  
    ViewData["Title"] = "Faq";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
        	<div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        		<div class=""container"">
        			<h1 class=""page-title"">F.A.Q<span>Pages</span></h1>
        		</div><!-- End .container -->
        	</div><!-- End .page-header -->
            <nav aria-label=""breadcrumb"" class=""breadcrumb-nav"">
                <div class=""container"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">FAQ</li>
                    </ol>
                </div><!-- End .container -->
            </nav><!-- End .breadcrumb-nav -->

            <div class=""page-content"">
                <div class=""container"">
                	<h2 class=""title text-center mb-3"">Questions</h2><!-- End .title -->
    ");
            WriteLiteral("    \t\t\t<div class=\"accordion accordion-rounded\" id=\"accordion-1\">\r\n");
#nullable restore
#line 26 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml"
                          foreach (var item in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					      <div class=""card card-box card-sm bg-light"">
						        <div class=""card-header"" id=""heading-1"">
						        	<h2 class=""card-title"">
						        		<a role=""button"" data-toggle=""collapse"" href=""#collapse-1"" aria-expanded=""true"" aria-controls=""collapse-1"">
						        			");
#nullable restore
#line 32 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml"
                                       Write(item.Question);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						        		</a>
						        	</h2>
						        </div><!-- End .card-header -->
						        <div id=""collapse-1"" class=""collapse show"" aria-labelledby=""heading-1"" data-parent=""#accordion-1"">
							        <div class=""card-body"">
								        ");
#nullable restore
#line 38 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml"
                                   Write(Html.Raw(item.Answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t        </div><!-- End .card-body -->\r\n\t\t\t\t\t\t        </div><!-- End .collapse -->\r\n\t\t\t\t\t      </div>\r\n\t\t\t\t\t         <!-- End .card -->\r\n");
#nullable restore
#line 43 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\Faq.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					</div><!-- End .accordion -->


                </div><!-- End .container -->
            </div><!-- End .page-content -->

            <div class=""cta cta-display bg-image pt-4 pb-4"" style=""background-image: url(assets/images/backgrounds/cta/bg-7.jpg);"">
                <div class=""container"">
                    <div class=""row justify-content-center"">
                        <div class=""col-md-10 col-lg-9 col-xl-7"">
                            <div class=""row no-gutters flex-column flex-sm-row align-items-sm-center"">
                                <div class=""col"">
                                    <h3 class=""cta-title text-white"">If You Have More Questions</h3><!-- End .cta-title -->
                                    <p class=""cta-desc text-white"">Quisque volutpat mattis eros</p><!-- End .cta-desc -->
                                </div><!-- End .col -->

                                <div class=""col-auto"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddea5f5f2c89ce597eb072ae2cc9cad9111fa03a8869", async() => {
                WriteLiteral("<span>CONTACT US</span><i class=\"icon-long-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div><!-- End .col-auto -->
                            </div><!-- End .row no-gutters -->
                        </div><!-- End .col-md-10 col-lg-9 -->
                    </div><!-- End .row -->
                </div><!-- End .container -->
            </div><!-- End .cta -->
        </main><!-- End .main -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Faq>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a358ddcac91d522294af40a5a553ca5673e270ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyAccount), @"mvc.1.0.view", @"/Views/Home/MyAccount.cshtml")]
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
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.ViewModels.OrderViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a358ddcac91d522294af40a5a553ca5673e270ef", @"/Views/Home/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c45f6ef369160357c8390ee92cfca89c78a328", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterFormModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
  
    ViewData["Title"] = "MyAccount";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"main\">\r\n\t<div class=\"page-header text-center\"");
            BeginWriteAttribute("style", " style=\"", 135, "\"", 218, 4);
            WriteAttributeValue("", 143, "background-image:", 143, 17, true);
            WriteAttributeValue(" ", 160, "url(\'", 161, 6, true);
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
WriteAttributeValue("", 166, Url.Content("~/assets/images/page-header-bg.jpg"), 166, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 216, "\')", 216, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
		<div class=""container"">
			<h1 class=""page-title"">My Account<span>Shop</span></h1>
		</div><!-- End .container -->
	</div><!-- End .page-header -->
	<nav aria-label=""breadcrumb"" class=""breadcrumb-nav mb-3"">
		<div class=""container"">
			<ol class=""breadcrumb"">
				<li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
				<li class=""breadcrumb-item""><a href=""#"">Shop</a></li>
				<li class=""breadcrumb-item active"" aria-current=""page"">My Account</li>
			</ol>
		</div><!-- End .container -->
	</nav><!-- End .breadcrumb-nav -->

	<div class=""page-content"">
		<div class=""dashboard"">
			<div class=""container"">
				<div class=""row"">
					<aside class=""col-md-4 col-lg-3"">
						<ul class=""nav nav-dashboard flex-column mb-3 mb-md-0"" role=""tablist"">
							<li class=""nav-item"">
								<a class=""nav-link active"" id=""tab-dashboard-link"" data-toggle=""tab"" href=""#tab-dashboard"" role=""tab"" aria-controls=""tab-dashboard"" aria-selected=""true"">Dashboard</a>
							</li>
				
							<li class");
            WriteLiteral("=\"nav-item\">\r\n\t\t\t\t\t\t\t\t<a class=\"nav-link\" id=\"tab-account-link\" data-toggle=\"tab\" href=\"#tab-account\" role=\"tab\" aria-controls=\"tab-account\" aria-selected=\"false\">Account Details</a>\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 37 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
                             if (@User.Identity.IsAuthenticated)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358ddcac91d522294af40a5a553ca5673e270ef8462", async() => {
                WriteLiteral("Sign Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 42 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						</ul>
					</aside><!-- End .col-lg-3 -->

					<div class=""col-md-8 col-lg-9"">
						<div class=""tab-content"">
							<div class=""tab-pane fade show active"" id=""tab-dashboard"" role=""tabpanel"" aria-labelledby=""tab-dashboard-link"">
								<p>
									Hello <span class=""font-weight-normal text-dark"">");
#nullable restore
#line 50 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
                                                                                Write(User.GetPrincipalName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> (not <span class=\"font-weight-normal text-dark\">");
#nullable restore
#line 50 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
                                                                                                                                                                Write(User.GetPrincipalName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>? ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358ddcac91d522294af40a5a553ca5673e270ef11198", async() => {
                WriteLiteral("Log out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@")
									<br>
									From your account dashboard you can view your <a href=""#tab-account"" class=""tab-trigger-link"">edit your password and account details</a>.
								</p>
							</div><!-- .End .tab-pane -->

						
	<div class=""tab-pane fade"" id=""tab-address"" role=""tabpanel"" aria-labelledby=""tab-address-link"">
								<p>The following addresses will be used on the checkout page by default.</p>

								<div class=""row"">
									<div class=""col-lg-6"">
										<div class=""card card-dashboard"">
											<div class=""card-body"">
												<h3 class=""card-title"">Billing Address</h3><!-- End .card-title -->

												<p>
													User Name<br>
													User Company<br>
													John str<br>
													New York, NY 10001<br>
													1-234-987-6543<br>
													yourmail@mail.com<br>
													<a href=""#"">Edit <i class=""icon-edit""></i></a>
												</p>
											</div><!-- End .card-body -->
										</div><!-- End .card-dashboard -->
									<");
            WriteLiteral(@"/div><!-- End .col-lg-6 -->

									<div class=""col-lg-6"">
										<div class=""card card-dashboard"">
											<div class=""card-body"">
												<h3 class=""card-title"">Shipping Address</h3><!-- End .card-title -->

												<p>
													You have not set up this type of address yet.<br>
													<a href=""#"">Edit <i class=""icon-edit""></i></a>
												</p>
											</div><!-- End .card-body -->
										</div><!-- End .card-dashboard -->
									</div><!-- End .col-lg-6 -->
								</div><!-- End .row -->
							</div><!-- .End .tab-pane -->

							<div class=""tab-pane fade"" id=""tab-account"" role=""tabpanel"" aria-labelledby=""tab-account-link"">
								");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a358ddcac91d522294af40a5a553ca5673e270ef14361", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label>First Name *</label>\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4019, "\"", 4027, 0);
                EndWriteAttribute();
                WriteLiteral(@">
										</div><!-- End .col-sm-6 -->

										<div class=""col-sm-6"">
											<label>Last Name *</label>
											<input type=""text"" class=""form-control"" required>
										</div><!-- End .col-sm-6 -->
									</div><!-- End .row -->

									<label>Display Name *</label>
									<input type=""text"" class=""form-control"" required>
									<small class=""form-text"">This will be how your name will be displayed in the account section and in reviews</small>

									<label>Email address *</label>
									<input type=""email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4602, "\"", 4634, 1);
#nullable restore
#line 113 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Home\MyAccount.cshtml"
WriteAttributeValue("", 4610, User.GetPrincipalName(), 4610, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

									<label>Current password (leave blank to leave unchanged)</label>
									<input type=""password"" class=""form-control"">

									<label>New password (leave blank to leave unchanged)</label>
									<input type=""password"" class=""form-control"">

									<label>Confirm new password</label>
									<input type=""password"" class=""form-control mb-2"">

									<button type=""submit"" class=""btn btn-outline-primary-2"">
										<span>SAVE CHANGES</span>
										<i class=""icon-long-arrow-right""></i>
									</button>
								");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div><!-- .End .tab-pane -->\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div><!-- End .col-lg-9 -->\r\n\t\t\t\t</div><!-- End .row -->\r\n\t\t\t</div><!-- End .container -->\r\n\t\t</div><!-- End .dashboard -->\r\n\t</div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterFormModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

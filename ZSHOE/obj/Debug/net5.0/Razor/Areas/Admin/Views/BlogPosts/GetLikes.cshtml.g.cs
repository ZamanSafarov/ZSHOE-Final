#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6131572036ffed6b7d9aadae47db33198647ea9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPosts_GetLikes), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPosts/GetLikes.cshtml")]
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
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.CategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.ProductModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.BrandModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Business.TagModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6131572036ffed6b7d9aadae47db33198647ea9a", @"/Areas/Admin/Views/BlogPosts/GetLikes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f5eeff6385b7284c8481a0064a6f8f6290018c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BlogPosts_GetLikes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BlogPostLike>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""row align-items-end"">

        <div class=""col"">
            <div class=""page-header-breadcrumb"">
                <ul class=""breadcrumb-title"">
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6131572036ffed6b7d9aadae47db33198647ea9a5861", async() => {
                WriteLiteral(" <i class=\"feather icon-home\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"breadcrumb-item\" style=\"float: left;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6131572036ffed6b7d9aadae47db33198647ea9a7383", async() => {
                WriteLiteral("All blogposts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                    <li class=""breadcrumb-item"" style=""float: left;"">
                        <span>All liked users</span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>


<!-- Page-body start -->
<div class=""page-body"">


    <!-- Horizontal-border table start -->
    <div class=""card"">
        <div class=""card-block table-border-style"">
            <div class=""table-responsive"">
                <table class=""table table-framed table-imaged"">

                    <thead>
                        <tr>
                            <th>
                                Author
                            </th>
                            <th>
                                Liked date
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 50 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 54 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
                               Write(item.CreatedByUser?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
                                                         Write(item.CreatedByUser?.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 57 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 60 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Horizontal-border table end -->\r\n    ");
#nullable restore
#line 69 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Areas\Admin\Views\BlogPosts\GetLikes.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<!-- Page-body end -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BlogPostLike>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7e9b89ef9f586b9aa473900e3b493848fc75da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RecentArrivals_Default), @"mvc.1.0.view", @"/Views/Shared/Components/RecentArrivals/Default.cshtml")]
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
#nullable restore
#line 12 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\_ViewImports.cshtml"
using ZSHOE.Domain.Models.Entities.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc7e9b89ef9f586b9aa473900e3b493848fc75da", @"/Views/Shared/Components/RecentArrivals/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c7c3eccd49f15a409992bb20d1e6d2c543a396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_RecentArrivals_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image-hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
  
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""owl-carousel owl-simple"" data-toggle=""owl""
     data-owl-options='{
                            ""nav"": false,
                            ""dots"": true,
                            ""margin"": 20,
                            ""loop"": false,
                            ""responsive"": {
                                ""0"": {
                                    ""items"":2
                                },
                                ""480"": {
                                    ""items"":2
                                },
                                ""768"": {
                                    ""items"":3
                                },
                                ""992"": {
                                    ""items"":4
                                },
                                ""1200"": {
                                    ""items"":4,
                                    ""nav"": true
                                }
                            }
                ");
            WriteLiteral("        }\'>\r\n");
#nullable restore
#line 33 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
     foreach (var item in Model)
    {
        var imagePath = item.ProductImages.FirstOrDefault()?.Name;
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                                                
        int intValue = Convert.ToInt32(item.Rate);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product product-4\">\r\n            <figure class=\"product-media\">\r\n");
#nullable restore
#line 41 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                 if (item.CreatedDate > DateTime.Now.AddDays(-6))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"product-label label-new\">New</span>\r\n");
#nullable restore
#line 44 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                 if (intValue > 1)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"product-label label-top\">Top</span>\r\n");
#nullable restore
#line 49 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7e9b89ef9f586b9aa473900e3b493848fc75da9670", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc7e9b89ef9f586b9aa473900e3b493848fc75da9945", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1882, "~/uploads/images/", 1882, 17, true);
#nullable restore
#line 51 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
AddHtmlAttributeValue("", 1899, imagePath, 1899, 10, false);

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
                WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                     foreach (var itemImage in item.ProductImages.Where(pi => pi.IsMain == false && pi.DeletedDate == null))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fc7e9b89ef9f586b9aa473900e3b493848fc75da12078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2138, "~/uploads/images/", 2138, 17, true);
#nullable restore
#line 54 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
AddHtmlAttributeValue("", 2155, itemImage.Name, 2155, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <div class=\"product-action-vertical\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2346, "\"", 2388, 3);
            WriteAttributeValue("", 2353, "javascript:addToFavorites(", 2353, 26, true);
#nullable restore
#line 59 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
WriteAttributeValue("", 2379, item.Id, 2379, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2387, ")", 2387, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-product-icon btn-wishlist btn-expandable\"><span>add to wishlist</span></a>\r\n                </div><!-- End .product-action -->\r\n\r\n                <div class=\"product-action\">\r\n                    <a style=\"cursor:pointer;\"  data-product-id=\"");
#nullable restore
#line 63 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" onclick=""addToBasket(event)"" class=""btn-product btn-cart""><span>add to cart</span></a>
                </div><!-- End .product-action -->
            </figure><!-- End .product-media -->

            <div class=""product-body"">
                <div class=""product-cat"">
                    <a>");
#nullable restore
#line 69 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                  Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div><!-- End .product-cat -->\r\n                <h3 class=\"product-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc7e9b89ef9f586b9aa473900e3b493848fc75da18067", async() => {
#nullable restore
#line 71 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3><!-- End .product-title -->\r\n                <div class=\"product-price\">\r\n                    $");
#nullable restore
#line 73 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div><!-- End .product-price -->\r\n                <div class=\"product-nav product-nav-dots\">\r\n");
#nullable restore
#line 76 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                     foreach (var color in item.ProductCatalog){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\" class=\"active\"");
            BeginWriteAttribute("style", " style=\"", 3490, "\"", 3529, 2);
            WriteAttributeValue("", 3498, "background:", 3498, 11, true);
#nullable restore
#line 77 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
WriteAttributeValue("", 3509, color.Color.HexCode, 3509, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"sr-only\">:");
#nullable restore
#line 77 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                                                                                                             Write(color.Color.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n");
#nullable restore
#line 78 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n                </div><!-- End .product-nav -->\r\n            </div><!-- End .product-body -->\r\n        </div>\r\n");
            WriteLiteral("        <!-- End .product -->\r\n");
#nullable restore
#line 85 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\Components\RecentArrivals\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div><!-- End .owl-carousel -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

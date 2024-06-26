#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "030a427148c7cb787cfc741708f7e0d23430567e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"030a427148c7cb787cfc741708f7e0d23430567e", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c7c3eccd49f15a409992bb20d1e6d2c543a396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsViewModel>
    #nullable disable
    {
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
        private global::ZSHOE.Domain.AppCode.TagHelpers.RateStarTagHelper __ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var imagePath = Model.Product.ProductImages.FirstOrDefault(i => i.IsMain == true)?.Name;
    var colorCode = Model.ProductCatalog.Color.HexCode;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav border-0 mb-0"">
        <div class=""container d-flex align-items-center"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Products</li>
            </ol>

        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <div class=""product-details-top"">
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""product-gallery product-gallery-vertical"">
                            <div class=""row"">
                                <figure class=""product-main-image"">
                                    <img id=""product-zoom""");
            BeginWriteAttribute("src", " src=\"", 1132, "\"", 1183, 1);
#nullable restore
#line 28 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
WriteAttributeValue("", 1138, Url.Content("~/uploads/images/" + imagePath), 1138, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-zoom-image=\"");
#nullable restore
#line 28 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                                                                           Write(Url.Content("~/uploads/images/" + imagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""product image"">

                                    <a  id=""btn-product-gallery"" class=""btn-product-gallery"">
                                        <i class=""icon-arrows""></i>
                                    </a>
                                </figure><!-- End .product-main-image -->

                                <div id=""product-zoom-gallery"" class=""product-image-gallery"">
                                    <a class=""product-gallery-item active"" data-image=""");
#nullable restore
#line 36 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                                  Write(Url.Content("~/uploads/images/" + imagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-zoom-image=\"");
#nullable restore
#line 36 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                                                                                                  Write(Url.Content("~/uploads/images/" + imagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1895, "\"", 1946, 1);
#nullable restore
#line 37 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
WriteAttributeValue("", 1901, Url.Content("~/uploads/images/" + imagePath), 1901, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product side\">\r\n                                    </a>\r\n");
#nullable restore
#line 39 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                     foreach (var itemImage in Model.Product.ProductImages.Where(pi => pi.IsMain == false))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"product-gallery-item active\" data-image=\"");
#nullable restore
#line 41 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                                      Write(Url.Content("~/uploads/images/" + itemImage.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-zoom-image=\"");
#nullable restore
#line 41 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                                                                                                           Write(Url.Content("~/uploads/images/" + itemImage.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2437, "\"", 2493, 1);
#nullable restore
#line 42 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
WriteAttributeValue("", 2443, Url.Content("~/uploads/images/" + itemImage.Name), 2443, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product side\">\r\n                                        </a>\r\n");
#nullable restore
#line 44 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"



                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div><!-- End .product-image-gallery -->
                            </div><!-- End .row -->
                        </div><!-- End .product-gallery -->
                    </div><!-- End .col-md-6 -->

                    <div class=""col-md-6"">
                        <div class=""product-details"">
                            <h1 class=""product-title"">");
#nullable restore
#line 55 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                 Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><!-- End .product-title -->\r\n\r\n\r\n                            <div class=\"ratings-container\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("rate", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "030a427148c7cb787cfc741708f7e0d23430567e10998", async() => {
            }
            );
            __ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper = CreateTagHelper<global::ZSHOE.Domain.AppCode.TagHelpers.RateStarTagHelper>();
            __tagHelperExecutionContext.Add(__ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper);
#nullable restore
#line 59 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
__ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper.RateValue = Model.Product.Rate;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("rate-value", __ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper.RateValue, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
__ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper.ProductId = Model.Product.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("rate-product-id", __ZSHOE_Domain_AppCode_TagHelpers_RateStarTagHelper.ProductId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                              \r\n                            </div><!-- End .rating-container -->\r\n\r\n                            <div class=\"product-price\">\r\n                                $");
#nullable restore
#line 64 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                            Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div><!-- End .product-price -->\r\n\r\n                            <div class=\"product-content\">\r\n                                <p>");
#nullable restore
#line 68 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                              Write(Html.Raw(Model.Product.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div><!-- End .product-content -->

                            <div class=""details-filter-row details-row-size"">
                                <label>Color:</label>

                                <div class=""product-nav product-nav-thumbs"">
                                    <a  class=""active"">
                                        <div");
            BeginWriteAttribute("style", " style=\"", 4035, "\"", 4096, 5);
            WriteAttributeValue("", 4043, "background-color:", 4043, 17, true);
#nullable restore
#line 76 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
WriteAttributeValue("", 4060, colorCode, 4060, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4070, ";width:", 4070, 7, true);
            WriteAttributeValue(" ", 4077, "100%;height:", 4078, 13, true);
            WriteAttributeValue(" ", 4090, "100%;", 4091, 6, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                    </a>
                                </div><!-- End .product-nav -->
                            </div><!-- End .details-filter-row -->

                            <div class=""details-filter-row details-row-size"">
                                <label for=""size"">Size:</label>
                                <span>");
#nullable restore
#line 83 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                 Write(Model.ProductCatalog.Size.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div><!-- End .details-filter-row -->\r\n\r\n\r\n                            <div class=\"product-details-action\">\r\n                                <a style=\"cursor:pointer\" data-product-id=\"");
#nullable restore
#line 89 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                                                      Write(Model.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"addToBasket(event)\" class=\"btn-product btn-cart\"><span>add to cart</span></a>\r\n\r\n                                <div class=\"details-action-wrapper\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 4937, "\"", 4988, 3);
            WriteAttributeValue("", 4944, "javascript:addToFavorites(", 4944, 26, true);
#nullable restore
#line 92 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
WriteAttributeValue("", 4970, Model.Product.Id, 4970, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4987, ")", 4987, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn-product btn-wishlist"" title=""Wishlist""><span>Add to Wishlist</span></a>
                                </div><!-- End .details-action-wrapper -->
                            </div><!-- End .product-details-action -->

                            <div class=""product-details-footer"">
                                <div class=""product-cat"">
                                    <span>Category:</span>
                                   
                                    <a href=""#"">");
#nullable restore
#line 100 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                                           Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                
                                    
                                </div><!-- End .product-cat -->

                                <div class=""social-icons social-icons-sm"">
                                    <span class=""social-label"">Share:</span>
                                    <a href=""#"" class=""social-icon"" title=""Facebook"" target=""_blank""><i class=""icon-facebook-f""></i></a>
                                    <a href=""#"" class=""social-icon"" title=""Twitter"" target=""_blank""><i class=""icon-twitter""></i></a>
                                    <a href=""#"" class=""social-icon"" title=""Instagram"" target=""_blank""><i class=""icon-instagram""></i></a>
                                    <a href=""#"" class=""social-icon"" title=""Pinterest"" target=""_blank""><i class=""icon-pinterest""></i></a>
                                </div>
                            </div><!-- End .product-details-footer -->
                        </div><!-- End .product-details -->
    ");
            WriteLiteral(@"                </div><!-- End .col-md-6 -->
                </div><!-- End .row -->
            </div><!-- End .product-details-top -->

            <div class=""product-details-tab"">
                <ul class=""nav nav-pills justify-content-center"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""product-desc-link"" data-toggle=""tab"" href=""#product-desc-tab"" role=""tab"" aria-controls=""product-desc-tab"" aria-selected=""true"">Description</a>
                    </li>
                </ul>
                <div class=""tab-content"">
                    <div class=""tab-pane fade show active"" id=""product-desc-tab"" role=""tabpanel"" aria-labelledby=""product-desc-link"">
                        <div class=""product-desc-content"">
                            <h3>Product Information</h3>
                            ");
#nullable restore
#line 128 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                       Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div><!-- End .product-desc-content -->
                    </div><!-- .End .tab-pane -->
                  
                </div><!-- End .tab-content -->
            </div><!-- End .product-details-tab -->

            <h2 class=""title text-center mb-4"">Rated Products</h2><!-- End .title text-center -->
          
            ");
#nullable restore
#line 137 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
       Write(await Component.InvokeAsync("RatedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div><!-- End .container -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>

        $('.rate li').click(function (e) {
            e.preventDefault();
            e.stopPropagation();

            const data = $(e.currentTarget).data();

            console.log(data);

            $.ajax({
                url: '");
#nullable restore
#line 153 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Details.cshtml"
                 Write(Url.Action("SetProductRate"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'POST',
                data: data,
                contentType: 'application/x-www-form-urlencoded',
                success: function (response) {
                    location.reload()
                    console.log(response);
                },
                error: function (response) {
                    console.error(response);
                }
            });
        });


    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral(@"
    <style>
        .rate {
            display: flex;
        }

            .rate li {
                color: #f9ba48;
                margin-right: 1px;
                list-style: none;
                font-family: ""Font Awesome 5 Free"";
                cursor: pointer;
            }

                .rate li::before {
                    content: ""\f005"";
                    font-weight: 400;
                }

            .rate.rate-half1 li:nth-child(1)::before {
                content: ""\f5c0"";
                font-weight: 900;
            }

            .rate.rate-1 li:nth-child(1)::before,
            .rate.rate-half2 li:nth-child(1)::before,
            .rate.rate-3 li:nth-child(1)::before,
            .rate.rate-3 li:nth-child(2)::before,
            .rate.rate-half3 li:nth-child(1)::before,
            .rate.rate-half3 li:nth-child(2)::before,
            .rate.rate-half4 li:nth-child(1)::before,
            .rate.rate-half4 li:nth-child(2)::before,
            .");
                WriteLiteral(@"rate.rate-half4 li:nth-child(3)::before,
            .rate.rate-4 li:nth-child(1)::before,
            .rate.rate-4 li:nth-child(2)::before,
            .rate.rate-4 li:nth-child(3)::before,
            .rate.rate-half5 li:nth-child(1)::before,
            .rate.rate-half5 li:nth-child(2)::before,
            .rate.rate-half5 li:nth-child(3)::before,
            .rate.rate-half5 li:nth-child(4)::before,
            .rate.rate-5 li:nth-child(1)::before,
            .rate.rate-5 li:nth-child(2)::before,
            .rate.rate-5 li:nth-child(3)::before,
            .rate.rate-5 li:nth-child(4)::before {
                content: ""\f005"";
                font-weight: 900;
            }

            .rate.rate-half2 li:nth-child(2)::before {
                content: ""\f5c0"";
                font-weight: 900;
            }

            .rate.rate-2 li:nth-child(1)::before,
            .rate.rate-2 li:nth-child(2)::before {
                content: ""\f005"";
                font-weight: 900;
 ");
                WriteLiteral(@"           }

            .rate.rate-half3 li:nth-child(3)::before {
                content: ""\f5c0"";
                font-weight: 900;
            }

            .rate.rate-3 li:nth-child(3)::before {
                content: ""\f005"";
                font-weight: 900;
            }

            .rate.rate-half4 li:nth-child(4)::before {
                content: ""\f5c0"";
                font-weight: 900;
            }

            .rate.rate-4 li:nth-child(4)::before {
                content: ""\f005"";
                font-weight: 900;
            }

            .rate.rate-half5 li:nth-child(5)::before {
                content: ""\f5c0"";
                font-weight: 900;
            }

            .rate.rate-5 li:nth-child(5)::before {
                content: ""\f005"";
                font-weight: 900;
            }
    </style>
            ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a73029946669d432e1b5f33647d74d537de9786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a73029946669d432e1b5f33647d74d537de9786", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b4d27f5f6fdc7ad58997ee0466065c2d215a79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedViewModel<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "popularity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Shop</h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav mb-2"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Shop</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <div class=""toolbox"">
                        <div class=""toolbox-left"">
                            <div class=""toolbox-info"">
                                Showing <span>9 of 56</");
            WriteLiteral(@"span> Products
                            </div><!-- End .toolbox-info -->
                        </div><!-- End .toolbox-left -->

                        <div class=""toolbox-right"">
                            <div class=""toolbox-sort"">
                                <label for=""sortby"">Sort by:</label>
                                <div class=""select-custom"">
                                    <select name=""sortby"" id=""sortby"" class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a73029946669d432e1b5f33647d74d537de97867546", async() => {
                WriteLiteral("Most Popular");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a73029946669d432e1b5f33647d74d537de97868834", async() => {
                WriteLiteral("Most Rated");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a73029946669d432e1b5f33647d74d537de978610037", async() => {
                WriteLiteral("Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div><!-- End .toolbox-sort -->
                        </div><!-- End .toolbox-right -->
                    </div><!-- End .toolbox -->

                    <div class=""products mb-3"">
                        <div class=""row justify-content-center"">
                            <div id=""products"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a73029946669d432e1b5f33647d74d537de978611655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 49 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div><!-- End .row -->\r\n                    </div><!-- End .products -->\r\n");
            WriteLiteral("                    <!-- Pagination -->\r\n                    <div class=\"div mb-40\" style=\"text-align:center\">\r\n                        <div class=\"col-12\">\r\n                            ");
#nullable restore
#line 76 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Index.cshtml"
                       Write(Model.GetPager(Url, "Index", paginateFunction: "goPage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div><!-- End .col-lg-9 -->\r\n                <aside class=\"col-lg-3 order-lg-first\">\r\n                    ");
#nullable restore
#line 81 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shop\Index.cshtml"
               Write(await Component.InvokeAsync("SearchPanel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <!-- End .sidebar sidebar-shop -->\r\n                </aside><!-- End .col-lg-3 -->\r\n            </div><!-- End .row -->\r\n        </div><!-- End .container -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n");
            DefineSection("addcss", async() => {
                WriteLiteral(@"

    <style>


        .pagination {
            display: inline-block;
            padding-left: 12px;
            margin: 20px 0;
            border-radius: 4px;
        }

            .pagination li {
                display: inline-block;
                text-transform: uppercase;
            }

            .pagination > li:first-child > a, .pagination > li:first-child > span, .pagination > li:last-child > a, .pagination > li:last-child > span {
                border-radius: 0;
            }

            .pagination > .disabled > a, .pagination > .disabled > a:focus, .pagination > .disabled > a:hover, .pagination > .disabled > span, .pagination > .disabled > span:focus, .pagination > .disabled > span, pagination > li > a:hover {
                color: #777;
                cursor: not-allowed;
                background-color: #fff;
                border-color: #ddd;
            }

            .pagination > li a {
                font-size: 15px;
                font-weigh");
                WriteLiteral(@"t: bold;
                padding: 6px 14px;
                transition: all 0.15s linear;
            }

            .pagination > li > a, .pagination > li > span {
                position: relative;
                float: left;
                padding: 6px 12px;
                margin-left: -1px;
                line-height: 1.42857143;
                color: #337ab7;
                text-decoration: none;
                background-color: #fff;
                border: 1px solid #ddd;
                color: #888;
                border-radius: 50%;
            }

            .pagination > .active > a, .pagination > .active > a:focus, .pagination > .active > a:hover, .pagination > .active > span, .pagination > .active > span:focus, .pagination > .active > span:hover {
                z-index: 2;
                color: #fff;
                cursor: default;
                background-color: black;
                border-color: black;
            }

            .pagination a {
     ");
                WriteLiteral(@"           color: #fff;
                font-size: 12px;
                margin: 0 10px;
            }

            .pagination > li > a:hover {
                color: #fff;
                background-color: black;
                transition: all 0.15s linear;
            }


            .pagination a i {
                margin: 0 5px;
            }


        .widget li {
            list-style: none;
            line-height: 28px;
            padding: 10px 0;
            position: relative;
        }

        .list-category-item {
            margin-left: 10px;
            border-bottom: 1px solid #eee;
            border: none;
        }

        .category-input {
            transform: scale(1.4);
            margin-right: 8px;
            accent-color: #403b3b;
        }




        .category-hover-item:hover .label-text, .widget li:hover .show-children {
            color: lightgray;
        }

        .show-children {
            cursor: pointer;
            ");
                WriteLiteral(@"padding-top: 5px;
            position: absolute;
            right: 10px;
        }




        .border-none {
            border: none;
        }


        .widget_filter_price .ui-widget-content {
            background: #ddd;
            border-radius: 2px;
            height: 4px;
            border: none;
        }

        .widget_filter_price .ui-slider .ui-slider-range {
            background: #ab8e66;
        }

        .widget_filter_price .ui-slider .ui-slider-handle {
            width: 0;
            height: 0;
            border: none;
            top: -6px;
            border-radius: 1em;
            cursor: ew-resize;
            margin-left: -0.3em;
            outline: 0 none;
            position: absolute;
            z-index: 2;
            border-color: #ab8e66 transparent;
        }

            .widget_filter_price .ui-slider .ui-slider-handle::before {
                content: """";
                border-style: solid;
                border-wi");
                WriteLiteral(@"dth: 8px 6px 0 6px;
                border-color: #ab8e66 transparent;
            }

        .widget_filter_price .price-slider-amount {
            margin-top: 25px;
            font-size: 13px;
            color: #666666;
            overflow: hidden;
        }

        .price-slider-amount span {
            display: inline-block;
            font-size: 15px;
            color: #0a0a0a;
            border: 1px solid #eeeeee;
            padding: 4px 10px;
            font-weight: 600;
            border-radius: 0;
        }










        .woof_Widget .price-slider-amount span:first-child {
            margin-right: 10px;
        }

        .widget_filter_price .ui-widget-content {
            background: #ddd;
            border-radius: 2px;
            height: 4px;
            border: none;
        }

        .widget_filter_price .ui-slider .ui-slider-range {
            background: #ab8e66;
        }

        .widget_filter_price .ui-slider .ui-slider-han");
                WriteLiteral(@"dle {
            width: 0;
            height: 0;
            border: none;
            top: -6px;
            border-radius: 1em;
            cursor: ew-resize;
            margin-left: -0.3em;
            outline: 0 none;
            position: absolute;
            z-index: 2;
            border-color: #ab8e66 transparent;
        }

            .widget_filter_price .ui-slider .ui-slider-handle::before {
                content: """";
                border-style: solid;
                border-width: 8px 6px 0 6px;
                border-color: #ab8e66 transparent;
            }

        .widget_filter_price .price-slider-amount {
            margin-top: 25px;
            font-size: 13px;
            color: #666666;
            overflow: hidden;
        }






        [data-entity-type] {
            position: relative;
            padding-left: 30px;
            display: block;
            cursor: pointer;
        }

            [data-entity-type]:not(.filled)::befor");
                WriteLiteral(@"e {
                content: """";
                font-size: 0.7em;
                font-weight: 900;
                font-family: ""Font Awesome 5 Free"";
                position: absolute;
                width: 20px;
                height: 20px;
                border-radius: 2px;
                top: 50%;
                left: 0px;
                transform: translateY(-50%);
                text-align: center;
                text-indent: 1px;
                line-height: 1.7em;
                border-radius: 50%;
                border: 1px solid #343a40;
            }

            [data-entity-type].active:not(.filled)::before {
                content: ""✓"";
                color: #ffffff;
                background-color: #343a40;
                border-color: #343a40;
            }

            [data-entity-type].filled {
                width: 30px;
                height: 25px;
                border-radius: 2px;
                border: 1px solid #cccccc85;
           ");
                WriteLiteral(@" }

                [data-entity-type].filled::before {
                    content: """";
                    display: inline-block;
                    padding-left: 1px;
                    line-height: 7pt;
                    font-size: 5pt;
                    font-weight: 900;
                    font-family: ""Font Awesome 5 Free"";
                    position: absolute;
                    top: 1px;
                    right: 1px;
                }

                [data-entity-type].filled.active::before {
                    content: ""\f00c"";
                    color: #000000c4;
                    background-color: #ffffff;
                    border: 1px solid #000000c4;
                    width: 12px;
                    height: 12px;
                    border-radius: 100%;
                }

        #price-range[range]::before {
            content: attr(range);
            display: flex;
            justify-content: center;
            padding-top: 15px;
        }");
                WriteLiteral(@"

        .def-item {
            padding-bottom: 16px;
            font-size: 15px;
            line-height: 1.4;
        }

        .def-cap {
            font-size: 22px;
            font-weight: 400;
            color: #fff;
            width: 100%;
            padding: 0 20px;
            border-radius: 5px;
            background: #484848;
            border-bottom: 1px solid #dbdbdb;
        }

        .border-default .def-list {
            overflow-y: scroll;
            max-height: 206px;
        }

        .def-color-name {
            display: inline-block;
            padding-left: 15px;
            width: 100px;
            font-size: 16px;
            color: black;
        }

        .def-link {
            color: black;
        }

            .def-link:hover, .def-link:focus, .def-link:active {
                outline: none;
                text-decoration: none;
                color: black;
            }



        .rate {
            display: fle");
                WriteLiteral(@"x;
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
            .rate.rate-half4 li:nth-child(3)::before,
            .r");
                WriteLiteral(@"ate.rate-4 li:nth-child(1)::before,
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
            }

            .rate.rate-half3 li:nth-chil");
                WriteLiteral(@"d(3)::before {
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
            DefineSection("addjs", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $(`.show-children`).click(function () {

                let btnId = $(this).data(""btn-id"");

                $("".children-categories"").each(function () {

                    let categoryId = $(this).data(""id"");

                    if (btnId == categoryId) {
                        $(`.children-categories.ul-${categoryId}`).slideToggle({ duration: 250 });
                        $(`.show-children-${btnId}`).toggleClass(""rotate"");
                    }
                })

            })

            $("".label-text"").click(function () {
                let entityId = $(this).data(""entity-id"");

                $(`.category-hover-item .label-text-${entityId}`).toggleClass(""checked"");
            })


            $("".category-input"").click(function () {
                let entityId = $("".label-text-category"").data(""entity-id"");

                $(`.category-hover-item .label-text-category-${entityId}`).toggleClass(""");
                WriteLiteral(@"checked"");
            })

            $('li div input.category-input').click(function () {

                setFilter();
            });
        })

        const priceRangeData = $(""#price-slider"").data();


        const searchModel = {
            categories: [],
            brands: [],
            colors: [],
            sizes: [],
            min: priceRangeData.priceMin,
            max: priceRangeData.priceMax
        };

        $(document).ready(function () {
            $('.blog-pagination.ptb-20')
                .removeClass('blog-pagination')
                .removeClass('ptb-20')
                .addClass('list-inline');




            //var priceSlider = document.getElementById('price-slider');



            //priceSlider.setAttribute('range', `${searchModel.min}₼ - ${searchModel.max}₼`);
            //var slider = document.querySelector(""#price-slider"");
            //if (!slider.classList.contains('noUi-target')) {
            //    noUiSlider.create(sl");
                WriteLiteral(@"ider, {
            //        start: [0, searchModel.max],
            //        connect: true,
            //        values: [searchModel.min, searchModel.max],
            //        range: {
            //            'min':0,
            //            'max': searchModel.max
            //        },
            //        format: wNumb({
            //            decimals: 0,
            //            prefix: '$'
            //        })
            //    });
            //} else {
            //    slider.noUiSlider.updateOptions({
            //        start: [0, searchModel.max],
            //        range: {
            //            'min': 0,
            //            'max': searchModel.max
            //        },
            //        format: wNumb({
            //            decimals: 0
            //        })
            //    });
            //}

           

            //// Update Price Range
            //priceSlider.noUiSlider.on('update', function (e, ui) {
     ");
                WriteLiteral(@"       //    $('#filter-price-range').text(e.join(' - '));
            //    $(e.target).attr('range', `${ui.values[0]}₼ - ${ui.values[1]}₼`);
            //    searchModel.min = ui.values[0];
            //    searchModel.max = ui.values[1];

            //    filterProducts();
            //});



            $('[data-entity-type]').click(function (e) {

                e.preventDefault();

                let model = $(e.currentTarget).data();  //entityType  id

                if ($(e.currentTarget).hasClass('active') == true) {
                    $(e.currentTarget).removeClass('active');
                    searchModel[`${model.entityType}`] = searchModel[`${model.entityType}`].filter(item => item != model.id);
                }
                else {
                    $(e.currentTarget).addClass('active');

                    if (searchModel[`${model.entityType}`].filter(item => item == model.id).length == 0) {
                        searchModel[`${model.entityType}`].push(m");
                WriteLiteral(@"odel.id);
                    }
                }

                filterProducts();
            });
        });

        function filterProducts() {
            if ($.pid != undefined) {
                clearTimeout($.pid);
            }

            $.pid = setTimeout(function () {
                console.log(searchModel);

                $.ajax({
                    type: 'POST',
                    data: searchModel,
                    contentType: 'application/x-www-form-urlencoded',
                    success: function (response) {

                        $('#products').html(response);
                        //console.log(response);
                    },
                    error: function (response) {
                        console.log(response);
                    }
                });
            }, 1500);
        }


        $("".forColors"").click(function () {
            $(this).toggleClass(""selected"")
        })


    </script>




");
                WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedViewModel<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\_BasketScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d19942a46d53ddd165908a8cee9da36796211e8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketScriptsPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketScriptsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d19942a46d53ddd165908a8cee9da36796211e8e", @"/Views/Shared/_BasketScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c7c3eccd49f15a409992bb20d1e6d2c543a396", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__BasketScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("removeable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/sweetalert/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d19942a46d53ddd165908a8cee9da36796211e8e5297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
<script>

    function removeFromBasket(element, name) {

        swal(`Are you sure to delete '${name}' from your cart?`, {
            title: ""Delete"",
            text: `Are you sure to delete '${name}' from your cart?`,
            icon: ""warning"",
            buttons: true,
            dangerMode: true,
            buttons: [""No"", ""Yes""]
        })
            .then((value) => {

                if (value == true) {
                    const elementData = $(element).data();
                    console.log(elementData);

                    $.ajax({
                        url: `");
#nullable restore
#line 23 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\_BasketScriptsPartial.cshtml"
                         Write(Url.Action("RemoveFromBasket","Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                        type: 'POST',
                        data: elementData,
                        contentType: 'application/x-www-form-urlencoded',
                        success: function (response) {
                            if (response.error == false) {

                                const removeTarget = $(element).attr('area-remove-target');

                                if (removeTarget != undefined) {
                                    $(removeTarget).remove();
                                }

                                //if (response.value.count == undefined) {
                                //    $('.item-countt').text('')
                                //}
                                //else {
                                //    $('.item-count').text(`${response.value.count}`) //basket header
                                //}


                                if (response.value?.count == null) {
                                    $('.cart-count').text("""");
      ");
            WriteLiteral(@"                          } else {
                                    $('.cart-count').text(response.value.count);
                                }

                                if (response.value?.total == null) {
                                    $('.total-price').add("".Price-amount"").text(""0.00$"");
                                } else {
                                    $('.total-price').add("".Price-amount"").text(`${response.value.total}.00$`);
                                }

                                toastr.success(response.message, 'Success');
                                return;
                            }

                            toastr.error(response.message, 'Error');
                        },
                        error: function (response, status, xhr) {
                            console.log(response, status, xhr);
                        }
                    });
                }
            });


    }


    function changeQuantity(event, element) {

        if ");
            WriteLiteral(@"($.processId != undefined) {
            clearTimeout($.processId);
            $.processId = undefined;
        }

        if (element.value < 1) {
            console.log(""olmadiki"", element.value)
            return;
        }

        $.processId = setTimeout(function () {

            const elementData = $(element).data();
            elementData.Quantity = element.value;

            console.log(elementData)

            $.ajax({
                url: `");
#nullable restore
#line 93 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\_BasketScriptsPartial.cshtml"
                 Write(Url.Action("ChangeBasketQuantity","Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                type: 'POST',
                data: elementData,
                contentType: 'application/x-www-form-urlencoded',
                success: function (response) {
                    console.log(response)

                    if (response.error == false) {
                      
                        $("".total-price"").text(`${response.value.summary},00$`);

                        if (response.value?.total == null) {
                            $(`.product-subtotal-${response.value.id}`).text(``)
                        } else {
                            $(`.product-subtotal-${response.value.id}`).text(`${response.value.total}$`)
                        }

                        if (response.value?.price == null) {
                            $(`.amount-${response.value.id}`).text(``)
                        } else {
                            $(`.amount-${response.value.id}`).text(`${response.value.price},00$`)
                        }

                        if(response.value?.quan");
            WriteLiteral(@"tity == null){
                            $(`.info-product-${response.value.id}`).text(``)
                        }
                        else{
                            $(`.info-product-${response.value.id}`).text(`${response.value.quantity}`)
                        }

                        if (response.value?.total == null) {
                            $('.total-price').add('.info-amount').text("""");
                        } else {
                            $('.total-price').add('.info-amount').text(`${response.value.summary},00$`);
                        }

                        toastr.success(response.message, 'Success');
                        return;
                    }

                    toastr.error(response.message, 'Error');
                },
                error: function (response, status, xhr) {
                    console.log(response, status, xhr);
                }
            });

        }, 700);

    }

    function addToFavorites(productId) {
        const favorites =");
            WriteLiteral(@" ($.cookie('favorites') || '').split(',').filter(item => item.length > 0);

        if (favorites.filter(item => item == productId).length == 0) {
            favorites.push(productId);

            $.cookie('favorites', favorites.toString(), { path: '/' });
        }

        let isInArray = true;

        $.each(favorites, function (index, value) {
            if (value === productId) {
                isInArray = true;
            } else {
                isInArray = false;
            }
        });

        if (isInArray) {
            toastr.success(""Added to favorites"");
        } else {
            toastr.success(""Product is already in your favorites"");
        }

        console.log($.cookie('favorites'))



    }

    function addToBasket(e) {
        e.preventDefault();

        const elementData = $(e.currentTarget).data();

        $.ajax({
            url: `");
#nullable restore
#line 181 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\_BasketScriptsPartial.cshtml"
             Write(Url.Action("Basket","Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
            type: 'POST',
            data: elementData,
            contentType: 'application/x-www-form-urlencoded',
            success: function (response) {
                if (response.error == false) {
                    //$(e.target).closest('div.card').remove();

                    var newBasketProduct = `
                    <div class='product basket-item-${response.value.product.productId}'>
                        <div class='product-cart-details'>
                            <h4 class='product-title'>
                                <a asp-controller='shop' asp-action='details' asp-route-id='${response.value.product.productId}'>${response.value.product.product.name}</a>
                            </h4>

                            <span class='cart-product-info'>
                                <span class='cart-product-qty'>${response.value.product.quantity}</span>
                                x ${response.value.product.product.price}
                            </span>
               ");
            WriteLiteral(@"         </div>

                        <figure class='product-image-container'>
                            <a asp-controller='shop' asp-action='details' asp-route-id='${response.value.product.productId} class='product-image'>
                                <img src='/uploads/images/${response.value.product.product.productImages[0].name}' alt='product'>
                            </a>
                        </figure>
                        <a onclick='removeFromBasket(this,""${response.value.product.product.name}"");return;' data-product-id='${response.value.product.productId}' area-remove-target='.basket-item-${response.value.product.productId}' style='cursor:pointer' class='btn-remove' title='Remove Product'><i class='icon-close'></i></a>

                    </div>`;

                    $("".dropdown-cart-products"").append(newBasketProduct);


                    $("".cart-count"").css('display', 'block !important');
                    $("".cart-count"").text(response.value.basketInfo.count);
            ");
            WriteLiteral(@"        $("".total-price"").text(`${response.value.basketInfo.total}.00 $`);



                   
                    console.log(response)

                    toastr.success(response.message, 'Success');
                    return;

                }
                console.log(response)

                toastr.info(response.message, 'Info');
            },
            error: function (response, status, xhr) {
                console.log(response, status, xhr);
            }
        });
    }


    $(document).ready(function () {

        if ($.searchProductId != undefined) {
            clearTimeout($.searchProductId);
        }


        $.searchProductId = setTimeout(function () {
            

            $("".input-search"").on(""input"", function (e) {
                var searchTerm = e.currentTarget.value
                

                var obj = { ""searchTerm"": searchTerm }

                //console.log(obj)

                $.ajax({
                    url: '");
#nullable restore
#line 257 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Shared\_BasketScriptsPartial.cshtml"
                     Write(Url.Action("SearchProducts", "Shop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    type: 'POST',
                    data: obj,
                    dataType: 'html',
                    contentType: 'application/x-www-form-urlencoded',
                    success: function (res) {
                        setTimeout(function () {
                            

                            $(""ul.search-results"").html(res).css(""display"", ""block"");

                            if ($("".input-search"").val = '') {
                                $(""ul.search-results"").css(""display"", ""none !important"");
                                return;
                            }

                            if ($(""ul.search-results"").children().length == 0) {
                                var noProduct = ""<div class='searched-item'><span>No product found</span></div>""
                                $(""ul.search-results"").html(noProduct);

                                var interval = setInterval(function () {
                                    $(""ul.search-results"").css(""display""");
            WriteLiteral(@", ""none !important"");
                                    clearInterval(interval);
                                }, 2000);
                            }
                            $(document).click(function (event) {
                                $(""ul.search-results"").css(""display"", ""none"");
                            })

                        }, 1000);

                    },
                    error: function (res) {
                        //console.warn(res);
                    }

                })
            })
           

        }, 2000);
    })
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

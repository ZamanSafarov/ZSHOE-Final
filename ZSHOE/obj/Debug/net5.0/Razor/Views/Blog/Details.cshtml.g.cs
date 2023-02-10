#pragma checksum "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df46b26e241e08ef2fd9364affca6ae12590922e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df46b26e241e08ef2fd9364affca6ae12590922e", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f7b35d88b37c975eae9949a4ab8c13b1780a6a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogPost>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("replyForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

    IEnumerable<BlogPostComment> GetComments(BlogPostComment parent)
    {
        if (parent.ParentId != null)
            yield return parent;

        foreach (var item in parent.Children.SelectMany(c => GetComments(c)))
        {
            yield return item;
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Single Post <span>Blog</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav mb-3"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""blog.html"">Blog</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Blog Single</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <article class=""entry single-entry"">
                        <figure clas");
            WriteLiteral("s=\"entry-media\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "df46b26e241e08ef2fd9364affca6ae12590922e6631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1437, "~/uploads/images/", 1437, 17, true);
#nullable restore
#line 41 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 1454, Model.ImagePath, 1454, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </figure><!-- End .entry-media -->

                        <div class=""entry-body"">
                            <div class=""entry-meta"">
                                <span class=""entry-author"">
                                    by <a href=""#"">Zaman Safarov</a>
                                </span>
                                <span class=""meta-separator"">|</span>
                                <a href=""#"">");
#nullable restore
#line 50 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                       Write(Model.PublishedDate?.ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <span class=\"meta-separator\">|</span>\r\n                                <a href=\"#\">");
#nullable restore
#line 52 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                       Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</a>\r\n                            </div><!-- End .entry-meta -->\r\n\r\n                            <h2 class=\"entry-title\">\r\n                               ");
#nullable restore
#line 56 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h2><!-- End .entry-title -->\r\n\r\n                            <div class=\"entry-cats\">\r\n                                in  ");
#nullable restore
#line 60 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                     foreach (var tag in Model.TagCloud)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a class=\"blog-tag__link d-inline-block\" href=\"#\">\r\n                                            ");
#nullable restore
#line 64 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                       Write(tag.Tag.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 67 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div><!-- End .entry-cats -->\r\n\r\n                            <div class=\"entry-content editor-content\">\r\n                                <p>");
#nullable restore
#line 71 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                              Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                <div class=\"pb-1\"></div><!-- End .mb-1 -->\r\n\r\n\r\n                                <blockquote>\r\n                                  <p>\"");
#nullable restore
#line 77 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                 Write(Html.Raw(Model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</p>
                                </blockquote>

                            </div><!-- End .entry-content -->

                            <div class=""entry-footer row no-gutters flex-column flex-md-row"">
                                <div class=""col-md"">
                                    <div class=""entry-tags"">
                                        <span>Tags:</span>
");
#nullable restore
#line 86 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                         foreach (var tag in Model.TagCloud)
                                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a href=\"#\">");
#nullable restore
#line 88 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                   Write(tag.Tag.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n");
#nullable restore
#line 89 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div><!-- End .entry-tags -->
                                </div><!-- End .col -->

                                <div class=""col-md-auto mt-2 mt-md-0"">
                                    <div class=""social-icons social-icons-color"">
                                        <span class=""social-label"">Share this post:</span>
                                        <a href=""#"" class=""social-icon social-facebook"" title=""Facebook"" target=""_blank""><i class=""icon-facebook-f""></i></a>
                                        <a href=""#"" class=""social-icon social-twitter"" title=""Twitter"" target=""_blank""><i class=""icon-twitter""></i></a>
                                        <a href=""#"" class=""social-icon social-pinterest"" title=""Pinterest"" target=""_blank""><i class=""icon-pinterest""></i></a>
                                        <a href=""#"" class=""social-icon social-linkedin"" title=""Linkedin"" target=""_blank""><i class=""icon-linkedin""></i></a>
                        ");
            WriteLiteral(@"            </div><!-- End .soial-icons -->
                                </div><!-- End .col-auto -->
                            </div><!-- End .entry-footer row no-gutters -->
                        </div><!-- End .entry-body -->

                        
                    </article><!-- End .entry -->

                    <nav class=""pager-nav"" aria-label=""Page navigation"">
                        <a class=""pager-link pager-link-prev"" href=""#"" aria-label=""Previous"" tabindex=""-1"">
                            Previous Post
                            <span class=""pager-link-title"">Cras iaculis ultricies nulla</span>
                        </a>

                        <a class=""pager-link pager-link-next"" href=""#"" aria-label=""Next"" tabindex=""-1"">
                            Next Post
                            <span class=""pager-link-title"">Praesent placerat risus</span>
                        </a>
                    </nav><!-- End .pager-nav -->

                    <div class=");
            WriteLiteral(@"""related-posts"">
                        <h3 class=""title"">Recent Posts</h3><!-- End .title -->

                        <div class=""owl-carousel owl-simple"" data-toggle=""owl""
                             data-owl-options='{
                                        ""nav"": false,
                                        ""dots"": true,
                                        ""margin"": 20,
                                        ""loop"": false,
                                        ""responsive"": {
                                            ""0"": {
                                                ""items"":1
                                            },
                                            ""480"": {
                                                ""items"":2
                                            },
                                            ""768"": {
                                                ""items"":3
                                            }
                                    ");
            WriteLiteral(@"    }
                                    }'>
                            <article class=""entry entry-grid"">
                                <figure class=""entry-media"">
                                    <a href=""single.html"">
                                        <img src=""assets/images/blog/grid/3cols/post-1.jpg"" alt=""image desc"">
                                    </a>
                                </figure><!-- End .entry-media -->

                                <div class=""entry-body"">
                                    <div class=""entry-meta"">
                                        <a href=""#"">Nov 22, 2018</a>
                                        <span class=""meta-separator"">|</span>
                                        <a href=""#"">2 Comments</a>
                                    </div><!-- End .entry-meta -->

                                    <h2 class=""entry-title"">
                                        <a href=""single.html"">Cras ornare tristique elit.</a>
   ");
            WriteLiteral(@"                                 </h2><!-- End .entry-title -->

                                    <div class=""entry-cats"">
                                        in <a href=""#"">Lifestyle</a>,
                                        <a href=""#"">Shopping</a>
                                    </div><!-- End .entry-cats -->
                                </div><!-- End .entry-body -->
                            </article><!-- End .entry -->

                            <article class=""entry entry-grid"">
                                <figure class=""entry-media"">
                                    <a href=""single.html"">
                                        <img src=""assets/images/blog/grid/3cols/post-2.jpg"" alt=""image desc"">
                                    </a>
                                </figure><!-- End .entry-media -->

                                <div class=""entry-body"">
                                    <div class=""entry-meta"">
                                    ");
            WriteLiteral(@"    <a href=""#"">Nov 21, 2018</a>
                                        <span class=""meta-separator"">|</span>
                                        <a href=""#"">0 Comments</a>
                                    </div><!-- End .entry-meta -->

                                    <h2 class=""entry-title"">
                                        <a href=""single.html"">Vivamus ntulla necante.</a>
                                    </h2><!-- End .entry-title -->

                                    <div class=""entry-cats"">
                                        in <a href=""#"">Lifestyle</a>
                                    </div><!-- End .entry-cats -->
                                </div><!-- End .entry-body -->
                            </article><!-- End .entry -->

                            <article class=""entry entry-grid"">
                                <figure class=""entry-media"">
                                    <a href=""single.html"">
                                       ");
            WriteLiteral(@" <img src=""assets/images/blog/grid/3cols/post-3.jpg"" alt=""image desc"">
                                    </a>
                                </figure><!-- End .entry-media -->

                                <div class=""entry-body"">
                                    <div class=""entry-meta"">
                                        <a href=""#"">Nov 18, 2018</a>
                                        <span class=""meta-separator"">|</span>
                                        <a href=""#"">3 Comments</a>
                                    </div><!-- End .entry-meta -->

                                    <h2 class=""entry-title"">
                                        <a href=""single.html"">Utaliquam sollicitudin leo.</a>
                                    </h2><!-- End .entry-title -->

                                    <div class=""entry-cats"">
                                        in <a href=""#"">Fashion</a>,
                                        <a href=""#"">Lifestyle</a>
        ");
            WriteLiteral(@"                            </div><!-- End .entry-cats -->
                                </div><!-- End .entry-body -->
                            </article><!-- End .entry -->

                            <article class=""entry entry-grid"">
                                <figure class=""entry-media"">
                                    <a href=""single.html"">
                                        <img src=""assets/images/blog/grid/3cols/post-4.jpg"" alt=""image desc"">
                                    </a>
                                </figure><!-- End .entry-media -->

                                <div class=""entry-body"">
                                    <div class=""entry-meta"">
                                        <a href=""#"">Nov 15, 2018</a>
                                        <span class=""meta-separator"">|</span>
                                        <a href=""#"">4 Comments</a>
                                    </div><!-- End .entry-meta -->

                       ");
            WriteLiteral(@"             <h2 class=""entry-title"">
                                        <a href=""single.html"">Fusce pellentesque suscipit.</a>
                                    </h2><!-- End .entry-title -->

                                    <div class=""entry-cats"">
                                        in <a href=""#"">Travel</a>
                                    </div><!-- End .entry-cats -->
                                </div><!-- End .entry-body -->
                            </article><!-- End .entry -->
                        </div><!-- End .owl-carousel -->
                    </div><!-- End .related-posts -->

                    <div class=""comments"">
                        <h3 class=""title"">");
#nullable restore
#line 242 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                     Write(Model.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comments</h3><!-- End .title -->\r\n                       \r\n                        <ul class=\"commentAppend\">\r\n");
#nullable restore
#line 245 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                             foreach (var comment in Model.Comments.Where(c => c.ParentId == null))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <div class=\"comment\"");
            BeginWriteAttribute("id", " id=\"", 13142, "\"", 13160, 2);
            WriteAttributeValue("", 13147, "c-", 13147, 2, true);
#nullable restore
#line 248 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
WriteAttributeValue("", 13149, comment.Id, 13149, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 248 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                                                    Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <div class=""comment-body"">
                                        <a class=""comment-reply"">Reply</a>
                                        <div class=""comment-user"">
                                            <h4>");
#nullable restore
#line 252 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                            Write($"{comment.CreatedByUser?.Name} {comment.CreatedByUser?.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                            <span class=\"comment-date\">");
#nullable restore
#line 253 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                                  Write(comment.CreatedDate.ToString("MMMM d, yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div><!-- End .comment-user -->\r\n\r\n                                        <div class=\"comment-content\">\r\n                                            <p>");
#nullable restore
#line 257 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                          Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div><!-- End .comment-content -->\r\n                                    </div><!-- End .comment-body -->\r\n                                </div><!-- End .comment -->\r\n");
#nullable restore
#line 261 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                 foreach (var subComment in GetComments(comment))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul>\r\n                                    <li>\r\n                                        <div class=\"comment\"");
            BeginWriteAttribute("id", " id=\"", 14335, "\"", 14356, 2);
            WriteAttributeValue("", 14340, "c-", 14340, 2, true);
#nullable restore
#line 265 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
WriteAttributeValue("", 14342, subComment.Id, 14342, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-comment-id=\"");
#nullable restore
#line 265 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                                                               Write(subComment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                            <div class=""comment-body"">
                                                <a class=""comment-reply"">Reply</a>
                                                <div class=""comment-user"">
                                                    <h4>");
#nullable restore
#line 269 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                    Write($"{subComment.CreatedByUser?.Name} {subComment.CreatedByUser?.Surname}");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                                    <span class=\"comment-date\">");
#nullable restore
#line 270 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                                          Write(subComment.CreatedDate.ToString("MMMM d, yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </div><!-- End .comment-user -->\r\n\r\n                                                <div class=\"comment-content\">\r\n                                                     <p> ");
#nullable restore
#line 274 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                                    Write(subComment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div><!-- End .comment-content -->
                                            </div><!-- End .comment-body -->
                                        </div><!-- End .comment -->
                                    </li>
                                </ul>
");
#nullable restore
#line 280 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\r\n");
#nullable restore
#line 282 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                       
                    </div><!-- End .comments -->
                    <div class=""reply"">
                        <div class=""heading"">
                            <h3 class=""title"">Leave A Reply</h3><!-- End .title -->
                            <p class=""title-desc"">Your email address will not be published. Required fields are marked *</p>
                        </div><!-- End .heading -->

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df46b26e241e08ef2fd9364affca6ae12590922e29600", async() => {
                WriteLiteral("\r\n\r\n                            <div id=\"replyToComment\"></div>\r\n                            <input type=\"hidden\" name=\"postId\"");
                BeginWriteAttribute("value", " value=\"", 16207, "\"", 16224, 1);
#nullable restore
#line 295 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
WriteAttributeValue("", 16215, Model.Id, 16215, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""comment mb-30"">
                                <textarea name=""Comment""
                                          class=""form-control""
                                          id=""comment-text""
                                          placeholder=""Comment *""></textarea>
                            </div>
                            <button type=""submit"" class=""btn btn-outline-primary-2"">
                                <span>POST COMMENT</span>
                                <i class=""icon-long-arrow-right""></i>
                            </button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div><!-- End .reply -->\r\n                </div><!-- End .col-lg-9 -->\r\n\r\n            </div><!-- End .row -->\r\n        </div><!-- End .container -->\r\n    </div><!-- End .page-content -->\r\n</main><!-- End .main -->\r\n\r\n");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".comment-reply"").click(function (e) {
                e.preventDefault();

                $(""#replyToComment"").html(""<a href='javascript:removeSelectedReply()' class='remove-selected-comment' >&times</a>"").append($(e.currentTarget).closest("".comment"").clone());
            })

            $(""#replyForm"").submit(function (e) {
                e.preventDefault();

                let formData = new FormData(e.currentTarget);

                let toCommentId = $(`#replyToComment div.comment`).data(""comment-id"");


                //console.log(""commentId"",toCommentId);

                if (toCommentId != undefined) {
                    formData.set(""commentId"", toCommentId);
                }


                $.ajax({
                    url: `");
#nullable restore
#line 340 "D:\Coding\Final-Project\ZSHOE-Solution\ZSHOE\Views\Blog\Details.cshtml"
                     Write(Url.Action("PostComment", "Blog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                    type: ""POST"",
                    data: formData,
                    contentType: false,
                    processData: false,
                    dataType: ""json"",
                    success: function (res) {
                        //console.log(res);
                    },
                    error: function (response) {

                        if (response.statusText == ""parsererror"") {
                            if (toCommentId != undefined) {
                                $(response.responseText).insertAfter($(`#c-${toCommentId}`));

                                $(""#replyToComment"").html("""")
                                e.currentTarget.reset();
                                $(""#comment-text"").val("""");
                            }
                            else {
                                $(""div.comments ul.commentAppend"").append($(response.responseText))
                                $(""#comment-text"").val("""");
                     ");
                WriteLiteral(@"       }
                        }

                        console.warn(response);
                    }
                });
            })
        })

        function removeSelectedReply(el) {
            $(""#replyToComment"").html("""");
        }
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogPost> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

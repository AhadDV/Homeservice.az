#pragma checksum "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571a653b1933c204606c577f3f599ab8d80bd653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blogs), @"mvc.1.0.view", @"/Views/Blog/Blogs.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.service.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\_ViewImports.cshtml"
using HomeService.app.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571a653b1933c204606c577f3f599ab8d80bd653", @"/Views/Blog/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599a3c90f551cd2f9cac3a20c8f3092dfccf49d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
  
    ViewData["Title"] = "Blogs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"blog\" class=\"blog\">\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-md-8\">\r\n                <div class=\"section-title\">\r\n                    <h2>");
#nullable restore
#line 12 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                   Write(localizaer["Blog"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n        \r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
             foreach (var item in Model.Blogs.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-image\">\r\n                            <a href=\"javascript:void(0)\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "571a653b1933c204606c577f3f599ab8d80bd6536067", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 798, "~/assets/images/blog/", 798, 21, true);
#nullable restore
#line 24 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
AddHtmlAttributeValue("", 819, item.ImageFile, 819, 15, false);

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
            WriteLiteral("\r\n                            </a>\r\n                            <span class=\"blog-tag\">\r\n\r\n");
#nullable restore
#line 28 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                 if ((localizaer["Language"] == "Az"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionAz);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                                                                  
                                }
                                else if ((localizaer["Language"] == "En"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionEn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                                                                  
                                }
                                else
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionRu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </div>\r\n                        <div class=\"blog-content\">\r\n                            <h3>\r\n                                <a href=\"javascript:void(0)\">\r\n");
#nullable restore
#line 48 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                     if ((localizaer["Language"] == "Az"))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                   Write(Html.Raw(item.TitleAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                               
                                    }
                                    else if ((localizaer["Language"] == "En"))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                   Write(Html.Raw(item.TitleEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                               
                                    }
                                    else
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                   Write(Html.Raw(item.TitleRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                               
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                            </h3>\r\n                            <p>\r\n");
#nullable restore
#line 66 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                 if ((localizaer["Language"] == "Az"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                 
                                }
                                else if ((localizaer["Language"] == "En"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                 

                                }
                                else
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                 

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571a653b1933c204606c577f3f599ab8d80bd65314837", async() => {
#nullable restore
#line 84 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                                                              Write(localizaer["Read More"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 88 "C:\Users\HP\Desktop\HomeService2\HomeService\HomeService.app\Views\Blog\Blogs.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Localization.IStringLocalizer<SharedResource> localizaer { get; private set; }
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

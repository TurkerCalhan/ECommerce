#pragma checksum "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd24d39cf93e425ac027a520b793f143e8ad8bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Web.ViewConponents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\_ViewImports.cshtml"
using ECommerce.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd24d39cf93e425ac027a520b793f143e8ad8bf6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-bar__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("template-index belle template-index-belle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html class=\"no-js\" lang=\"en\">\r\n\r\n<!-- belle/index.html   11 Nov 2019 12:16:10 GMT -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd24d39cf93e425ac027a520b793f143e8ad8bf65409", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"">
    <title>Belle Multipurpose Bootstrap 4 Html Template</title>
    <meta name=""description"" content=""description"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Favicon -->
    <link rel=""shortcut icon"" href=""/assets/images/favicon.png"" />
    <!-- Plugins CSS -->
    <link rel=""stylesheet"" href=""/assets/css/plugins.css"">
    <!-- Bootstap CSS -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">
    <!-- Main Style CSS -->
    <link rel=""stylesheet"" href=""/assets/css/style.css"">
    <link rel=""stylesheet"" href=""/assets/css/responsive.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd24d39cf93e425ac027a520b793f143e8ad8bf67157", async() => {
                WriteLiteral(@"
    <div id=""pre-loader"">
        <img src=""/assets/images/loader.gif"" alt=""Loading..."" />
    </div>
    <div class=""pageWrapper"">
        <!--Search Form Drawer-->
        <div class=""search"">
            <div class=""search__form"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd24d39cf93e425ac027a520b793f143e8ad8bf67683", async() => {
                    WriteLiteral("\r\n                    <button class=\"go-btn search__button\" type=\"submit\"><i class=\"icon anm anm-search-l\"></i></button>\r\n                    <input class=\"search__input\" type=\"search\" name=\"q\"");
                    BeginWriteAttribute("value", " value=\"", 1419, "\"", 1427, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Search entire store...\" aria-label=\"Search\" autocomplete=\"off\">\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button type=\"button\" class=\"search-trigger close-btn\"><i class=\"anm anm-times-l\"></i></button>\r\n            </div>\r\n        </div>\r\n        <!--End Search Form Drawer-->\r\n        <!--Top Header-->\r\n        ");
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("TopHeader"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--End Top Header-->\r\n        <!--Header-->\r\n        ");
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("HeaderWrap"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--End Header-->\r\n        <!--Mobile Menu-->\r\n        ");
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\Shared\_Layout.cshtml"
   Write(await Component.InvokeAsync("MobileNavWrapper"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--End Mobile Menu-->\r\n        ");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!--Footer-->
        <footer id=""footer"">
            <div class=""newsletter-section"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-12 col-sm-12 col-md-12 col-lg-7 w-100 d-flex justify-content-start align-items-center"">
                            <div class=""display-table"">
                                <div class=""display-table-cell footer-newsletter"">
                                    <div class=""section-header text-center"">
                                        <label class=""h2""><span>sign up for </span>newsletter</label>
                                    </div>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd24d39cf93e425ac027a520b793f143e8ad8bf611773", async() => {
                    WriteLiteral("\r\n                                        <div class=\"input-group\">\r\n                                            <input type=\"email\" class=\"input-group__field newsletter__input\" name=\"EMAIL\"");
                    BeginWriteAttribute("value", " value=\"", 3005, "\"", 3013, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Email address\"");
                    BeginWriteAttribute("required", " required=\"", 3042, "\"", 3053, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                            <span class=""input-group__btn"">
                                                <button type=""submit"" class=""btn newsletter__submit"" name=""commit"" id=""Subscribe""><span class=""newsletter__submit-text--large"">Subscribe</span></button>
                                            </span>
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""col-12 col-sm-12 col-md-12 col-lg-5 d-flex justify-content-end align-items-center"">
                            <div class=""footer-social"">
                                <ul class=""list--inline site-footer__social-icons social-icons"">
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Facebook""><i class=""icon icon-facebook""></i></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Twitter""><i class=""icon icon-twitter""></i> <span class=""icon__fallback-text"">Twitter</span></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Pinterest""><i class=""icon icon-pinterest""></i>");
                WriteLiteral(@" <span class=""icon__fallback-text"">Pinterest</span></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Instagram""><i class=""icon icon-instagram""></i> <span class=""icon__fallback-text"">Instagram</span></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Tumblr""><i class=""icon icon-tumblr-alt""></i> <span class=""icon__fallback-text"">Tumblr</span></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on YouTube""><i class=""icon icon-youtube""></i> <span class=""icon__fallback-text"">YouTube</span></a></li>
                                    <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Vimeo""><i class=""icon icon-vimeo-alt""></i> <span class=""icon__fallbac");
                WriteLiteral(@"k-text"">Vimeo</span></a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""site-footer"">
                <div class=""container"">
                    <!--Footer Links-->
                    <div class=""footer-top"">
                        <div class=""row"">
                            <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                                <h4 class=""h4"">Quick Shop</h4>
                                <ul>
                                    <li><a href=""#"">Women</a></li>
                                    <li><a href=""#"">Men</a></li>
                                    <li><a href=""#"">Kids</a></li>
                                    <li><a href=""#"">Sportswear</a></li>
                                    <li><a href=""#"">Sale</a></li>
                                </ul>
                            </d");
                WriteLiteral(@"iv>
                            <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                                <h4 class=""h4"">Informations</h4>
                                <ul>
                                    <li><a href=""#"">About us</a></li>
                                    <li><a href=""#"">Careers</a></li>
                                    <li><a href=""#"">Privacy policy</a></li>
                                    <li><a href=""#"">Terms &amp; condition</a></li>
                                    <li><a href=""#"">My Account</a></li>
                                </ul>
                            </div>
                            <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                                <h4 class=""h4"">Customer Services</h4>
                                <ul>
                                    <li><a href=""#"">Request Personal Data</a></li>
                                    <li><a href=""#"">FAQ's</a></li>
                      ");
                WriteLiteral(@"              <li><a href=""#"">Contact Us</a></li>
                                    <li><a href=""#"">Orders and Returns</a></li>
                                    <li><a href=""#"">Support Center</a></li>
                                </ul>
                            </div>
                            <div class=""col-12 col-sm-12 col-md-3 col-lg-3 contact-box"">
                                <h4 class=""h4"">Contact Us</h4>
                                <ul class=""addressFooter"">
                                    <li><i class=""icon anm anm-map-marker-al""></i><p>55 Gallaxy Enque,<br>2568 steet, 23568 NY</p></li>
                                    <li class=""phone""><i class=""icon anm anm-phone-s""></i><p>(440) 000 000 0000</p></li>
                                    <li class=""email""><i class=""icon anm anm-envelope-l""></i><p>sales@yousite.com</p></li>
                                </ul>
                            </div>
                        </div>
                    </div>
        ");
                WriteLiteral(@"            <!--End Footer Links-->
                    <hr>
                    <div class=""footer-bottom"">
                        <div class=""row"">
                            <!--Footer Copyright-->
                            <div class=""col-12 col-sm-12 col-md-6 col-lg-6 order-1 order-md-0 order-lg-0 order-sm-1 copyright text-sm-center text-md-left text-lg-left""><span></span> <a href=""templateshub.net"">Templates Hub</a></div>
                            <!--End Footer Copyright-->
                            <!--Footer Payment Icon-->
                            <div class=""col-12 col-sm-12 col-md-6 col-lg-6 order-0 order-md-1 order-lg-1 order-sm-0 payment-icons text-right text-md-center"">
                                <ul class=""payment-icons list--inline"">
                                    <li><i class=""icon fa fa-cc-visa"" aria-hidden=""true""></i></li>
                                    <li><i class=""icon fa fa-cc-mastercard"" aria-hidden=""true""></i></li>
                               ");
                WriteLiteral(@"     <li><i class=""icon fa fa-cc-discover"" aria-hidden=""true""></i></li>
                                    <li><i class=""icon fa fa-cc-paypal"" aria-hidden=""true""></i></li>
                                    <li><i class=""icon fa fa-cc-amex"" aria-hidden=""true""></i></li>
                                    <li><i class=""icon fa fa-credit-card"" aria-hidden=""true""></i></li>
                                </ul>
                            </div>
                            <!--End Footer Payment Icon-->
                        </div>
                    </div>
                </div>
            </div>
        </footer>
        <!--End Footer-->
        <!--Scoll Top-->
        <span id=""site-scroll""><i class=""icon anm anm-angle-up-r""></i></span>
        <!--End Scoll Top-->
        <!--Quick View popup-->
        <div class=""modal fade quick-view-popup"" id=""content_quickview"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""m");
                WriteLiteral(@"odal-body"">
                        <div id=""ProductSection-product-template"" class=""product-template__container prstyle1"">
                            <div class=""product-single"">
                                <!-- Start model close -->
                                <a href=""javascript:void()"" data-dismiss=""modal"" class=""model-close-btn pull-right"" title=""close""><span class=""icon icon anm anm-times-l""></span></a>
                                <!-- End model close -->
                                <div class=""row"">
                                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                                        <div class=""product-details-img"">
                                            <div class=""pl-20"">
                                                <img src=""/assets/images/product-detail-page/camelia-reversible-big1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 11531, "\"", 11537, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                                        <div class=""product-single__meta"">
                                            <h2 class=""product-single__title"">Product Quick View Popup</h2>
                                            <div class=""prInfoRow"">
                                                <div class=""product-stock""> <span class=""instock "">In Stock</span> <span class=""outstock hide"">Unavailable</span> </div>
                                                <div class=""product-sku"">SKU: <span class=""variant-sku"">19115-rdxs</span></div>
                                            </div>
                                            <p class=""product-single__price product-single__price-product-template"">
                                                <span class=""visua");
                WriteLiteral(@"lly-hidden"">Regular price</span>
                                                <s id=""ComparePrice-product-template""><span class=""money"">$600.00</span></s>
                                                <span class=""product-price__price product-price__price-product-template product-price__sale product-price__sale--single"">
                                                    <span id=""ProductPrice-product-template""><span class=""money"">$500.00</span></span>
                                                </span>
                                            </p>
                                            <div class=""product-single__description rte"">
                                                Belle Multipurpose Bootstrap 4 Html Template that will give you and your customers a smooth shopping experience which can be used for various kinds of stores such as fashion,...
                                            </div>

                                            
                                ");
                WriteLiteral(@"            <div class=""display-table shareRow"">
                                                <div class=""display-table-cell"">
                                                    <div class=""wishlist-btn"">
                                                        <a class=""wishlist add-to-wishlist"" href=""#"" title=""Add to Wishlist""><i class=""icon anm anm-heart-l"" aria-hidden=""true""></i> <span>Add to Wishlist</span></a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!--End-product-single-->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--End Quick View popup-->
        <!-- Newsletter Popup -->
        <d");
                WriteLiteral(@"iv class=""newsletter-wrap"" id=""popup-container"">
            <div id=""popup-window"">
                <a class=""btn closepopup""><i class=""icon icon anm anm-times-l""></i></a>
                <!-- Modal content-->
                <div class=""display-table splash-bg"">
                    <div class=""display-table-cell width40""><img src=""/assets/images/newsletter-img.jpg"" alt=""Join Our Mailing List"" title=""Join Our Mailing List"" /> </div>
                    <div class=""display-table-cell width60 text-center"">
                        <div class=""newsletter-left"">
                            <h2>Join Our Mailing List</h2>
                            <p>Sign Up for our exclusive email list and be the first to know about new products and special offers</p>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd24d39cf93e425ac027a520b793f143e8ad8bf627096", async() => {
                    WriteLiteral("\r\n                                <div class=\"input-group\">\r\n                                    <input type=\"email\" class=\"input-group__field newsletter__input\" name=\"EMAIL\"");
                    BeginWriteAttribute("value", " value=\"", 15612, "\"", 15620, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"Email address\"");
                    BeginWriteAttribute("required", " required=\"", 15649, "\"", 15660, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                                    <span class=""input-group__btn"">
                                        <button type=""submit"" class=""btn newsletter__submit"" name=""commit"" id=""subscribeBtn""> <span class=""newsletter__submit-text--large"">Subscribe</span> </button>
                                    </span>
                                </div>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <ul class=""list--inline site-footer__social-icons social-icons"">
                                <li><a class=""social-icons__link"" href=""#"" title=""Facebook""><i class=""fa fa-facebook-official"" aria-hidden=""true""></i></a></li>
                                <li><a class=""social-icons__link"" href=""#"" title=""Twitter""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                                <li><a class=""social-icons__link"" href=""#"" title=""Pinterest""><i class=""fa fa-pinterest"" aria-hidden=""true""></i></a></li>
                                <li><a class=""social-icons__link"" href=""#"" title=""Instagram""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
                                <li><a class=""social-icons__link"" href=""#"" title=""YouTube""><i class=""fa fa-youtube"" aria-hidden=""true""></i></a></li>
                                <li><a class=""social-icons__link"" href=""#"" title=""Vimeo""><i class=""fa fa-vimeo"" aria-hidden=""true""></i></a></li>
             ");
                WriteLiteral(@"               </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Newsletter Popup -->
        <!-- Including Jquery -->
        <script src=""/assets/js/vendor/jquery-3.3.1.min.js""></script>
        <script src=""/assets/js/vendor/modernizr-3.6.0.min.js""></script>
        <script src=""/assets/js/vendor/jquery.cookie.js""></script>
        <script src=""/assets/js/vendor/wow.min.js""></script>
        <!-- Including Javascript -->
        <script src=""/assets/js/bootstrap.min.js""></script>
        <script src=""/assets/js/plugins.js""></script>
        <script src=""/assets/js/popper.min.js""></script>
        <script src=""/assets/js/lazysizes.js""></script>
        <script src=""/assets/js/main.js""></script>
        <!--For Newsletter Popup-->
        <script>
            jQuery(document).ready(function(){
              jQuery('.closepopup').on('click', function () {
                  jQuery('#popup-container').");
                WriteLiteral(@"fadeOut();
                  jQuery('#modalOverly').fadeOut();
              });

              var visits = jQuery.cookie('visits') || 0;
              visits++;
              jQuery.cookie('visits', visits, { expires: 1, path: '/' });
              console.debug(jQuery.cookie('visits'));
              if ( jQuery.cookie('visits') > 1 ) {
                jQuery('#modalOverly').hide();
                jQuery('#popup-container').hide();
              } else {
                  var pageHeight = jQuery(document).height();
                  jQuery('<div id=""modalOverly""></div>').insertBefore('body');
                  jQuery('#modalOverly').css(""height"", pageHeight);
                  jQuery('#popup-container').show();
              }
              if (jQuery.cookie('noShowWelcome')) { jQuery('#popup-container').hide(); jQuery('#active-popup').hide(); }
            });

            jQuery(document).mouseup(function(e){
              var container = jQuery('#popup-container');
              i");
                WriteLiteral(@"f( !container.is(e.target)&& container.has(e.target).length === 0)
              {
                container.fadeOut();
                jQuery('#modalOverly').fadeIn(200);
                jQuery('#modalOverly').hide();
              }
            });
            var readyfunction = function()
            {
                var categoryName = $(""#categoryName"").val();// hidden input i??erisindeki de??eri al??r yani kategoyname
                var page = $(""#page"").val();

                $(""#loadMore"").click(function(){
                    $.post(""/producthtml"",
                    {name:categoryName,page:page},
                    function(data,status){
                        var p = parseInt(page)+1;//parseInt string de??erleri int yapar
                        $(""#page"").val(p);// bir input i??erisindeki value de??erini de??i??tirir
                        $(""#productHtml"").append(data);

                    });

                });
                $(""#btnAddBasket"").click(function(){
      ");
                WriteLiteral(@"              var quantity = $(""#Quantity"").val();
                    var productId = $(""#productId"").val();

                    $.post(""/baskethtml"",{quantity:quantity,productId:productId},function(data,status){
                    $(""#header-cart"").html(data);

                    });});

                  $.post(""/getbasket"",{},function(data,status){
                                    $(""#header-cart"").html(data);

                                    });

            }
            function AddBasketHomePage(quantity,Id){


                $.post(""/baskethtml"",{quantity:quantity,productId:Id},function(data,status){
                    $(""#header-cart"").html(data);

                    });
            }

            function CheckOut()
            {
                var email = $(""#inputEmail"").val();
                var city = $(""#inputCity"").val();
                var firstName = $(""#inputFirstName"").val();
                var lastName = $(""#inputLastName"").val();
           ");
                WriteLiteral(@"     var address = $(""#inputAddress"").val();
                var phone = $(""#inputPhone"").val();


                  $.post(""/checkoutok"",{
                      inputFirstName:firstName,
                      inputLastName:lastName,
                      inputEmail : email,
                      inputCity : city,
                      inputAddress : address,
                      inputPhone : phone},function(data,status){
                   if (data == ""Login"")
                   {
                       window.location.replace(""/login"");
                   }
                   else if(data == ""Error"")
                   {
                       alert(""Sat??n Alma Ba??ar??s??z."");
                       window.location.replace(""/"");
                   }
                   else
                   {
                       alert(""Sipari?? Al??nd??."")
                       window.location.replace(""/"");
                   }
                    });
            }
            $(document).ready(r");
                WriteLiteral("eadyfunction);\r\n        </script>\r\n        <!--End For Newsletter Popup-->\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<!-- belle/index.html   11 Nov 2019 12:20:55 GMT -->\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

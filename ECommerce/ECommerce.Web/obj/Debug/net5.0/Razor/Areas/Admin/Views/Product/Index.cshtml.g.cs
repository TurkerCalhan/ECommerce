#pragma checksum "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73195d182e8d25e94cd2268f0cf6fa19696c07ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Web.ViewConponents.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using ECommerce.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
using ECommerce.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73195d182e8d25e94cd2268f0cf6fa19696c07ed", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2968736dbe31a6c94be6d93d385d3a6727c5ebcd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini layout-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73195d182e8d25e94cd2268f0cf6fa19696c07ed5034", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
Write(await Component.InvokeAsync("Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73195d182e8d25e94cd2268f0cf6fa19696c07ed6264", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- Preloader -->
        <div class=""preloader flex-column justify-content-center align-items-center"">
            <img class=""animation__shake"" src=""dist/img/AdminLTELogo.png"" alt=""AdminLTELogo"" height=""60"" width=""60"">
        </div>

        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
            <!-- Left navbar links -->
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""index3.html"" class=""nav-link"">Home</a>
                </li>
                <li class=""nav-item d-none d-sm-inline-block"">
                    <a href=""#"" class=""nav-link"">Contact</a>
                </li>
            </ul>

            <!-- Right navbar links -->
          ");
                WriteLiteral(@"  <ul class=""navbar-nav ml-auto"">
                <!-- Navbar Search -->
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""navbar-search"" href=""#"" role=""button"">
                        <i class=""fas fa-search""></i>
                    </a>
                    <div class=""navbar-search-block"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73195d182e8d25e94cd2268f0cf6fa19696c07ed8004", async() => {
                    WriteLiteral(@"
                            <div class=""input-group input-group-sm"">
                                <input class=""form-control form-control-navbar"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                <div class=""input-group-append"">
                                    <button class=""btn btn-navbar"" type=""submit"">
                                        <i class=""fas fa-search""></i>
                                    </button>
                                    <button class=""btn btn-navbar"" type=""button"" data-widget=""navbar-search"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </li>

                <!-- Messages Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-comments""></i>
                        <span class=""badge badge-danger navbar-badge"">3</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Brad Diesel
                                        <span class=""float-right text-sm text-dan");
                WriteLiteral(@"ger""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">Call me whenever you can...</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        John Pierce
                                        <span cla");
                WriteLiteral(@"ss=""float-right text-sm text-muted""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">I got your message bro</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <!-- Message Start -->
                            <div class=""media"">
                                <img src=""dist/img/user3-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                                <div class=""media-body"">
                                    <h3 class=""dropdown-item-title"">
                                        Nora Silvester
                    ");
                WriteLiteral(@"                    <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                                    </h3>
                                    <p class=""text-sm"">The subject goes here</p>
                                    <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                                </div>
                            </div>
                            <!-- Message End -->
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Messages</a>
                    </div>
                </li>
                <!-- Notifications Dropdown Menu -->
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                        <i class=""far fa-bell""></i>
                        <span class=""badge badge-warning navbar-badge"">15</span>
   ");
                WriteLiteral(@"                 </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                        <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-envelope mr-2""></i> 4 new messages
                            <span class=""float-right text-muted text-sm"">3 mins</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-users mr-2""></i> 8 friend requests
                            <span class=""float-right text-muted text-sm"">12 hours</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item"">
                            <i class=""fas fa-file mr-2"">");
                WriteLiteral(@"</i> 3 new reports
                            <span class=""float-right text-muted text-sm"">2 days</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""#"" class=""dropdown-item dropdown-footer"">See All Notifications</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""fullscreen"" href=""#"" role=""button"">
                        <i class=""fas fa-expand-arrows-alt""></i>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-widget=""control-sidebar"" data-controlsidebar-slide=""true"" href=""#"" role=""button"">
                        <i class=""fas fa-th-large""></i>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->
        <!-- Main Sidebar Container -->
        ");
#nullable restore
#line 154 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
   Write(await Component.InvokeAsync("MainSidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

        <!-- Content Wrapper. Contains page content -->
        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <section class=""content-header"">
                <div class=""container-fluid"">
                    <div class=""row mb-2"">
                        <div class=""col-sm-6"">
                            <h1>Kullanıcı İşlemleri</h1>
                        </div>
                        <div class=""col-sm-6"">
                            <ol class=""breadcrumb float-sm-right"">
                                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                                <li class=""breadcrumb-item active"">DataTables</li>
                            </ol>
                        </div>
                    </div>
                </div><!-- /.container-fluid -->
            </section>

            <!-- Main content -->
            <section class=""content"">
         ");
                WriteLiteral(@"       <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <h3 class=""card-title"">Ürün Listesi</h3>
                                </div>
                                <!-- /.card-header -->
                                <div class=""card-body"">
                                    <table id=""example2"" class=""table table-bordered table-hover"">
                                        <thead>
                                            <tr>
                                                <th>Resim</th>
                                                <th>Ürün Adı</th>
                                                <th>Seo Url</th>
                                                <th>Fiyat</th>
                                                <th>Açıklama</th>
                                    ");
                WriteLiteral("            <th>İşlemler</th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 199 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
                                             foreach (var item in Model.Products)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td><img width=\"150\"");
                BeginWriteAttribute("src", " src=\"", 11078, "\"", 11160, 2);
                WriteAttributeValue("", 11084, "/product/", 11084, 9, true);
#nullable restore
#line 202 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 11093, Model.ProductImages.FirstOrDefault(x=>x.ProductId == item.Id).Name, 11093, 67, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                                                    <td>");
#nullable restore
#line 203 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 204 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(item.SeoName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 205 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 206 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    <td>\r\n                                                        <a");
                BeginWriteAttribute("href", " href=\"", 11590, "\"", 11625, 2);
                WriteAttributeValue("", 11597, "/admin/users/remove/", 11597, 20, true);
#nullable restore
#line 208 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 11617, item.Id, 11617, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sil</a> |\r\n                                                        <a");
                BeginWriteAttribute("href", " href=\"", 11696, "\"", 11731, 2);
                WriteAttributeValue("", 11703, "/admin/product/edit/", 11703, 20, true);
#nullable restore
#line 209 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 11723, item.Id, 11723, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Düzenle</a> |\r\n                                                        <a");
                BeginWriteAttribute("href", " href = \"", 11806, "\"", 11845, 2);
                WriteAttributeValue("", 11815, "/admin/product/images/", 11815, 22, true);
#nullable restore
#line 210 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 11837, item.Id, 11837, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Resimler</a>\r\n\r\n                                                        </td>\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 215 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </tbody>
                                        <tfoot>
                                            <tr>
                                                <th>Resim</th>
                                                <th>Ürün Adı</th>
                                                <th>Seo Url</th>
                                                <th>Fiyat</th>
                                                <th>Açıklama</th>
                                                <th>İşlemler</th>
                                            </tr>
                                        </tfoot>
                                    </table>
                                </div>
                                <!-- /.card-body -->
                            </div>
                            <!-- /.card -->
                            <!-- /.card -->
                        </div>
                        <!-- /.col -->
                    </div>
           ");
                WriteLiteral(@"         <!-- /.row -->
                </div>
                <!-- /.container-fluid -->
            </section>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->
        <!-- /.content-wrapper -->
        <footer class=""main-footer"">
            <strong>Copyright &copy; 2014-2021 <a href=""https://adminlte.io"">AdminLTE.io</a>.</strong>
            All rights reserved.
            <div class=""float-right d-none d-sm-inline-block"">
                <b>Version</b> 3.2.0
            </div>
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->
    ");
#nullable restore
#line 261 "C:\Users\Administrator\Desktop\ECommerce\ECommerce.Web\Areas\Admin\Views\Product\Index.cshtml"
Write(await Component.InvokeAsync("Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script src=""/admin/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
    <script src=""/admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>
    <script src=""/admin/plugins/jszip/jszip.min.js""></script>
    <script src=""/admin/plugins/pdfmake/pdfmake.min.js""></script>
    <script src=""/admin/plugins/pdfmake/vfs_fonts.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.html5.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.print.min.js""></script>
    <script src=""/admin/plugins/datatables-buttons/js/buttons.colVis.min.js""></script>

    <script>");
                WriteLiteral(@"
        $(function () {
          $(""#example1"").DataTable({
            ""responsive"": true, ""lengthChange"": false, ""autoWidth"": false,
            ""buttons"": [""copy"", ""csv"", ""excel"", ""pdf"", ""print"", ""colvis""]
          }).buttons().container().appendTo('#example1_wrapper .col-md-6:eq(0)');
          $('#example2').DataTable({
            ""paging"": true,
            ""lengthChange"": false,
            ""searching"": false,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": false,
            ""responsive"": true,
          });
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
